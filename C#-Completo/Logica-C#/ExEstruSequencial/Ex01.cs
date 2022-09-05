using System;

class Ex01
{
  static void Main()
  {
    int n1, n2, soma;

    Console.WriteLine("Digite um numero: ");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro numero: ");
    n2 = int.Parse(Console.ReadLine());

    soma = n1 + n2;

    Console.WriteLine("SOMA = {0}", soma);
  }
}
