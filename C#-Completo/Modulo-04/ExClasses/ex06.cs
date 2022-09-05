using System;
using System.Globalization;

namespace Course
{
    class ex06
    {
        static void Main()
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: "); aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.PrimeiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.SegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.TerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.NotaFinal() >= 60.00)
                Console.WriteLine("APROVADO");
            else{
                Console.WriteLine("REPROVADO");
                double dif = 60 - aluno.NotaFinal();
                Console.WriteLine("FALTARAM " + dif.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
                }
        }
    }

    class Aluno
    {
        public string Nome;
        public double PrimeiroTrimestre;
        public double SegundoTrimestre;
        public double TerceiroTrimestre;

        public double NotaFinal()
        {
            return (PrimeiroTrimestre * 30.00 + SegundoTrimestre * 35.00 + TerceiroTrimestre * 35.00)/100.00; 
        }

    }
}