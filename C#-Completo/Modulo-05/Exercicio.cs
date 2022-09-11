using System;
using System.Globalization;

namespace SisBancario
{
    class Program
    {
        static void Main()
        {
            double dep = 0;
            Conta conta1;

            Console.Write("Entre o número da conta: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial (s/n)? ");
            char user = Console.ReadLine();
            if (user == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                 conta1 = new Conta(n, nome, dep);
            }
            else
                Conta conta1 = new Conta(n, nome);
            
            Console.WriteLine("\nDados da Conta:\n" + conta1);

            Console.Write("\nEntre um valor para depósito: ");
            dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Deposito(dep);

            Console.WriteLine("Dados da conta atualizados:\n" + conta1);
            
            Console.Write("\nEntre um valor para saque: ");
            dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Saque(dep);
            
            Console.WriteLine("Dados da conta atualizados:\n" + conta1);
        }
    }

    class Conta
    {
        public int Numero {get; private set; }
        public double Saldo {get; private set; }
        public string Titular {get; set; }

        public Conta(int num, string nome)
        {
            Numero = num;
            Titular = nome;
        }

        public Conta(int num, string nome, double depInicial) : this(num, nome)
        {
            Deposito(depInicial);
        }
        
        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.00;
        }

        public override string ToString()
        {
            return "Conta: " + Numero + ", " 
                   + "Titular: " + Titular + ", "
                   + "Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}