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

    DateTime now = DateTime.Now;
    if (checkIn < now || checkOut < now)
    {
        Console.WriteLine("Erro na reserva: Datas precisam ser futuras");
    }
    else if (checkOut <= checkIn)
    {
        Console.WriteLine("Erro na reserva: Check-Out nao pode ser anterior ao Check-In");
    }
    else
    {
        reservation.updateDays(checkIn, checkOut);
        System.Console.WriteLine("Reservation: " + reservation);
    }
}