using Microsoft.EntityFrameworkCore;
using RelationsUsingFLUENT_API.Models.ManyToMany.Ejercicio1;
using RelationsUsingFLUENT_API.Models.ManyToMany.Ejercicio2;
using RelationsUsingFLUENT_API.Models.OneToMany;
using RelationsUsingFLUENT_API.Models.OneToOne;

namespace RelationsUsingFLUENT_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One-to-One
            modelBuilder.Entity<CarCompany>()
                .HasOne(x => x.CarModel)
                .WithOne(p => p.CarCompany)
                .HasForeignKey<CarModel>(t => t.CarCompanyId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Employee>()
                .HasOne(x => x.EmployeeAddress)
                .WithOne(s => s.Employee)
                .HasForeignKey<EmployeeAddress>(t => t.EmployeeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            //One-to-Many
            modelBuilder.Entity<Doctor>()
                .HasMany(x => x.PattientsList)
                .WithOne(p => p.Doctor)
                .HasForeignKey(p => p.DoctorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            //*---------------------------------*


            //Many-to-Many
            modelBuilder.Entity<StudentMateria>()
                .HasKey(x => new { x.StudentId, x.MateriaId });

            modelBuilder.Entity<StudentMateria>()
                .HasOne(x => x.Student)
                .WithMany( t => t.StudentMaterias)
                .HasForeignKey(p => p.StudentId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StudentMateria>()
                .HasOne( x => x.Materia)
                .WithMany(t => t.StudentMaterias)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            //*************************************************
            modelBuilder.Entity<PersonBusiness>()
                .HasKey(s => new { s.PersonId, s.BusinessId });

            modelBuilder.Entity<PersonBusiness>()
                .HasOne(t => t.Person)
                .WithMany(x => x.PersonBusiness)
                .HasForeignKey(p => p.PersonId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PersonBusiness>()
                .HasOne(x => x.Business)
                .WithMany(p => p.PersonBusinesses)
                .HasForeignKey( s => s.BusinessId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);






        }

    }
}
