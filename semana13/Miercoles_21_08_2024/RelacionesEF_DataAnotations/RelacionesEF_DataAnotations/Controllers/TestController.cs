using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelacionesEF_DataAnotations.Models.OneToOne;
using RelacionesEF_DataAnotations.Repositorios.OneToOne;

namespace RelacionesEF_DataAnotations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly RepositorioOneToOne _repositorioOneToOne;
        public TestController(RepositorioOneToOne repositorioOneToOne)
        {
            _repositorioOneToOne = repositorioOneToOne;
        }

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
    }
}
