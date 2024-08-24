namespace RelationsUsingFLUENT_API.Models.OneToMany
{
    public class Pattient
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int DoctorId { get; set; } // Foreign Key
        public Doctor? Doctor { get; set; } // Propiedad de navegacion

    }
}
