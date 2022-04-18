using System;
using Newtonsoft.Json;

namespace NHL_Score_App.Models
{
    [Serializable]
    public partial class TeamsModel
    {
        [JsonProperty("away")]
        public TeamModel Away { get; set; }
        [JsonProperty("home")]
        public TeamModel Home { get; set; }

    }
}
