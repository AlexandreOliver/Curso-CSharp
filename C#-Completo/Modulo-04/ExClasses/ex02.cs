using System;
using System.Globalization;

namespace Course
{
    class Ex02
    {
        static void Main()
        {
            float media;
            Funcionario x, y;
            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            x.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário::");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            y.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (float) ((x.Salario + y.Salario) / 2.0);

            Console.WriteLine("Salario Medio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    class Funcionario
    {
        public string Nome;
        public float Salario;
    }

}