using Newtonsoft.Json;
using SteamServerCreationTool.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace SteamServerCreationTool.Forms
{
    public partial class MainForm : Form
    {
        //Stored Information
        private Settings settings;

        private SteamApps apps = null; // All apps from api (Only "server" and excludes "linux")

        //Temporary information
        private App selectedApp = null;

        private InstalledServer selectedInstalledApp = null;

        //"Temporary variables"
        public string steamCMDFolderPath;

        public string installedSteamCMDPath;

        //Initialize MainForm component
        public MainForm() => InitializeComponent();

        /// <summary>
        /// Select install directory of SteamCMD.
        /// If directory was selected: Download SteamCMD;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstallCMDButton_Click(object sender, EventArgs e)
        {
            //Initiate a Webclient
            using (WebClient wc = new WebClient())
            {
                ShowProgressbar(true);

                //Initiate a FolderBrowserDialog
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    //Set FolderBrowserDialog information
                    fbd.Description = "Select steamCMD install location:";
                    fbd.ShowNewFolderButton = true;

                    // Show FolderBrowserDialog
                    if (fbd.ShowDialog() == DialogResult.OK && Directory.Exists(fbd.SelectedPath))
                    {
                        // Update title to show what the application is working on
                        this.Text = Core.softwareNameShort + " " + Core.softwareName + " - Fixing SteamCMD...";

                        // Remember install folder
                        steamCMDFolderPath = fbd.SelectedPath;
                        installedSteamCMDPath = Path.Combine(steamCMDFolderPath, "steamcmd.exe");

                        //Setup and start download
                        wc.DownloadFileCompleted += Wc_DownloadFileCompleted; ;
                        wc.DownloadFileAsync(new Uri("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip"), steamCMDFolderPath + "\\steamcmd.zip");
                    }
                    else
                    {
                        ShowProgressbar(false);
                    }
                }
            }
        }

        /// <summary>
        /// Set progressbar state
        /// </summary>
        /// <param name="state"></param>
        private void ShowProgressbar(bool state)
        {
            ProgressBarInfo.Enabled = state;
            ProgressBarInfo.Visible = state;
        }

        /// <summary>
        /// Method for completing download of steamcmd.zip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // Download location
            string steamCMDzip = Path.Combine(steamCMDFolderPath + @"\steamcmd.zip");

            //Try extracting the downloaded file. Catch all failed attempts in a messagebox.
            try
            {
                ZipFile.ExtractToDirectory(steamCMDzip, steamCMDFolderPath);
            }
            catch (ArgumentNullException x) { MessageBox.Show(x.Message, "Unpack Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (ArgumentException x) { MessageBox.Show(x.Message, "Unpack Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (PathTooLongException x) { MessageBox.Show(x.Message, "Unpack Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (FileNotFoundException x) { MessageBox.Show(x.Message, "Unpack Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (DirectoryNotFoundException x) { MessageBox.Show(x.Message, "Unpack Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (IOException x) { MessageBox.Show(x.Message, "Unpack Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (UnauthorizedAccessException x) { MessageBox.Show(x.Message, "Unpack Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (NotSupportedException x) { MessageBox.Show(x.Message, "Unpack Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (InvalidDataException x) { MessageBox.Show(x.Message, "Unpack Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            //Try deleting downloaded archive to clean up. Catch failed attempts in a messagebox.
            try
            {
                File.Delete(steamCMDzip);
            }
            catch (ArgumentNullException x) { MessageBox.Show(x.Message, "Deletion of downloaded compressed archive error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (ArgumentException x) { MessageBox.Show(x.Message, "Deletion of downloaded compressed archive error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (PathTooLongException x) { MessageBox.Show(x.Message, "Deletion of downloaded compressed archive error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (DirectoryNotFoundException x) { MessageBox.Show(x.Message, "Deletion of downloaded compressed archive error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (IOException x) { MessageBox.Show(x.Message, "Deletion of downloaded compressed archive error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (NotSupportedException x) { MessageBox.Show(x.Message, "Deletion of downloaded compressed archive error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (UnauthorizedAccessException x) { MessageBox.Show(x.Message, "Deletion of downloaded compressed archive error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            // If "steamcmd.exe" was found.
            if (File.Exists(installedSteamCMDPath))
            {
                //Set button information OK
                LocateSteamCMDButton.Text = "SteamCMD Located ✓";
                LocateSteamCMDButton.ForeColor = Color.Green;

                //Set settings, save.
                settings.steamCMD_installLocation = installedSteamCMDPath;
                Core.SaveCurrentSettings(settings);
            }
            else
            {
                MessageBox.Show("Something went wrong when unpacking \"steamcmd.exe\". File was not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Update title to show what the application is working on
            this.Text = Core.softwareNameShort + " " + Core.softwareName; ;

            ShowProgressbar(false);
        }

        /// <summary>
        /// Locate SteamCMD with the use of OpenFileDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocateSteamCMDButton_Click(object sender, EventArgs e)
        {
            //Initiate a OpenFileDialog
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                //Set OpenFileDialog info
                ofd.InitialDirectory = "c:\\";
                ofd.FileName = "steamcmd";
                ofd.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
                ofd.FilterIndex = 1;

                //Show dialogue and check if file exist
                if (ofd.ShowDialog() == DialogResult.OK && ofd.CheckFileExists)
                {
                    //Update location of steamcmd
                    steamCMDFolderPath = ofd.FileName;
                    settings.steamCMD_installLocation = steamCMDFolderPath;

                    //Set button information OK
                    LocateSteamCMDButton.Text = "SteamCMD Located ✓";
                    LocateSteamCMDButton.ForeColor = Color.Green;

                    Core.SaveCurrentSettings(settings);
                }
            }
        }

        /// <summary>
        /// Open directory of the installed steamcmd.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSteamCMDButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(settings.steamCMD_installLocation))
                Process.Start(new FileInfo(settings.steamCMD_installLocation).DirectoryName);
            else
                MessageBox.Show("The directory of SteamCMD has not been setup yet.", "Error opening directory!");
        }

        /// <summary>
        /// Open URL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSteamCMDHelp_Click(object sender, EventArgs e) => Process.Start("https://developer.valvesoftware.com/wiki/SteamCMD");

        /// <summary>
        /// Selected server changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SteamServerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (apps == null || SteamServerList.SelectedIndex == -1) return;

            //Null variables
            App app = null;
            selectedInstalledApp = null;

            //Disable buttons
            InstallServerButton.Enabled = false;
            DeleteServerButton.Enabled = false;

            //Empty field untill installation is found
            App_InstallLocationBox.Text = "";

            //Get the correct app from the list
            foreach (var item in apps.Applist.Apps)
            {
                if (item.Appid == GetAppid(SteamServerList.SelectedItem.ToString()))
                {
                    app = item;
                    break;
                }
            }

            if (app != null)
            {
                //We now set the app as selected
                selectedApp = app;

                //Check if server is installed
                bool installed = false;
                for (int i = 0; i < settings.installedServer.Count; i++)
                {
                    if (settings.installedServer[i].app.Appid == app.Appid)
                    {
                        installed = true;
                        selectedInstalledApp = settings.installedServer[i];
                        break;
                    }
                }

                // Set information from the app
                App_installedLabel.Text = installed.ToString();
                App_idLabel.Text = app.Appid.ToString();
                App_nameLabel.Text = app.Name;

                if (selectedInstalledApp != null)
                {
                    //If the app is installed but the directory is missing
                    if (!Directory.Exists(selectedInstalledApp.installPath))
                    {
                        //Delete references, folder etc - Refresh
                        MessageBox.Show("The server is registered as installed but the folder could not be found. Removing database entry...", "Install Directory Missing!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DeleteServer(selectedInstalledApp);
                        RefreshSelectedServerList();
                        return;
                    }
                    /*
                     * The idea here was to add a check for files in this directory
                     * but it wont work since steam automatically creates files in
                     * this directory eg. "steamapps" and server files/directories.
                     *
                     * There is no way of detecting a successful installation without reading steamCMD output to the console.
                     *
                    */

                    // Load install-path into field
                    App_InstallLocationBox.Text = selectedInstalledApp.installPath;

                    //If the directory exist, enable buttons.
                    if (Directory.Exists(App_InstallLocationBox.Text))
                    {
                        InstallServerButton.Enabled = true;
                        DeleteServerButton.Enabled = true;
                    }
                    else
                    {
                        InstallServerButton.Enabled = false;
                        DeleteServerButton.Enabled = false;
                    }
                }
            }
            else
            {
                // The app is not installed, null fields.

                selectedApp = null;
                selectedInstalledApp = null;

                App_installedLabel.Text = "";
                App_idLabel.Text = "";
                App_nameLabel.Text = "";
                App_InstallLocationBox.Text = "";

                InstallServerButton.Enabled = true;
                DeleteServerButton.Enabled = true;
            }
        }

        /// <summary>
        /// Get appid from string
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private int GetAppid(string name)
        {
            string[] split = name.Split(']');
            if (split.Length > 1)
            {
                return Int32.Parse(split[0].Substring(1));
            }
            else return -1;
        }

        /// <summary>
        /// Delete server information, folder, files.
        /// </summary>
        /// <param name="selectedInstalledApp"></param>
        private void DeleteServer(InstalledServer selectedInstalledApp)
        {
            //Get index of installed server
            int removeID = -1;
            for (int i = 0; i < settings.installedServer.Count; i++)
            {
                if (settings.installedServer[i].app.Appid == selectedInstalledApp.app.Appid)
                {
                    removeID = i;
                    break;
                }
            }

            // if the index was found
            if (removeID != -1)
            {
                //Remove index, save.
                settings.installedServer.RemoveAt(removeID);
                Core.SaveCurrentSettings(settings);
            }
        }

        /// <summary>
        /// Refresh servers from steam API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServersRefreshButton_Click(object sender, EventArgs e)
        {
            //Disable buttons
            App_InstallLocationBox.Enabled = false;
            OpenServerButton.Enabled = false;
            ServersRefreshButton.Enabled = false;
            SteamServerList.Enabled = false;

            // Update title to show what the application is working on
            this.Text = Core.softwareNameShort + " " + Core.softwareName + " - Updating server list...";

            //Nullify app information
            App_installedLabel.Text = "";
            App_idLabel.Text = "";
            App_nameLabel.Text = "";
            App_InstallLocationBox.Text = "";

            ShowProgressbar(true);

            //Clear list to not make duplicates
            SteamServerList.Items.Clear();
            SteamServerList.Items.Add("Loading...");
            SteamServerList.SelectedIndex = 0;
            SteamServerList.Refresh();

            try
            {
                //Try downloading the list of apps from steam
                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("User-Agent", "Other");

                    wc.DownloadStringCompleted += Wc_DownloadStringCompletedList;
                    wc.DownloadStringAsync(new Uri("https://api.steampowered.com/ISteamApps/GetAppList/v2/"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Steam apps list download complete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wc_DownloadStringCompletedList(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Steam API apps download cancelled...");
                return;
            }

            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Steam API Apps Download Error");
                return;
            }

            //Check if we have results
            if (e.Result != "")
            {
                //Convert downloaded data to apps v2
                apps = JsonConvert.DeserializeObject<SteamApps>(e.Result);

                if (apps != null)
                {
                    //Check which indexes to purge from the list
                    List<int> removeIndexes = new List<int>();
                    for (int i = 0; i < apps.Applist.Apps.Count; i++)
                    {
                        if (!apps.Applist.Apps[i].Name.Contains("Server") || apps.Applist.Apps[i].Name.Contains("linux")) removeIndexes.Add(i);
                    }

                    //Sort the list and reverse so we dont mess with indexes of the list.
                    removeIndexes.Sort();
                    removeIndexes.Reverse();

                    //Remove indexes in decending order
                    foreach (var item in removeIndexes) apps.Applist.Apps.RemoveAt(item);

                    GC.Collect(); // Needed?

                    //Clear list to populate with new data
                    SteamServerList.Items.Clear();

                    //Order list
                    apps.Applist.Apps = apps.Applist.Apps.OrderBy(o => o.Name).ToList();

                    //Add add apps to the list
                    foreach (var item in apps.Applist.Apps) SteamServerList.Items.Add("[" + item.Appid + "] " + item.Name);

                    //Select the most common install
                    SteamServerList.SelectedIndex = SteamServerList.FindString("[740] Counter-Strike Global Offensive - Dedicated Server");

                    ShowProgressbar(false);

                    OpenServerButton.Enabled = true;
                    SteamServerList.Enabled = true;
                    ServersRefreshButton.Enabled = true;
                    App_InstallLocationBox.Enabled = true;

                    // Update title to show what the application is working on
                    this.Text = Core.softwareNameShort + " " + Core.softwareName;
                }
            }
            else
            {
                MessageBox.Show("The result was not expected. Application cannot function with the downloaded information. Exiting...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Main setup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Make sure size is correct
            this.Size = new Size(429, 339);

            //Disable buttons
            InstallServerButton.Enabled = false;
            DeleteServerButton.Enabled = false;

            //Set author/app information
            BottomLabel.Text = "(" + Core.softwareNameShort + ") " + Core.softwareName + " " + Core.GetVersion() + "\n\rCreated by " + Core.authorName + " AKA " + Core.authorRealName + "";
            ProjectLink.Text = "Github: n0tic/SteamServerCreationTool";

            //Load settings
            settings = Core.LoadData();

            //If we have settings
            if (settings != null)
            {
                // Check if SteamCMD install was found
                if (File.Exists(settings.steamCMD_installLocation))
                {
                    LocateSteamCMDButton.Text = "SteamCMD Located ✓";
                    LocateSteamCMDButton.ForeColor = Color.Green;
                }
            }
            else
                settings = new Settings(); // New settings file

            //Do we have an ethernet connection?
            if (!Core.CheckNetwork())
            {
                InstallCMDButton.Enabled = false;
                ServersRefreshButton.Enabled = false;
                SteamServerList.Enabled = false;
            }
            else
            {
                InstallCMDButton.Enabled = true;
                ServersRefreshButton.Enabled = false;
                SteamServerList.Enabled = false;

                //Get steam apps list refreshed
                ServersRefreshButton_Click(null, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Select app install location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void App_InstallLocationBox_Click(object sender, EventArgs e)
        {
            //Initialize FolderBrowserDialog
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                //Set FolderBrowserDialog information
                fbd.Description = "Select a location to install server:";
                fbd.ShowNewFolderButton = true;

                // Show FolderBrowserDialog dialogue and check if selection is valid
                if (fbd.ShowDialog() == DialogResult.OK && Directory.Exists(fbd.SelectedPath))
                {
                    //Set path
                    App_InstallLocationBox.Text = fbd.SelectedPath;

                    //Enable buttons
                    InstallServerButton.Enabled = true;
                    DeleteServerButton.Enabled = true;

                    //if we have an installation
                    if (selectedInstalledApp != null)
                    {
                        //Check if install-path exist, have files and it checks if textfield and saved data of path match, otherwise it offers to move the files.
                        if (Directory.Exists(selectedInstalledApp.installPath) && Directory.GetFiles(selectedInstalledApp.installPath).Length > 1 && selectedInstalledApp.installPath != fbd.SelectedPath)
                            InstallServerButton.Text = "Move Server";
                        else InstallServerButton.Text = "Install Server";

                        DeleteServerButton.Enabled = true;
                    }
                    else
                    {
                        DeleteServerButton.Enabled = false; // Its not installed so we disable this button
                    }
                }
            }
        }

        /// <summary>
        /// Install or move installation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstallServerButton_Click(object sender, EventArgs e)
        {
            // This section requires SteamCMD to be set-up to continue regardless of move or install.
            if (!File.Exists(settings.steamCMD_installLocation))
            {
                MessageBox.Show("The reference to steamCMD is either empty or steamCMD is missing! Please locate or install steamCMD.", "SteamCMD Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InstallServerButton.Enabled = false; // Disable button untill features are done.

            //If button text is set to "Move Server"
            if (InstallServerButton.Text == "Move Server")
            {
                //Initiate new Thread to async the move of server files.
                new Thread(() =>
                {
                    //Start progressbar
                    Invoke(new Action(() =>
                    {
                        ShowProgressbar(true);
                    }));

                    //Move folders, subfolders and files
                    Core.MoveFolder(selectedInstalledApp.installPath, App_InstallLocationBox.Text);

                    //Get install index
                    int tmpInt = -1;
                    for (int i = 0; i < settings.installedServer.Count; i++)
                    {
                        if (settings.installedServer[i].app.Appid == selectedInstalledApp.app.Appid)
                        {
                            tmpInt = i;
                            break;
                        }
                    }

                    //If we found installation, change installed directory
                    if (tmpInt != -1) settings.installedServer[tmpInt].installPath = App_InstallLocationBox.Text;

                    //Stop progressbar, modify button, save new settings and lastly, refresh list.
                    Invoke(new Action(() =>
                    {
                        ShowProgressbar(false);

                        InstallServerButton.Text = "Install Server";
                        InstallServerButton.Enabled = true;

                        Core.SaveCurrentSettings(settings);
                        RefreshSelectedServerList();
                    }));
                }).Start();
            }
            else // Fresh install
            {
                //Keep track of success
                bool install = true;

                //This needs no explanation, no? It simply updates data with provided defaults if new install
                string validated = "";
                if (ValidateBox.Checked) validated = "validate ";
                else validated = "";

                //This needs no explanation, no? It simply updates data with provided defaults if new install
                string installDir = "";
                string appID = "";
                if (selectedInstalledApp != null)
                {
                    appID = selectedInstalledApp.app.Appid.ToString();
                    installDir = selectedInstalledApp.installPath;
                }
                else
                {
                    appID = selectedApp.Appid.ToString();
                    installDir = App_InstallLocationBox.Text;
                }

                /*
                 * if server was deleted and for some reason, fields were not nullified. Create the directory.
                 */

                if (!Directory.Exists(installDir))
                {
                    try
                    {
                        Directory.CreateDirectory(installDir);
                    }
                    catch
                    {
                        InstallServerButton.Enabled = true; // Enable button
                        MessageBox.Show("It appears the folder did not exist and the application was unable to create the directory.", "Directory Creation Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                /*
                 * Give the user a warning if the install directory is not empty.
                 * A precaution so that the user dont install eg. CSGO server onto a Ark Server
                 * which may have conflicting files, which in return, destroys another server.
                */
                if (Core.IsFolderEmpty(installDir))
                {
                    if (MessageBox.Show("It appears the installation folder is not empty.\n\rAre you sure you want to continue installing/updating this server?", "Directory Not Empty!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        InstallServerButton.Enabled = true;
                        return;
                    }
                }

                // Start a new thread with the installation as async using user input
                new Thread(() =>
                {
                    //Initiating process
                    using (Process process = new Process
                    {
                        //Setting startinfo
                        StartInfo =
                        {
                            UseShellExecute = false,
                            FileName = settings.steamCMD_installLocation,
                            Arguments = "+login anonymous +force_install_dir \"" + installDir + "\" +app_update " + appID + " " + validated + "+quit" // Building argument string
                        }
                    })
                    {
                        //Try starting the process
                        try
                        {
                            process.Start();
                        }
                        catch (ObjectDisposedException x) { MessageBox.Show(x.Message); install = false; }
                        catch (InvalidOperationException x) { MessageBox.Show(x.Message); install = false; }
                        catch (Win32Exception x) { MessageBox.Show(x.Message); install = false; }

                        //Wait for process to stop, if it exists.
                        try
                        {
                            process?.WaitForExit();
                        }
                        catch (Win32Exception x) { MessageBox.Show(x.Message); install = false; }
                        catch (OutOfMemoryException x) { MessageBox.Show(x.Message); install = false; }
                        catch (IOException x) { MessageBox.Show(x.Message); install = false; }
                        catch (SystemException x) { MessageBox.Show(x.Message); install = false; }

                        // Register installation if new and save settings.
                        if (install && selectedInstalledApp == null)
                        {
                            settings.installedServer.Add(new InstalledServer(installDir, selectedApp));
                            Core.SaveCurrentSettings(settings);
                        }

                        Invoke(new Action(() =>
                        {
                            //Refresh data regardless of success.
                            RefreshSelectedServerList();

                            InstallServerButton.Enabled = true;
                        }));
                    }
                }).Start();
            }
        }

        /// <summary>
        /// Refreshes the server list.
        /// </summary>
        private void RefreshSelectedServerList()
        {
            int tmpInt = SteamServerList.SelectedIndex;
            SteamServerList.SelectedIndex = 0;
            SteamServerList.SelectedIndex = tmpInt;
        }

        /// <summary>
        /// Deletes a server directory and files + stored installed server data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteServerButton_Click(object sender, EventArgs e)
        {
            if (selectedInstalledApp != null)
            {
                try
                {
                    //Delete directory with all files.
                    Directory.Delete(selectedInstalledApp.installPath, true);

                    //Get index of installed app
                    int tmpInt = -1;
                    for (int i = 0; i < settings.installedServer.Count; i++)
                    {
                        if (settings.installedServer[i].app.Appid == selectedInstalledApp.app.Appid)
                        {
                            tmpInt = i;
                            break;
                        }
                    }

                    //Remove index
                    if (tmpInt != -1) settings.installedServer.RemoveAt(tmpInt);

                    //Refresh and save
                    RefreshSelectedServerList();
                    Core.SaveCurrentSettings(settings);
                }
                catch (ArgumentNullException x) { MessageBox.Show(x.Message); }
                catch (PathTooLongException x) { MessageBox.Show(x.Message); }
                catch (DirectoryNotFoundException x) { MessageBox.Show(x.Message); }
                catch (IOException x) { MessageBox.Show(x.Message); }
                catch (UnauthorizedAccessException x) { MessageBox.Show(x.Message); }
                catch (ArgumentException x) { MessageBox.Show(x.Message); }
            }
        }

        /// <summary>
        /// Open Game server Login Tokens (GSLTs) link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_Click(object sender, EventArgs e) => Process.Start("https://steamcommunity.com/dev/managegameservers?l=english");

        /// <summary>
        /// Open server setup query link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (SteamServerList.Items.Count > 0 && selectedApp != null)
            {
                string query = selectedApp.Name.Replace(' ', '+');
                Process.Start("https://www.google.com/search?q=" + query + "+server+setup");
            }
        }

        /// <summary>
        /// Open installed server directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenServerButton_Click(object sender, EventArgs e)
        {
            if (selectedInstalledApp != null)
            {
                Process.Start(selectedInstalledApp.installPath);
            }
            else MessageBox.Show("The server doesnt appear to be in the database. Install the server first.", "Error opening directory!");
        }

        /// <summary>
        /// Open Github link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjectLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start(Core.projectURL);

        /// <summary>
        /// Toggle window size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowExpander_Click(object sender, EventArgs e)
        {
            if (this.Size == new Size(429, 429))
            {
                this.Size = new Size(429, 339);
                WindowExpander.Image = Properties.Resources.Down;
            }
            else
            {
                this.Size = new Size(429, 429);
                WindowExpander.Image = Properties.Resources.Up;
            }
        }
    }
}