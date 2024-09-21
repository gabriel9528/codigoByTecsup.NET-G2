using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoCapas.AccesoDatos.Data.Repository.IRepository;
using ProyectoCapas.Models;
using System.Security.Claims;

namespace ProyectoCapas.Areas.Admin.Controllers
{
    [Authorize(Roles = "Administrador")]
    [Area("Admin")]
    public class UsuariosController : Controller
    {
        private readonly IContenedorTrabajo _icontenedorTrabajo;

        public UsuariosController(IContenedorTrabajo icontenedorTrabajo)
        {
            _icontenedorTrabajo = icontenedorTrabajo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //var listUsuarios = _iUnitOfWork.IUserRepository.GetAll(); 
            //return View(listUsuarios);

            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var usuarioActual = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            return View(_icontenedorTrabajo.IUsuarioRepository.GetAll(x => x.Id != usuarioActual.Value));
        }

        [HttpGet]
        public IActionResult Bloquear(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            _icontenedorTrabajo.IUsuarioRepository.BloquearUsuario(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Desbloquear(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            _icontenedorTrabajo.IUsuarioRepository.DesbloquearUsuario(id);
            return RedirectToAction("Index");
        }
    }
}
