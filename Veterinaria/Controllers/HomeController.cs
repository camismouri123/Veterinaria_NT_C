using Microsoft.AspNetCore.Mvc;

namespace VeterinariaPichichus.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("MostrarDuenios", "Duenios");
        }
    }
}
