
using Ejercicio5_PolimorfismoDinamico_ClaseAbstracta;

public class Program
{
    public static void Main(String[] args)
    {
        Alumno alumnito = new Alumno("Jorgito");
        Empleado empleado = new Empleado("Juan");

        Persona[] personas = new Persona[2];
        personas[0] = new Alumno("Alumno Pedrito");
        personas[1] = new Empleado("Empleada Andrea");

        for(int i = 0; i < personas.Length; i++)
        {
            Console.WriteLine(personas[i].Saludar());
        }
    }
}