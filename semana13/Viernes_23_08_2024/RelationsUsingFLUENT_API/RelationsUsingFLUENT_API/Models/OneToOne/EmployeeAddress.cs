using System.ComponentModel.DataAnnotations.Schema;

namespace RelationsUsingFLUENT_API.Models.OneToOne
{
    public class EmployeeAddress
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

    }
}
