using Ejercicio1_Before;

class Program
{
    static void Main(string[] args)
    {
        DateTime checkInDate = DateTime.Now;
        DateTime checkOutDate = checkInDate.AddDays(2);

        //WriteLine(new AppointmentService().Create("", "", DateTime.MinValue));
        Console.WriteLine(new HotelBookingService().Create("Gabriel Retamozo", "gabriel@gmail.com", checkInDate, checkOutDate));

        Console.ReadLine();
    }
}