using Microsoft.AspNetCore.Mvc;
using ProyectoCapas.AccesoDatos.Data.Repository.IRepository;
using ProyectoCapas.Models;

namespace ProyectoCapas.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriasController : Controller
    {
        private readonly IContenedorTrabajo _icontenedorTrabajo;

        public CategoriasController(IContenedorTrabajo icontenedorTrabajo)
        {
            _icontenedorTrabajo = icontenedorTrabajo;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Categoria categoria)
        {
            if (ModelState.IsValid) 
            {
                _icontenedorTrabajo.ICategoriaRepository.Add(categoria);
                _icontenedorTrabajo.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(categoria);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Categoria categoria = new Categoria();
            categoria = _icontenedorTrabajo.ICategoriaRepository.GetById(id);
            if (categoria == null)
            {
                return NotFound();
            }
            return View(categoria);
        }

        [HttpPost]
        public IActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _icontenedorTrabajo.ICategoriaRepository.Update(categoria);
                _icontenedorTrabajo.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(categoria);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objCategoria = _icontenedorTrabajo.ICategoriaRepository.GetById(id);
            if (objCategoria == null)
            {
                return Json(new { success = false, message = "Error al borrar la categoría" });
            }

            _icontenedorTrabajo.ICategoriaRepository.Remove(objCategoria);
            _icontenedorTrabajo.Save();

            return Json(new { success = true, message = "Categoría borrada exitosamente" });
        }

        #region Llamadas a la API"
            public IActionResult GetAll()
        {
            var item = _icontenedorTrabajo.ICategoriaRepository.GetAll();
            return Json(new { data = _icontenedorTrabajo.ICategoriaRepository.GetAll() });
        }
        #endregion
    }
}
