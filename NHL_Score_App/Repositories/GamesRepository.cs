using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHL_Score_App.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace NHL_Score_App.Repositories
{
    public class GamesRepository
    {
        private static readonly string API_URL = "https://nhl-score-api.herokuapp.com/api/scores/latest";

        public async static Task<GameModel[]> getGamesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(API_URL);

                if(response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<GameRequest>(await response.Content.ReadAsStringAsync()).Games;
                }
                throw new Exception("Expected JSON response");
            }
        }
    }
}
