using System;
using System.Windows.Forms;

namespace SteamServerCreationTool.Forms
{
    public partial class SettingsForm : Form
    {
        private MainForm main;

        public SettingsForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void CreateServerForm_Load(object sender, EventArgs e)
        {
            username_inputbox.Text = main.settings.userData.username;

            string pass = main.settings.userData.GetPassword();
            if (pass != null) password_inputbox.Text = pass;

            if (main.settings.useUserData)
            {
                radio_UseAnon.Checked = false;
                radio_UseUser.Checked = true;
            }
            else
            {
                radio_UseAnon.Checked = true;
                radio_UseUser.Checked = false;
            }

            AutoCloseBox.Checked = main.settings.autoQuit;
            ValidateBox.Checked = main.settings.validate;
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            main.settings.userData.SetUsername(username_inputbox.Text);
            main.settings.userData.SetPassword(password_inputbox.Text);

            if (radio_UseAnon.Checked) main.settings.useUserData = false;
            else main.settings.useUserData = true;

            main.settings.autoQuit = this.AutoCloseBox.Checked;
            main.settings.validate = this.ValidateBox.Checked;

            Core.SaveSettings(main.settings);
            Close();
        }

        private void TogglePassword_Click(object sender, EventArgs e)
        {
            password_inputbox.UseSystemPasswordChar = !password_inputbox.UseSystemPasswordChar;

            if (password_inputbox.UseSystemPasswordChar)
            {
                TogglePassword.Text = "Show Password";
            }
            else
            {
                TogglePassword.Text = "Hide Password";
            }
        }
    }
}