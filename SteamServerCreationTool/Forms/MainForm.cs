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
            // TODO: If found...

            /*
             new Thread(() => {

                Invoke(new Action(() => {
                    UpdateSteamCMDButton.Enabled = false;
                }));

                using (Process process = new Process
                {
                    StartInfo =
                {
                    UseShellExecute = false,
                    FileName = test,
                    Arguments = "+quit"
                }
                })
                {
                    try
                    {
                        process.Start();
                    }
                    catch (ObjectDisposedException x) { MessageBox.Show(x.Message); }
                    catch (InvalidOperationException x) { MessageBox.Show(x.Message); }
                    catch (Win32Exception x) { MessageBox.Show(x.Message); }

                    try
                    {
                        process.WaitForExit();
                    }
                    catch (Win32Exception x) { MessageBox.Show(x.Message); }
                    catch (OutOfMemoryException x) { MessageBox.Show(x.Message); }
                    catch (IOException x) { MessageBox.Show(x.Message); }
                    catch (SystemException x) { MessageBox.Show(x.Message); }

                    Invoke(new Action(() => {
                        UpdateSteamCMDButton.Enabled = true;
                    }));
                }
            }).Start();
             */



            using (WebClient wc = new WebClient())
            {
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

                        ProgressBarInfo.Enabled = true;
                        ProgressBarInfo.Visible = true;

                        installedSteamCMDPath = Path.Combine(steamCMDFolderPath, "steamcmd.exe");
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
                        LocateSteamCMDButton.Text = "SteamCMD Located ✓";
                        LocateSteamCMDButton.ForeColor = Color.Green;
                    }
                }
            }
        }

        private void OpenSteamCMDButton_Click(object sender, EventArgs e)
        {
            SteamServerList.SelectedIndex = 5;
        }

        private void OpenSteamCMDHelp_Click(object sender, EventArgs e) => Process.Start("https://developer.valvesoftware.com/wiki/SteamCMD");

        private void SteamServerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            App app = null;

            InstallServerButton.Enabled = false;
            DeleteServerButton.Enabled = false;

            foreach (var item in apps.Applist.Apps)
            {
                if(item.Name == SteamServerList.SelectedItem.ToString())
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
                    if (settings.installedServer[i].app.Name == app.Name)
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
            }
        }

        private void ServersRefreshButton_Click(object sender, EventArgs e)
        {
            App_InstallLocationBox.Enabled = false;

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

                    foreach (var item in apps.Applist.Apps) SteamServerList.Items.Add(item.Name);

                    SteamServerList.SelectedIndex = SteamServerList.FindString("Counter-Strike Global Offensive - Dedicated Server");

                    ProgressBarInfo.Enabled = false;
                    ProgressBarInfo.Visible = false;
                    SteamServerList.Enabled = true;
                    ServersRefreshButton.Enabled = true;
                    App_InstallLocationBox.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("The result was not exptected. Exiting...");
                Environment.Exit(0);
            }
        }

        private void MainForm_Load(object sender, EventArgs e) 
        {
            InstallServerButton.Enabled = false;
            DeleteServerButton.Enabled = false;

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
            new Thread(() => {

                bool install = true;

                Invoke(new Action(() => {
                    InstallServerButton.Enabled = false;
                }));

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

                    Invoke(new Action(() => {
                        if(install && selectedInstalledApp == null)
                        {
                            settings.installedServer.Add(new InstalledServer(installDir, selectedApp));
                            Core.SaveCurrentSettings(settings);
                        }

                        int tmpInt = SteamServerList.SelectedIndex;
                        SteamServerList.SelectedIndex = 0;
                        SteamServerList.SelectedIndex = tmpInt;

                        InstallServerButton.Enabled = true;
                    }));
                }
            }).Start();
        }

        private void DeleteServerButton_Click(object sender, EventArgs e)
        {
            if(selectedInstalledApp != null)
            {
                File.Delete(selectedInstalledApp.installPath);
                SteamServerList.SelectedIndex = SteamServerList.SelectedIndex;
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
    }
}
