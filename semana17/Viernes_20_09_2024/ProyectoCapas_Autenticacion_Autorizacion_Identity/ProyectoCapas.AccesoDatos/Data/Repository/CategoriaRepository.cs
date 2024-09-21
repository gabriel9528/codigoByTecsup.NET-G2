using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoCapas.AccesoDatos.Data.Repository.IRepository;
using ProyectoCapas.Data;
using ProyectoCapas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCapas.AccesoDatos.Data.Repository
{
    public class UsuarioRepository : Repository<ApplicationUser>, IUsuarioRepository
    {
        private readonly ApplicationDbContext _db;

        public UsuarioRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void BloquearUsuario(string userId)
        {
            var usuarioDesdeDb = _db.ApplicationUser.FirstOrDefault(u => u.Id == userId);
            usuarioDesdeDb.LockoutEnd = DateTime.Now.AddYears(1000);
            _db.SaveChanges();
        }

        public void DesbloquearUsuario(string userId)
        {
            var usuarioDesdeDb = _db.ApplicationUser.FirstOrDefault(u => u.Id == userId);
            usuarioDesdeDb.LockoutEnd = DateTime.Now;
            _db.SaveChanges();
        }
    }
}
