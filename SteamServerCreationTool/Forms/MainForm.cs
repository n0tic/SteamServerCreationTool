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

                    if (fbd.ShowDialog() == DialogResult.OK)
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
                app.Appid.ToString();

                ProgressBarInfo.Enabled = true;
                ProgressBarInfo.Visible = true;

                using(WebClient wc = new WebClient())
                {
                    wc.Headers.Add("User-Agent", "Other");

                    wc.DownloadStringCompleted += Wc_DownloadStringCompleted;
                    wc.DownloadStringAsync(new Uri(Core.appDetailsURL + app.Appid.ToString()));
                }
            }
        }

        private void Wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            ProgressBarInfo.Enabled = false;
            ProgressBarInfo.Visible = false;

            if (e.Cancelled)
            {
                MessageBox.Show("Downloading of app details was cancelled.");
                return;
            }

            if(e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
                return;
            }

            Console.WriteLine(e.Result);
        }

        private void ServersRefreshButton_Click(object sender, EventArgs e)
        {
            ProgressBarInfo.Value = 0;
            ProgressBarInfo.Enabled = true;
            ProgressBarInfo.Visible = true;

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

                    foreach (var item in apps.Applist.Apps) SteamServerList.Items.Add("[" + item.Appid.ToString() + "] " + item.Name);

                    SteamServerList.SelectedIndex = SteamServerList.FindString("[740] Counter-Strike Global Offensive - Dedicated Server");

                    ProgressBarInfo.Enabled = false;
                    ProgressBarInfo.Visible = false;
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
            //InstallCMDButton.Enabled = false;
            SteamServerList.Enabled = false;

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

            if(Core.CheckNetwork())
            {
                ServersRefreshButton_Click(null, EventArgs.Empty);
            }
            else
            {

            }
        }
    }
}
