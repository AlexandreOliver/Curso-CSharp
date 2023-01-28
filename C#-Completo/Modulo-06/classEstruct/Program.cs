using System;

namespace classEstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste t1 = new Teste();
            Teste t2;

            Console.WriteLine("Classe:\n");
            // Classes sao Tipos referência

            t1.Nome = "Alexandre";
            t2 = t1; // Aqui t2 passa a apontar para o valor de p1 na memoria
            Console.WriteLine("Atriburo Nome em t1: {0}\nAtributo nome em t2: {1}", t1.Nome, t2.Nome);
            Console.ReadLine();

            t1.Nome = "Jose"; // Alterando o atributo gera uma falsa sensação de estar alterando apenas em t1.
            Console.WriteLine("Atributo Nome em t1: {0}\nAtributo nome em t2: {1}", t1.Nome, t2.Nome);
            // Classes nao podem ser entendidas como "caixas" mas sim como ponteiros.

            
            Console.WriteLine("Struct:\n");
            // Structs sao Tipos valor.

            Point p, t;

            p.x = 10;

            t = p; // Aqui o conteudo de p é copiado para t.
            Console.WriteLine("Atriburo x em p: {0}\nAtributo x em t: {1}", p.x, t.x);
            Console.ReadLine();

            t.x = 20; // Alterando apenas o atributo x em t.
            Console.WriteLine("Atriburo x em p: {0}\nAtributo x em t: {1}", p.x, t.x);
            //Struct podem ser entendidas como caixas;

        }
    }

    class Teste
    {
        public string Nome;
    }

    struct Point
    {
        public double x;
    }

}
