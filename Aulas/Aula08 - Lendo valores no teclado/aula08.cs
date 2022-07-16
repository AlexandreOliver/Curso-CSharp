using System;

class Aula08
{
    static void Main()
    {
        int v1, v2, soma;
        string nome;

        // Capturando os valores do teclado com ReadLine()
        Console.Write("Digite seu Nome: "); nome = Console.ReadLine();
        
        // Duas formas de Converter do tipo String para Int
        Console.Write("Digite o n1: "); v1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o n2: "); v2 = Convert.ToInt32(Console.ReadLine());

        soma =  v1 + v2;

        Console.WriteLine("A soma de {0} e {1} é {2}", v1, v2, soma);
        


    }
}