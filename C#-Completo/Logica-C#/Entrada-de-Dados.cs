using System;
using System.Globalization; // Usado para se ter o metodo CultureInfo

class EntradaDeDados
{
    static void Main()
    {
	int n1 = int.Parse(Console.ReadLine());
	char ch = char.Parse(Console.ReadLine());
	double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

/*     
	CultureInfo.InvariantCulture serve para permitir que o
	computador entenda "." no lugar de "," para separar a parte
	inteira da decimal de um numero, utilizando o padrao EUA.
	
*/
	string[] vet = Console.ReadLine().Split(' ');
	string nome = vet[0];
	char sexo = char.Parse(vet[1]);
	int idade = int.Parse(vet[2]);
	double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

	Console.WriteLine("Você digitou:");
	Console.WriteLine(n1);
	Console.WriteLine(ch);
	Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
	Console.WriteLine(nome);
	Console.WriteLine(sexo);
	Console.WriteLine(idade);
	Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
    }
}
