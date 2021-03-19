
namespace SteamServerCreationTool.Forms
{
    partial class CreateServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateServerForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.app_id = new System.Windows.Forms.Label();
            this.app_name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.InstallDirButton = new System.Windows.Forms.Button();
            this.App_InstallLocationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DeleteServerButton = new System.Windows.Forms.Button();
            this.ValidateBox = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NameTextbox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 60);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "TIP: Give your server a unique name so you can differentiate your servers.";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(6, 19);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(448, 20);
            this.NameTextbox.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.app_id);
            this.groupBox1.Controls.Add(this.app_name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.InstallDirButton);
            this.groupBox1.Controls.Add(this.App_InstallLocationBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 122);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Information";
            // 
            // app_id
            // 
            this.app_id.AutoSize = true;
            this.app_id.Location = new System.Drawing.Point(62, 31);
            this.app_id.Name = "app_id";
            this.app_id.Size = new System.Drawing.Size(39, 13);
            this.app_id.TabIndex = 30;
            this.app_id.Text = "app_id";
            // 
            // app_name
            // 
            this.app_name.AutoSize = true;
            this.app_name.Location = new System.Drawing.Point(74, 16);
            this.app_name.Name = "app_name";
            this.app_name.Size = new System.Drawing.Size(57, 13);
            this.app_name.TabIndex = 29;
            this.app_name.Text = "app_name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "-";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(6, 105);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(69, 13);
            this.linkLabel2.TabIndex = 19;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Server Setup";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(452, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "NOTE: SSCT/SteamServerCreationTool does not configure any installation. That is s" +
    "omething you need to do manually. Also, some servers require a GSLT token to wor" +
    "k.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.linkLabel1.Location = new System.Drawing.Point(97, 106);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(174, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Gameserver Login Tokens (GSLTs)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // InstallDirButton
            // 
            this.InstallDirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallDirButton.Image = global::SteamServerCreationTool.Properties.Resources._033_folder_7_EDIT;
            this.InstallDirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InstallDirButton.Location = new System.Drawing.Point(348, 44);
            this.InstallDirButton.Name = "InstallDirButton";
            this.InstallDirButton.Size = new System.Drawing.Size(105, 26);
            this.InstallDirButton.TabIndex = 26;
            this.InstallDirButton.Text = "Install Directory";
            this.InstallDirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InstallDirButton.UseVisualStyleBackColor = true;
            this.InstallDirButton.Click += new System.EventHandler(this.InstallDirButton_Click);
            // 
            // App_InstallLocationBox
            // 
            this.App_InstallLocationBox.Location = new System.Drawing.Point(6, 47);
            this.App_InstallLocationBox.Name = "App_InstallLocationBox";
            this.App_InstallLocationBox.Size = new System.Drawing.Size(336, 20);
            this.App_InstallLocationBox.TabIndex = 24;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ValidateBox);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.DeleteServerButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 41);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(351, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 24);
            this.button1.TabIndex = 33;
            this.button1.Text = "Install Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // DeleteServerButton
            // 
            this.DeleteServerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteServerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteServerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteServerButton.Location = new System.Drawing.Point(6, 11);
            this.DeleteServerButton.Name = "DeleteServerButton";
            this.DeleteServerButton.Size = new System.Drawing.Size(103, 24);
            this.DeleteServerButton.TabIndex = 32;
            this.DeleteServerButton.Text = "Cancel";
            this.DeleteServerButton.UseVisualStyleBackColor = true;
            this.DeleteServerButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ValidateBox
            // 
            this.ValidateBox.AutoSize = true;
            this.ValidateBox.Checked = true;
            this.ValidateBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ValidateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateBox.Location = new System.Drawing.Point(251, 16);
            this.ValidateBox.Name = "ValidateBox";
            this.ValidateBox.Size = new System.Drawing.Size(94, 17);
            this.ValidateBox.TabIndex = 34;
            this.ValidateBox.Text = "Validate Install";
            this.ValidateBox.UseVisualStyleBackColor = true;
            // 
            // CreateServerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 258);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateServerForm";
            this.ShowInTaskbar = false;
            this.Text = "Create Server";
            this.Load += new System.EventHandler(this.CreateServerForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button InstallDirButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox App_InstallLocationBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteServerButton;
        private System.Windows.Forms.Label app_id;
        private System.Windows.Forms.Label app_name;
        public System.Windows.Forms.CheckBox ValidateBox;
    }
}