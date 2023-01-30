using System;

namespace Entities;

class Reservation
{
    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
    {
        RoomNumber = roomNumber;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public int Duration()
    {
        TimeSpan duracao = CheckOut.Subtract(CheckIn);
        
        return (int) duracao.TotalDays;
    }

    public void updateDays(DateTime checkIn, DateTime checkOut)
    {
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public override string ToString()
    {
        return "Reservation: " 
              + RoomNumber 
              + ", check-in: " 
              + CheckIn.ToString("dd/MM/yyyy") 
              + ", check-out: "
              + CheckOut.ToString("dd/MM/yyyy")
              + ", "
              + Duration()
              + " nights";
    }
}