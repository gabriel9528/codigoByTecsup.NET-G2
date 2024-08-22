using Microsoft.EntityFrameworkCore;
using RelacionesEF_DataAnotations.Data;
using RelacionesEF_DataAnotations.Models.OneToMany;

namespace RelacionesEF_DataAnotations.Repositorios.OneToMany
{
    public class RepositorioOneToMany
    {
        private readonly AppDbContext _dbContext;
        public RepositorioOneToMany(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Patient
        public async Task AddPatient(Patient patient)
        {
            _dbContext.Patients.Add(patient);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Patient>> GetPatients() =>
            await _dbContext.Patients.Include(x=>x.Doctor).ToListAsync();

        //Doctor
        public async Task AddDoctor(Doctor doctor)
        {
            _dbContext.Doctors.Add(doctor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Doctor>> GetDoctors() =>
            await _dbContext.Doctors.Include(x=>x.Patients).ToListAsync();
    }
}
