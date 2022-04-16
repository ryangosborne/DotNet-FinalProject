using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Score_App.Models
{
    public class GameModel
    {
        // All the fields we need to build out for the API
        public string startTime { get; set; }
        public ObservableCollection<TeamModel> Teams { get; set; }
        public ObservableCollection<GoalsModel> goals { get; set; }
        public bool overTime { get; set; }
    }
}
