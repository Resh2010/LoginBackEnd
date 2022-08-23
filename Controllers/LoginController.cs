using Microsoft.AspNetCore.Mvc;

namespace LoginBackend.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public bool LoginCheck(string username,string password)
        {
            if(username=="reshma" && password=="resh123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
