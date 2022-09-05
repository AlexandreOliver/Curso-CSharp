using System;
using System.Globalization;

class Ex04
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        float soma = 0.0f;

        for (int i=0; i < n; i++)
        {
            string[] vet = Console.ReadLine().Split(" ");
            float v1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            float v2 = float.Parse(vet[1], CultureInfo.InvariantCulture);

            if (v2 == 0)
                Console.WriteLine("divisao impossivel");
            else
            {
                soma = v1 / v2;
                Console.WriteLine(soma.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}