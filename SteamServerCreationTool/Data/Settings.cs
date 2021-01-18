using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamServerCreationTool.Data
{
    public class Settings
    {
        public string steamCMD_installLocation = "";

        public List<InstalledServer> installedServer = new List<InstalledServer>(); 
    }

    public class InstalledServer
    {
        public string installPath;
        public SteamApps app;

        public InstalledServer(string installPath, SteamApps app)
        {
            this.installPath = installPath;
            this.app = app;
        }
    }
}
