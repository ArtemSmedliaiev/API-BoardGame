using API_BoardGame.Model;
using API_BoardGame.BoardGameClient;
using Microsoft.AspNetCore.Mvc;

namespace API_BoardGame.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        [HttpGet(Name = "GetCategories")]
        public CategoriesInfo GamesCategories()
        {
            Client client = new Client();
            return client.GetCategoriesAsync().Result;
        }
    }
}
