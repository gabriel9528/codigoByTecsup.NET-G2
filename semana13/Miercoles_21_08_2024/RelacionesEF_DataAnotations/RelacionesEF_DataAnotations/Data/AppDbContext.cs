using Microsoft.EntityFrameworkCore;
using RelacionesEF_DataAnotations.Models.OneToOne;

namespace RelacionesEF_DataAnotations.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarCompany> CarCompanies { get; set; }
    }
}
