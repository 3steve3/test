using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniMix.Services.AppleMusic;

namespace UniMix.Controllers.Search
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        readonly AppleMusicService _appleMusicService;
        public SearchController(AppleMusicService service) { _appleMusicService = service; }
        [HttpPost("/SearchAll")]
        public ActionResult UserAuth([FromQuery]QueryParameters query)
        {
            return Ok();
        }
    }
}
