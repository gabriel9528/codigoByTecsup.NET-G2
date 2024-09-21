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
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoriaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetListCategorias()
        {
            return _db.Categorias.Select(x => new SelectListItem()
            {
                Text = x.Nombre,
                Value = x.Id.ToString()
            });
        }

        public void Update(Categoria categoria)
        {
            var objCategorias = _db.Categorias.FirstOrDefault(x => x.Id == categoria.Id);
            objCategorias.Nombre = categoria.Nombre;
            objCategorias.Orden = categoria.Orden;
            _db.SaveChanges();
        }
    }
}
