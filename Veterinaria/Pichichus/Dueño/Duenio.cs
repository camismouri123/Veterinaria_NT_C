using System.ComponentModel.DataAnnotations;
using VeterinariaPichichus.Pichichus.Dueño.Mascota;

namespace VeterinariaPichichus.veterinaria.Dueño
{
    public class Duenio
    {
        [Key]
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }


        public Duenio() { }
                // Constructor de la clase Duenio

        public Duenio(string nombre, string apellido, string email, int telefono, int dni )
        {
           
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            DNI = dni;
            
        }
    }


}
