using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamServerCreationTool.Forms
{
    public partial class ManageInstallsForm : Form
    {
        MainForm main;

        Data.InstalledServer app = null;

        public ManageInstallsForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void ManageInstallsForm_Load(object sender, EventArgs e) => PopulateDataField();

        private void PopulateDataField()
        {
            InstalledServerList.Items.Clear();

            foreach (var item in main.settings.installedServer) InstalledServerList.Items.Add(item.name);
        }

        private void InstalledServerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                app = null;
                foreach (var item in main.settings.installedServer)
                {
                    if(InstalledServerList.Items[InstalledServerList.SelectedIndex].ToString() == item.name)
                    {
                        app = item;
                        break;
                    }
                }

                if(app != null)
                {
                    textBox1.Text = app.name;
                    app_id_label.Text = app.app.Appid.ToString();
                    app_name_label.Text = app.app.Name;
                    App_InstallLocationBox.Text = app.installPath;

                    UpdateSelectedButton.Enabled = true;
                    DeleteSelectedButton.Enabled = true;
                    UpdateServerNameButton.Enabled = true;

                    if(!Directory.Exists(app.installPath))
                    {
                        DialogResult test = MessageBox.Show("The installation folder was not found!\n\rDo you want to remove this database entry?", "Directory Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        switch(test)
                        {
                            case DialogResult.Yes:
                                DeleteServer(app);
                                PopulateDataField();
                                app = null;

                                textBox1.Text = "";
                                app_id_label.Text = "";
                                app_name_label.Text = "";
                                App_InstallLocationBox.Text = "";

                                UpdateSelectedButton.Enabled = false;
                                DeleteSelectedButton.Enabled = false;
                                UpdateServerNameButton.Enabled = false;

                                break;
                            case DialogResult.No: return;
                        }
                    }
                }
                else
                {
                    textBox1.Text = "";
                    app_id_label.Text = "";
                    app_name_label.Text = "";
                    App_InstallLocationBox.Text = "";

                    UpdateSelectedButton.Enabled = false;
                    DeleteSelectedButton.Enabled = false;
                    UpdateServerNameButton.Enabled = false;
                }
            }
            catch { }
        }

        private void DeleteServer(Data.InstalledServer selectedInstalledApp)
        {
            //Get index of installed server
            int removeID = -1;
            for (int i = 0; i < main.settings.installedServer.Count; i++)
            {
                if (main.settings.installedServer[i].name == selectedInstalledApp.name)
                {
                    removeID = i;
                    break;
                }
            }

            // if the index was found
            if (removeID != -1)
            {
                //Remove index, save.
                main.settings.installedServer.RemoveAt(removeID);
                Core.SaveCurrentSettings(main.settings);
            }
        }

        private void UpdateAllServersButton_Click(object sender, EventArgs e)
        {
            UpdateAllServersButton.Enabled = false;
            DeleteAllServersButton.Enabled = false;
            DeleteSelectedButton.Enabled = false;

            ProgressBarInfo.Enabled = true;
            ProgressBarInfo.Visible = true;
            ProgressBarInfo.Value = 0;
            ProgressBarInfo.Maximum = main.settings.installedServer.Count;

            // TODO: fix later
            /*
            if (SequentialBox.Checked)
            {
                string validated = "";
                if (main.ValidateBox.Checked) validated = "validate ";
                else validated = "";

                // Start a new thread with the installation as async using user input
                new Thread(() =>
                {
                    for (int i = 0; i < main.settings.installedServer.Count; i++)
                    {
                        //settings.installedServer[i]
                        Thread processX = new Thread(() =>
                        {
                            //Initiating process
                            using (Process process = new Process
                            {
                                //Setting startinfo
                                StartInfo =
                                    {
                                        UseShellExecute = false,
                                        FileName = main.settings.steamCMD_installLocation,
                                        Arguments = "+login anonymous +force_install_dir \"" + main.settings.installedServer[i].installPath + "\" +app_update " + main.settings.installedServer[i].app.Appid + " " + validated + "+quit" // Building argument string
                                    }
                                })
                            {
                                //Try starting the process
                                try
                                {
                                    process.Start();
                                }
                                catch (ObjectDisposedException x) { MessageBox.Show(x.Message); }
                                catch (InvalidOperationException x) { MessageBox.Show(x.Message); }
                                catch (Win32Exception x) { MessageBox.Show(x.Message); }

                                //Wait for process to stop, if it exists.
                                try
                                {
                                    process?.WaitForExit();
                                }
                                catch (Win32Exception x) { MessageBox.Show(x.Message); }
                                catch (OutOfMemoryException x) { MessageBox.Show(x.Message); }
                                catch (IOException x) { MessageBox.Show(x.Message); }
                                catch (SystemException x) { MessageBox.Show(x.Message); }
                            }
                        });

                        processX.Start();

                        while (processX.IsAlive) Thread.Sleep(1000);

                        Invoke(new Action(() => {
                            ProgressBarInfo.Value++;
                        }));
                    }

                    Invoke(new Action(() => {
                        UpdateAllServersButton.Enabled = true;
                        DeleteAllServersButton.Enabled = true;
                        DeleteSelectedButton.Enabled = true;

                        ProgressBarInfo.Enabled = false;
                        ProgressBarInfo.Visible = false;
                    }));

                }).Start();
            }
            else
            {
                for (int i = 0; i < main.settings.installedServer.Count; i++)
                {
                    main.StartSteamCMDServerDownload(main.settings.installedServer[i], true);
                }

                UpdateAllServersButton.Enabled = true;
                DeleteAllServersButton.Enabled = true;
                DeleteSelectedButton.Enabled = true;

                ProgressBarInfo.Enabled = false;
                ProgressBarInfo.Visible = false;
            } */
        }

        private void DeleteAllServersButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("For now, this feature is running on the main thread; meaning that this feature will temporarily freeze the application from user inputs until the process has finished. Do not close the application. Are you sure you want to continue?", "BEFORE PROCEEDING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            UpdateAllServersButton.Enabled = false;
            DeleteAllServersButton.Enabled = false;
            DeleteSelectedButton.Enabled = false;

            ProgressBarInfo.Enabled = true;
            ProgressBarInfo.Visible = true;
            ProgressBarInfo.Value = 0;
            ProgressBarInfo.Maximum = main.settings.installedServer.Count;

            List<int> tmpInt = new List<int>();

            foreach (var item in main.settings.installedServer)
            {
                try
                {
                    Directory.Delete(item.installPath, true);
                }
                catch (PathTooLongException x) { MessageBox.Show(x.Message); }
                catch (DirectoryNotFoundException x) { MessageBox.Show(x.Message); }
                catch (IOException x) { MessageBox.Show(x.Message); }
                catch (UnauthorizedAccessException x) { MessageBox.Show(x.Message); }
                catch (ArgumentNullException x) { MessageBox.Show(x.Message); }
                catch (ArgumentException x) { MessageBox.Show(x.Message); }

                //Get index of installed app
                for (int x = 0; x < main.settings.installedServer.Count; x++)
                {
                    if (main.settings.installedServer[x].app.Appid == item.app.Appid)
                    {
                        tmpInt.Add(x);
                        break;
                    }
                }
            }

            tmpInt.Sort();
            tmpInt.Reverse();

            foreach (var item in tmpInt)
            {
                main.settings.installedServer.RemoveAt(item);
            }

            UpdateAllServersButton.Enabled = true;
            DeleteAllServersButton.Enabled = true;
            DeleteSelectedButton.Enabled = true;

            ProgressBarInfo.Enabled = false;
            ProgressBarInfo.Visible = false;

            PopulateDataField();
            Core.SaveCurrentSettings(main.settings);
        }

        private void ClearDatabaseSaveServerData_Click(object sender, EventArgs e)
        {
            //Clear and lastly, refresh.
            InstalledServerList.Items.Clear();
            main.settings.installedServer.Clear();

            //Save
            Core.SaveCurrentSettings(main.settings);
        }

        private void InstallDirButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Make sure the server is offline before proceeding. This may result in server corruption.", "Directory Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }
            
            //Initialize FolderBrowserDialog
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                //Set FolderBrowserDialog information
                fbd.Description = "Select a location to move server to:";
                fbd.ShowNewFolderButton = true;

                // Show FolderBrowserDialog dialogue and check if selection is valid
                if (fbd.ShowDialog() == DialogResult.OK && Directory.Exists(fbd.SelectedPath))
                {

                    if(app!= null && app.installPath != fbd.SelectedPath)
                    {
                        if (MessageBox.Show("Are you sure you want to move the install directory of this server?", "Directory Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            //Initiate new Thread to async the move of server files.
                            new Thread(() =>
                            {
                                //Start progressbar
                                Invoke(new Action(() => {
                                    UpdateAllServersButton.Enabled = false;
                                    DeleteAllServersButton.Enabled = false;
                                    UpdateSelectedButton.Enabled = false;
                                    DeleteSelectedButton.Enabled = false;
                                    UpdateServerNameButton.Enabled = false;
                                    InstallDirButton.Enabled = false;
                                    OpenServerButton.Enabled = false;

                                    ProgressBarInfo.Enabled = true;
                                    ProgressBarInfo.Visible = true;
                                }));

                                //Move folders, subfolders and files
                                Core.MoveFolder(app.installPath, fbd.SelectedPath);
                                app.installPath = fbd.SelectedPath;

                                //Get install index
                                /*int tmpInt = -1;
                                for (int i = 0; i < settings.installedServer.Count; i++)
                                {
                                    if (settings.installedServer[i].app.Appid == selectedInstalledApp.app.Appid)
                                    {
                                        tmpInt = i;
                                        break;
                                    }
                                }*/

                                //If we found installation, change installed directory
                                //if (tmpInt != -1) settings.installedServer[tmpInt].installPath = App_InstallLocationBox.Text;

                                //Stop progressbar, modify button, save new settings and lastly, refresh list.
                                Invoke(new Action(() => {
                                    UpdateAllServersButton.Enabled = true;
                                    DeleteAllServersButton.Enabled = true;
                                    UpdateSelectedButton.Enabled = true;
                                    DeleteSelectedButton.Enabled = true;
                                    UpdateServerNameButton.Enabled = true;
                                    InstallDirButton.Enabled = true;
                                    OpenServerButton.Enabled = true;

                                    ProgressBarInfo.Enabled = false;
                                    ProgressBarInfo.Visible = false;

                                    Core.SaveCurrentSettings(main.settings);
                                }));
                            }).Start();
                        }
                    }
                }
            }
        }

        private void OpenServerButton_Click(object sender, EventArgs e)
        {
            if (app != null) Process.Start(app.installPath);
            else MessageBox.Show("The server doesnt appear to be in the database. Install the server first.", "Error opening directory!");
        }

        private void UpdateServerNameButton_Click(object sender, EventArgs e)
        {
            if(app != null)
            {
                if(!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    bool unique = true;
                    foreach (var installed in main.settings.installedServer)
                    {
                        if (installed.name == textBox1.Text)
                        {
                            unique = false;
                            break;
                        }
                    }

                    if(unique)
                    {
                        app.name = textBox1.Text;
                        PopulateDataField();
                        InstalledServerList.SelectedIndex = InstalledServerList.FindStringExact(app.name);
                    }
                    else MessageBox.Show("There is aready a server with that name. \n\rPlease chose a unique name for the server.", "Name Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("The name cannot be empty or just a whitespace.", "Name Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            if (app != null)
            {
                try
                {
                    //Delete directory with all files.
                    try
                    {
                        Directory.Delete(app.installPath, true);
                    }
                    catch (PathTooLongException x) { MessageBox.Show(x.Message); }
                    catch (DirectoryNotFoundException x) { MessageBox.Show(x.Message); }
                    catch (IOException x) { MessageBox.Show(x.Message); }
                    catch (UnauthorizedAccessException x) { MessageBox.Show(x.Message); }
                    catch (ArgumentNullException x) { MessageBox.Show(x.Message); }
                    catch (ArgumentException x) { MessageBox.Show(x.Message); }

                    //Get index of installed app
                    int tmpInt = -1;
                    for (int i = 0; i < main.settings.installedServer.Count; i++)
                    {
                        if (main.settings.installedServer[i].name == app.name)
                        {
                            tmpInt = i;
                            break;
                        }
                    }

                    //Remove index
                    if (tmpInt != -1) main.settings.installedServer.RemoveAt(tmpInt);

                    //Refresh and save
                    Core.SaveCurrentSettings(main.settings);
                }
                catch (ArgumentNullException x) { MessageBox.Show(x.Message); }
                catch (PathTooLongException x) { MessageBox.Show(x.Message); }
                catch (DirectoryNotFoundException x) { MessageBox.Show(x.Message); }
                catch (IOException x) { MessageBox.Show(x.Message); }
                catch (UnauthorizedAccessException x) { MessageBox.Show(x.Message); }
                catch (ArgumentException x) { MessageBox.Show(x.Message); }
            }
        }
    }
}
