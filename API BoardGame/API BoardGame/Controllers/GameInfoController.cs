using API_BoardGame.Model;
using API_BoardGame.BoardGameClient;
using Microsoft.AspNetCore.Mvc;

namespace API_BoardGame.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class GameInfoController : ControllerBase
    {
        [HttpGet(Name = "GetGamesInfo")]
        public GamesInfo GamesInfo(string Game)
        {
            Client client = new Client();
            return client.GetGamesInfoAsync(Game).Result;           
        }
    }  
}
