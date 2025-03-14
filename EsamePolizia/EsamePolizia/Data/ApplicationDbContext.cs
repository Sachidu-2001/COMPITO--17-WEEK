using EsamePolizia.Models;
using Microsoft.EntityFrameworkCore;

namespace EsamePolizia.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Anagrafica> Anagrafiche { get; set; }
        public DbSet<Tipo_Violazione> Tipo_Violazioni { get; set; }
        public DbSet<Verbale> Verbali { get; set; }

    }
}
