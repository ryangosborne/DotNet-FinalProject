using System;
using Newtonsoft.Json;

namespace NHL_Score_App.Models
{
    [Serializable]
    public partial class StatusModel
    {
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("progress")]
        public ProgressModel Progress { get; set; }
    }
}