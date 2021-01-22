
namespace SteamServerCreationTool.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InstallCMDButton = new System.Windows.Forms.Button();
            this.LocateSteamCMDButton = new System.Windows.Forms.Button();
            this.SteamServerList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenSteamCMDHelp = new System.Windows.Forms.Button();
            this.OpenSteamCMDButton = new System.Windows.Forms.Button();
            this.ProgressBarInfo = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ServersRefreshButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ValidateBox = new System.Windows.Forms.CheckBox();
            this.DeleteServerButton = new System.Windows.Forms.Button();
            this.InstallServerButton = new System.Windows.Forms.Button();
            this.App_installedLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.App_nameLabel = new System.Windows.Forms.Label();
            this.App_idLabel = new System.Windows.Forms.Label();
            this.OpenServerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.App_InstallLocationBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tooltipper = new System.Windows.Forms.ToolTip(this.components);
            this.NewReleaseButton = new System.Windows.Forms.Button();
            this.WindowExpander = new System.Windows.Forms.PictureBox();
            this.UpdateAllServersButton = new System.Windows.Forms.Button();
            this.DeleteAllServersButton = new System.Windows.Forms.Button();
            this.ClearDatabaseSaveServerData = new System.Windows.Forms.Button();
            this.SequentialBox = new System.Windows.Forms.CheckBox();
            this.BottomLabel = new System.Windows.Forms.Label();
            this.ProjectLink = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExpandToSaveData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.githubProjectHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.GrayBackgroundPanel = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.InstalledServerList = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowExpander)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // InstallCMDButton
            // 
            this.InstallCMDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallCMDButton.Location = new System.Drawing.Point(6, 19);
            this.InstallCMDButton.Name = "InstallCMDButton";
            this.InstallCMDButton.Size = new System.Drawing.Size(156, 24);
            this.InstallCMDButton.TabIndex = 0;
            this.InstallCMDButton.Text = "Install SteamCMD";
            this.Tooltipper.SetToolTip(this.InstallCMDButton, "Install SteamCMD by selecting install location. Download and unpacking starts imm" +
        "ediately.");
            this.InstallCMDButton.UseVisualStyleBackColor = true;
            this.InstallCMDButton.Click += new System.EventHandler(this.InstallCMDButton_Click);
            // 
            // LocateSteamCMDButton
            // 
            this.LocateSteamCMDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocateSteamCMDButton.Location = new System.Drawing.Point(201, 19);
            this.LocateSteamCMDButton.Name = "LocateSteamCMDButton";
            this.LocateSteamCMDButton.Size = new System.Drawing.Size(156, 24);
            this.LocateSteamCMDButton.TabIndex = 1;
            this.LocateSteamCMDButton.Text = "Locate SteamCMD";
            this.Tooltipper.SetToolTip(this.LocateSteamCMDButton, "Locate \"steamcmd.exe\" on your drive.");
            this.LocateSteamCMDButton.UseVisualStyleBackColor = true;
            this.LocateSteamCMDButton.Click += new System.EventHandler(this.LocateSteamCMDButton_Click);
            // 
            // SteamServerList
            // 
            this.SteamServerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SteamServerList.FormattingEnabled = true;
            this.SteamServerList.Location = new System.Drawing.Point(6, 19);
            this.SteamServerList.Name = "SteamServerList";
            this.SteamServerList.Size = new System.Drawing.Size(311, 21);
            this.SteamServerList.TabIndex = 3;
            this.Tooltipper.SetToolTip(this.SteamServerList, "A full list of servers registered with steam.\r\nList is filtering away linux build" +
        "s and shows only servers with \"server\" in the name.");
            this.SteamServerList.SelectedIndexChanged += new System.EventHandler(this.SteamServerList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.InstallCMDButton);
            this.groupBox1.Controls.Add(this.OpenSteamCMDHelp);
            this.groupBox1.Controls.Add(this.LocateSteamCMDButton);
            this.groupBox1.Controls.Add(this.OpenSteamCMDButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 51);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SteamCMD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(194, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 25);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // OpenSteamCMDHelp
            // 
            this.OpenSteamCMDHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.OpenSteamCMDHelp.Location = new System.Drawing.Point(161, 19);
            this.OpenSteamCMDHelp.Name = "OpenSteamCMDHelp";
            this.OpenSteamCMDHelp.Size = new System.Drawing.Size(27, 24);
            this.OpenSteamCMDHelp.TabIndex = 8;
            this.OpenSteamCMDHelp.Text = "?";
            this.Tooltipper.SetToolTip(this.OpenSteamCMDHelp, "Valve SteamCMD Wiki page to find more information about SteamCMD.");
            this.OpenSteamCMDHelp.UseVisualStyleBackColor = true;
            this.OpenSteamCMDHelp.Click += new System.EventHandler(this.OpenSteamCMDHelp_Click);
            // 
            // OpenSteamCMDButton
            // 
            this.OpenSteamCMDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenSteamCMDButton.Image = global::SteamServerCreationTool.Properties.Resources._016_folder_24_EDIT;
            this.OpenSteamCMDButton.Location = new System.Drawing.Point(356, 19);
            this.OpenSteamCMDButton.Name = "OpenSteamCMDButton";
            this.OpenSteamCMDButton.Size = new System.Drawing.Size(27, 24);
            this.OpenSteamCMDButton.TabIndex = 4;
            this.Tooltipper.SetToolTip(this.OpenSteamCMDButton, "Open Directory");
            this.OpenSteamCMDButton.UseVisualStyleBackColor = true;
            this.OpenSteamCMDButton.Click += new System.EventHandler(this.OpenSteamCMDButton_Click);
            // 
            // ProgressBarInfo
            // 
            this.ProgressBarInfo.Enabled = false;
            this.ProgressBarInfo.Location = new System.Drawing.Point(0, 0);
            this.ProgressBarInfo.MarqueeAnimationSpeed = 1;
            this.ProgressBarInfo.Maximum = 10;
            this.ProgressBarInfo.Name = "ProgressBarInfo";
            this.ProgressBarInfo.Size = new System.Drawing.Size(413, 2);
            this.ProgressBarInfo.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBarInfo.TabIndex = 9;
            this.ProgressBarInfo.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Controls.Add(this.ServersRefreshButton);
            this.groupBox2.Controls.Add(this.SteamServerList);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 54);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Selector";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Image = global::SteamServerCreationTool.Properties.Resources._079_search_EDIT;
            this.SearchButton.Location = new System.Drawing.Point(324, 18);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(27, 23);
            this.SearchButton.TabIndex = 10;
            this.Tooltipper.SetToolTip(this.SearchButton, "Search for a server.");
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ServersRefreshButton
            // 
            this.ServersRefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServersRefreshButton.Image = global::SteamServerCreationTool.Properties.Resources._075_reload_EDIT;
            this.ServersRefreshButton.Location = new System.Drawing.Point(356, 18);
            this.ServersRefreshButton.Name = "ServersRefreshButton";
            this.ServersRefreshButton.Size = new System.Drawing.Size(27, 23);
            this.ServersRefreshButton.TabIndex = 9;
            this.Tooltipper.SetToolTip(this.ServersRefreshButton, "Refresh server list by downloading the new list from steam api.");
            this.ServersRefreshButton.UseVisualStyleBackColor = true;
            this.ServersRefreshButton.Click += new System.EventHandler(this.ServersRefreshButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel2);
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.ValidateBox);
            this.groupBox3.Controls.Add(this.DeleteServerButton);
            this.groupBox3.Controls.Add(this.InstallServerButton);
            this.groupBox3.Controls.Add(this.App_installedLabel);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.App_nameLabel);
            this.groupBox3.Controls.Add(this.App_idLabel);
            this.groupBox3.Controls.Add(this.OpenServerButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.App_InstallLocationBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox3.Location = new System.Drawing.Point(12, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 160);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server Information";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(319, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(69, 13);
            this.linkLabel2.TabIndex = 19;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Server Setup";
            this.Tooltipper.SetToolTip(this.linkLabel2, "This will launch the selected server as a google query for server setup. \r\nSome s" +
        "ervers have the same name and you may need to add the app id to the query.");
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.linkLabel1.Location = new System.Drawing.Point(6, 103);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(174, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Gameserver Login Tokens (GSLTs)";
            this.Tooltipper.SetToolTip(this.linkLabel1, resources.GetString("linkLabel1.ToolTip"));
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // ValidateBox
            // 
            this.ValidateBox.AutoSize = true;
            this.ValidateBox.Checked = true;
            this.ValidateBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ValidateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateBox.Location = new System.Drawing.Point(293, 105);
            this.ValidateBox.Name = "ValidateBox";
            this.ValidateBox.Size = new System.Drawing.Size(94, 17);
            this.ValidateBox.TabIndex = 16;
            this.ValidateBox.Text = "Validate Install";
            this.Tooltipper.SetToolTip(this.ValidateBox, "Should SteamCMD validate installation after completion?");
            this.ValidateBox.UseVisualStyleBackColor = true;
            // 
            // DeleteServerButton
            // 
            this.DeleteServerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteServerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteServerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteServerButton.Location = new System.Drawing.Point(9, 129);
            this.DeleteServerButton.Name = "DeleteServerButton";
            this.DeleteServerButton.Size = new System.Drawing.Size(103, 24);
            this.DeleteServerButton.TabIndex = 15;
            this.DeleteServerButton.Text = "Delete Server";
            this.Tooltipper.SetToolTip(this.DeleteServerButton, "This will delete all the server files and the install directory.\r\nIt will also de" +
        "lete the database entry for the server.\r\n");
            this.DeleteServerButton.UseVisualStyleBackColor = true;
            this.DeleteServerButton.Click += new System.EventHandler(this.DeleteServerButton_Click);
            // 
            // InstallServerButton
            // 
            this.InstallServerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallServerButton.Location = new System.Drawing.Point(290, 129);
            this.InstallServerButton.Name = "InstallServerButton";
            this.InstallServerButton.Size = new System.Drawing.Size(93, 24);
            this.InstallServerButton.TabIndex = 13;
            this.InstallServerButton.Text = "Install Server";
            this.Tooltipper.SetToolTip(this.InstallServerButton, resources.GetString("InstallServerButton.ToolTip"));
            this.InstallServerButton.UseVisualStyleBackColor = true;
            this.InstallServerButton.Click += new System.EventHandler(this.InstallServerButton_Click);
            // 
            // App_installedLabel
            // 
            this.App_installedLabel.AutoSize = true;
            this.App_installedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_installedLabel.Location = new System.Drawing.Point(71, 16);
            this.App_installedLabel.Name = "App_installedLabel";
            this.App_installedLabel.Size = new System.Drawing.Size(0, 13);
            this.App_installedLabel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Installed:";
            // 
            // App_nameLabel
            // 
            this.App_nameLabel.AutoSize = true;
            this.App_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_nameLabel.Location = new System.Drawing.Point(76, 46);
            this.App_nameLabel.Name = "App_nameLabel";
            this.App_nameLabel.Size = new System.Drawing.Size(0, 13);
            this.App_nameLabel.TabIndex = 8;
            // 
            // App_idLabel
            // 
            this.App_idLabel.AutoSize = true;
            this.App_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_idLabel.Location = new System.Drawing.Point(62, 31);
            this.App_idLabel.Name = "App_idLabel";
            this.App_idLabel.Size = new System.Drawing.Size(0, 13);
            this.App_idLabel.TabIndex = 7;
            // 
            // OpenServerButton
            // 
            this.OpenServerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenServerButton.Image = global::SteamServerCreationTool.Properties.Resources._016_folder_24_EDIT;
            this.OpenServerButton.Location = new System.Drawing.Point(356, 79);
            this.OpenServerButton.Name = "OpenServerButton";
            this.OpenServerButton.Size = new System.Drawing.Size(27, 22);
            this.OpenServerButton.TabIndex = 5;
            this.Tooltipper.SetToolTip(this.OpenServerButton, "Open Directory");
            this.OpenServerButton.UseVisualStyleBackColor = true;
            this.OpenServerButton.Click += new System.EventHandler(this.OpenServerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Install Location:";
            // 
            // App_InstallLocationBox
            // 
            this.App_InstallLocationBox.Location = new System.Drawing.Point(9, 80);
            this.App_InstallLocationBox.Name = "App_InstallLocationBox";
            this.App_InstallLocationBox.Size = new System.Drawing.Size(341, 20);
            this.App_InstallLocationBox.TabIndex = 2;
            this.Tooltipper.SetToolTip(this.App_InstallLocationBox, "This field requires a valid directory in which to install selected server.\r\nIf a " +
        "server is already installed you will get an option to move install directory.");
            this.App_InstallLocationBox.Click += new System.EventHandler(this.App_InstallLocationBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "App Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "App ID:";
            // 
            // Tooltipper
            // 
            this.Tooltipper.AutoPopDelay = 10000;
            this.Tooltipper.InitialDelay = 500;
            this.Tooltipper.ReshowDelay = 100;
            this.Tooltipper.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Tooltipper.ToolTipTitle = "Information";
            // 
            // NewReleaseButton
            // 
            this.NewReleaseButton.Enabled = false;
            this.NewReleaseButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.NewReleaseButton.FlatAppearance.BorderSize = 2;
            this.NewReleaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewReleaseButton.ForeColor = System.Drawing.Color.Green;
            this.NewReleaseButton.Location = new System.Drawing.Point(238, 10);
            this.NewReleaseButton.Name = "NewReleaseButton";
            this.NewReleaseButton.Size = new System.Drawing.Size(147, 22);
            this.NewReleaseButton.TabIndex = 14;
            this.NewReleaseButton.Text = "New Version Available!";
            this.Tooltipper.SetToolTip(this.NewReleaseButton, "A version miss-match was detected.\r\nClick to visit the project releases page to d" +
        "ownload a newer version!");
            this.NewReleaseButton.UseVisualStyleBackColor = true;
            this.NewReleaseButton.Visible = false;
            this.NewReleaseButton.Click += new System.EventHandler(this.NewReleaseButton_Click);
            // 
            // WindowExpander
            // 
            this.WindowExpander.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WindowExpander.Image = global::SteamServerCreationTool.Properties.Resources.Down;
            this.WindowExpander.Location = new System.Drawing.Point(197, 285);
            this.WindowExpander.Name = "WindowExpander";
            this.WindowExpander.Size = new System.Drawing.Size(15, 15);
            this.WindowExpander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WindowExpander.TabIndex = 14;
            this.WindowExpander.TabStop = false;
            this.Tooltipper.SetToolTip(this.WindowExpander, "View application information...");
            this.WindowExpander.Click += new System.EventHandler(this.WindowExpander_Click);
            // 
            // UpdateAllServersButton
            // 
            this.UpdateAllServersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAllServersButton.Location = new System.Drawing.Point(6, 19);
            this.UpdateAllServersButton.Name = "UpdateAllServersButton";
            this.UpdateAllServersButton.Size = new System.Drawing.Size(121, 24);
            this.UpdateAllServersButton.TabIndex = 13;
            this.UpdateAllServersButton.Text = "Update All Servers";
            this.Tooltipper.SetToolTip(this.UpdateAllServersButton, "Install SteamCMD by selecting install location. Download and unpacking starts imm" +
        "ediately.");
            this.UpdateAllServersButton.UseVisualStyleBackColor = true;
            this.UpdateAllServersButton.Click += new System.EventHandler(this.UpdateAllServersButton_Click);
            // 
            // DeleteAllServersButton
            // 
            this.DeleteAllServersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAllServersButton.Location = new System.Drawing.Point(133, 19);
            this.DeleteAllServersButton.Name = "DeleteAllServersButton";
            this.DeleteAllServersButton.Size = new System.Drawing.Size(121, 24);
            this.DeleteAllServersButton.TabIndex = 13;
            this.DeleteAllServersButton.Text = "Delete All Servers";
            this.Tooltipper.SetToolTip(this.DeleteAllServersButton, "Install SteamCMD by selecting install location. Download and unpacking starts imm" +
        "ediately.");
            this.DeleteAllServersButton.UseVisualStyleBackColor = true;
            this.DeleteAllServersButton.Click += new System.EventHandler(this.DeleteAllServersButton_Click);
            // 
            // ClearDatabaseSaveServerData
            // 
            this.ClearDatabaseSaveServerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearDatabaseSaveServerData.Location = new System.Drawing.Point(24, 49);
            this.ClearDatabaseSaveServerData.Name = "ClearDatabaseSaveServerData";
            this.ClearDatabaseSaveServerData.Size = new System.Drawing.Size(212, 24);
            this.ClearDatabaseSaveServerData.TabIndex = 15;
            this.ClearDatabaseSaveServerData.Text = "Clear Database, Save Server Data";
            this.Tooltipper.SetToolTip(this.ClearDatabaseSaveServerData, "Install SteamCMD by selecting install location. Download and unpacking starts imm" +
        "ediately.");
            this.ClearDatabaseSaveServerData.UseVisualStyleBackColor = true;
            this.ClearDatabaseSaveServerData.Click += new System.EventHandler(this.ClearDatabaseSaveServerData_Click);
            // 
            // SequentialBox
            // 
            this.SequentialBox.AutoSize = true;
            this.SequentialBox.Location = new System.Drawing.Point(51, 0);
            this.SequentialBox.Name = "SequentialBox";
            this.SequentialBox.Size = new System.Drawing.Size(76, 17);
            this.SequentialBox.TabIndex = 19;
            this.SequentialBox.Text = "Sequential";
            this.Tooltipper.SetToolTip(this.SequentialBox, "Should the actions run sequentially or paralell.");
            this.SequentialBox.UseVisualStyleBackColor = true;
            // 
            // BottomLabel
            // 
            this.BottomLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.BottomLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.BottomLabel.Location = new System.Drawing.Point(3, 16);
            this.BottomLabel.Name = "BottomLabel";
            this.BottomLabel.Size = new System.Drawing.Size(383, 64);
            this.BottomLabel.TabIndex = 12;
            this.BottomLabel.Text = "label5";
            // 
            // ProjectLink
            // 
            this.ProjectLink.AutoSize = true;
            this.ProjectLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProjectLink.Location = new System.Drawing.Point(3, 67);
            this.ProjectLink.Name = "ProjectLink";
            this.ProjectLink.Size = new System.Drawing.Size(107, 13);
            this.ProjectLink.TabIndex = 13;
            this.ProjectLink.TabStop = true;
            this.ProjectLink.Text = "Github/Project Home";
            this.ProjectLink.Click += new System.EventHandler(this.ProjectLink_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ProjectLink);
            this.groupBox4.Controls.Add(this.NewReleaseButton);
            this.groupBox4.Controls.Add(this.BottomLabel);
            this.groupBox4.Location = new System.Drawing.Point(12, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(389, 83);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Application Information";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton3,
            this.toolStripSeparator2,
            this.ExpandToSaveData,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripProgressBar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(693, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.ExitButton});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(81, 22);
            this.toolStripDropDownButton3.Text = "Application";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(173, 22);
            this.ExitButton.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ExpandToSaveData
            // 
            this.ExpandToSaveData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExpandToSaveData.Image = ((System.Drawing.Image)(resources.GetObject("ExpandToSaveData.Image")));
            this.ExpandToSaveData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExpandToSaveData.Name = "ExpandToSaveData";
            this.ExpandToSaveData.Size = new System.Drawing.Size(107, 22);
            this.ExpandToSaveData.Text = "Toggle Saved Data";
            this.ExpandToSaveData.Click += new System.EventHandler(this.InstalledServersButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubProjectHomeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(83, 22);
            this.toolStripDropDownButton1.Text = "Information";
            // 
            // githubProjectHomeToolStripMenuItem
            // 
            this.githubProjectHomeToolStripMenuItem.Name = "githubProjectHomeToolStripMenuItem";
            this.githubProjectHomeToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.githubProjectHomeToolStripMenuItem.Text = "Github / Project Home";
            this.githubProjectHomeToolStripMenuItem.Click += new System.EventHandler(this.ProjectLink_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.WindowExpander_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Enabled = false;
            this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(1, 0, 17, 4);
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(260, 21);
            this.toolStripProgressBar1.Visible = false;
            // 
            // GrayBackgroundPanel
            // 
            this.GrayBackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.GrayBackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.GrayBackgroundPanel.Name = "GrayBackgroundPanel";
            this.GrayBackgroundPanel.Size = new System.Drawing.Size(413, 2);
            this.GrayBackgroundPanel.TabIndex = 16;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.InstalledServerList);
            this.groupBox5.Location = new System.Drawing.Point(415, 117);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(260, 191);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Installed Server List";
            // 
            // InstalledServerList
            // 
            this.InstalledServerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstalledServerList.FormattingEnabled = true;
            this.InstalledServerList.Location = new System.Drawing.Point(3, 16);
            this.InstalledServerList.Name = "InstalledServerList";
            this.InstalledServerList.ScrollAlwaysVisible = true;
            this.InstalledServerList.Size = new System.Drawing.Size(254, 172);
            this.InstalledServerList.TabIndex = 1;
            this.InstalledServerList.SelectedIndexChanged += new System.EventHandler(this.InstalledServerList_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.SequentialBox);
            this.groupBox6.Controls.Add(this.ClearDatabaseSaveServerData);
            this.groupBox6.Controls.Add(this.UpdateAllServersButton);
            this.groupBox6.Controls.Add(this.DeleteAllServersButton);
            this.groupBox6.Location = new System.Drawing.Point(415, 31);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(260, 80);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(688, 414);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.ProgressBarInfo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.WindowExpander);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrayBackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSCT Steam Server Creation Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowExpander)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InstallCMDButton;
        private System.Windows.Forms.Button LocateSteamCMDButton;
        private System.Windows.Forms.Button OpenSteamCMDButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OpenSteamCMDHelp;
        private System.Windows.Forms.ProgressBar ProgressBarInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ServersRefreshButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox App_InstallLocationBox;
        private System.Windows.Forms.Button OpenServerButton;
        private System.Windows.Forms.Label App_nameLabel;
        private System.Windows.Forms.Label App_idLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label App_installedLabel;
        private System.Windows.Forms.Button InstallServerButton;
        private System.Windows.Forms.Button DeleteServerButton;
        private System.Windows.Forms.ToolTip Tooltipper;
        private System.Windows.Forms.CheckBox ValidateBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox WindowExpander;
        private System.Windows.Forms.Label BottomLabel;
        private System.Windows.Forms.LinkLabel ProjectLink;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button NewReleaseButton;
        private System.Windows.Forms.Button SearchButton;
        public System.Windows.Forms.ComboBox SteamServerList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem githubProjectHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel GrayBackgroundPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox InstalledServerList;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button UpdateAllServersButton;
        private System.Windows.Forms.Button DeleteAllServersButton;
        private System.Windows.Forms.Button ClearDatabaseSaveServerData;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ExpandToSaveData;
        private System.Windows.Forms.CheckBox SequentialBox;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}