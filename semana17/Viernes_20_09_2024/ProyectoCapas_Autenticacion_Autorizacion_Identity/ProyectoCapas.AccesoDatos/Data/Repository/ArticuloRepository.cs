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
            var objDesdeDb = _db.Articulo.FirstOrDefault(x => x.Id == articulo.Id);
            objDesdeDb.Nombre = articulo.Nombre;
            objDesdeDb.Descripcion = articulo.Descripcion;
            objDesdeDb.UrlImagen = articulo.UrlImagen;
            objDesdeDb.CategoriaId = articulo.CategoriaId;
            //_db.SaveChanges();  
        }
    }
}
