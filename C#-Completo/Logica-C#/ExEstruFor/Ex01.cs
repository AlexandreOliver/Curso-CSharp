using System;

class Ex01
{
    static void Main()
    {
        int x;

        x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= x; i++)
        {
            if (i % 2 != 0)
                Console.WriteLine(i);
            
        }
    }
}