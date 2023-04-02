using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniMix.Services;

namespace UniMix.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotifyAuth : ControllerBase, IAuth
    {
        [HttpPost]
        public ActionResult UserAuth(string response)
        {



            return null;
        }
    }
}
