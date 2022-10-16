using System;
using System.Collections.Generic;

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
        public bool autoQuit = true;

        public bool validate = true;
        public string steamCMD_installLocation = "";

        // Server data
        public List<InstalledServer> installedServer = new List<InstalledServer>();

        public string GetLogin()
        {
            if (!useUserData) return "anonymous";
            else if (useUserData && !userData.IsEmpty()) return userData.Username + " " + userData.GetPassword();
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
        public string Username { get; private set; }
        public string Password { get; private set; }

        public UserData()
        {
            this.Username = null;
            this.Password = null;
        }

        public bool IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(this.Username) || this.Password == null || this.Password.Length < 1) return true;
            else return false;
        }

        public void SetUsername(string name) => this.Username = name;

        public void SetPassword(string pass) => this.Password = Core.Base64Encode(pass);

        public string GetPassword()
        {
            try
            {
                return Core.Base64Decode(this.Password);
            }
            catch { return null; }
        }
    }
}