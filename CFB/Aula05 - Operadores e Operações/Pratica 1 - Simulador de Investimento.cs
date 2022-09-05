using System;

class Aula05
{
    static void Main()
    {
        double capital, parcela, juros, total, valor;
        int tempo;

        Console.WriteLine("Simulador de Investimento");

        Console.WriteLine("Capital inicial: ");
        capital = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Parcelas(0 se nao tiver): ");
        parcela = Convert.ToDouble((Console.ReadLine()));
        Console.WriteLine("Juros: ");
        juros = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Duração(meses): ");
        tempo = int.Parse(Console.ReadLine());

        tempo /= 12;
        juros = juros/100 + 1;
        // Juros Compostos
        total = capital * Math.Pow(juros, tempo);

        Console.WriteLine(total);

    }
}