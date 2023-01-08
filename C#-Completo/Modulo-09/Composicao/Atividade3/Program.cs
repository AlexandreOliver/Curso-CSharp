using Atividade3.Entities;
using Atividade3.Entities.Enums;


Console.WriteLine("Enter cliente data:");

Console.Write("Name: ");
string name = Console.ReadLine() ?? " ";
Console.Write("Email: ");
string email =  Console.ReadLine() ?? " ";
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthdate = DateTime.Parse(Console.ReadLine() ?? "01/01/2022" );

Client cliente = new Client(name, email, birthdate);

Console.WriteLine("Enter order data: ");

Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
Console.Write("How many items to this order? ");
int num = int.Parse(Console.ReadLine() ?? "0");

Product produto = new Product();

Order order = new Order(cliente, DateTime.Now, status);

for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string nameProduct = Console.ReadLine() ?? " ";
    Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Quantity: ");
    int qnt = int.Parse(Console.ReadLine()?? "0");

    produto.Name = nameProduct ?? " ";
    produto.Price = price;
    OrderItem orderItem = new OrderItem(produto, qnt);

    order.addItem(orderItem);

}




Console.WriteLine("\nORDER SUMMARY:");
Console.WriteLine(order.ToString());

/* 
Enter cliente data:
Name: Alex Green
Email: alex@gmail.com
Birth date (DD/MM/YYYY): 15/03/1985
Enter order data:
Status: Processing
How many items to this order? 2
Enter #1 item data:
Product name: TV
Product price: 1000.00
Quantity: 1
Enter #2 item data:
Product name: Mouse
Product price: 40.00
Quantity: 2

ORDER SUMMARY:
Order moment: 20/04/2018 11:25:09
Order status: Processing
Client: Alex Green (15/03/1985) - alex@gmail.com
Order items:
TV, $1000.00, Quantity: 1, Subtotal: $1000.00
Mouse, $40.00, Quantity: 2, Subtotal: $80.00
Total price: $1080.00
*/