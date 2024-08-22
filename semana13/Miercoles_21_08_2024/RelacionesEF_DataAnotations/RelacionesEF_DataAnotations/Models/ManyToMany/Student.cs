namespace RelacionesEF_DataAnotations.Models.ManyToMany
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        //Relacion de muchos a muchos
        public List<Subject>? Subjects { get; set; } //Propiedad de navegacion
    }
}
