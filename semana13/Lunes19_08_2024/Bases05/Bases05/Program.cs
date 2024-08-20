using System.Diagnostics.Metrics;
using System;
using Bases05;

class Porgram
{
    public static void Main()
    {
        //Ejercicio 11: En este ejercicio, deberás trabajar con la lista de estudiantes y
        //realizar operaciones de conteo, reversión, ordenamiento y cálculos de agregación.

        //Parte 1: Contar los Estudiantes Aprobados
        //usando LINQ para contar el número de estudiantes con un promedio(Average) mayor a 14.0.
        //Imprime el resultado en la consola.

        List<Student> studentList = new List<Student>()
        {
            new Student(1, "Gabriel", "Mercadotecnia", 16),
            new Student(2, "Luis", "Derecho", 15),
            new Student(3, "Ana", "Medicina", 17),
            new Student(4, "Sofia", "Ingeniería", 14),

        };

        Console.WriteLine("*-----------------------------------------------*");
        int queryCount =(from x in studentList
                         where x.Average > 14
                         select x).Count();

        Console.WriteLine("Número de estudiantes con promedio mayor a 14: " + queryCount);

        //Parte 2: Revertir la Lista de Estudiantes
        //Reversa el orden de la lista de estudiantes aprobados y muestra el
        //resultado en la consola, indicando que son "Desaprobados".

        Console.WriteLine("*-----------------------------------------------*");
        var queryReverse = (from x in studentList
                            where x.Average > 14
                            select x).Reverse();

        foreach(var item in queryReverse)
        {
            Console.WriteLine(item + " Desaprobado");
        }

        //Parte 3: Ordenar la Lista de Estudiantes
        //Ordena la lista de estudiantes aprobados por nombre y
        //muestra el resultado en la consola.

        Console.WriteLine("*-----------------------------------------------*");
        Console.WriteLine("Descendente");
        var queryOrderingByDescending = from x in studentList
                                        orderby x.Average descending
                                        select x;

        foreach(var item in queryOrderingByDescending)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("*-----------------------------------------------*");
        Console.WriteLine("Ascendente");
        var queryOrderingByAscending = from x in studentList
                                        orderby x.Average ascending
                                        select x;

        foreach (var item in queryOrderingByAscending)
        {
            Console.WriteLine(item);
        }

        int[] numbers = { 2, 8, 25, 16, 31, 5, 34, 24, 11 };

        //Obten el minimo valor
        int min = numbers.Min();
        Console.WriteLine("Minimo: " + min);

        //Obten el maximo valor
        int max = (from x in numbers select x).Max();
        Console.WriteLine("Maximo: " + max);

        //Obten el promedio
        double average = numbers.Average();
        Console.WriteLine("Promedio: " + average);

        //Obten la suma
        int sum = (from x in numbers select x).Sum();
        Console.WriteLine("Suma: " + sum);

    }
}