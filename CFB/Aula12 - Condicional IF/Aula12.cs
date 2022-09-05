using System;

class Aula12
{
    static void Main()
    {
        int nota=0;
        string resultado = "Reprovado";

        Console.Write("Qual a media do aluno? ");
        nota = int.Parse(Console.ReadLine());

        if (nota >= 60)
        {
            resultado = "Aprovado";
        }

        Console.WriteLine("Situação: {0}", resultado);

    }
}