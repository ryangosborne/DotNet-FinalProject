using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace NHL_Score_App.Models
{
    public partial class TeamModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }
        public string Logo
        {
            get
            {
                switch (Id)
                {
                    // New Jersey Devils - ID 1
                    case 1:
                        return "Assets/team_logos/devils.png";
                    // New York Islanders - ID 2
                    case 2:
                        return "Assets/team_logos/islanders.png";
                    // New York Rangers - ID 3
                    case 3:
                        return "Assets/team_logos/rangers.png";
                    // Philadelphia Flyers - ID 4
                    case 4:
                        return "Assets/team_logos/flyers.png";
                    // Pittsburgh Penguins - ID 5
                    case 5:
                        return "Assets/team_logos/penguins.png";
                    // Boston Bruins - ID 6
                    case 6:
                        return "Assets/team_logos/bruins.png";
                    // Buffalo Sabres - ID 7
                    case 7:
                        return "Assets/team_logos/sabres.png";
                    // Montréal Canadiens - ID 8
                    case 8:
                        return "Assets/team_logos/canadiens.png";
                    // Ottawa Senators - ID 9
                    case 9:
                        return "Assets/team_logos/senators.png";
                    // Toronto Maple Leafs - ID 10
                    case 10:
                        return "Assets/team_logos/mapleleafs.png";
                    // Carolina Hurricanes - ID 12
                    case 12:
                        return "Assets/team_logos/hurricanes.png";
                    // Florida Panthers - ID 13
                    case 13:
                        return "Assets/team_logos/panthers.png";
                    // Tampa Bay Lightning - ID 14
                    case 14:
                        return "Assets/team_logos/lightning.png";
                    // Washington Capitals - ID 15
                    case 15:
                        return "Assets/team_logos/capitals.png";
                    // Chicago Blackhawks - ID 16
                    case 16:
                        return "Assets/team_logos/blackhawks.png";
                    // Detroit Red Wings - ID 17
                    case 17:
                        return "Assets/team_logos/redwings.png";
                    // Nashville Predators - ID 18
                    case 18:
                        return "Assets/team_logos/predators.png";
                    // St. Louis Blues - ID 19
                    case 19:
                        return "Assets/team_logos/blues.png";
                    // Calgary Flames - ID 20
                    case 20:
                        return "Assets/team_logos/flames.png";
                    // Colorado Avalanche - ID 21
                    case 21:
                        return "Assets/team_logos/avalanche.png";
                    // Edmonton Oilers - ID 22
                    case 22:
                        return "Assets/team_logos/oilers.png";
                    // Vancouver Canucks - ID 23
                    case 23:
                        return "Assets/team_logos/canucks.png";
                    // Anaheim Ducks - ID 24
                    case 24:
                        return "Assets/team_logos/ducks.png";
                    // Dallas Stars - ID 25
                    case 25:
                        return "Assets/team_logos/stars.png";
                    // Los Angeles Kings - ID 26
                    case 26:
                        return "Assets/team_logos/kings.png";
                    // San Jose Sharks - ID 28
                    case 28:
                        return "Assets/team_logos/sharks.png";
                    // Columbus Blue Jackets - ID 29
                    case 29:
                        return "Assets/team_logos/bluejackets.png";
                    // Minnesota Wild - ID 30
                    case 30:
                        return "Assets/team_logos/wild.png";
                    // Winnipeg Jets - ID 52
                    case 52:
                        return "Assets/team_logos/jets.png";
                    // Arizona Coyotes - ID 53
                    case 53:
                        return "Assets/team_logos/coyotes.png";
                    // Vegas Golden Knights - ID 54
                    case 54:
                        return "Assets/team_logos/.png";

                    default:
                        return null;
                }
            }
        }
    }
}
