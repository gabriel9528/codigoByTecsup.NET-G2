using Microsoft.AspNetCore.Mvc;
using ProyectoCapas.AccesoDatos.Data.Repository.IRepository;
using ProyectoCapas.Models;
using ProyectoCapas.Models.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoCapas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticulosController : Controller
    {
        private readonly IContenedorTrabajo _icontenedorTrabajo;

        public ArticulosController(IContenedorTrabajo contenedorTrabajo)
        {
            _icontenedorTrabajo = contenedorTrabajo;
        }
        public IActionResult Index()
        {
            var item = _icontenedorTrabajo.IArticuloRepository.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ArticuloCategoriaViewModel articuloCategoriaViewModel = new ArticuloCategoriaViewModel()
            {
                Articulo = new Articulo(),
                ListaCategorias = _icontenedorTrabajo.ICategoriaRepository.GetListCategorias()
            };

            return View(articuloCategoriaViewModel);
        }

        [HttpPost]
        public IActionResult Create(ArticuloCategoriaViewModel articuloCategoriaViewModel)
        {
            return View();
        }

        #region Llamadas a la API
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _icontenedorTrabajo.IArticuloRepository.GetAll(includeProperties: "Categoria") });
        }
        #endregion
    }
}
