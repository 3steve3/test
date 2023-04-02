using Microsoft.AspNetCore.Mvc;
using UniMix.Services.AppleMusic;

namespace UniMix.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppleMusicAuthController : ControllerBase, IAuth
    {
        readonly AppleMusicService _appleMusicService;
        public AppleMusicAuthController(AppleMusicService service) { _appleMusicService = service; }
        [HttpPost("/UserToken")]
        public ActionResult UserAuth(string UserToken)
        {
            _appleMusicService.AddUserToken(UserToken);
            return Ok();
        }
        [HttpGet("/Key")]
        public ActionResult Key()
        {
            return Ok(AppleMusicDevKey.Key);
        }
    }
}
