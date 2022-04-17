using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NHL_Score_App.Models
{
    [Serializable]
    public class GameModel
    { 
        // All the fields we need to build out for the API
        [JsonProperty("date.raw")]
        public string Date { get; set; }
        [JsonProperty("startTime")]
        public string startTime { get; set; }
        [JsonProperty("teams")]
        public ObservableCollection<TeamModel> Teams { get; set; }
        [JsonProperty("goals")]
        public ObservableCollection<GoalsModel> Goals { get; set; }
        public bool overTime { get; set; }
    }
}
