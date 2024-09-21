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
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ArticulosController(IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostingEnvironment)
        {
            _icontenedorTrabajo = contenedorTrabajo;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            var item = _icontenedorTrabajo.IArticuloRepository.GetAll();
            return View();
        }

        #region Create
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
        [ValidateAntiForgeryToken]
        public IActionResult Create(ArticuloCategoriaViewModel articuloCategoriaViewModel)
        {
            string mainRoute = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            if(articuloCategoriaViewModel.Articulo.Id == 0 && files.Count > 0)
            {
                string nameFile = Guid.NewGuid().ToString();
                var upload = Path.Combine(mainRoute, @"imagenes\articulos");
                var extension = Path.GetExtension(files[0].FileName);

                using (var fileStreams = new FileStream(Path.Combine(upload, nameFile + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStreams);
                }

                articuloCategoriaViewModel.Articulo.UrlImagen = @"\imagenes\articulos\" + nameFile + extension;
                articuloCategoriaViewModel.Articulo.FechaCreacion = DateTime.Now.ToString();

                _icontenedorTrabajo.IArticuloRepository.Add(articuloCategoriaViewModel.Articulo);
                _icontenedorTrabajo.Save();

                return RedirectToAction(nameof(Index));

            }
            
            articuloCategoriaViewModel.ListaCategorias = _icontenedorTrabajo.ICategoriaRepository.GetListCategorias();
            return View(articuloCategoriaViewModel);
        }
        #endregion

        #region Edit
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            ArticuloCategoriaViewModel articuloCategoriaViewModel = new ArticuloCategoriaViewModel()
            {
                Articulo = new Articulo(),
                ListaCategorias = _icontenedorTrabajo.ICategoriaRepository.GetListCategorias()
            };

            if(id != null)
            {
                articuloCategoriaViewModel.Articulo = _icontenedorTrabajo.IArticuloRepository.GetById(id.GetValueOrDefault());
            }

            return View(articuloCategoriaViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ArticuloCategoriaViewModel articuloCategoriaViewModel)
        {
            string mainRoute = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var objArticulo = _icontenedorTrabajo.IArticuloRepository.GetById(articuloCategoriaViewModel.Articulo.Id);

            //En caso de que se haya subido una nueva imagen
            if(files.Count() > 0)
            {
                string nameFile = Guid.NewGuid().ToString();
                var upload = Path.Combine(mainRoute, @"imagenes\articulos");
                var extension = Path.GetExtension(files[0].FileName);

                //Comprobamos si existe la imagen
                var rutaImagenAntigua = Path.Combine(mainRoute, objArticulo.UrlImagen.TrimStart('\\'));

                if(System.IO.File.Exists(rutaImagenAntigua))
                {
                    System.IO.File.Delete(rutaImagenAntigua);
                }

                //Subimos la nueva imagen
                using (var fileStreams = new FileStream(Path.Combine(upload, nameFile + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStreams);
                }

                articuloCategoriaViewModel.Articulo.UrlImagen = @"\imagenes\articulos\" + nameFile + extension;
                articuloCategoriaViewModel.Articulo.FechaCreacion = DateTime.Now.ToString();

                _icontenedorTrabajo.IArticuloRepository.Update(articuloCategoriaViewModel.Articulo);
                _icontenedorTrabajo.Save();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                //cuando no subimos ninguna imagen nueva
                articuloCategoriaViewModel.Articulo.UrlImagen = objArticulo.UrlImagen;
            }
            _icontenedorTrabajo.IArticuloRepository.Update(articuloCategoriaViewModel.Articulo);
            _icontenedorTrabajo.Save();

           return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Delete
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var oArticulo = _icontenedorTrabajo.IArticuloRepository.GetById(id);
            string rutaPrincipal = _hostingEnvironment.WebRootPath;
            var rootImage = Path.Combine(rutaPrincipal, oArticulo.UrlImagen.TrimStart('\\'));
            if (System.IO.File.Exists(rootImage))
            {
                System.IO.File.Delete(rootImage);
            }

            if (oArticulo == null)
            {
                return Json(new { success = false, message = "Error, eliminando articulo" });
            }

            _icontenedorTrabajo.IArticuloRepository.Remove(oArticulo);
            _icontenedorTrabajo.Save();
            return Json(new { success = true, message = "Articulo eliminado exitosamente" });

        }

        #endregion

        #region Llamadas a la API
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _icontenedorTrabajo.IArticuloRepository.GetAll(includeProperties: "Categoria") });
        }
        #endregion
    }
}
