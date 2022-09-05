using System;

class Ex02
{
    static void Main()
    {
        int x, y;

        while (true)
        {
            Console.WriteLine("sss");
            string[] vet = Console.ReadLine().Split(" ");
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            
            if (x == 0 || y == 0)
                break;
            else if (x > 0 && y > 0)
                Console.WriteLine("primeiro");
            else if (x < 0 && y > 0)
                Console.WriteLine("segundo");
            else if (x < 0 && y < 0)
                Console.WriteLine("terceiro");
            else
                Console.WriteLine("quarto");
            
        }

    }
}