using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaPichichus.Context;
using VeterinariaPichichus.veterinaria.Dueño;


namespace VeterinariaPichichus.Models
{
    public class Actividad_Duenio
    {
        Persistir_Duenio Persistir_Duenio = new Persistir_Duenio();

        public bool GrabarDuenio(Duenio duenio)
        {
            return Persistir_Duenio.GrabarDuenio(duenio);
        }


        public Duenio? BuscarDuenioPorDNI(string dni)
        {
            return Persistir_Duenio.BuscarDuenioPorDNI(dni);

        }
        public List<Duenio> ObtengoTodosLosDuenios()
        {
            return Persistir_Duenio.ObtengoTodosLosDuenios();
        }
    }
}
