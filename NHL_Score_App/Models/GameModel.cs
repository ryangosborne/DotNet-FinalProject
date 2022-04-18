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
        [JsonProperty("startTime")]
        public string startTime { get; set; }
        [JsonProperty("teams")]
        public TeamsModel Teams { get; set; }
        [JsonProperty("goals")]
        public GoalsModel[] Goals { get; set; }

        public int GoalsAwayTeam { 
            get
            {
                var awayAbbr = Teams.Away.Abbreviation;
                var goals = Array.FindAll(Goals, goal => goal.Team == awayAbbr);
                return goals.Length;
            }
        }
        public int GoalsHomeTeam {
            get
            {
                var homeAbbr = Teams.Home.Abbreviation;
                var goals = Array.FindAll(Goals, goal => goal.Team == homeAbbr);
                return goals.Length;
            }
        }

    }
}
