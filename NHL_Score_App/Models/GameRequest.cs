﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace NHL_Score_App.Models
{
    [Serializable]
    public class GameRequest
    {
        [JsonProperty("games")]
        public GameModel[] Games { get; set; }

        public GameRequest(GameModel[] games)
        {
            Games = games;
        }
    }
}
