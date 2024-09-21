using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ProyectoCapas.AccesoDatos.Data.Repository.IRepository;
using ProyectoCapas.Models;
using ProyectoCapas.Models.ViewModel;

namespace ProyectoCapas.Areas.Admin.Controllers
{
    [Authorize(Roles = "Administrador")]
    [Area("Admin")]
    public class SlidersController : Controller
    {
        private readonly IContenedorTrabajo _icontenedorTrabajo;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public SlidersController(IContenedorTrabajo icontenedorTrabajo, IWebHostEnvironment hostingEnvironment)
        {
            _icontenedorTrabajo = icontenedorTrabajo;
            _hostingEnvironment = hostingEnvironment;
        }


        [HttpGet]
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
        public IActionResult Create(Slider slider)
        {
            string rutaPrincipal = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            if (files.Count() > 0)
            {
                string nombreArchivo = Guid.NewGuid().ToString();
                var upload = Path.Combine(rutaPrincipal, @"imagenes\sliders");
                var extension = Path.GetExtension(files[0].FileName);

                using (var fileStreams = new FileStream(Path.Combine(upload, nombreArchivo + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStreams);
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
            if (id != null)
            {
                var slider = _icontenedorTrabajo.ISliderRepository.Get(id.GetValueOrDefault());
                return View(slider);
            }

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Slider slider)
        {

            string rutaPrincipal = _hostingEnvironment.WebRootPath;
            var archivos = HttpContext.Request.Form.Files;

            var oSlider = _icontenedorTrabajo.ISliderRepository.Get(slider.Id);

            if (archivos.Count() > 0)
            {
                //Creamos una nueva imagen
                string nombreArchivo = Guid.NewGuid().ToString();
                var subida = Path.Combine(rutaPrincipal, @"imagenes\sliders");
                var extension = Path.GetExtension(archivos[0].FileName);

                var rutaImagen = Path.Combine(rutaPrincipal, oSlider.UrlImagen.TrimStart('\\'));

                if (System.IO.File.Exists(rutaImagen))
                {
                    System.IO.File.Delete(rutaImagen);
                }

                using (var fileStreams = new FileStream(Path.Combine(subida, nombreArchivo + extension), FileMode.Create))
                {
                    archivos[0].CopyTo(fileStreams);
                }

                slider.UrlImagen = @"\imagenes\sliders\" + nombreArchivo + extension;

                _icontenedorTrabajo.ISliderRepository.Update(slider);
                _icontenedorTrabajo.Save();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                //en caso no cambiemos la imagen
                slider.UrlImagen = oSlider.UrlImagen;
            }

            _icontenedorTrabajo.ISliderRepository.Update(slider);
            _icontenedorTrabajo.Save();

            return RedirectToAction(nameof(Index));
        }


        #endregion

        #region Delete
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var oSlider = _icontenedorTrabajo.ISliderRepository.Get(id);
            string rutaPrincipal = _hostingEnvironment.WebRootPath;
            var rutaImagen = Path.Combine(rutaPrincipal, oSlider.UrlImagen.TrimStart('\\'));
            if (System.IO.File.Exists(rutaImagen))
            {
                System.IO.File.Delete(rutaImagen);
            }

            if (oSlider == null)
            {
                return Json(new { success = false, message = "Error, eliminando slider" });
            }

            _icontenedorTrabajo.ISliderRepository.Remove(oSlider);
            _icontenedorTrabajo.Save();
            return Json(new { success = true, message = "Slider eliminado exitosamente" });

        }

        #endregion


        #region Lllamadas a la API

        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _icontenedorTrabajo.ISliderRepository.GetAll() });
        }

        #endregion
    }
}
