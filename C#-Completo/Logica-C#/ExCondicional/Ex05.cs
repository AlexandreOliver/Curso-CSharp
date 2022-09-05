using System;
using System.Globalization;

class Ex05
{
    static void Main()
    {
        int qntItem, codItem;
        float preco;

        string[] vet = Console.ReadLine().Split(" ");
        codItem = int.Parse(vet[0]);
        qntItem = int.Parse(vet[1]);
        
        if (codItem == 1)
        {
            preco = (float)(qntItem * 4.0);
        }
        else
        {
            if (codItem == 2)
            {
                preco = (float)(qntItem * 4.5);
            }
            else
            {
                if (codItem == 3)
                {
                    preco = (float)(qntItem * 5.0);
                }
                else
                {
                    if (codItem == 4)
                    {
                        preco = (float)(qntItem * 2.0);
                    }
                    else
                    {
                        preco = (float)(qntItem * 1.5);
                    }
                }
            }
        }

        Console.WriteLine("Total: R$ {0}", preco.ToString("F2", CultureInfo.InvariantCulture));
    }
}