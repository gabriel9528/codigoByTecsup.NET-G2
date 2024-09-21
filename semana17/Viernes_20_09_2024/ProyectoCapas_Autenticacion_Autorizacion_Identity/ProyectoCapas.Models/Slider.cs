using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCapas.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese un nombre para el Slider")]
        [Display(Name = "Nombre del Slider")]
        public string Nombre { get; set; }
        [Required]
        public bool State { get; set; }
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }
    }
}
