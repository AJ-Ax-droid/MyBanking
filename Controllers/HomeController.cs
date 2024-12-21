using Microsoft.AspNetCore.Mvc;

namespace MyBanking.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult LoginPage()
        {
            return View();
        }
    }
}
