namespace RelacionesEF_DataAnotations.Models.ManyToMany
{
    public class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        //Relacion de muchos a muchos
        public List<Student>? Students { get; set; } //Propiedad de navegacion
    }
}
