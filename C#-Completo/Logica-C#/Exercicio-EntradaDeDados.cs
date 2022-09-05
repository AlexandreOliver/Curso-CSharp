using System;

class Exercicio
{
    static void Main()
    {
	string nome, ultimo_nome;
	int quartos, idade;
	float preco, altura;

	Console.WriteLine("Entre com seu nome completo:");
	nome = Console.ReadLine();
	Console.WriteLine("Quantos quartos tem na sua casa?");
	quartos = int.Parse(Console.ReadLine());
	Console.WriteLine("Entre com o preço de um produto:");
	preco = float.Parse(Console.ReadLine());

	Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha): ");
	string[] vet_infos = Console.ReadLine().Split(' ');
	ultimo_nome = vet_infos[0];
	idade = int.Parse(vet_infos[1]);
	altura = float.Parse(vet_infos[2]);

	Console.WriteLine(nome);
	Console.WriteLine(quartos);
	Console.WriteLine(preco.ToString("F2"));
	Console.WriteLine(ultimo_nome);
	Console.WriteLine(idade);
	Console.WriteLine(altura.ToString("F2"));

	
    }
}
