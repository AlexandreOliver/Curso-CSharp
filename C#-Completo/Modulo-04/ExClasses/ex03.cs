using System;
using System.Globalization;

namespace Course
{
    class Ex03
    {
        static void Main()
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoedas.PrecoEmReais(dolares, cotacao).ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    class ConversorDeMoedas
    {           
        public static double PrecoEmReais(double qntDolares, double cotacao)
        {
            double valorliquido =  cotacao * qntDolares;
            
            return valorliquido + (valorliquido * 0.06);
        }
    } 
}