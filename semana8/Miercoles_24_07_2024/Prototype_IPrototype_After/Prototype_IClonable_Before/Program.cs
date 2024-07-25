using static System.Console;

using Prototype_IClonable_Before;

class Program
{
    static void Main(string[] args)
    {
        var notebook = new Producto("Mackbook Pro", new Category("Computers", new Person("Gabriel")));

        var iphone = (Producto)notebook.DeepCopy();
        iphone.Name = "iPhone 12";
        iphone.Category.Name = "Smartphones";
        iphone.Category.Person.Name = "John";
        WriteLine(notebook);
        WriteLine("*--------------------------------------------------------------------------*");
        WriteLine(iphone);
       
    }
}