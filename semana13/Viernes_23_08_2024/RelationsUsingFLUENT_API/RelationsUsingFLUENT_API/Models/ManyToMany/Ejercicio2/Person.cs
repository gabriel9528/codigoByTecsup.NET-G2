namespace RelationsUsingFLUENT_API.Models.ManyToMany.Ejercicio2
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<PersonBusiness>? PersonBusiness { get; set; }
    }
}
