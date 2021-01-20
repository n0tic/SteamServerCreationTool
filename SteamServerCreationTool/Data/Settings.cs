using System.Collections.Generic;

namespace SteamServerCreationTool.Data
{
    /// <summary>
    /// Class to store information between sessions
    /// </summary>
    public class Settings
    {
        public string steamCMD_installLocation = "";

        public List<InstalledServer> installedServer = new List<InstalledServer>();
    }

    /// <summary>
    /// Class to stor eapp information
    /// </summary>
    public class InstalledServer
    {
        public string installPath;
        public App app;

        public InstalledServer(string installPath, App app)
        {
            this.installPath = installPath;
            this.app = app;
        }
    }
}