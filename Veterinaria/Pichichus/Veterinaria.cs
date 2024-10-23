using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaPichichus.Pichichus;

namespace VeterinariaPichichus.veterinaria
{
    public class Veterinaria
    {

        public string Nombre { get; set; }
        public List<Turno> Turnos { get; set; }

        public Veterinaria(string nombre)
        {
            Nombre = nombre;
            Turnos = new List<Turno>();
        }
    }
}
