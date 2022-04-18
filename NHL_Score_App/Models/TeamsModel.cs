using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NHL_Score_App.Models
{
    public partial class TeamsModel
    {
        [JsonProperty("away")]
        public TeamModel Away { get; set; }
        [JsonProperty("home")]
        public TeamModel Home { get; set; }

    }
}
