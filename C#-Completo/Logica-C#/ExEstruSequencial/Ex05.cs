using System;
using System.Globalization;

class Ex05
{
    static void Main()
    {
        int qnt1, qnt2, cod1, cod2;
        float v1, v2, preco;

        string[] vet1 = Console.ReadLine().Split(' ');
         cod1 = int.Parse(vet1[0]);
         qnt1 = int.Parse(vet1[1]);
         v1 = float.Parse(vet1[2], CultureInfo.InvariantCulture);
         
        vet1 = Console.ReadLine().Split(' ');
         cod2 = int.Parse(vet1[0]);
         qnt2 = int.Parse(vet1[1]);
         v2 = float.Parse(vet1[2], CultureInfo.InvariantCulture);

        preco = qnt1 * v1 + qnt2 * v2;

        Console.WriteLine("VALOR A PAGAR: {0:c}", preco.ToString("F2", CultureInfo.InvariantCulture));

    }
}