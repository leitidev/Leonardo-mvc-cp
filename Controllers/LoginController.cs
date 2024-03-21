using Microsoft.AspNetCore.Mvc;

namespace Leonardo_mvc_cp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Logar()
        {
            return View();
        }
    }
}
