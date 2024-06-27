

using Ejercicio1;

public class Program
{
    ////Ejercicio1
    //static void Main(string[] args)
    //{
    //    Persona alumno = new Persona();
    //    alumno.nombre = "Gabriel";
    //    alumno.fechaNacimiento = Convert.ToDateTime("10/10/1995");
    //    alumno.Registrar();
    //    //alumno.edad;
    //    Console.ReadKey();
    //}

    //Ejercicio2
    static void Main(string[] args)
    {
        PersonaPropiedades empleado = new PersonaPropiedades();
        empleado.Nombre = "Fernando";
        empleado.FechaNacimiento = Convert.ToDateTime("01/05/1996");
        
        //empleado.Edad = 25;
        empleado.Registrar();
        Console.ReadKey();
    }

}