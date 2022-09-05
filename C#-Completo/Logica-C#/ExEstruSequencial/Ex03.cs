using System;

class Ex03
{
    static void Main()
    {
        int a, b, c, d, diferenca;

        Console.Write("Digite o valor de A: ");
        a = int.Parse(Console.ReadLine());
        
        Console.Write("Digite o valor de B: ");
        b = int.Parse(Console.ReadLine());
        
        Console.Write("Digite o valor de C: ");
        c = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de D: ");
        d = int.Parse(Console.ReadLine());

        diferenca = a * b - c * d;

        Console.WriteLine("DIFERENCA = {0}", diferenca);

    }

}