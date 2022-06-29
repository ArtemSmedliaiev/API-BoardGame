using API_BoardGame.Model;
using API_BoardGame.BoardGameClient;
using Microsoft.AspNetCore.Mvc;

namespace API_BoardGame.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamesYearController : ControllerBase
    {
        [HttpGet(Name = "GetGamesOnYear")]
        public GamesInfo GamesYear(int Year)
        {
            Client client = new Client();
            return client.GetGamesYearAsync(Year).Result;
        }
    }
}
