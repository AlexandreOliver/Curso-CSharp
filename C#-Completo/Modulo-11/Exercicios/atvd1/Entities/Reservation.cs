using System;
using Entities.Exceptions;

namespace Entities;

class Reservation
{
    public int RoomNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
    {
        if (checkOut <= checkIn)
        {
            throw new DomainException("Erro na reserva: Check-Out nao pode ser anterior ao Check-In");
        }
        
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
        DateTime now = DateTime.Now;
        if (checkIn < now || checkOut < now)
        {
            throw new DomainException("Erro na reserva: Datas precisam ser futuras");
        }
        if (checkOut <= checkIn)
        {
            throw new DomainException("Erro na reserva: Check-Out nao pode ser anterior ao Check-In");
        }
        
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