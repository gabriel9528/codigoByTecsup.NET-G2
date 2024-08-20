using Bases03;

class Program
{
    static void Main()
    {
        //Ejercicio 9
        //Gestionar la información de estudiantes en una institución educativa.
        //Cada estudiante tiene un nombre, un ID, el nombre de un curso en el que está inscrito,
        //y un promedio de calificaciones.

        List<Student> studentList = new List<Student>()
        {
            new Student(1, "Gabriel", "Mercadotecnia", 16),
            new Student(2, "Luis", "Derecho", 15),
            new Student(3, "Ana", "Medicina", 17),
            new Student(4, "Sofia", "Ingeniería", 14),

        };

        //Encontar a los estudiantes con promedio mayor a 15
        var rejects = from x in studentList
                      where x.Average > 15
                      select x;

        //Eoncontrar a los estudiantes que lleven el curso de Derecho
        var derecho = studentList.Where(x => x.Course == "Derecho");

        //Mostramos los resultados
        Console.WriteLine("Rejects");
        foreach(var item in rejects)
            Console.WriteLine(item);

        Console.WriteLine("Derecho");
        foreach(var item in derecho)
            Console.WriteLine(item);

    }
}