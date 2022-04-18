using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
