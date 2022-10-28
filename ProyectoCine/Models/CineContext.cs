using Microsoft.EntityFrameworkCore;

namespace ProyectoCine.Models
{
    public class CineContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer("Data Source = GUIDO; Initial Catalog=Cine; Integrated Security= true");
        }

        public DbSet<Pelicula> peliculas { get; set; }

        public DbSet<Entrada> entradas { get; set; }

    }
}
