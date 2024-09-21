using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCapas.Models
{
    public class Articulo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del Articulo es obligatorio")]
        [Display(Name = "Nombre del Articulo")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripcion del articulo es obligatoria")]
        public string Descripcion { get; set; }

        [Display(Name = "Fecha de creacion")]
        public string FechaCreacion { get; set; } = string.Empty;

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; } = string.Empty;

        [Required(ErrorMessage = "La categoria es obligatoria")]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }
    }
}
