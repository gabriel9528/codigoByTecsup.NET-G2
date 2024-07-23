using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FactoryMethod2
{
    public abstract class Pizza
    {
        public string Nombre { get; set; }
        public string Masa { get; set; }
        public string Salsas { get; set; }
        public List<string> Extras { get; set; } = new List<string>();

        public void Preparar()
        {
            WriteLine($"Preparando {Nombre}");
            WriteLine($"Colocando masa... {Masa}");
            WriteLine($"Agregando salsa... {Salsas}");
            WriteLine($"Agregando ingredientes:{ string.Join(",", Extras)}");
        }
        public void Cocinar()
        {
            WriteLine("Cocinando por 25 minutos a 180 grados");
        }
        public void Cortar() => WriteLine("Cortando la pizza en partes iguales");
        public void Encajar() => WriteLine("Colocando la pizza en la caja");
    }


    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(TypeOfPizza type);
        public Pizza OrderPizza(TypeOfPizza type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Preparar();
            pizza.Cocinar();
            pizza.Cortar();
            pizza.Encajar();

            return pizza;
        }
    }

    public enum TypeOfPizza
    {
        Peperoni,
        Napolitana,
        Vegetariana
    }

    public class ArequipaPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            return (Pizza)Activator
                .CreateInstance(Type.GetType($"FactoryMethod2.Arequipa{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));
        }
    }

    public class LimaPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            return (Pizza)Activator
                .CreateInstance(Type.GetType($"FactoryMethod2.Lima{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"));
        }
    }

    #region Arequipa

    internal class ArequipaPeperoniPizza : Pizza
    {
        public ArequipaPeperoniPizza()
        {
            Nombre = "Pizza de Peperoni";
            Masa = "Masa delgada";
            Salsas = "Salsa de tomate";
            Extras.Add("Salsas de especias");
        }
    }

    internal class ArequipaNapolitanaPizza : Pizza
    {
        public ArequipaNapolitanaPizza()
        {
            Nombre = "Pizza Napolitana";
            Masa = "Masa delgada";
            Salsas = "Salsa de tomate";
            Extras.Add("Queso Mozarela");
        }
    }

    internal class ArequipaVegetarianaPizza : Pizza
    {
        public ArequipaVegetarianaPizza()
        {
            Nombre = "Pizza Vegetariana";
            Masa = "Masa delgada";
            Salsas = "Salsa de tomate";
            Extras.Add("Queso Mozarela");
        }
    }

    #endregion


    #region Lima

    internal class LimaPeperoniPizza : Pizza
    {
        public LimaPeperoniPizza()
        {
            Nombre = "Pizza de Peperoni";
            Masa = "Masa delgada";
            Salsas = "Salsa de tomate";
            Extras.Add("Salsas de especias");
        }
    }

    internal class LimaNapolitanaPizza : Pizza
    {
        public LimaNapolitanaPizza()
        {
            Nombre = "Pizza Napolitana";
            Masa = "Masa delgada";
            Salsas = "Salsa de tomate";
            Extras.Add("Queso Mozarela");
        }
    }

    internal class LimaVegetarianaPizza : Pizza
    {
        public LimaVegetarianaPizza()
        {
            Nombre = "Pizza Vegetariana";
            Masa = "Masa delgada";
            Salsas = "Salsa de tomate";
            Extras.Add("Queso Mozarela");
        }
    }

    #endregion

    public class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new LimaPizzaStore();
            Pizza pizza = store.OrderPizza(TypeOfPizza.Napolitana);
            WriteLine($"Orden: {pizza.Nombre}, estara lista para entregarse en 20 minutos");
            ReadLine();
        }
    }

}
