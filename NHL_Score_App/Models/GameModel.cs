using System;
using Newtonsoft.Json;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace NHL_Score_App.Models
{
    [Serializable]
    public partial class GameModel
    { 
        // All the fields we need to build out for the API
        [JsonProperty("startTime")]
        public string startTime { get; set; }
        [JsonProperty("status")]
        public StatusModel Status { get; set; }
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
        public Brush HomeBrush 
        {
            
            get
            {
                var brush = new SolidColorBrush();
                if (GoalsHomeTeam > GoalsAwayTeam)
                {
                    // home won
                    brush.Color = Color.FromArgb(255, 0, 105, 35);
                }
                else if (GoalsHomeTeam < GoalsAwayTeam)
                {
                    // home lost
                    brush.Color = Color.FromArgb(255, 158, 0, 13);
                }
                else
                {
                    // tie
                    brush.Color = Color.FromArgb(255, 225, 242, 5);
                }
                return brush;
            }
        }
        public Brush AwayBrush
        {
            get
            {
                var brush = new SolidColorBrush();
                if (GoalsHomeTeam < GoalsAwayTeam)
                {
                    // away won
                    brush.Color = Color.FromArgb(255, 0, 105, 35);
                }
                else if (GoalsHomeTeam > GoalsAwayTeam)
                {
                    // away lost
                    brush.Color = Color.FromArgb(255, 158, 0, 13);
                }
                else
                {
                    // Tie
                    brush.Color = Color.FromArgb(255, 225, 242, 5);
                }
                return brush;

            }
        }
    }
}
