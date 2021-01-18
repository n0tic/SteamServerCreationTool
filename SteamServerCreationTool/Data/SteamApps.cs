using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamServerCreationTool.Data
{
    public partial class SteamApps
    {
        [JsonProperty("applist")]
        public Applist Applist { get; set; }
    }

    public partial class Applist
    {
        [JsonProperty("apps")]
        public List<App> Apps { get; set; }
    }

    public partial class App
    {
        [JsonProperty("appid")]
        public long Appid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
