
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
            this.InstallServerButton = new System.Windows.Forms.Button();
            this.App_nameLabel = new System.Windows.Forms.Label();
            this.App_idLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tooltipper = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExpandToSaveData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.githubProjectHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsButton = new System.Windows.Forms.ToolStripButton();
            this.GrayBackgroundPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.ProgressBarInfo.Size = new System.Drawing.Size(419, 2);
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
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
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
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
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
            this.SettingsButton,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(419, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitButton});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(81, 22);
            this.toolStripDropDownButton3.Text = "Application";
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(180, 22);
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
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check For Update";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
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
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(414, 240);
            this.Controls.Add(this.ProgressBarInfo);
            this.Controls.Add(this.toolStrip1);
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Label App_nameLabel;
        private System.Windows.Forms.Label App_idLabel;
        private System.Windows.Forms.Button InstallServerButton;
        private System.Windows.Forms.ToolTip Tooltipper;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button SearchButton;
        public System.Windows.Forms.ComboBox SteamServerList;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
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
    }
}