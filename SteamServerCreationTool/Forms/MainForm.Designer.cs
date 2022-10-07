
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
            this.SteamServerList = new System.Windows.Forms.ComboBox();
            this.ProgressBarInfo = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TotalServerLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ServersRefreshButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.InstallServerButton = new System.Windows.Forms.Button();
            this.App_nameLabel = new System.Windows.Forms.Label();
            this.App_idLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tooltipper = new System.Windows.Forms.ToolTip(this.components);
            this.AutoInstallButton = new System.Windows.Forms.Button();
            this.SteamCMDInfoButton = new System.Windows.Forms.Button();
            this.ManuallyLocateSteamCMDButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Button_VisitDownloadButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExpandToSaveData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.githubProjectHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshServerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsButton = new System.Windows.Forms.ToolStripButton();
            this.GrayBackgroundPanel = new System.Windows.Forms.Panel();
            this.SteamCMD_InstallBox = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SteamCMD_LocatedBox = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SteamCMD_InstallBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SteamCMD_LocatedBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
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
            // ProgressBarInfo
            // 
            this.ProgressBarInfo.Enabled = false;
            this.ProgressBarInfo.Location = new System.Drawing.Point(0, 0);
            this.ProgressBarInfo.MarqueeAnimationSpeed = 1;
            this.ProgressBarInfo.Maximum = 10;
            this.ProgressBarInfo.Name = "ProgressBarInfo";
            this.ProgressBarInfo.Size = new System.Drawing.Size(419, 2);
            this.ProgressBarInfo.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBarInfo.TabIndex = 9;
            this.ProgressBarInfo.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TotalServerLabel);
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
            // TotalServerLabel
            // 
            this.TotalServerLabel.AutoSize = true;
            this.TotalServerLabel.Location = new System.Drawing.Point(86, 0);
            this.TotalServerLabel.Name = "TotalServerLabel";
            this.TotalServerLabel.Size = new System.Drawing.Size(19, 13);
            this.TotalServerLabel.TabIndex = 11;
            this.TotalServerLabel.Text = "(0)";
            this.Tooltipper.SetToolTip(this.TotalServerLabel, "Total Servers Found");
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
            this.groupBox3.Controls.Add(this.InstallServerButton);
            this.groupBox3.Controls.Add(this.App_nameLabel);
            this.groupBox3.Controls.Add(this.App_idLabel);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox3.Location = new System.Drawing.Point(12, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 83);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server Information";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(7, 50);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(69, 13);
            this.linkLabel2.TabIndex = 19;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Server Setup";
            this.Tooltipper.SetToolTip(this.linkLabel2, "This will launch the selected server as a google query for server setup. \r\nSome s" +
        "ervers have the same name and you may need to add the app id to the query.");
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.linkLabel1.Location = new System.Drawing.Point(7, 67);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(174, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Gameserver Login Tokens (GSLTs)";
            this.Tooltipper.SetToolTip(this.linkLabel1, resources.GetString("linkLabel1.ToolTip"));
            this.linkLabel1.Click += new System.EventHandler(this.LinkLabel1_Click);
            // 
            // InstallServerButton
            // 
            this.InstallServerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallServerButton.Location = new System.Drawing.Point(290, 50);
            this.InstallServerButton.Name = "InstallServerButton";
            this.InstallServerButton.Size = new System.Drawing.Size(93, 24);
            this.InstallServerButton.TabIndex = 13;
            this.InstallServerButton.Text = "Create Server";
            this.Tooltipper.SetToolTip(this.InstallServerButton, resources.GetString("InstallServerButton.ToolTip"));
            this.InstallServerButton.UseVisualStyleBackColor = true;
            this.InstallServerButton.Click += new System.EventHandler(this.InstallServerButton_Click);
            // 
            // App_nameLabel
            // 
            this.App_nameLabel.AutoSize = true;
            this.App_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_nameLabel.Location = new System.Drawing.Point(76, 16);
            this.App_nameLabel.Name = "App_nameLabel";
            this.App_nameLabel.Size = new System.Drawing.Size(0, 13);
            this.App_nameLabel.TabIndex = 8;
            // 
            // App_idLabel
            // 
            this.App_idLabel.AutoSize = true;
            this.App_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_idLabel.Location = new System.Drawing.Point(62, 32);
            this.App_idLabel.Name = "App_idLabel";
            this.App_idLabel.Size = new System.Drawing.Size(0, 13);
            this.App_idLabel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "App Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 32);
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
            // AutoInstallButton
            // 
            this.AutoInstallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoInstallButton.Image = global::SteamServerCreationTool.Properties.Resources._016_double_chevron;
            this.AutoInstallButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AutoInstallButton.Location = new System.Drawing.Point(3, 19);
            this.AutoInstallButton.Name = "AutoInstallButton";
            this.AutoInstallButton.Size = new System.Drawing.Size(93, 24);
            this.AutoInstallButton.TabIndex = 0;
            this.AutoInstallButton.Text = "Auto-Install";
            this.AutoInstallButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Tooltipper.SetToolTip(this.AutoInstallButton, "Install SteamCMD by selecting install location. Download and unpacking starts imm" +
        "ediately.");
            this.AutoInstallButton.UseVisualStyleBackColor = true;
            this.AutoInstallButton.Click += new System.EventHandler(this.InstallCMDButton_Click);
            // 
            // SteamCMDInfoButton
            // 
            this.SteamCMDInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.SteamCMDInfoButton.Location = new System.Drawing.Point(96, 19);
            this.SteamCMDInfoButton.Name = "SteamCMDInfoButton";
            this.SteamCMDInfoButton.Size = new System.Drawing.Size(27, 24);
            this.SteamCMDInfoButton.TabIndex = 8;
            this.SteamCMDInfoButton.Text = "?";
            this.Tooltipper.SetToolTip(this.SteamCMDInfoButton, "Valve SteamCMD Wiki page to find more information about SteamCMD.");
            this.SteamCMDInfoButton.UseVisualStyleBackColor = true;
            this.SteamCMDInfoButton.Click += new System.EventHandler(this.OpenSteamCMDHelp_Click);
            // 
            // ManuallyLocateSteamCMDButton
            // 
            this.ManuallyLocateSteamCMDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManuallyLocateSteamCMDButton.Image = global::SteamServerCreationTool.Properties.Resources._031_ellipsis;
            this.ManuallyLocateSteamCMDButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManuallyLocateSteamCMDButton.Location = new System.Drawing.Point(130, 19);
            this.ManuallyLocateSteamCMDButton.Name = "ManuallyLocateSteamCMDButton";
            this.ManuallyLocateSteamCMDButton.Size = new System.Drawing.Size(125, 24);
            this.ManuallyLocateSteamCMDButton.TabIndex = 1;
            this.ManuallyLocateSteamCMDButton.Text = "Manually Locate";
            this.ManuallyLocateSteamCMDButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Tooltipper.SetToolTip(this.ManuallyLocateSteamCMDButton, "Locate \"steamcmd.exe\" on your drive.");
            this.ManuallyLocateSteamCMDButton.UseVisualStyleBackColor = true;
            this.ManuallyLocateSteamCMDButton.Click += new System.EventHandler(this.LocateSteamCMDButton_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Green;
            this.button7.Location = new System.Drawing.Point(6, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(351, 24);
            this.button7.TabIndex = 1;
            this.button7.Text = "SteamCMD Located ✓";
            this.Tooltipper.SetToolTip(this.button7, "Locate \"steamcmd.exe\" on your drive.");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.InstallCMDButton_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = global::SteamServerCreationTool.Properties.Resources._016_folder_24_EDIT;
            this.button8.Location = new System.Drawing.Point(356, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(27, 24);
            this.button8.TabIndex = 4;
            this.Tooltipper.SetToolTip(this.button8, "Open SteamCMD Directory");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.OpenSteamCMDButton_Click);
            // 
            // Button_VisitDownloadButton
            // 
            this.Button_VisitDownloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_VisitDownloadButton.Image = global::SteamServerCreationTool.Properties.Resources._021_browser;
            this.Button_VisitDownloadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_VisitDownloadButton.Location = new System.Drawing.Point(262, 19);
            this.Button_VisitDownloadButton.Name = "Button_VisitDownloadButton";
            this.Button_VisitDownloadButton.Size = new System.Drawing.Size(121, 24);
            this.Button_VisitDownloadButton.TabIndex = 13;
            this.Button_VisitDownloadButton.Text = "Visit Download";
            this.Button_VisitDownloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Tooltipper.SetToolTip(this.Button_VisitDownloadButton, "Visit the download page for SteamCMD. Read up on how to use it and unpack it your" +
        "self.");
            this.Button_VisitDownloadButton.UseVisualStyleBackColor = true;
            this.Button_VisitDownloadButton.Click += new System.EventHandler(this.Button_VisitDownloadButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.ExpandToSaveData,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.SettingsButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(419, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
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
            this.ExpandToSaveData.Size = new System.Drawing.Size(94, 22);
            this.ExpandToSaveData.Text = "Manage Servers";
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
            this.refreshServerListToolStripMenuItem,
            this.checkForUpdateToolStripMenuItem,
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
            // refreshServerListToolStripMenuItem
            // 
            this.refreshServerListToolStripMenuItem.Name = "refreshServerListToolStripMenuItem";
            this.refreshServerListToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.refreshServerListToolStripMenuItem.Text = "Refresh Server List";
            this.refreshServerListToolStripMenuItem.Click += new System.EventHandler(this.RefreshServerListToolStripMenuItem_Click);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check For Update";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdateToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.WindowExpander_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingsButton.Image = global::SteamServerCreationTool.Properties.Resources._012_cogwheel;
            this.SettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(23, 22);
            this.SettingsButton.Text = "toolStripButton1";
            this.SettingsButton.ToolTipText = "Global Settings";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // GrayBackgroundPanel
            // 
            this.GrayBackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.GrayBackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.GrayBackgroundPanel.Name = "GrayBackgroundPanel";
            this.GrayBackgroundPanel.Size = new System.Drawing.Size(413, 2);
            this.GrayBackgroundPanel.TabIndex = 16;
            // 
            // SteamCMD_InstallBox
            // 
            this.SteamCMD_InstallBox.Controls.Add(this.Button_VisitDownloadButton);
            this.SteamCMD_InstallBox.Controls.Add(this.pictureBox4);
            this.SteamCMD_InstallBox.Controls.Add(this.pictureBox2);
            this.SteamCMD_InstallBox.Controls.Add(this.AutoInstallButton);
            this.SteamCMD_InstallBox.Controls.Add(this.SteamCMDInfoButton);
            this.SteamCMD_InstallBox.Controls.Add(this.ManuallyLocateSteamCMDButton);
            this.SteamCMD_InstallBox.Location = new System.Drawing.Point(0, 0);
            this.SteamCMD_InstallBox.Name = "SteamCMD_InstallBox";
            this.SteamCMD_InstallBox.Size = new System.Drawing.Size(389, 51);
            this.SteamCMD_InstallBox.TabIndex = 13;
            this.SteamCMD_InstallBox.TabStop = false;
            this.SteamCMD_InstallBox.Text = "SteamCMD";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Location = new System.Drawing.Point(126, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 25);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // SteamCMD_LocatedBox
            // 
            this.SteamCMD_LocatedBox.Controls.Add(this.SteamCMD_InstallBox);
            this.SteamCMD_LocatedBox.Controls.Add(this.button7);
            this.SteamCMD_LocatedBox.Controls.Add(this.button8);
            this.SteamCMD_LocatedBox.Location = new System.Drawing.Point(12, 31);
            this.SteamCMD_LocatedBox.Name = "SteamCMD_LocatedBox";
            this.SteamCMD_LocatedBox.Size = new System.Drawing.Size(389, 51);
            this.SteamCMD_LocatedBox.TabIndex = 14;
            this.SteamCMD_LocatedBox.TabStop = false;
            this.SteamCMD_LocatedBox.Text = "SteamCMD";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Silver;
            this.pictureBox4.Location = new System.Drawing.Point(258, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1, 25);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(414, 240);
            this.Controls.Add(this.SteamCMD_LocatedBox);
            this.Controls.Add(this.ProgressBarInfo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.SteamCMD_InstallBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SteamCMD_LocatedBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar ProgressBarInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ServersRefreshButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label App_nameLabel;
        private System.Windows.Forms.Label App_idLabel;
        private System.Windows.Forms.Button InstallServerButton;
        private System.Windows.Forms.ToolTip Tooltipper;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button SearchButton;
        public System.Windows.Forms.ComboBox SteamServerList;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem githubProjectHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel GrayBackgroundPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ExpandToSaveData;
        private System.Windows.Forms.ToolStripButton SettingsButton;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label TotalServerLabel;
        private System.Windows.Forms.ToolStripMenuItem refreshServerListToolStripMenuItem;
        private System.Windows.Forms.GroupBox SteamCMD_InstallBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button AutoInstallButton;
        private System.Windows.Forms.Button SteamCMDInfoButton;
        private System.Windows.Forms.Button ManuallyLocateSteamCMDButton;
        private System.Windows.Forms.GroupBox SteamCMD_LocatedBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Button_VisitDownloadButton;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}