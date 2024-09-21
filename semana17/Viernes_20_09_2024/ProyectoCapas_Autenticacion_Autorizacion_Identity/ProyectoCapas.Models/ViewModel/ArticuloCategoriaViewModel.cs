using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProyectoCapas.Models.ViewModel
{
    public class ArticuloCategoriaViewModel
    {
        public Articulo Articulo { get; set; }
        public IEnumerable<SelectListItem> ListaCategorias { get; set; }
    }
}
