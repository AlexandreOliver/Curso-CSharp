using System;

namespace Course
{
    class Ex01
    {
        static void Main()
        {
            Pessoa x, y;

            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.Idade = int.Parse(Console.ReadLine());

            if (x.Idade > y.Idade)
                Console.WriteLine("Pessoa mais velha: " + x.Nome);
            else
                Console.WriteLine("Pessoa mais velha: " + y.Nome);
        }
    }
    
    class Pessoa
    {
        public int Idade;
        public string Nome; 
    }
}