using System;
using System.Globalization;

namespace Course
{
    class ex05
    {
        static void Main()
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: "); 
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: "); 
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: "); 
            funcionario.imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("\nFuncionario: " + funcionario);

            Console.Write("\nDigite a porcentagem para aumentar o salário: "); 
            funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("\nDados Atualizados: " + funcionario);
        }
    }

    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem/100); 
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}