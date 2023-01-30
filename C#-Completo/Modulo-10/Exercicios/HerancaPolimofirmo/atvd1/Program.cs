using System.Globalization;
using System.Collections.Generic;
using Entities;


List<Product> listaDeProduto = new List<Product> ();

Console.Write("Enter the number of products: ");
int numeroDeProdutos = int.Parse(Console.ReadLine());

for (int i = 1; i <= numeroDeProdutos; i++)
{
    Console.WriteLine($"\nProduct #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    string tipoDeProduto = Console.ReadLine();

    Console.Write("Name: ");
    string nome = Console.ReadLine();
    Console.Write("Price: ");
    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    if (tipoDeProduto == "i")
    {
        Console.Write("Customs fee: ");
        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        listaDeProduto.Add(new ImportedProduct(nome, preco, fee));
    }
    else if (tipoDeProduto == "u")
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime data = DateTime.Parse(Console.ReadLine());

        listaDeProduto.Add(new UsedProduct(nome, preco, data));
    }
    else 
    {
        listaDeProduto.Add(new Product(nome, preco));
    }
}

Console.WriteLine("\nPRICE TAGS:");
foreach (Product i in listaDeProduto)
{
    Console.WriteLine(i.priceTag());
}



Console.Write("");

/*
Name: Tablet
Price: 260.00
Customs fee: 20.00
Product #2 data:
Common, used or imported (c/u/i)? c
Name: Notebook
Price: 1100.00
Product #3 data:
Common, used or imported (c/u/i)? u
Name: Iphone
Price: 400.00
Manufacture date (DD/MM/YYYY): 15/03/2017
PRICE TAGS:
Tablet $ 280.00 (Customs fee: $ 20.00)
Notebook $ 1100.00
Iphone (used) $ 400.00 (Manufacture date: 15/03/2017)
*/