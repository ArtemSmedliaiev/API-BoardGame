using Newtonsoft.Json;
using API_BoardGame.Model;
using API_BoardGame.Constants;



namespace API_BoardGame.BoardGameClient
{
    public class Client
    {
        private HttpClient _client;
        private static string _adress;
        private static string _client_id;
        public Client()
        {
            _adress = constants.adress;
            _client_id = constants.client_id;
            _client = new HttpClient();
            _client.BaseAddress = new Uri(_adress);
        }
        public async Task<GamesInfo> GetGamesInfoAsync(string game)
        {
            var responce = await _client.GetAsync($"/api/search?name={game}&pretty=true&limit=50&client_id={_client_id}");
            var content = responce.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<GamesInfo>(content);
            return result;
        }

        public async Task<GamesInfo> GetGamesCategoriesAsync(string categoriesname)
        {
            var responce = await _client.GetAsync($"/api/search?categories={categoriesname}&pretty=true&limit=50&client_id={_client_id}");
            var content = responce.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<GamesInfo>(content);
            return result;
        }

        public async Task<GamesInfo> GetGamesMechanicsAsync(string mechanicsname)
        {
            var responce = await _client.GetAsync($"/api/search?mechanics={mechanicsname}&pretty=true&limit=50&client_id={_client_id}");
            var content = responce.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<GamesInfo>(content);
            return result;
        }

        public async Task<GamesInfo> GetGamesYearAsync(int year)
        {
            var responce = await _client.GetAsync($"/api/search?year_published={year}&pretty=true&limit=50&client_id={_client_id}");
            var content = responce.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<GamesInfo>(content);
            return result;
        }

        public async Task<GamesInfo> GetRandomGameAsync()
        {
            var responce = await _client.GetAsync($"/api/search?random=true&pretty=true&client_id={_client_id}");
            var content = responce.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<GamesInfo>(content);
            return result;
        }

        public async Task<CategoriesInfo> GetCategoriesAsync()
        {
            var responce = await _client.GetAsync($"/api/game/categories?pretty=true&client_id={_client_id}");
            var content = responce.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<CategoriesInfo>(content);
            return result;
        }

        public async Task<MechanicsInfo> GetMechanicsAsync()
        {
            var responce = await _client.GetAsync($"/api/game/mechanics?pretty=true&client_id={_client_id}");
            var content = responce.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<MechanicsInfo>(content);
            return result;
        }
    }   
}
