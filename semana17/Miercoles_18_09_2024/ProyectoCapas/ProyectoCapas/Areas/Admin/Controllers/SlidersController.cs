using Microsoft.AspNetCore.Mvc;
using ProyectoCapas.AccesoDatos.Data.Repository.IRepository;

namespace ProyectoCapas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlidersController : Controller
    {
        private readonly IContenedorTrabajo _icontenedorTrabajo;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public SlidersController(IContenedorTrabajo icontenedorTrabajo, IWebHostEnvironment iWebHostEnvironment)
        {
            _icontenedorTrabajo = icontenedorTrabajo;
            _hostingEnvironment = iWebHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region LLAMADAS A LA API

        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _icontenedorTrabajo.ISliderRepository.GetAll() });
        }

        #endregion
    }
}
