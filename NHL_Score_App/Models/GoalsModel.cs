using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace NHL_Score_App.Models
{
    [Serializable]
    public class GoalsModel
    {
        [JsonProperty("period")]
        public string Period { get; set; }
        [JsonProperty("min")]
        public int Minutes { get; set; }
        [JsonProperty("sec")]
        public int Seconds { get; set; }
        [JsonProperty("assists")]
        public ObservableCollection<PlayerModel> Assists { get; set; }
        [JsonProperty("scorer")]
        public PlayerModel Scorer { get; set; }
        [JsonProperty("team")]
        public TeamModel Team { get; set; }

        public string GoalAsString
        {
            get
            {
                return "Period: " + Period + " " + Minutes + " : " + Seconds;
            }
        }
    }
}