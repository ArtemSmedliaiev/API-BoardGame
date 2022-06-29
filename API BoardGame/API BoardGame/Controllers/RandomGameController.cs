using API_BoardGame.Model;
using API_BoardGame.BoardGameClient;
using Microsoft.AspNetCore.Mvc;


namespace API_BoardGame.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomGameController : ControllerBase
    {
        [HttpGet(Name = "GetRandomGame")]
        public GamesInfo RandomGame()
        {
            Client client = new Client();
            return client.GetRandomGameAsync().Result;
        }
    }
}
