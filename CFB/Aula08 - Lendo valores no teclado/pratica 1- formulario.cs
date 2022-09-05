using System;

class Aula08
{
    static void Main()
    {
        string nome, sexo, lemaVida, nomeMae, nomePai;
        int meuAnoNasc, anoNascMae, qntirmaos, qntfilhos;
        float peso, altura;

        Console.WriteLine(" Ola, voce poderia responder nosso formulario?");
        Console.WriteLine("+ -------------------------------------------- +");
        
        Console.WriteLine("|                Dados Gerais:                  ");
        Console.Write("| Nome: ");
        nome = Console.ReadLine();
        Console.Write("| Seu Sexo(M/F): ");
        sexo = Console.ReadLine();
        Console.Write("| Nome da sua Mãe: ");
        nomeMae = Console.ReadLine();
        Console.Write("| Nome do seu Pai: ");
        nomePai = Console.ReadLine();

        Console.WriteLine("+ -------------------------------------------- +");
        Console.WriteLine("|                Dados Adicionais:              ");
        Console.Write("| Seu ano de Nascimento: ");
        meuAnoNasc = int.Parse(Console.ReadLine());
        Console.Write("| Ano de Nascimento da sua Mae: ");
        anoNascMae = int.Parse(Console.ReadLine());
        Console.Write("| Quantos irmoes voce tem? ");
        qntirmaos = int.Parse(Console.ReadLine());
        Console.Write("| Quantos filhos voce tem? ");
        qntfilhos = int.Parse(Console.ReadLine());
        Console.WriteLine("+ -------------------------------------------- +");

        Console.WriteLine("\nOrganizando Dados...");


    }
}
