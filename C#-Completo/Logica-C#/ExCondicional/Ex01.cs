using System;

class Ex01
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        if (n > 0)
            Console.WriteLine("NAO NEGATIVO");
        else
            Console.WriteLine("NEGATIVO");
    }
}