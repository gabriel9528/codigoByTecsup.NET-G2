using System.ComponentModel.DataAnnotations;

namespace MVC_Razor.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Es muy importante ingresar su nombre")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Es muy importante ingresar su telefono")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Es muy importante ingresar su celular")]
        public string? CellPhone { get; set; }
        [Required(ErrorMessage = "Es muy importante ingresar su email")]
        public string? Email { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
