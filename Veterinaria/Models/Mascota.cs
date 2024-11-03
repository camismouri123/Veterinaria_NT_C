using System.ComponentModel.DataAnnotations;

namespace VeterinariaPichichus.Models
{
    public class Mascota
    {
        [Key]
        public int idMascota { get; set; }
        public string Nombre { get; set; }
        public TipoMascota Tipo { get; set; }
        public int Edad { get; set; }
        public string Raza { get; set; }
        public string Color { get; set; }
        public int Peso { get; set; }

        public ICollection<Duenio> Duenios { get; set; } = new List<Duenio>();


    }
}
