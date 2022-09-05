using System;
using System.Globalization;

class Ex06
{
    static void Main()
    {
        double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;

        string[] vet = Console.ReadLine().Split(" ");
          a = double.Parse(vet[0], CultureInfo.InvariantCulture);
          b = double.Parse(vet[1], CultureInfo.InvariantCulture);
          c = double.Parse(vet[2], CultureInfo.InvariantCulture);

        triangulo = a*c/2;
        circulo = 3.14159 * c * c;
        trapezio = (a+b)*c/2;
        quadrado = b * b;
        retangulo = a * b;

        Console.WriteLine("TRIANGULO: {0}", triangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: {0}", circulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: {0}", trapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: {0}", quadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: {0}", retangulo.ToString("F3", CultureInfo.InvariantCulture));
    }
}