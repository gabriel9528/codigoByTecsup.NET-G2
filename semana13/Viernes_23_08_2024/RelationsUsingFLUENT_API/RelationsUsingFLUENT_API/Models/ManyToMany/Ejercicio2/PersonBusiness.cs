namespace RelationsUsingFLUENT_API.Models.ManyToMany.Ejercicio2
{
    public class PersonBusiness
    {
        public int PersonId { get; set; }
        public int BusinessId { get; set; }
        public Person? Person { get; set; }
        public Business? Business { get; set; }
    }
}
