using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NHL_Score_App.Models
{
    public partial class StatusModel
    {
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("progress")]
        public ProgressModel Progress { get; set; }
    }
}
