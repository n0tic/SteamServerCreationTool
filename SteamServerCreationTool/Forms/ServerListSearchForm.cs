using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamServerCreationTool.Forms
{
    public partial class ServerListSearchForm : Form
    {
        MainForm main;

        public ServerListSearchForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;

            foreach (var item in main.SteamServerList.Items)
            {
                ResultsList.Items.Add(item.ToString());
            }
        }

        private void SearchField_TextChanged(object sender, EventArgs e)
        {
            ResultsList.Items.Clear();

            List<string> results = new List<string>();

            foreach (var item in main.SteamServerList.Items)
            {
                if (Core.Contains(item.ToString(), SearchField.Text, StringComparison.OrdinalIgnoreCase)) results.Add(item.ToString());
            }

            foreach (var item in results)
            {
                ResultsList.Items.Add(item);
            }
        }

        private void ResultsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ResultsList.SelectedIndex != -1)
            {
                main.SteamServerList.SelectedIndex = main.SteamServerList.FindStringExact(ResultsList.Items[ResultsList.SelectedIndex].ToString());
            }
        }

        private void ResultsList_DoubleClick(object sender, EventArgs e)
        {
            if (ResultsList.SelectedIndex != -1)
            {
                main.SteamServerList.SelectedIndex = main.SteamServerList.FindStringExact(ResultsList.Items[ResultsList.SelectedIndex].ToString());
                Close();
            }
        }
    }
}
