

using ISP_Ejercicio1_Before;

class Program
{
    static void Main(string[] args)
    {
        IPrintTask simplePrinter = new HPLaserJetPrinter();
        simplePrinter.Print("Imprimeme algo");
        simplePrinter.Scan("Scaneame algo");
        simplePrinter.Fax("Realizame un fax");
    }
}
