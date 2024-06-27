

using Ejercicio3;

public class Program
{
    static void Main(string[] args)
    {
        //Crea instancias de la clase casa utilizando diferentes cosntructores
        Casa casa1 = new Casa();
        Casa casa2 = new Casa("Casa de campo", 1000000);
        Casa casa3 = new Casa("Casa moderna", 1500000, 500, 300);

        //Definir propiedades para la casa 3
        casa3.tipo = "Casa Tradicional";
        casa3.precio = 1200000;
        casa3.areaTerreno = 600;
        casa3.areaConstruida = 350;

        casa3.Vender();
        casa3.Vender("Gabriel");
        casa3.Vender(200000);
    }
}