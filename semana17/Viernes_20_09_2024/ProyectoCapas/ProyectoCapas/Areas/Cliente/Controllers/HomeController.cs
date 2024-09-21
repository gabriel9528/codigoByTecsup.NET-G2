using Microsoft.AspNetCore.Mvc;
using ProyectoCapas.AccesoDatos.Data.Repository.IRepository;
using ProyectoCapas.Models;
using ProyectoCapas.Models.ViewModels;
using System.Diagnostics;

namespace ProyectoCapas.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class HomeController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;

        public HomeController(IContenedorTrabajo contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;
        }

        public IActionResult Index()
        {
            SlidersArticulosViewModel slidersArticulosViewModel = new SlidersArticulosViewModel()
            {
                listArticulos = _contenedorTrabajo.IArticuloRepository.GetAll(includeProperties: "Categoria"),
                listSliders = _contenedorTrabajo.ISliderRepository.GetAll()
            };

            ViewBag.IsHome = true;

            return View(slidersArticulosViewModel);
        }

        [HttpGet]
        public IActionResult Detalle(int id)
        {
            var articulo = _contenedorTrabajo.IArticuloRepository.GetFirstOrDefault(includeProperties: "Categoria", filter: x => x.Id == id);
            return View(articulo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
