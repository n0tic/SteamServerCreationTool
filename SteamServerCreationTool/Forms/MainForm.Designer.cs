
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
            this.InstallCMDButton = new System.Windows.Forms.Button();
            this.LocateSteamCMDButton = new System.Windows.Forms.Button();
            this.SteamServerList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenSteamCMDHelp = new System.Windows.Forms.Button();
            this.OpenSteamCMDButton = new System.Windows.Forms.Button();
            this.ProgressBarInfo = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ServersRefreshButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.LocateSteamCMDButton.UseVisualStyleBackColor = true;
            this.LocateSteamCMDButton.Click += new System.EventHandler(this.LocateSteamCMDButton_Click);
            // 
            // SteamServerList
            // 
            this.SteamServerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SteamServerList.FormattingEnabled = true;
            this.SteamServerList.Location = new System.Drawing.Point(6, 19);
            this.SteamServerList.Name = "SteamServerList";
            this.SteamServerList.Size = new System.Drawing.Size(344, 21);
            this.SteamServerList.TabIndex = 3;
            this.SteamServerList.SelectedIndexChanged += new System.EventHandler(this.SteamServerList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.InstallCMDButton);
            this.groupBox1.Controls.Add(this.OpenSteamCMDHelp);
            this.groupBox1.Controls.Add(this.LocateSteamCMDButton);
            this.groupBox1.Controls.Add(this.OpenSteamCMDButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
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
            this.OpenSteamCMDButton.UseVisualStyleBackColor = true;
            this.OpenSteamCMDButton.Click += new System.EventHandler(this.OpenSteamCMDButton_Click);
            // 
            // ProgressBarInfo
            // 
            this.ProgressBarInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProgressBarInfo.Enabled = false;
            this.ProgressBarInfo.Location = new System.Drawing.Point(0, 0);
            this.ProgressBarInfo.MarqueeAnimationSpeed = 5;
            this.ProgressBarInfo.Name = "ProgressBarInfo";
            this.ProgressBarInfo.Size = new System.Drawing.Size(413, 2);
            this.ProgressBarInfo.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBarInfo.TabIndex = 9;
            this.ProgressBarInfo.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ServersRefreshButton);
            this.groupBox2.Controls.Add(this.SteamServerList);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 54);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Selector";
            // 
            // ServersRefreshButton
            // 
            this.ServersRefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServersRefreshButton.Image = global::SteamServerCreationTool.Properties.Resources._075_reload_EDIT;
            this.ServersRefreshButton.Location = new System.Drawing.Point(356, 18);
            this.ServersRefreshButton.Name = "ServersRefreshButton";
            this.ServersRefreshButton.Size = new System.Drawing.Size(27, 23);
            this.ServersRefreshButton.TabIndex = 9;
            this.ServersRefreshButton.UseVisualStyleBackColor = true;
            this.ServersRefreshButton.Click += new System.EventHandler(this.ServersRefreshButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 154);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "App Installed Label";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "App Name Label";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "App ID Label";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SteamServerCreationTool.Properties.Resources._016_folder_24_EDIT;
            this.button1.Location = new System.Drawing.Point(356, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 22);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 20);
            this.textBox1.TabIndex = 2;
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
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ProgressBarInfo);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InstallCMDButton;
        private System.Windows.Forms.Button LocateSteamCMDButton;
        private System.Windows.Forms.ComboBox SteamServerList;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}