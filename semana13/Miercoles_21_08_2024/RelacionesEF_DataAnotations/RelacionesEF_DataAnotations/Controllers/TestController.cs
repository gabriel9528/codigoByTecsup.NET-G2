using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelacionesEF_DataAnotations.Models.OneToMany;
using RelacionesEF_DataAnotations.Models.OneToOne;
using RelacionesEF_DataAnotations.Repositorios.OneToMany;
using RelacionesEF_DataAnotations.Repositorios.OneToOne;

namespace RelacionesEF_DataAnotations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly RepositorioOneToOne _repositorioOneToOne;
        private readonly RepositorioOneToMany _repositorioOneToMany;
        public TestController(RepositorioOneToOne repositorioOneToOne,
            RepositorioOneToMany repositorioOneToMany)
        {
            _repositorioOneToOne = repositorioOneToOne;
            _repositorioOneToMany = repositorioOneToMany;
        }

        //OneToOne
        [HttpPost("CartCompany")]
        public async Task<IActionResult> AddCarCompany(CarCompany carCompany)
        {
            await _repositorioOneToOne.AddCarCompany(carCompany);
            return Ok("Company Saved");
        }

        [HttpPost("CartModel")]
        public async Task<IActionResult> AddCarModel(CarModel carModel)
        {
            await _repositorioOneToOne.AddCarModel(carModel);
            return Ok("Model Saved");
        }

        [HttpGet("CartCompany")]
        public async Task<IActionResult> GetCarCompanies()
        {
            var companies = await _repositorioOneToOne.GetCarCompanies();
            return Ok(companies);
        }

        [HttpGet("CarModel")]
        public async Task<IActionResult> GetCarModels() =>
            Ok(await _repositorioOneToOne.GetCarModels());

        //OneToMany

        [HttpPost("Doctor")]
        public async Task<IActionResult> AddDoctor([FromBody] Doctor doctor)
        {
            await _repositorioOneToMany.AddDoctor(doctor);
            return Ok("Doctor saved");
        }

        [HttpPost("Patient")]
        public async Task<IActionResult> AddPatient([FromBody] Patient patient)
        {
            await _repositorioOneToMany.AddPatient(patient);
            return Ok("Patient saved");
        }

        [HttpGet("Doctors")]
        public async Task<IActionResult> GetDoctors()
        {
            return Ok(await _repositorioOneToMany.GetDoctors());
        }

        [HttpGet("Patients")]
        public async Task<IActionResult> GetPatients()
        {
            return Ok(await _repositorioOneToMany.GetPatients());
        }
    }
}
