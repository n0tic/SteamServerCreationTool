using System.Collections.Generic;
using System;

namespace SteamServerCreationTool.Data
{
    /// <summary>
    /// Class to store information between sessions
    /// </summary>
   [Serializable]
    public class Settings
    {
        // User data
        public UserData userData;
        public bool useUserData = false; // Use anonymous user.

        // Steam data
        public string steamCMD_installLocation = "";

        // Server data
        public List<InstalledServer> installedServer = new List<InstalledServer>();

        public string GetLogin()
        {
            if (!useUserData) return "anonymous";
            else if (useUserData && !userData.IsEmpty()) return userData.username + " " + userData.GetPassword();
            else return null;
        }
    }

    /// <summary>
    /// Class to store app information
    /// </summary>
    [Serializable]
    public class InstalledServer
    {
        public string name;
        public string installPath;
        public App app;

        public InstalledServer(string name, string installPath, App app)
        {
            this.name = name;
            this.installPath = installPath;
            this.app = app;
        }
    }

    [Serializable]
    public class UserData
    {
        public string username { get; private set; }
        public string password { get; private set; }

        public UserData()
        {
            this.username = null;
            this.password = null;
        }

        public bool IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(this.username) || this.password == null || this.password.Length < 1) return true;
            else return false;
        }

        public void SetUsername(string name) => this.username = name;
        public void SetPassword(string pass) => this.password = Core.Base64Encode(pass);

        public string GetPassword()
        {
            try
            {
                return Core.Base64Decode(this.password);
            }
            catch { return null; }
        }
    }
}