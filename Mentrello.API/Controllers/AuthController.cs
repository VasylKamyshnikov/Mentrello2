using Mentrello.Services.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Mentrello.API.Controllers
{
    [Route("auth")]
    public class AuthController : ControllerBase
    {
        [Route("sign-in")]
        [HttpGet]
        public IActionResult SignIn()
        {
            var userss = User.Identity;

            return Redirect("");
        }
    }
}
