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
    public class ArticuloRepository : Repository<Articulo>, IArticuloRepository
    {
        private readonly ApplicationDbContext _db;

        public ArticuloRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Articulo articulo)
        {
            var objArticulo = _db.Articulos.FirstOrDefault(x=>x.Id == articulo.Id);
            if (objArticulo != null)
            {
                objArticulo.Nombre = articulo.Nombre;
                objArticulo.Descripcion = articulo.Descripcion;
                objArticulo.UrlImagen = articulo.UrlImagen;
                objArticulo.CategoriaId = articulo.CategoriaId;
            }
        }
    }
}
