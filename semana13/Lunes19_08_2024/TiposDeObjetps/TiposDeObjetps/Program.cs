using System.Collections;
using TiposDeObjetps;

class Program
{
    public static void Main()
    {
        //Ejercicio 10
        //Uso de coleccione genericas: donde vamos a crear una coleccion generica e
        //identificar un unico tipo de objeto

        ArrayList arrayList = new ArrayList();
        arrayList.AddRange(new object[]
        {
            "hello world",
            5,
            2.99,
            true,
            10,
            18,
            8.58,
            "goodbye world"
        });

        var values = arrayList.OfType<double>();
        foreach(var value in values)
        {
            Console.WriteLine(value);
        }


        Console.WriteLine("*--------------------------------*");
        Console.WriteLine("Ejercicio 2A");
        ArrayList arrayList2 = new ArrayList();
        arrayList2.AddRange(new object[]
        {
            new Student(1, "Gabriel", "Mercadotecnia", 16),
            new Student(2, "Luis", "Derecho", 15),
            new Student(3, "Ana", "Medicina", 17),
            new Student(4, "Sofia", "Ingeniería", 14),

        });

        var values2 = arrayList2.OfType<Student>();
        foreach (var value in values2)
        {
            Console.WriteLine(value);
        }
    }
}