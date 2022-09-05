using System;
using System.Globalization;

class Ex03
{
    static void Main()
    {
        int elementos = int.Parse(Console.ReadLine()); 

        for (int i=0; i < elementos; i++)
        {
            string[] notas = Console.ReadLine().Split(" ");
	    float n1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
	    float n2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
	    float n3 = float.Parse(notas[2], CultureInfo.InvariantCulture);

	    float media = (float) (n1*2.0 + n2*3.0 + n3*5.0)/10;
	    
	    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
	}

    }
}
