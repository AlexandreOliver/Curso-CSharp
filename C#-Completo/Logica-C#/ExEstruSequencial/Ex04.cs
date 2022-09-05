using System;
using System.Globalization;

class Ex04
{
    static void Main()
    {
        int numero, horastrabalhadas;
        float vhoras, salario;

        Console.Write("Sua identificação numerica: ");
        numero = int.Parse(Console.ReadLine());
        Console.Write("Horas Trabalhadas: ");
        horastrabalhadas = int.Parse(Console.ReadLine());
        Console.Write("Valor por cada hora: ");
        vhoras = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        salario = horastrabalhadas * vhoras;

        Console.WriteLine("NUMBER = {0}", numero);
        Console.WriteLine("SALARY = U$ {0}", salario.ToString("F2", CultureInfo.InvariantCulture));

    }
}
