using System;
using Newtonsoft.Json;

namespace NHL_Score_App.Models
{
    [Serializable]
    public partial class PlayerModel
    {
        [JsonProperty("player")]
        public string Name { get; set; }
        [JsonProperty("seasonTotal")]
        public int seasonTotal { get; set; }
    }
}
