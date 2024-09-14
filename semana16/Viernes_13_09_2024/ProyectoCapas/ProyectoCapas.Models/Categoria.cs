using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCapas.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Es obligatorio un nombre para la Categoria")]
        [Display(Name = "Nombre de la Categoria")]
        public string? Nombre { get; set; }

        [Display(Name = "Orden de la Categoria")]
        [Range(1, 100, ErrorMessage = "El orden de la Categoria debe estar entre 1 y 100")]
        public int? Orden { get; set; }
    }
}
