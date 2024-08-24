namespace RelationsUsingFLUENT_API.Models.ManyToMany.Ejercicio1
{
    public class StudentMateria
    {
        public int StudentId { get; set; }
        public int MateriaId { get; set; }

        public Student? Student { get; set; }
        public Materia? Materia { get; set; }
    }
}
