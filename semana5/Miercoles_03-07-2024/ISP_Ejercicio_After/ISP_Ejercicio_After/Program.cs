
using ISP_Ejercicio_After;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("SimplePrinter:");
        SimplePrinter simplePrinter = new SimplePrinter();
        simplePrinter.Print("Imprimeme algo");
        simplePrinter.Scan("Scaneame algo");


        Console.WriteLine("*----------------------------------------*");
        Console.WriteLine("HPLaserJetPrinter:");
        HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
        hPLaserJetPrinter.Print("Imprimeme algo");
        hPLaserJetPrinter.Scan("Scaneame algo");
        hPLaserJetPrinter.Fax("Realizame un fax");
    }
}