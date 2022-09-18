using System;
using System.Globalization;

namespace Mod6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Soma = " + Calculator.Soma(12, 34, 54, 56, 90));
        }

        class Calculator
        {
            // params permite que meu metodo aceite varios parametros
            public static double Soma(params int[] numeros)
            {
                int sum = 0;
                for (int i = 0; i < numeros.Length; i++)
                {
                    sum += numeros[i];
                }
                return sum;
            }
        }
    }
}