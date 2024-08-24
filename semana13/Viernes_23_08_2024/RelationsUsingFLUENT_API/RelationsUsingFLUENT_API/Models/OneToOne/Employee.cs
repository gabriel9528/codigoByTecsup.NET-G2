namespace RelationsUsingFLUENT_API.Models.OneToOne
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public EmployeeAddress? EmployeeAddress { get; set; }
    }
}
