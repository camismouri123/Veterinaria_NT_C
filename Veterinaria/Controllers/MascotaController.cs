using Microsoft.AspNetCore.Mvc;
using VeterinariaPichichus.Context;

namespace VeterinariaPichichus.Controllers
{
    public class MascotaController : Controller
    {
        DuenioContext context = new DuenioContext();
        public IActionResult MostrarMascota()
        {
            List<Pichichus.Dueño.Mascota.Mascota> ListadoMascotas = context.Mascota.ToList();
            return View(ListadoMascotas);
        }
    }
}
