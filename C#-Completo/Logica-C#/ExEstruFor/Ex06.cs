using System;

class Ex06
{
    static void Main()
    {
        int n;

        n = int.Parse(Console.ReadLine());

        for (int i=1; n >= i; i++)
        {
            if (n % i == 0)
                Console.WriteLine(i);
        }
    }
}