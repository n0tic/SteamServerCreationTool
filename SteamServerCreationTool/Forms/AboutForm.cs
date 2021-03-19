using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamServerCreationTool.Forms
{
    partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);

            TextLabel.Text = "(" + Core.softwareNameShort + ") " + Core.softwareName + " " + Core.GetVersion() + "\n\rCreated by " + Core.authorName + " AKA " + Core.authorRealName + "\n\rContact: " + Core.authorContact;
            ProjectLink.Text = "Github/Project Home";
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        #endregion

        private void ProjectLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start(Core.projectURL);
    }
}
