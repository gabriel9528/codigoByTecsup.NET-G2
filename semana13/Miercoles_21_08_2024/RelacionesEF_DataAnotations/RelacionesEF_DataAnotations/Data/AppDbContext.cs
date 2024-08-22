using Microsoft.EntityFrameworkCore;
using RelacionesEF_DataAnotations.Models.ManyToMany;
using RelacionesEF_DataAnotations.Models.OneToMany;
using RelacionesEF_DataAnotations.Models.OneToOne;

namespace RelacionesEF_DataAnotations.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //OneToOne
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarCompany> CarCompanies { get; set; }

        //OneToMany
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }

        //ManyToMany
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
