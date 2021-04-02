using SteamServerCreationTool.Data;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SteamServerCreationTool.Forms
{
    public partial class CreateServerForm : Form
    {
        public bool ok = false;
        private MainForm main;
        private Data.App app;

        public CreateServerForm(MainForm main, Data.App app)
        {
            InitializeComponent();
            this.main = main;
            this.app = app;
        }

        private void CreateServerForm_Load(object sender, EventArgs e)
        {
            if (app != null)
            {
                NameTextbox.Text = app.Name;
                app_name.Text = app.Name;
                app_id.Text = app.Appid.ToString();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (app != null)
            {
                string name = app.Name;
                string query = name.Replace(' ', '+');
                Process.Start("https://www.google.com/search?q=" + query + "+server+setup");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://steamcommunity.com/dev/managegameservers?l=english");

        private void InstallDirButton_Click(object sender, EventArgs e)
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
                }
            }
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            bool unique = true;
            foreach (var installed in main.settings.installedServer)
            {
                if (installed.name == NameTextbox.Text)
                {
                    unique = false;
                    break;
                }
            }

            if (!Directory.Exists(App_InstallLocationBox.Text))
            {
                MessageBox.Show("The selected directory is not valid or does not exist. \n\rPlease select a valid installation directory and try again.", "Directory Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*
             * Give the user a warning if the install directory is not empty.
             * A precaution so that the user dont install eg. CSGO server onto an Ark Server
             * which may have conflicting files, which in turn, destroys another server.
            */
            if (Core.IsFolderEmpty(App_InstallLocationBox.Text))
            {
                if (MessageBox.Show("It appears the installation folder is not empty.\n\rAre you sure you want to continue installing/updating this server?", "Directory Not Empty!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            if (unique)
            {
                StartSteamCMDServerDownload(app);

                DialogResult = DialogResult.OK;
                Close();
            }
            else MessageBox.Show("There is aready a server with that name. \n\rPlease chose a unique name for the server.", "Name Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StartSteamCMDServerDownload(Data.App app, bool skip = false)
        {
            //Keep track of success
            bool install = true;

            //This needs no explanation, no? It simply updates data with provided defaults if new install
            string validated = "";
            if (ValidateBox.Checked) validated = "validate ";
            else validated = "";

            string installDir = App_InstallLocationBox.Text;
            string appID = app.Appid.ToString();

            string login = main.settings.GetLogin();
            if(login == null) if (MessageBox.Show("Login information has failed validation.\n\rContinue with anonymous download?", "Login Information Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No) return;

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
                            FileName = main.settings.steamCMD_installLocation,
                            Arguments = "+login " + login + " +force_install_dir \"" + installDir + "\" +app_update " + appID + " " + validated + "+quit" // Building argument string
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
                    if (install)
                    {
                        string startScript = Properties.Resources.StartServerScript;
                        startScript = startScript.Replace("{steamcmd_dir}", "\"" + Path.GetDirectoryName(main.settings.steamCMD_installLocation) + "\"");
                        startScript = startScript.Replace("{server_dir}", installDir);
                        startScript = startScript.Replace("{app_id}", appID);
                        startScript = startScript.Replace("{app_name}", app.Name);

                        Core.SaveToFile(installDir + @"\StartServerScript.bat", startScript);

                        main.settings.installedServer.Add(new InstalledServer(NameTextbox.Text, installDir, app));
                        Core.SaveSettings(main.settings);

                        System.Media.SystemSounds.Exclamation.Play();
                    }
                }
            }).Start();
        }
    }
}