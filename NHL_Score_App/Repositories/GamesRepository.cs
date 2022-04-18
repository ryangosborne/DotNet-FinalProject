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
    // Alex's test
    public class DataObject
    {
        public string Name { get; set; }
    }
    public class GamesRepository
    {
        // Alex's test
        private const string TEST_URL = "https://jsonplaceholder.typicode.com/users";

        private static readonly string API_URL = "https://nhl-score-api.herokuapp.com/api/scores/latest";

        public async static Task<DataModel> getGamesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(API_URL);

                if(response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<DataModel>(await response.Content.ReadAsStringAsync());
                }
                throw new Exception("Expected JSON response");
            }
        }

        public async static Task<IEnumerable<GameModel>> getGamesFromAPI()
        {
            List<GameModel> games = new List<GameModel>();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(API_URL);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync("").ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var gameList = JsonConvert.DeserializeObject<GameList>(jsonString);

                if (gameList != null)
                {
                    games.AddRange(gameList.Games);
                }
            }

            return games;
        }
    }
}
