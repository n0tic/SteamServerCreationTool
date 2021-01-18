using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamServerCreationTool
{
    public static class Core
    {
        public static LoadForm mainRef = null;

        public static string softwareName = "StarterPack";

        public static string authorRealName = "Victor Rimsby";
        public static string authorName = "N0tiC";
        public static string companyName = "ByteVault Studio";
        public static string authorContact = "contact@bytevaultstudio.se";
        public static string companyWebsite = "http://bytevaultstudio.se/";

        public static string serversURL = "https://raw.githubusercontent.com/dgibbs64/SteamCMD-AppID-List-Servers/master/steamcmd_appid_servers.json";

        #region Version

        public static BuildTypes buildType = BuildTypes.Alpha;
        public static int majorVersion = 0;
        public static int minorVersion = 1;
        public static int buildVersion = 1;

        public enum BuildTypes
        {
            Alpha,
            Beta,
            Normal
        }

        public static string GetVersion() => majorVersion.ToString() + "." + minorVersion.ToString() + "." + buildVersion.ToString() + " " + buildType.ToString();

        #endregion Version

        #region Move Window

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void MoveWindow(Form window, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(window.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion Move Window

        #region Network

        public static bool CheckNetwork()
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            }
            catch
            {
                //mainRef.noticeSystem.SetNoticePanel(true, "SSL/TSL(12) connection could not be established. Networking disabled.", Modules.NoticeSystem.NoticeType.Warning);
                return false;
            }

            try
            {
                using (var client = new WebClient().OpenRead("http://www.google.com/")) return true;
            }
            catch
            {
                //mainRef.noticeSystem.SetNoticePanel(true, "Could not detect a valid ethernet connection. Networking disabled.", Modules.NoticeSystem.NoticeType.Error);
                return false;
            }
        }

        public static bool RemoteFileExists(string url)
        {
            try
            {
                //Creating the HttpWebRequest
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                //Setting the Request method HEAD, you can also use GET too.
                request.Method = "HEAD";
                //Getting the Web Response.
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //Returns TRUE if the Status code == 200
                response.Close();
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                //Any exception will returns false.
                return false;
            }
        }

        public static string GetUTCTime()
        {
            System.Int32 unixTimestamp = (System.Int32)(System.DateTime.UtcNow.Subtract(new System.DateTime(1970, 1, 1))).TotalSeconds;
            return unixTimestamp.ToString();
        }

        #endregion Network

        #region IO
        public static string GetCurrentDirectory() => @AppDomain.CurrentDomain.BaseDirectory;
        /*
        public static void SaveCurrentSettings(Applications.Applications applications)
        {
            using (StreamWriter writer = new StreamWriter("data")) writer.Write(JsonConvert.SerializeObject(applications));
        }

        public static Applications.Applications LoadData()
        {
            if (File.Exists("data")) using (StreamReader streamReader = new StreamReader("data", Encoding.UTF8)) return JsonConvert.DeserializeObject<Applications.Applications>(streamReader.ReadToEnd());
            else return new Applications.Applications();
        }
        */
        #endregion
    }
}
