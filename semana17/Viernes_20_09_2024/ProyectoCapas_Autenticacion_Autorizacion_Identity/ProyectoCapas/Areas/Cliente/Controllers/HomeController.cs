using Microsoft.AspNetCore.Mvc;
using ProyectoCapas.AccesoDatos.Data.Repository.IRepository;
using ProyectoCapas.Models;
using ProyectoCapas.Models.ViewModel;
using System.Diagnostics;

namespace ProyectoCapas.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class HomeController : Controller
    {
        private readonly IContenedorTrabajo _icontenedorTrabajo;

        public HomeController(IContenedorTrabajo icontenedorTrabajo)
        {
            _icontenedorTrabajo = icontenedorTrabajo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                listSliders = _icontenedorTrabajo.ISliderRepository.GetAll(),
                listArticulos = _icontenedorTrabajo.IArticuloRepository.GetAll(includeProperties: "Categoria")
            };

            ViewBag.IsHome = true;

            return View(homeViewModel);
        }

        [HttpGet]
        public IActionResult Detalle(int id)
        {
            var articulo = _icontenedorTrabajo.IArticuloRepository.GetFirstOrDefault(includeProperties: "Categoria", filter: a => a.Id == id);

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
