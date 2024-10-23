using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VeterinariaPichichus.veterinaria.Dueño;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VeterinariaPichichus.Pichichus.Dueño.Mascota
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public TipoMascota Tipo{ get; set; }
        public int Edad { get; set; }
        public string Raza { get; set; }
        public string Color { get; set; }
        public int Peso { get; set; }

        public ICollection<Duenio> Duenios { get; set; } = new List<Duenio>();


        public Mascota(string nombre, TipoMascota tipo, int edad, string raza, string color, int peso)
        {
            Nombre = nombre;
            Tipo = tipo;
            Edad = edad;
            Raza = raza;
            Color = color;
            Peso = peso;


        }
    }
}
