using System;
using System.Net;
using System.Windows.Forms;
using System.ComponentModel;


namespace SteamServerCreationTool
{
    public partial class LoadForm : Form
    {
        public LoadForm() => InitializeComponent();

        private void LoadForm_Load(object sender, EventArgs e)
        {
            try
            {
                using(WebClient wc = new WebClient())
                {
                    wc.Headers.Add("Content-Type", "application/json");
                    wc.Headers.Add("User-Agent", "DIMS /0.1 +http://www.xxx.dk");

                    WebHeaderCollection myWebHeaderCollection = wc.ResponseHeaders;

                    string result = wc.DownloadString("https://raw.githubusercontent.com/dgibbs64/SteamCMD-AppID-List-Servers/master/steamcmd_appid_servers.json");//(Core.serversURL);

                    MessageBox.Show(result);

                    if(myWebHeaderCollection != null)
                        for (int i = 0; i < myWebHeaderCollection.Count; i++)
                            Console.WriteLine("\t" + myWebHeaderCollection.GetKey(i) + " = " + myWebHeaderCollection.Get(i));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            InternetChecker.DoWork += InternetChecker_DoWork;
            InternetChecker.RunWorkerAsync();
        }

        private void InternetChecker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Core.CheckNetwork())
            {
                MessageBox.Show("nope");
            }
            else
            {
                MessageBox.Show("Application failed to verify an active ethernet connection.\n\r\n\rCheck your connection or try again later.", "No Ethernet Connection Detected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}
