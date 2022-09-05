using System;
using System.Globalization;

class Ex02
{
    static void Main()
	{
	    double raio, pi = 3.14159, area;

	    Console.WriteLine("Raio: ");
	    raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
	    
	    area = pi * raio * raio;
	    Console.WriteLine("A={0}", area.ToString("F4", CultureInfo.InvariantCulture));
	}
}
