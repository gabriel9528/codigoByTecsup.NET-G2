using Microsoft.EntityFrameworkCore;
using MVC_Razor.Models;

namespace MVC_Razor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Contacto> Contactos { get; set; }
    }
}
