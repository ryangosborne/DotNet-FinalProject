using System;
using Newtonsoft.Json;

namespace NHL_Score_App.Models
{
    [Serializable]
    public partial class ProgressModel
    {
        [JsonProperty("currentPeriod")]
        public int CurrentPeriod { get; set; }
    }
}
