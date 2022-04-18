using System;
using System.Threading.Tasks;
using NHL_Score_App.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace NHL_Score_App.Repositories
{
    public class GamesRepository
    {
        // https://github.com/peruukki/nhl-score-api
        /* A JSON API that returns the scores and goals from the latest finished or on-going NHL games,
         * based on the schedule and standings information from the NHL Stats API. 
         * The NHL Stats API is undocumented, but unofficial documentation exists.
         * The API is available at https://nhl-score-api.herokuapp.com/, and it serves as the backend for nhl-recap.*/

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
    }
}
