using API_BoardGame.Model;
using API_BoardGame.BoardGameClient;
using Microsoft.AspNetCore.Mvc;

namespace API_BoardGame.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamesCategoriesController : ControllerBase
    {
        [HttpGet(Name = "GetGamesOnCategories")]
        public GamesInfo GamesCategories(string Categories)
        {
            Client client = new Client();
            return client.GetGamesCategoriesAsync(Categories).Result;
        }
    }
}
