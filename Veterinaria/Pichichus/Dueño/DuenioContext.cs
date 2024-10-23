using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaPichichus.veterinaria.Dueño;

namespace VeterinariaPichichus.Pichichus.Dueño
{
    public class DuenioContext : DbContext
    {
        public DbSet<Duenio> Duenios { get; set; }
       // public DbSet<Mascota> Mascotas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = MOURINOOS\\AXSQLEXPRESS ; Initial Catalog = Duenio;  Encrypt= true;trustservercertificate =true; Integrated Security = true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
