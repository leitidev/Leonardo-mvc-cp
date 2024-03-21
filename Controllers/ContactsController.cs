using Microsoft.AspNetCore.Mvc;

namespace Leonardo_mvc_cp.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Contato()
        {
            return View();
        }
    }
}
