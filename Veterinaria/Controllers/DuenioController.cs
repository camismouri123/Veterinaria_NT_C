using Microsoft.AspNetCore.Mvc;
using System.Collections;
using VeterinariaPichichus.Context;
using VeterinariaPichichus.Models;

namespace VeterinariaPichichus.Controllers
{
    public class DuenioController : Controller
    {
        DuenioContext context = new DuenioContext();
        public IActionResult MostrarDuenio()
        {

            compuesta d = new compuesta();

            return View(d.ListadoObjetos());
        }
    }

    public class compuesta
    {
        DuenioContext context = new DuenioContext();

        public ArrayList ListadoObjetos()
        {
            List<Duenio> listaDeDuenios = context.Duenios.ToList();
            List<Mascota> listaDeMascotas = context.Mascota.ToList();

            ArrayList lista = new ArrayList();
            lista.Add(listaDeDuenios);
            lista.Add(listaDeMascotas);

            return lista;
        }
    }
}

