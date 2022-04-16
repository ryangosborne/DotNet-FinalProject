using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace NHL_Score_App.Models
{
    public class GoalsModel
    {
        public string Period { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public ObservableCollection<PlayerModel> Assists { get; set; }
        public PlayerModel Scorer { get; set; }
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