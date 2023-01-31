using Entities;
using Entities.Exceptions;

int number;
try
{
    Console.Write("Room Number: ");
    number = int.Parse(Console.ReadLine());
    Console.Write("Check-in date: (dd/MM/yyyy): ");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-Out date: (dd/MM/yyyy): ");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());

    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);


    Console.WriteLine("\nAtualize a Reserva:");
    Console.Write("Check-in date: (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-Out date: (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    reservation.updateDays(checkIn, checkOut);
    System.Console.WriteLine("Reservation: " + reservation);
}
catch (DomainException e)
{
    Console.WriteLine(e.Message);
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}