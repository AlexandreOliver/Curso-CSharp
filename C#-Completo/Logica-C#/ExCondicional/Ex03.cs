using System;

class Ex03
{
    static void Main()
    {
        //string c = "6 24";
        String[] vet = Console.ReadLine().Split(" ");
        int a = int.Parse(vet[0]);
        int b = int.Parse(vet[1]);
        
        if (a % b == 0 || b % a == 0)
            Console.WriteLine("Sao Multiplos");
        else
            Console.WriteLine("Nao sao Multiplos");
    }
}