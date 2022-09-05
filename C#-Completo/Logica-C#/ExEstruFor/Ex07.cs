using System;

class Ex07
{
    static void Main()
    {
        int n;

        n = int.Parse(Console.ReadLine());

        for (int i=1; n >= i; i++)
        {
            Console.WriteLine("{0} {1} {2}", i, i*i, i*i*i);
        }
    }
}