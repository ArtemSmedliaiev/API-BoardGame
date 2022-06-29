using API_BoardGame.Model;
using API_BoardGame.BoardGameClient;
using Microsoft.AspNetCore.Mvc;

namespace API_BoardGame.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamesMechanicsController : ControllerBase
    {
        [HttpGet(Name = "GetGamesOnMechanics")]
        public GamesInfo GamesMechanics(string Mechanics)
        {
            Client client = new Client();
            return client.GetGamesMechanicsAsync(Mechanics).Result;
        }
    }
}
