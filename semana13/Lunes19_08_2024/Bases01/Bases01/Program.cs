class Program
{
    public static void Main()
    {
        //Ejercicio 3
        //Dado un arreglo de números enteros, filtra los números que están entre 6 y 16
        //(sin incluir ambos extremos) y almacénalos en una secuencia de enteros
        //(IEnumerable<int>). Luego, recorre la secuencia resultante y muestra cada número en la consola.
        Console.WriteLine("Ejercicio 3");
        Console.WriteLine("");

        int[] numbers = { 1, 5, 7, 11, 15, 2, 13, 21, 9, 8 };
        IEnumerable<int> result = from x in numbers
                                  where x > 6 && x < 16
                                  select x;

        foreach(int number in result)
        {
            Console.WriteLine(number);
        }

        //Ejercicio 4
        //Filtrar y Ordenar Cadenas Dado un arreglo de cadenas que representan postres,
        //filtra aquellos que contienen la palabra "manzana" y ordénalos alfabéticamente.
        //Muestra los resultados en la consola.

        Console.WriteLine("*--------------------------------------------------------------*");
        Console.WriteLine("Ejercicio 4");
        Console.WriteLine("");

        string[] desserts = { "Pie de manzana",  "Pastel de chocolate", "manzana caramelizadas", "Flan", "Fresas con creama" };
        IEnumerable<string> result2 = desserts.Where(x => x.Contains("manzana")).OrderBy(x => x);

        foreach(var item in result2)
        {
            Console.WriteLine(item);
        }

        //Ejercicio 5
        //Crea un método que reciba un objeto y muestre su tipo y la ubicación de su ensamblado.
        //Utiliza este método para analizar los resultados de las secuencias anteriores (valuesInt y valuesString).
        Console.WriteLine("*--------------------------------------------------------------*");
        Console.WriteLine("Ejercicio 5");
        Console.WriteLine("");
        static void resultInformation(object object2)
        {
            Console.WriteLine("Tipo: {0} ", object2.GetType().Name);
            Console.WriteLine("Ubicacion: {0}", object2.GetType().Assembly.GetName().Name);
        }

        resultInformation(result);
        Console.WriteLine("------------------------------");
        resultInformation(result2);

        //Ejercicio 6
        //Filtra los números pares de un arreglo y muestra los resultados. Cambia un valor en el
        //arreglo original después de la primera iteración y observa cómo la ejecución diferida afecta los resultados.

        Console.WriteLine("*--------------------------------------------------------------*");
        Console.WriteLine("Ejercicio 6");
        Console.WriteLine("");
        IEnumerable<int> valuesIntArray = from x in numbers
                                          where x % 2 == 0
                                          select x;

        foreach(int number in valuesIntArray)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Ejecucion diferida");
        Console.WriteLine(valuesIntArray);

        //numbers[1] = 20;

        foreach(int x in valuesIntArray)
        {
            Console.WriteLine(x);
        }

        //Ejercicio 7
        //Filtra los números pares de un arreglo y almacénalos en un arreglo y una lista.
        //Demuestra la ejecución inmediata cambiando un valor en el arreglo original después de
        //la ejecución, y muestra los resultados.
        Console.WriteLine("*--------------------------------------------------------------*");
        Console.WriteLine("Ejercicio 7");
        Console.WriteLine("");

        Console.WriteLine("Ejecucion Inmediata");
        int[] inmediatedValuesArray = 
            (from n in numbers where n % 2 == 0 select n).ToArray();

        List<int> inmediatedValuesList =
            (from n in numbers where n % 2 == 0 select n).ToList();

        Console.WriteLine("Arreglo");

        foreach (var item in inmediatedValuesArray)
        {
            Console.WriteLine(item);
        }

        numbers[1] = 22;
    }
}