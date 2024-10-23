using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaPichichus.veterinaria;
using VeterinariaPichichus.veterinaria.Dueño;

namespace VeterinariaPichichus.Pichichus
{
    public class Turno
    {
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public Servicio Tiposervicio { get; set; }
        public Duenio NombreDuenio { get; set; }

        public Turno(DateTime fecha, DateTime hora,Servicio tipoServicio,Duenio duenio)
        {
            Fecha = fecha;
            Hora = hora;
            Tiposervicio = tipoServicio;
            NombreDuenio = duenio;

        }

    }
}
