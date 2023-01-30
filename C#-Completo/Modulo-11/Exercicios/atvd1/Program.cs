using Entities;

Console.Write("Room Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Check-in date: (dd/MM/yyyy): ");
DateTime checkIn = DateTime.Parse(Console.ReadLine());
Console.Write("Check-Out date: (dd/MM/yyyy): ");
DateTime checkOut = DateTime.Parse(Console.ReadLine());


if (checkOut <= checkIn)
{
    Console.WriteLine("Erro na reserva, data incompativel");
}
else
{
    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine("\nAtualize a Reserva:");
    Console.Write("Check-in date: (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-Out date: (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    string error = reservation.updateDays(checkIn, checkOut);
    if (error != null)
    {
        System.Console.WriteLine(error);
    }
    else
    {
        System.Console.WriteLine("Reservation: " + reservation);
    }
}