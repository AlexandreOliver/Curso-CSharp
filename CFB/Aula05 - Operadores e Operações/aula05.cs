using System;

class Aula05
{
    static void Main()
    {
        // Operadores aritmeticos: +, -, *, /, %
        int res = 10 % 2;

        // Operadores Relacionais: >, <, >=, <=, !=, 
        bool boleana = 10 < 5;

        // Decremento e Acremento: -= ou --, += ou ++, *=, /=, %=
        res--;
        res++;

        // Operadores Logicos: & - and, | - or, ! - not
        boleana = 10 > 5 & 10 > 6;

        Console.WriteLine(boleana);
    }
}