using Crud_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Contacto> Contactos { get; set; }
    }
}
