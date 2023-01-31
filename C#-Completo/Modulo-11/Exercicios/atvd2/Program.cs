using System.Globalization;
using Entities;
using Entities.Exceptions;


try
{
Console.WriteLine("Enter account data");
System.Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());

System.Console.Write("Holder: ");
string holder = Console.ReadLine();

System.Console.Write("Initial balance: ");
double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

System.Console.Write("Withdraw limit: ");
double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Account conta = new Account(number, holder, balance, limit);

System.Console.Write("Enter amount for withdraw: ");
double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

conta.withdraw(saque);

Console.WriteLine(conta);
}
catch (DomainException e)
{
    System.Console.WriteLine("Erro: " + e.Message);
}