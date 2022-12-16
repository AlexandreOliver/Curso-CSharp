using System;

namespace Mod6
{
    class Program
    {
        static void Main()
        {
            int a = 10;
            int triple;

            Calculator.Triplo(a, out triple); // out faz o conteudo da variavel "Triple" ser "origin"
            Console.WriteLine(triple);
        }

    }

    class Calculator
    {
        public static void Triplo(int origin, out int result)
        {
            // out faz a variavel "result" ser a referencia da variavel "triple"
            result = origin * 3;
        }
    }
}