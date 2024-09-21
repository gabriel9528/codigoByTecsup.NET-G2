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
    public class SliderRepository : Repository<Slider>, ISliderRepository
    {
        private readonly ApplicationDbContext _db;

        public SliderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Slider slider)
        {
            var objSlider = _db.Sliders.FirstOrDefault(x => x.Id == slider.Id);
            if(objSlider != null)
            {
                objSlider.Nombre = slider.Nombre;
                objSlider.State = slider.State;
                objSlider.UrlImagen = slider.UrlImagen;
            }
        }
    }
}
