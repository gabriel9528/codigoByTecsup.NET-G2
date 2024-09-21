using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoCapas.AccesoDatos.Data.Repository.IRepository;
using ProyectoCapas.Models;

namespace ProyectoCapas.Areas.Admin.Controllers
{
    [Authorize(Roles = "Administrador")]    
    [Area("Admin")]
    public class CategoriasController : Controller
    {
        private readonly IContenedorTrabajo _icontenedorTrabajo;

        public CategoriasController(IContenedorTrabajo icontenedorTrabajo)
        {
            _icontenedorTrabajo = icontenedorTrabajo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Categoria categoria)
        {
            if(ModelState.IsValid)
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
            categoria = _icontenedorTrabajo.ICategoriaRepository.Get(id);
            if(categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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

        #region Lllamadas a la API

        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new {data = _icontenedorTrabajo.ICategoriaRepository.GetAll()});
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objDesdeDb = _icontenedorTrabajo.ICategoriaRepository.Get(id);
            if(objDesdeDb == null)
            {
                return Json(new { success = false, message = "Error al borrar la categoria" });
            }
            
            _icontenedorTrabajo.ICategoriaRepository.Remove(objDesdeDb);
            _icontenedorTrabajo.Save();

            return Json(new { success = true, message = "Categoria borrada exitosamente" });

        }

        #endregion
    }
}
