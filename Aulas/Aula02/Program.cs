using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args) //args recebe parametros do terminal
        {
            Console.WriteLine("CFB Cursos");

            if (args.GetLength(0) > 0)
            {
                Console.WriteLine(args.GetValue(0)); // ".GetValue(Posição)" pega o valor da posição
            }
            

        }
    }
}
