using AgendaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaAPI.Data
{
    public class AgendaDbContext : DbContext
    {
        public AgendaDbContext(DbContextOptions<AgendaDbContext> options) : base(options) { }
        public DbSet<Contacto> Contactos { get; set; }

    }
}
