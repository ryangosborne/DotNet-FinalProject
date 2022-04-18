using System;
using Newtonsoft.Json;

namespace NHL_Score_App.Models
{
    [Serializable]
    public partial class GoalsModel
    {
        [JsonProperty("period")]
        public string Period { get; set; }
        [JsonProperty("min")]
        public int Minutes { get; set; }
        [JsonProperty("sec")]
        public int Seconds { get; set; }
        [JsonProperty("assists")]
        public PlayerModel[] Assists { get; set; }
        [JsonProperty("scorer")]
        public PlayerModel Scorer { get; set; }
        [JsonProperty("team")]
        public string Team { get; set; }
    }
}