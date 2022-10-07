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
using System.Text;
using System.Windows.Forms;

namespace SteamServerCreationTool.Forms
{
    public partial class MainForm : Form
    {
        //Stored Information
        public Settings settings;

        public SteamApps apps = null; // All apps from api (Only "server" and excludes "linux")

        //Forms
        private ManageInstallsForm mif;

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
                        wc.DownloadFileAsync(new Uri("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip?utc=" + Core.GetUTCTime()), steamCMDFolderPath + "\\steamcmd.zip");
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
                SteamCMD_InstallBox.Visible = false;
                SteamCMD_LocatedBox.Visible = true;

                //Set settings, save.
                settings.steamCMD_installLocation = installedSteamCMDPath;
                Core.SaveSettings(settings);

                MessageBox.Show("SteamCMD installation was successful! Enjoy!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ofd.Filter = "Exe Files (.exe)|steamcmd.exe";
                ofd.FilterIndex = 1;

                //Show dialogue and check if file exist
                if (ofd.ShowDialog() == DialogResult.OK && ofd.CheckFileExists)
                {
                    //Update location of steamcmd
                    steamCMDFolderPath = ofd.FileName;
                    settings.steamCMD_installLocation = steamCMDFolderPath;

                    //Set button information OK
                    SteamCMD_InstallBox.Visible = false;
                    SteamCMD_LocatedBox.Visible = true;

                    Core.SaveSettings(settings);
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
        private void OpenSteamCMDHelp_Click(object sender, EventArgs e) => Process.Start("https://developer.valvesoftware.com/wiki/SteamCMD?=" + Core.GetUTCTime());

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
                for (int i = 0; i < settings.installedServer.Count; i++)
                {
                    if (settings.installedServer[i].app.Appid == app.Appid)
                    {
                        selectedInstalledApp = settings.installedServer[i];
                        break;
                    }
                }

                // Set information from the app
                App_idLabel.Text = app.Appid.ToString();
                App_nameLabel.Text = app.Name;

                InstallServerButton.Enabled = true;
            }
            else
            {
                // The app is not installed, null fields.

                selectedApp = null;
                selectedInstalledApp = null;

                App_idLabel.Text = "";
                App_nameLabel.Text = "";

                InstallServerButton.Enabled = true;
            }
        }

        /// <summary>
        /// Get appid from string
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetAppid(string name)
        {
            string[] split = name.Split(']');
            if (split.Length > 1)
            {
                return Int32.Parse(split[0].Substring(1));
            }
            else return -1;
        }

        /// <summary>
        /// Refresh servers from steam API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServersRefreshButton_Click(object sender, EventArgs e)
        {
            //Disable buttons
            ServersRefreshButton.Enabled = false;
            SearchButton.Enabled = false;
            SteamServerList.Enabled = false;

            // Update title to show what the application is working on
            this.Text = Core.softwareNameShort + " " + Core.softwareName + " - Getting server list...";

            //Nullify app information
            TotalServerLabel.Text = "(0)";
            App_idLabel.Text = "";
            App_nameLabel.Text = "";

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

                    wc.Encoding = Encoding.UTF8;
                    wc.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
                    wc.DownloadStringCompleted += Wc_DownloadStringCompletedList;
                    wc.DownloadStringAsync(new Uri(Core.serversURL));
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
                ShowProgressbar(false);

                SteamServerList.Enabled = true;
                ServersRefreshButton.Enabled = true;
                SearchButton.Enabled = true;

                TotalServerLabel.Text = "(X)";

                // Update title to show what the application is working on
                this.Text = Core.softwareNameShort + " " + Core.softwareName;

                MessageBox.Show("Steam API apps download cancelled...");
                
                return;
            }

            if (e.Error != null)
            {
                ShowProgressbar(false);

                SteamServerList.Enabled = true;
                ServersRefreshButton.Enabled = true;
                SearchButton.Enabled = true;

                TotalServerLabel.Text = "(X)";

                // Update title to show what the application is working on
                this.Text = Core.softwareNameShort + " " + Core.softwareName;

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
                        // Super weird, 90 Half-Life Server was not in the list and a lot of other was also missing.
                        // Denied response? Timed for "spamming"?
                        //{"appid":90,"name":"Half-Life Dedicated Server"}
                        //if (apps.Applist.Apps[i].Appid == 90) MessageBox.Show(apps.Applist.Apps[i].Name);

                        if (apps.Applist.Apps[i].Appid == 570) continue; //Allow Dota 2 to be downloaded.

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

                    SteamServerList.Enabled = true;
                    ServersRefreshButton.Enabled = true;
                    SearchButton.Enabled = true;

                    // Update title to show what the application is working on
                    this.Text = Core.softwareNameShort + " " + Core.softwareName;

                    TotalServerLabel.Text = $"({SteamServerList.Items.Count})";
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
            //Disable buttons
            InstallServerButton.Enabled = false;

            //Load settings
            settings = Core.LoadSettings();

            //If we have settings
            if (settings != null)
            {
                // Check if SteamCMD install was found
                if (File.Exists(settings.steamCMD_installLocation))
                {
                    SteamCMD_InstallBox.Visible = false;
                    SteamCMD_LocatedBox.Visible = true;
                }
            }
            else
            {
                settings = new Settings { userData = new UserData() }; // New settings file
                MessageBox.Show("WARNING: This is a Beta build. Not all features have been polished or tested 100%. Report any problems on the Github project issues page.", "Beta Release", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Do we have an ethernet connection?
            if (!Core.CheckNetwork())
            {
                AutoInstallButton.Enabled = false;
                ServersRefreshButton.Enabled = false;
                SearchButton.Enabled = false;
                SteamServerList.Enabled = false;

                MessageBox.Show("No Internet connection was detected. Disabling network features.", "No Internet detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Core.CheckForUpdates();

                AutoInstallButton.Enabled = true;
                ServersRefreshButton.Enabled = false;
                SearchButton.Enabled = false;
                SteamServerList.Enabled = false;

                //Get steam apps list refreshed
                ServersRefreshButton_Click(null, EventArgs.Empty);
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
                MessageBox.Show("The reference to steamCMD is either empty or steamCMD is missing! Please locate or install steamCMD first.", "SteamCMD Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (CreateServerForm csf = new CreateServerForm(this, selectedApp))
            {
                csf.StartPosition = FormStartPosition.CenterParent;
                DialogResult res = csf.ShowDialog();
            }
        }

        /// <summary>
        /// Open Game server Login Tokens (GSLTs) link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLabel1_Click(object sender, EventArgs e) => Process.Start("https://steamcommunity.com/dev/managegameservers?l=english");

        /// <summary>
        /// Open server setup query link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            if (selectedInstalledApp != null) Process.Start(selectedInstalledApp.installPath);
            else MessageBox.Show("The server doesnt appear to be in the database. Install the server first.", "Error opening directory!");
        }

        /// <summary>
        /// Toggle window size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowExpander_Click(object sender, EventArgs e)
        {
            using (AboutForm af = new AboutForm(this))
            {
                af.StartPosition = FormStartPosition.CenterParent;
                af.ShowDialog();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            using (ServerListSearchForm form = new ServerListSearchForm(this))
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }

        private void InstalledServersButton_Click(object sender, EventArgs e)
        {
            if (mif == null || mif.IsDisposed) mif = new ManageInstallsForm(this);

            mif.Show();
        }

        private void ProjectLink_Click(object sender, EventArgs e) => Process.Start(Core.projectURL);

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            using (SettingsForm sf = new SettingsForm(this))
            {
                sf.StartPosition = FormStartPosition.CenterParent;
                sf.ShowDialog();
            }
        }

        private void CheckForUpdateToolStripMenuItem_Click(object sender, EventArgs e) => Core.CheckForUpdates(true);

        private void RefreshServerListToolStripMenuItem_Click(object sender, EventArgs e) => ServersRefreshButton_Click(null, EventArgs.Empty);

        private void Button_VisitDownloadButton_Click(object sender, EventArgs e) => Process.Start("https://developer.valvesoftware.com/wiki/SteamCMD#Downloading_SteamCMD");
    }
}