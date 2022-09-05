using System;
using System.Globalization;

class Ex08
{
    static void Main()
    {
        float salario, imposto=0.0f;
        
        salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        if (salario >= 0 && salario <= 2000.00)
            
        else
        {
            if (salario >= 2000.01 && salario <= 3000) 
            {
                salario -= 2000;
                imposto = (float)(salario * 0.08);
            }
            else
            {
                if (salario >= 3000.01 && salario <= 4500.00)
                {
                    salario -= 2000;
                    imposto = (float)(1000 * 0.08);
                    salario -= 1000;
                    imposto += (float)(salario * 0.18);
                    
                }
                else
                {
                    salario -= 2000;
                    imposto = (float)(1000 * 0.08);
                    salario -= 1000;
                    imposto += (float)(1500 * 0.18);
                    salario -= 1500;
                    imposto += (float)(salario * 0.28);
                }
            }
        }
        
        if (imposto == 0.0f)
            Console.WriteLine("Isento");
        else
            Console.WriteLine("R$ {0}", imposto.ToString("F2", CultureInfo.InvariantCulture));
    }
}