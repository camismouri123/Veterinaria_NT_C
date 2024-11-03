using Microsoft.EntityFrameworkCore;
using VeterinariaPichichus.Models;

namespace VeterinariaPichichus.Context
{
    public class DuenioContext : DbContext
    {
        //public DbSet<Mascota> Mascotas { get; set; }

        public DbSet<Mascota> Mascotas { get; set; }

        public DbSet<Duenio> Duenios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = MOURINOOS\\AXSQLEXPRESS ; Initial Catalog = Duenio;  Encrypt= true;trustservercertificate =true; Integrated Security = true");
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Duenio>()
                .HasOne(d => d.MascotaDuenio)
                .HasForeingKey(m => m.MascotaId);
        }
    }
}
