using Entities;
using System.Globalization;


int nPessoa, nFunc;
char tipoPessoa;
string nome;
double renda, despesaSaude, total = 0;
List<Contribuintes> listaPessoas = new List<Contribuintes> ();

Console.Write("Enter the number of tax payers: ");
nPessoa = int.Parse(Console.ReadLine());

for (int i = 1; i <= nPessoa; i++)
{
    Console.WriteLine($"\nTax payer #{i} data:");
    Console.Write("Individual or company (i/c)? ");
    tipoPessoa = char.Parse(Console.ReadLine());
    
    Console.Write("Name: ");
    nome = Console.ReadLine();
    Console.Write("Anual income: ");
    renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (tipoPessoa == char.Parse("i"))
    {
        Console.Write("Health expenditures: ");
        despesaSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        listaPessoas.Add(new PessoaFisica(nome, renda, despesaSaude));
    }
    else
    {
        Console.Write("Number of employees: ");
        nFunc = int.Parse(Console.ReadLine());

        listaPessoas.Add(new PessoaJuridica(nome, renda, nFunc));
    } 
}

    Console.WriteLine("\nTAXES PAID:");
    foreach (Contribuintes i in listaPessoas)
    {
        Console.WriteLine($"{i.Name}: $ {i.Imposto().ToString("F2", CultureInfo.InvariantCulture)}");
        total += i.Imposto(); 
    }

    Console.WriteLine($"\nTOTAL TAXES: $ {total.ToString("F2", CultureInfo.InvariantCulture)}");

/*
Enter the number of tax payers: 3
Tax payer #1 data:
Individual or company (i/c)? i
Name: Alex
Anual income: 50000.00
Health expenditures: 2000.00
Tax payer #2 data:
Individual or company (i/c)? c
Name: SoftTech
Anual income: 400000.00
Number of employees: 25
Tax payer #3 data:
Individual or company (i/c)? i
Name: Bob
Anual income: 120000.00
Health expenditures: 1000.00
TAXES PAID:
Alex: $ 11500.00
SoftTech: $ 56000.00
Bob: $ 29500.00
TOTAL TAXES: $ 97000.00
*/
