using Microsoft.AspNetCore.Mvc;

namespace UniMix.Controllers.Auth
{
    public interface IAuth
    {
        ActionResult UserAuth(string response);
    }
}
