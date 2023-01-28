using System;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente[] quartos = new Cliente[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nAluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                quartos[quarto] = new Cliente(nome, email);
            }

            Console.WriteLine("\nQuartos Ocupados: ");
            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                    Console.WriteLine($"{i}: {quartos[i]}");
                
            }
        }
    }

    class Cliente
    {
        public string Nome {get; set;}
        public string Email {get; set;}

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
     }
}
