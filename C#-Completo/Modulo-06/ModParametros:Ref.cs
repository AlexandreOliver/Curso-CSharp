using System;

namespace Mod6
{
    class Program
    {
        static void Main()
        {
            int a = 10;
            Calculator.Triplo(ref a);// ref exige que a variavel seja atribuida
            Console.WriteLine(a);
        }
    }

    class Calculator
    {
        public static void Triplo(ref int x)
        {
            x = x * 3;
            /* O modificador ref faz a variavel "x" apontar para a
            variavel "a" assim o que acontece com "x" modifica "a".
            */
        }
    }
}