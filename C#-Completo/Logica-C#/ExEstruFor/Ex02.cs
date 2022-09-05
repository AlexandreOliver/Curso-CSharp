using System;

class Ex02
{
    static void Main()
    {
        int N, Nin=0, Nout=0;

        N = int.Parse(Console.ReadLine());

        for (int i=0; i < N; i++)
        {
            int num = int.Parse(Console.ReadLine());
            
            if (num >= 10 && num <= 20)
                Nin++;
            else
                Nout++;
        }

        Console.WriteLine(Nin + " in");
        Console.WriteLine(Nout + " out");
    }
}
