
namespace SteamServerCreationTool.Forms
{
    partial class ManageInstallsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageInstallsForm));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.InstalledServerList = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.UpdateAllServersButton = new System.Windows.Forms.Button();
            this.DeleteAllServersButton = new System.Windows.Forms.Button();
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.ProgressBarInfo = new System.Windows.Forms.ProgressBar();
            this.UpdateSelectedButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.app_name_label = new System.Windows.Forms.Label();
            this.app_id_label = new System.Windows.Forms.Label();
            this.OpenServerButton = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.InstallDirButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.App_InstallLocationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdateServerNameButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.InstalledServerList);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(260, 204);
            this.groupBox5.TabIndex = 19;
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
            this.InstalledServerList.Size = new System.Drawing.Size(254, 185);
            this.InstalledServerList.TabIndex = 1;
            this.InstalledServerList.SelectedIndexChanged += new System.EventHandler(this.InstalledServerList_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.UpdateAllServersButton);
            this.groupBox6.Controls.Add(this.DeleteAllServersButton);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(260, 50);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            this.groupBox6.Visible = false;
            // 
            // UpdateAllServersButton
            // 
            this.UpdateAllServersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAllServersButton.Location = new System.Drawing.Point(6, 17);
            this.UpdateAllServersButton.Name = "UpdateAllServersButton";
            this.UpdateAllServersButton.Size = new System.Drawing.Size(121, 24);
            this.UpdateAllServersButton.TabIndex = 13;
            this.UpdateAllServersButton.Text = "Update All Servers";
            this.UpdateAllServersButton.UseVisualStyleBackColor = true;
            // 
            // DeleteAllServersButton
            // 
            this.DeleteAllServersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAllServersButton.Location = new System.Drawing.Point(133, 17);
            this.DeleteAllServersButton.Name = "DeleteAllServersButton";
            this.DeleteAllServersButton.Size = new System.Drawing.Size(121, 24);
            this.DeleteAllServersButton.TabIndex = 13;
            this.DeleteAllServersButton.Text = "Delete All Servers";
            this.DeleteAllServersButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.Enabled = false;
            this.DeleteSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedButton.Location = new System.Drawing.Point(234, 17);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(220, 24);
            this.DeleteSelectedButton.TabIndex = 15;
            this.DeleteSelectedButton.Text = "Delete Selected Server";
            this.DeleteSelectedButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // ProgressBarInfo
            // 
            this.ProgressBarInfo.Enabled = false;
            this.ProgressBarInfo.Location = new System.Drawing.Point(0, 0);
            this.ProgressBarInfo.MarqueeAnimationSpeed = 1;
            this.ProgressBarInfo.Maximum = 10;
            this.ProgressBarInfo.Name = "ProgressBarInfo";
            this.ProgressBarInfo.Size = new System.Drawing.Size(760, 2);
            this.ProgressBarInfo.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBarInfo.TabIndex = 21;
            this.ProgressBarInfo.Visible = false;
            // 
            // UpdateSelectedButton
            // 
            this.UpdateSelectedButton.Enabled = false;
            this.UpdateSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.UpdateSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSelectedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSelectedButton.Location = new System.Drawing.Point(6, 17);
            this.UpdateSelectedButton.Name = "UpdateSelectedButton";
            this.UpdateSelectedButton.Size = new System.Drawing.Size(220, 24);
            this.UpdateSelectedButton.TabIndex = 22;
            this.UpdateSelectedButton.Text = "Update Selected Server";
            this.UpdateSelectedButton.UseVisualStyleBackColor = true;
            this.UpdateSelectedButton.Click += new System.EventHandler(this.UpdateSelectedButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.app_name_label);
            this.groupBox1.Controls.Add(this.app_id_label);
            this.groupBox1.Controls.Add(this.OpenServerButton);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.InstallDirButton);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.App_InstallLocationBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(285, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 92);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Information";
            // 
            // app_name_label
            // 
            this.app_name_label.AutoSize = true;
            this.app_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_name_label.Location = new System.Drawing.Point(81, 31);
            this.app_name_label.Name = "app_name_label";
            this.app_name_label.Size = new System.Drawing.Size(57, 13);
            this.app_name_label.TabIndex = 28;
            this.app_name_label.Text = "App Name";
            // 
            // app_id_label
            // 
            this.app_id_label.AutoSize = true;
            this.app_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_id_label.Location = new System.Drawing.Point(62, 16);
            this.app_id_label.Name = "app_id_label";
            this.app_id_label.Size = new System.Drawing.Size(43, 13);
            this.app_id_label.TabIndex = 27;
            this.app_id_label.Text = "App ID:";
            // 
            // OpenServerButton
            // 
            this.OpenServerButton.Enabled = false;
            this.OpenServerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenServerButton.Image = global::SteamServerCreationTool.Properties.Resources._016_folder_24_EDIT;
            this.OpenServerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenServerButton.Location = new System.Drawing.Point(348, 59);
            this.OpenServerButton.Name = "OpenServerButton";
            this.OpenServerButton.Size = new System.Drawing.Size(106, 26);
            this.OpenServerButton.TabIndex = 25;
            this.OpenServerButton.Text = "Open Directory";
            this.OpenServerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenServerButton.UseVisualStyleBackColor = true;
            this.OpenServerButton.Click += new System.EventHandler(this.OpenServerButton_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(385, 16);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(69, 13);
            this.linkLabel2.TabIndex = 19;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Server Setup";
            // 
            // InstallDirButton
            // 
            this.InstallDirButton.Enabled = false;
            this.InstallDirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallDirButton.Image = global::SteamServerCreationTool.Properties.Resources._033_folder_7_EDIT;
            this.InstallDirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InstallDirButton.Location = new System.Drawing.Point(240, 59);
            this.InstallDirButton.Name = "InstallDirButton";
            this.InstallDirButton.Size = new System.Drawing.Size(105, 26);
            this.InstallDirButton.TabIndex = 26;
            this.InstallDirButton.Text = "Install Directory";
            this.InstallDirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InstallDirButton.UseVisualStyleBackColor = true;
            this.InstallDirButton.Click += new System.EventHandler(this.InstallDirButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.linkLabel1.Location = new System.Drawing.Point(6, 46);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(174, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Gameserver Login Tokens (GSLTs)";
            // 
            // App_InstallLocationBox
            // 
            this.App_InstallLocationBox.Location = new System.Drawing.Point(9, 62);
            this.App_InstallLocationBox.Name = "App_InstallLocationBox";
            this.App_InstallLocationBox.Size = new System.Drawing.Size(225, 20);
            this.App_InstallLocationBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "App ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "App Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpdateServerNameButton);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(285, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 50);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Name";
            // 
            // UpdateServerNameButton
            // 
            this.UpdateServerNameButton.Enabled = false;
            this.UpdateServerNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateServerNameButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateServerNameButton.Location = new System.Drawing.Point(371, 16);
            this.UpdateServerNameButton.Name = "UpdateServerNameButton";
            this.UpdateServerNameButton.Size = new System.Drawing.Size(83, 26);
            this.UpdateServerNameButton.TabIndex = 29;
            this.UpdateServerNameButton.Text = "Update Name";
            this.UpdateServerNameButton.UseVisualStyleBackColor = true;
            this.UpdateServerNameButton.Click += new System.EventHandler(this.UpdateServerNameButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 20);
            this.textBox1.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UpdateSelectedButton);
            this.groupBox3.Controls.Add(this.DeleteSelectedButton);
            this.groupBox3.Location = new System.Drawing.Point(285, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 50);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server Actions";
            // 
            // ManageInstallsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(757, 225);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProgressBarInfo);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageInstallsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Installs";
            this.Load += new System.EventHandler(this.ManageInstallsForm_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox InstalledServerList;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button DeleteSelectedButton;
        private System.Windows.Forms.Button UpdateAllServersButton;
        private System.Windows.Forms.Button DeleteAllServersButton;
        private System.Windows.Forms.ProgressBar ProgressBarInfo;
        private System.Windows.Forms.Button UpdateSelectedButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OpenServerButton;
        private System.Windows.Forms.Button InstallDirButton;
        private System.Windows.Forms.TextBox App_InstallLocationBox;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label app_name_label;
        private System.Windows.Forms.Label app_id_label;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button UpdateServerNameButton;
    }
}