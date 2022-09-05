using System;

class Ex05
{
    static void Main()
    {
        int n, fatorial=1;

        n = int.Parse(Console.ReadLine()); //3

        for (int i=0; n > i; n--)
        {
            fatorial *= n;
        }
        
        Console.WriteLine(fatorial);
    }
}