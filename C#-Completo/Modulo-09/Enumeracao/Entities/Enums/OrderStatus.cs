using System;
using Enumeracao.Entities;

namespace Enumeracao.Entities.Enums
{
    public enum OrderStatus : int 
    {
        PedingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}