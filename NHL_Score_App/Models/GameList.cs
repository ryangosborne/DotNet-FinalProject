using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Score_App.Models
{
    [Serializable]
    public class GameList
    {
        [JsonProperty("games")]
        public IEnumerable<GameModel> Games { get; set; }
    }
}
