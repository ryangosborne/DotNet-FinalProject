using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NHL_Score_App.Models
{
    public partial class ProgressModel
    {
        [JsonProperty("currentPeriod")]
        public int CurrentPeriod { get; set; }
    }
}
