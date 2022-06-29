using API_BoardGame.Model;
using API_BoardGame.BoardGameClient;
using Microsoft.AspNetCore.Mvc;

namespace API_BoardGame.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MechanicsController : ControllerBase
    {
        [HttpGet(Name = "GetMechanics")]
        public MechanicsInfo GamesMechanics()
        {
            Client client = new Client();
            return client.GetMechanicsAsync().Result;
        }
    }
}
