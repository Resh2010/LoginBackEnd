using LoginBackend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginBackend.Controllers
{
    [EnableCors("AllowMyOrgin")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginCheck([FromBody] LoginModel loginModel)
        {
            if(loginModel.Username=="reshma" && loginModel.Password=="resh123")
            {
                return Ok();
            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized,"Wrong username and password");
            }
        }
    }
}
