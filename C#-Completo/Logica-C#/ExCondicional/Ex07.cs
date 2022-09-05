using System;
using System.Globalization;

class Ex07
{
    static void Main()
    {
        float x, y;

        string[] vet = Console.ReadLine().Split(" ");
        x = float.Parse(vet[0], CultureInfo.InvariantCulture);
        y = float.Parse(vet[1], CultureInfo.InvariantCulture);

        if (x > 0 && y > 0)
            Console.WriteLine("Q1");
        else
            if (x < 0 && y > 0)
                Console.WriteLine("Q2");
            else
                if (x < 0 && y < 0)
                    Console.WriteLine("Q3");
                else
                    if (x > 0 && y < 0)
                        Console.WriteLine("Q4");
                    else
                        Console.WriteLine("Origem");

    }
}