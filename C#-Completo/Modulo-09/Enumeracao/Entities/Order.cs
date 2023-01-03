using System;
using Enumeracao.Entities.Enums;

namespace Enumeracao.Entities
{
    public class Order
    {
    public int id { get; set; }
    public DateTime Moment {get; set; }
    public OrderStatus Status { get; set; }

    public override string ToString()
    {
        return id + ", " + Moment + ", " + Status;
    }

    }
}
