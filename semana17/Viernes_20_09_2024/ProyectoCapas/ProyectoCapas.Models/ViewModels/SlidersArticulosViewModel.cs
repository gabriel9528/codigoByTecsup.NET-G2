using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCapas.Models.ViewModels
{
    public class SlidersArticulosViewModel
    {
        public IEnumerable<Articulo> listArticulos { get; set; }
        public IEnumerable<Slider> listSliders { get; set; }
    }
}
