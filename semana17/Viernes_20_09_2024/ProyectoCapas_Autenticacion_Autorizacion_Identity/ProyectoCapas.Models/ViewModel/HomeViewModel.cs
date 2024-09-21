using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCapas.Models.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Slider> listSliders { get; set; }
        public IEnumerable<Articulo> listArticulos { get; set; }
    }
}
