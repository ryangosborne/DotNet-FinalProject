using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NHL_Score_App.Models
{
    [Serializable]
    public partial class DataModel
    {
        [JsonProperty("date.raw")]
        public string Date { get; set; }
        [JsonProperty("games")]
        public GameModel[] Games { get; set; }
    }
}
