using System.ComponentModel.DataAnnotations;
using VeterinariaPichichus.Pichichus.Dueño.Mascota;

namespace VeterinariaPichichus.veterinaria.Dueño
{
    public class Duenio
    {
        [Key]
        public int DNI { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(100)]
        public string Apellido { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(100)]
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
