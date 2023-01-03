using System;
using Enumeracao.Entities;
using Enumeracao.Entities.Enums;

Order pedido = new Order{
    id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PedingPayment
};

Console.WriteLine(pedido);

// Convertendo Enum para String
string txt = OrderStatus.PedingPayment.ToString();
Console.WriteLine(txt);

// Convertendo String para Enum
string txt2 = "Delivered";
OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
Console.WriteLine(os);