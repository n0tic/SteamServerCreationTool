
namespace SteamServerCreationTool.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radio_UseUser = new System.Windows.Forms.RadioButton();
            this.radio_UseAnon = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_inputbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.username_inputbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.TogglePassword = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TogglePassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radio_UseUser);
            this.groupBox1.Controls.Add(this.radio_UseAnon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.password_inputbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.username_inputbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 191);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Steam Account Information";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(240, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Note: Wrong login will result in failed downloads.";
            // 
            // radio_UseUser
            // 
            this.radio_UseUser.AutoSize = true;
            this.radio_UseUser.Location = new System.Drawing.Point(115, 99);
            this.radio_UseUser.Name = "radio_UseUser";
            this.radio_UseUser.Size = new System.Drawing.Size(119, 17);
            this.radio_UseUser.TabIndex = 33;
            this.radio_UseUser.Text = "Use above account";
            this.radio_UseUser.UseVisualStyleBackColor = true;
            // 
            // radio_UseAnon
            // 
            this.radio_UseAnon.AutoSize = true;
            this.radio_UseAnon.Checked = true;
            this.radio_UseAnon.Location = new System.Drawing.Point(7, 99);
            this.radio_UseAnon.Name = "radio_UseAnon";
            this.radio_UseAnon.Size = new System.Drawing.Size(102, 17);
            this.radio_UseAnon.TabIndex = 32;
            this.radio_UseAnon.TabStop = true;
            this.radio_UseAnon.Text = "Use Anonymous";
            this.radio_UseAnon.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Username:";
            // 
            // password_inputbox
            // 
            this.password_inputbox.Location = new System.Drawing.Point(6, 73);
            this.password_inputbox.Name = "password_inputbox";
            this.password_inputbox.Size = new System.Drawing.Size(407, 20);
            this.password_inputbox.TabIndex = 29;
            this.password_inputbox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 56);
            this.label1.TabIndex = 28;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // username_inputbox
            // 
            this.username_inputbox.Location = new System.Drawing.Point(6, 32);
            this.username_inputbox.Name = "username_inputbox";
            this.username_inputbox.Size = new System.Drawing.Size(526, 20);
            this.username_inputbox.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SaveSettingsButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 41);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.SaveSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSettingsButton.Location = new System.Drawing.Point(429, 11);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(103, 24);
            this.SaveSettingsButton.TabIndex = 33;
            this.SaveSettingsButton.Text = "Save Settings";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.InstallButton_Click);
            // 
            // TogglePassword
            // 
            this.TogglePassword.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.TogglePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TogglePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TogglePassword.Location = new System.Drawing.Point(419, 71);
            this.TogglePassword.Name = "TogglePassword";
            this.TogglePassword.Size = new System.Drawing.Size(113, 24);
            this.TogglePassword.TabIndex = 34;
            this.TogglePassword.Text = "Show Password";
            this.TogglePassword.UseVisualStyleBackColor = true;
            this.TogglePassword.Click += new System.EventHandler(this.TogglePassword_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(563, 261);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "Application Settings";
            this.Load += new System.EventHandler(this.CreateServerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox username_inputbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_inputbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radio_UseUser;
        private System.Windows.Forms.RadioButton radio_UseAnon;
        private System.Windows.Forms.Button TogglePassword;
    }
}