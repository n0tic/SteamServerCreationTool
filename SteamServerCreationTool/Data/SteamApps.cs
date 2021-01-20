using Newtonsoft.Json;
using System.Collections.Generic;

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