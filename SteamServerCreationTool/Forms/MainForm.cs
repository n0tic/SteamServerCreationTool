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
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamServerCreationTool.Forms
{
    public partial class MainForm : Form
    {
        Settings settings;
        SteamApps apps = null;
        App selectedApp = null;
        InstalledServer selectedInstalledApp = null;

        public string steamCMDFolderPath;
        public string installedSteamCMDPath;

        public MainForm() => InitializeComponent();

        private void InstallCMDButton_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                ProgressBarInfo.Enabled = true;
                ProgressBarInfo.Visible = true;

                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "Select steamCMD install location:";
                    fbd.ShowNewFolderButton = true;

                    if (fbd.ShowDialog() == DialogResult.OK && Directory.Exists(fbd.SelectedPath))
                    {
                        //Send content to string
                        steamCMDFolderPath = fbd.SelectedPath;

                        wc.DownloadFileCompleted += Wc_DownloadFileCompleted; ;
                        wc.DownloadFileAsync(new Uri("https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip"), steamCMDFolderPath + "\\steamcmd.zip");

                        installedSteamCMDPath = Path.Combine(steamCMDFolderPath, "steamcmd.exe");

                        this.Text = Core.softwareNameShort + " " + Core.softwareName + " - Fixing SteamCMD...";
                    }
                }
            }
        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string steamCMDzip = Path.Combine(steamCMDFolderPath + @"\steamcmd.zip");

            //try to extract the zip file
            try
            {
                ZipFile.ExtractToDirectory(steamCMDzip, steamCMDFolderPath);
            }
            catch { }

            //try to delete the zip file
            try
            {
                File.Delete(steamCMDzip);
            }
            catch { }

            if (File.Exists(installedSteamCMDPath))
            {
                settings.steamCMD_installLocation = installedSteamCMDPath;
                LocateSteamCMDButton.Text = "SteamCMD Located ✓";
                LocateSteamCMDButton.ForeColor = Color.Green;

                ProgressBarInfo.Enabled = false;
                ProgressBarInfo.Visible = false;

                this.Text = Core.softwareNameShort + " " + Core.softwareName; ;

                Core.SaveCurrentSettings(settings);
            }
        }

        private void LocateSteamCMDButton_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "c:\\";
                ofd.FileName = "steamcmd";
                ofd.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
                ofd.FilterIndex = 1;
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.CheckFileExists)
                    {
                        steamCMDFolderPath = ofd.FileName;
                        settings.steamCMD_installLocation = steamCMDFolderPath;
                        LocateSteamCMDButton.Text = "SteamCMD Located ✓";
                        LocateSteamCMDButton.ForeColor = Color.Green;

                        Core.SaveCurrentSettings(settings);
                    }
                }
            }
        }

        private void OpenSteamCMDButton_Click(object sender, EventArgs e)
        {
            if (LocateSteamCMDButton.Text == "SteamCMD Located ✓")
            {
                Process.Start(new FileInfo(settings.steamCMD_installLocation).DirectoryName);
            }
            else MessageBox.Show("The directory of SteamCMD has not been setup yet.", "Error opening directory!");
        }

        private void OpenSteamCMDHelp_Click(object sender, EventArgs e) => Process.Start("https://developer.valvesoftware.com/wiki/SteamCMD");

        private void SteamServerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            App app = null;
            selectedInstalledApp = null;

            InstallServerButton.Enabled = false;
            DeleteServerButton.Enabled = false;

            App_InstallLocationBox.Text = "";

            foreach (var item in apps.Applist.Apps)
            {
                if (item.Appid == GetAppid(SteamServerList.SelectedItem.ToString()))
                {
                    app = item;
                    break;
                }
            }

            if(app != null)
            {
                selectedApp = app;
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

                App_installedLabel.Text = installed.ToString();
                App_idLabel.Text = app.Appid.ToString();
                App_nameLabel.Text = app.Name;

                if(selectedInstalledApp != null)
                {
                    if(!Directory.Exists(selectedInstalledApp.installPath))
                    {
                        MessageBox.Show("The server is registered as installed but the folder could not be found. Removing database entry...", "Install Directory Missing!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DeleteServer(selectedInstalledApp);
                        RefreshSelectedServerList();
                        return;
                    }
                    /* TODO: Add later...
                    else if(Directory.GetFiles(selectedInstalledApp.installPath, "*", SearchOption.AllDirectories).ToList().Count > 0)
                    {
                        MessageBox.Show("The server is registered as installed but the folder was detected as empty. Removing database entry...", "Install Directory Empty!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DeleteServer(selectedInstalledApp);
                        RefreshSelectedServerList();
                        return;
                    }*/

                    App_InstallLocationBox.Text = selectedInstalledApp.installPath;
                    if(Directory.Exists(App_InstallLocationBox.Text))
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

        private int GetAppid(string name)
        {
            string[] split = name.Split(']');
            if (split.Length > 1)
            {
                return Int32.Parse(split[0].Substring(1));
            }
            else return -1;
        }

        private void DeleteServer(InstalledServer selectedInstalledApp)
        {
            int removeID = -1;
            for (int i = 0; i < settings.installedServer.Count; i++)
            {
                if(settings.installedServer[i].app.Appid == selectedInstalledApp.app.Appid)
                {
                    removeID = i;
                    break;
                }
            }

            if(removeID != -1)
            {
                settings.installedServer.RemoveAt(removeID);
                Core.SaveCurrentSettings(settings);
            }
        }

        private void ServersRefreshButton_Click(object sender, EventArgs e)
        {
            App_InstallLocationBox.Enabled = false;
            OpenServerButton.Enabled = false;

            this.Text = Core.softwareNameShort + " " + Core.softwareName + " - Updating server list...";

            App_installedLabel.Text = "";
            App_idLabel.Text = "";
            App_nameLabel.Text = "";
            App_InstallLocationBox.Text = "";

            ProgressBarInfo.Value = 0;
            ProgressBarInfo.Enabled = true;
            ProgressBarInfo.Visible = true;

            ServersRefreshButton.Enabled = false;
            SteamServerList.Enabled = false;

            SteamServerList.Items.Clear();
            SteamServerList.Items.Add("Loading...");

            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Headers.Add("User-Agent", "Other");

                    wc.DownloadProgressChanged += Wc_DownloadProgressChangedList;
                    wc.DownloadStringCompleted += Wc_DownloadStringCompletedList;
                    wc.DownloadStringAsync(new Uri("https://api.steampowered.com/ISteamApps/GetAppList/v2/"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Wc_DownloadProgressChangedList(object sender, DownloadProgressChangedEventArgs e) => ProgressBarInfo.Value = e.ProgressPercentage;

        private void Wc_DownloadStringCompletedList(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Cancelled");
                return;
            }

            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
                return;
            }

            if (e.Result != "")
            {
                apps = JsonConvert.DeserializeObject<SteamApps>(e.Result);
                if (apps != null)
                {
                    List<int> removeIndexes = new List<int>();
                    for (int i = 0; i < apps.Applist.Apps.Count; i++)
                    {
                        if (!apps.Applist.Apps[i].Name.Contains("Server") || apps.Applist.Apps[i].Name.Contains("linux")) removeIndexes.Add(i);
                    }

                    removeIndexes.Sort();
                    removeIndexes.Reverse();

                    foreach (var item in removeIndexes) apps.Applist.Apps.RemoveAt(item);

                    GC.Collect();

                    SteamServerList.Items.Clear();

                    apps.Applist.Apps = apps.Applist.Apps.OrderBy(o => o.Name).ToList();

                    foreach (var item in apps.Applist.Apps)
                    {
                        SteamServerList.Items.Add("[" + item.Appid + "] " + item.Name);
                    }

                    SteamServerList.SelectedIndex = SteamServerList.FindString("[740] Counter-Strike Global Offensive - Dedicated Server");
                }
            }
            else
            {
                MessageBox.Show("The result was not expected. Exiting...");
                Environment.Exit(0);
            }

            OpenServerButton.Enabled = true;
            ProgressBarInfo.Enabled = false;
            ProgressBarInfo.Visible = false;

            SteamServerList.Enabled = true;
            ServersRefreshButton.Enabled = true;
            App_InstallLocationBox.Enabled = true;

            this.Text = Core.softwareNameShort + " " + Core.softwareName;
        }

        private void MainForm_Load(object sender, EventArgs e) 
        {
            this.Size = new Size(429, 339);

            InstallServerButton.Enabled = false;
            DeleteServerButton.Enabled = false;

            BottomLabel.Text = "(" + Core.softwareNameShort + ") " + Core.softwareName + " " + Core.GetVersion() + "\n\rCreated by " + Core.authorName + " AKA " + Core.authorRealName + "";
            ProjectLink.Text = "Github: n0tic/SteamServerCreationTool";

            settings = Core.LoadData();
            if(settings != null)
            {
                if(File.Exists(settings.steamCMD_installLocation))
                {
                    LocateSteamCMDButton.Text = "SteamCMD Located ✓";
                    LocateSteamCMDButton.ForeColor = Color.Green;
                }
            }
            else
            {
                settings = new Settings();
            }

            if(!Core.CheckNetwork())
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

                ServersRefreshButton_Click(null, EventArgs.Empty);
            }
        }

        private void App_InstallLocationBox_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select a location to install server:";
                fbd.ShowNewFolderButton = true;

                if (fbd.ShowDialog() == DialogResult.OK && Directory.Exists(fbd.SelectedPath))
                {
                    App_InstallLocationBox.Text = fbd.SelectedPath;

                    InstallServerButton.Enabled = true;
                    DeleteServerButton.Enabled = true;

                    if (selectedInstalledApp != null)
                    {
                        if(Directory.Exists(selectedInstalledApp.installPath) && Directory.GetFiles(selectedInstalledApp.installPath).Length > 1 && selectedInstalledApp.installPath != fbd.SelectedPath)
                            InstallServerButton.Text = "Move Server";
                        else InstallServerButton.Text = "Install Server";

                        DeleteServerButton.Enabled = true;
                    }
                    else
                    {
                        DeleteServerButton.Enabled = false;
                    }
                }
            }
        }

        private void InstallServerButton_Click(object sender, EventArgs e)
        {
            if(!File.Exists(settings.steamCMD_installLocation))
            {
                MessageBox.Show("The reference to steamCMD is either empty or steamCMD is missing! Please locate or install steamCMD.", "SteamCMD Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InstallServerButton.Enabled = false;

            if (InstallServerButton.Text == "Move Server")
            {
                new Thread(() => {

                    Invoke(new Action(() => {
                        ProgressBarInfo.Enabled = true;
                        ProgressBarInfo.Visible = true;
                    }));

                    Core.MoveFolder(selectedInstalledApp.installPath, App_InstallLocationBox.Text);

                    int tmpInt = -1;
                    for (int i = 0; i < settings.installedServer.Count; i++)
                    {
                        if(settings.installedServer[i].app.Appid == selectedInstalledApp.app.Appid)
                        {
                            tmpInt = i;
                            break;
                        }
                    }

                    if(tmpInt != -1) settings.installedServer[tmpInt].installPath = App_InstallLocationBox.Text;

                    Invoke(new Action(() => {
                        ProgressBarInfo.Enabled = false;
                        ProgressBarInfo.Visible = false;

                        InstallServerButton.Text = "Install Server";
                        InstallServerButton.Enabled = true;

                        Core.SaveCurrentSettings(settings);
                        RefreshSelectedServerList();
                    }));

                }).Start();
            }
            else
            {
                bool install = true;

                string validated = "";
                if (ValidateBox.Checked) validated = "validate ";
                else validated = "";

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

                if (Core.IsFolderEmpty(installDir))
                {
                    if(MessageBox.Show("It appears the installation folder is not empty.\n\rAre you sure you want to continue installing/updating this server?", "Directory Not Empty!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        InstallServerButton.Enabled = true;
                        MessageBox.Show("Install/Update aborted!");
                        return;
                    }
                }

                new Thread(() => {

                    using (Process process = new Process
                    {
                        StartInfo =
                        {
                            UseShellExecute = false,
                            FileName = settings.steamCMD_installLocation,
                            Arguments = "+login anonymous +force_install_dir \"" + installDir + "\" +app_update " + appID + " " + validated + "+quit"
                        }
                    })
                    {
                        try
                        {
                            process.Start();
                        }
                        catch (ObjectDisposedException x) { MessageBox.Show(x.Message); install = false; }
                        catch (InvalidOperationException x) { MessageBox.Show(x.Message); install = false; }
                        catch (Win32Exception x) { MessageBox.Show(x.Message); install = false; }

                        try
                        {
                            process.WaitForExit();
                        }
                        catch (Win32Exception x) { MessageBox.Show(x.Message); install = false; }
                        catch (OutOfMemoryException x) { MessageBox.Show(x.Message); install = false; }
                        catch (IOException x) { MessageBox.Show(x.Message); install = false; }
                        catch (SystemException x) { MessageBox.Show(x.Message); install = false; }

                        //Wait one second to give files a second to populate
                        Thread.Sleep(1000);

                        Invoke(new Action(() => {

                            //!Core.IsFolderEmpty(installDir)

                            if (install && selectedInstalledApp == null)
                            {
                                settings.installedServer.Add(new InstalledServer(installDir, selectedApp));
                                Core.SaveCurrentSettings(settings);
                            }

                            //Refresh data regardless of success.
                            RefreshSelectedServerList();

                            InstallServerButton.Enabled = true;
                        }));
                    }
                }).Start();
            }
        }

        private void RefreshSelectedServerList()
        {
            int tmpInt = SteamServerList.SelectedIndex;
            SteamServerList.SelectedIndex = 0;
            SteamServerList.SelectedIndex = tmpInt;
        }

        private void DeleteServerButton_Click(object sender, EventArgs e)
        {
            if(selectedInstalledApp != null)
            {
                try
                {
                    Directory.Delete(selectedInstalledApp.installPath, true);
                    int tmpInt = -1;
                    for (int i = 0; i < settings.installedServer.Count; i++)
                    {
                        if(settings.installedServer[i].app.Appid == selectedInstalledApp.app.Appid)
                        {
                            tmpInt = i;
                            break;
                        }
                    }

                    if (tmpInt != -1) settings.installedServer.RemoveAt(tmpInt);

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

        private void linkLabel1_Click(object sender, EventArgs e) => Process.Start("https://steamcommunity.com/dev/managegameservers?l=english");

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (SteamServerList.Items.Count > 0 && selectedApp != null)
            {
                string query = selectedApp.Name.Replace(' ', '+');
                Process.Start("https://www.google.com/search?q=" + query + "+server+setup");
            }
        }

        private void OpenServerButton_Click(object sender, EventArgs e)
        {
            if (selectedInstalledApp != null)
            {
                Process.Start(selectedInstalledApp.installPath);
            }
            else MessageBox.Show("The server doesnt appear to be in the database. Install the server first.", "Error opening directory!");
        }

        private void ProjectLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start(Core.projectURL);

        private void WindowExpander_Click(object sender, EventArgs e)
        {
            if(this.Size == new Size(429, 429))
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
