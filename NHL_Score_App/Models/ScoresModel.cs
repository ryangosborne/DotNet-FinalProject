using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NHL_Score_App.Models
{
    public class ScoresModel
    {
        [JsonProperty("FLA")]
        public int awayScore { get; set; }
        
        [JsonProperty("DET")]
        public int homeScore { get; set; }
    }
}