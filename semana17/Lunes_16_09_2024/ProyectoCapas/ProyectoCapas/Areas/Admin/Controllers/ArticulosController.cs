using Microsoft.AspNetCore.Mvc;
using ProyectoCapas.AccesoDatos.Data.Repository.IRepository;
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



        #region Llamadas a la API
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _icontenedorTrabajo.IArticuloRepository.GetAll(includeProperties: "Categoria") });
        }
        #endregion
    }
}
