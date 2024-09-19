using Microsoft.AspNetCore.Mvc;
using ProyectoCapas.AccesoDatos.Data.Repository.IRepository;
using ProyectoCapas.Models;
using System.Net.WebSockets;

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

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Slider slider)
        {
            string rutaPrincipal = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            if (files.Count() > 0)
            {
                string nombreArchivo = Guid.NewGuid().ToString();
                var upload = Path.Combine(rutaPrincipal, @"imagenes\sliders");
                var extension = Path.GetExtension(files[0].FileName);

                using (var fileStream = new FileStream(Path.Combine(upload, nombreArchivo + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }

                slider.UrlImagen = @"\imagenes\sliders\" + nombreArchivo + extension;

                _icontenedorTrabajo.ISliderRepository.Add(slider);
                _icontenedorTrabajo.Save();

                return RedirectToAction(nameof(Index));
            }

            return View(slider);
        }
        #endregion


        #region Edit

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id != null)
            {
                Slider slider = _icontenedorTrabajo.ISliderRepository.GetById(id.GetValueOrDefault());
                return View(slider);
            }
            return NotFound();
        }

        #endregion

        #region LLAMADAS A LA API

        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _icontenedorTrabajo.ISliderRepository.GetAll() });
        }

        #endregion
    }
}
