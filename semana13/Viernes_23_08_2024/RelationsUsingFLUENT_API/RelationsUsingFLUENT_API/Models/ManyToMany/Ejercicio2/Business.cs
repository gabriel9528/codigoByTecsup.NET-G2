namespace RelationsUsingFLUENT_API.Models.ManyToMany.Ejercicio2
{
    public class Business
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<PersonBusiness>? PersonBusinesses { get; set; }
    }
}
