using Microsoft.EntityFrameworkCore;
using ultima.Models;

namespace PracticaFormularios.Models
{
    public class equiContext : DbContext
    {
        public equiContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<equipos> equipos { get; set; }
        public DbSet<marcas> marcas { get; set; }
        public DbSet<tipo_equipo> tipo_equipo { get; set; }
        public DbSet<estados_equipo> estados_equipo { get; set; }



    }
}
