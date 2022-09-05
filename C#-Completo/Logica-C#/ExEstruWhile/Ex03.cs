using System;

class Ex03
{
    static void Main()
    {
        int combu = int.Parse(Console.ReadLine());
        int qntGa=0, qntAl=0, qntDie=0;

        while (combu != 4)
        {
            if (combu == 3)
                qntDie += 1;
            else if (combu == 2)
                qntGa += 1;
            else if (combu == 1)
                qntAl += 1;
            
            combu = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: {0}", qntAl);
        Console.WriteLine("Gasolina: {0}", qntGa);
        Console.WriteLine("Diesel: {0}", qntDie);        
    }
}