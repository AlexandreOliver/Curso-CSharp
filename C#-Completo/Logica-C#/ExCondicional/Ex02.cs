using System;

class Ex02
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        if (n % 2 == 0)
            Console.WriteLine("PAR");
        else
            Console.WriteLine("IMPAR");
    }
}