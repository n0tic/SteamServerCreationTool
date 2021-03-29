using Newtonsoft.Json;
using SteamServerCreationTool.Data;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

/*
 Core system for the application providing name, version, links, feature methods etc.
 */

namespace SteamServerCreationTool
{
    public static class Core
    {
        public static bool debug = false;

        public static string softwareName = "Steam Server Creation Tool";
        public static string softwareNameShort = "SSCT";

        public static string authorRealName = "Victor Rimsby";
        public static string authorName = "N0tiC";
        public static string authorContact = "contact@bytevaultstudio.se";

        public static string projectURL = "https://github.com/n0tic/SteamServerCreationTool";

        public static string steamCMDURL = "https://steamcdn-a.akamaihd.net/client/installer/steamcmd.zip";
        public static string serversURL = "https://api.steampowered.com/ISteamApps/GetAppList/v2/";

        #region Version

        public static BuildTypes buildType = BuildTypes.Alpha;
        public static int majorVersion = 0;
        public static int minorVersion = 1;
        public static int buildVersion = 6;

        public enum BuildTypes
        {
            Alpha,
            Beta,
            Normal
        }

        public static string GetVersion() => majorVersion.ToString() + "." + minorVersion.ToString() + "." + buildVersion.ToString() + " " + buildType.ToString();

        #endregion Version

        #region Network

        public static void CheckForUpdates()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("User-Agent", "request");
                var data = GithubReleasesData.FromJson(wc.DownloadString("https://api.github.com/repos/n0tic/SteamServerCreationTool/releases"));
                if (data != null)
                {
                    int majorversion = Int32.Parse(data[0].TagName.Split('.')[0]), minorversion = Int32.Parse(data[0].TagName.Split('.')[1]), buildversion = Int32.Parse(data[0].TagName.Split('.')[2]);
                    int version = majorversion + minorversion + buildversion;
                    int currentVersion = majorVersion + minorVersion + buildVersion;

                    //MessageBox.Show(currentVersion + " vs " + version);

                    if (currentVersion >= version) return;
                    else
                    {
                        if (MessageBox.Show("There seem to be an update available.\n\rWould you like to go to the download location?", "Update Available!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Process.Start(projectURL + "/releases");
                        }
                    }
                }
            }
        }
        public static bool CheckNetwork()
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            }
            catch
            {
                MessageBox.Show("SSL/TSL(12) connection could not be established. Networking disabled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                using (var client = new WebClient().OpenRead("http://www.google.com/")) return true;
            }
            catch
            {
                MessageBox.Show("Could not detect a valid ethernet connection. Networking disabled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static void SaveToFile(string fullPath, string data)
        {
            using (StreamWriter writer = new StreamWriter(fullPath)) writer.Write(data);
        }

        public static void SaveCurrentSettings(Settings applications)
        {
            using (StreamWriter writer = new StreamWriter("data")) writer.Write(JsonConvert.SerializeObject(applications));
        }

        public static Settings LoadData()
        {
            if (File.Exists("data")) using (StreamReader streamReader = new StreamReader("data", Encoding.UTF8)) return JsonConvert.DeserializeObject<Settings>(streamReader.ReadToEnd());
            else return null;
        }

        public static bool IsFolderEmpty(string path)
        {
            if (Directory.GetFiles(path).Length > 0) return true;
            else return false;
        }

        public static void MoveFolder(string sourceDirectoryName, string targetDirectoryName)
        {
            Directory.CreateDirectory(targetDirectoryName);

            DirectoryInfo source = new DirectoryInfo(sourceDirectoryName);
            DirectoryInfo target = new DirectoryInfo(targetDirectoryName);

            MoveWork(source, target);

            foreach (var item in source.GetDirectories("*", SearchOption.AllDirectories))
            {
                try
                {
                    item.Delete(true);
                }
                catch { }
            }
        }

        private static void MoveWork(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.GetDirectories())
            {
                MoveWork(dir, target.CreateSubdirectory(dir.Name));
            }

            foreach (FileInfo file in source.GetFiles())
            {
                file.MoveTo(Path.Combine(target.FullName, file.Name));
            }
        }

        #endregion IO

        #region Extra

        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }

        #endregion Extra
    }
}