using System;

class a
{
    static void Main()
    {
        int user;
        
        Console.WriteLine("Vc tem 2 opções.");
        Console.Write("Escolha uma opção: ");
        user = int.Parse(Console.ReadLine());

        if (user == 1) 
            Console.WriteLine("Escolheu a 1.");
        else 
            Console.WriteLine("Escolheu a 2.");
            

        


    }
}