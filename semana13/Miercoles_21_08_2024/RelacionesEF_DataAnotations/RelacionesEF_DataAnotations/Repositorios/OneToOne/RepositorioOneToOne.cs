using Microsoft.EntityFrameworkCore;
using RelacionesEF_DataAnotations.Data;
using RelacionesEF_DataAnotations.Models.OneToOne;

namespace RelacionesEF_DataAnotations.Repositorios.OneToOne
{
    public class RepositorioOneToOne
    {
        private readonly AppDbContext _context;

        public RepositorioOneToOne(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<CarCompany>> GetCarCompanies() =>
            await _context.CarCompanies.ToListAsync();

        public async Task AddCarCompany(CarCompany carCompany)
        {
            _context.CarCompanies.Add(carCompany);
            await _context.SaveChangesAsync();
        }

        public async Task AddCarModel(CarModel carModel)
        {
            _context.CarModels.Add(carModel);
            await _context.SaveChangesAsync();
        }
        public async Task<List<CarModel>> GetCarModels() =>
            await _context.CarModels.ToListAsync();
    }
}
