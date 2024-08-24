namespace RelationsUsingFLUENT_API.Models.OneToMany
{
    public class Doctor
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public List<Pattient>? PattientsList { get; set; }
    }
}
