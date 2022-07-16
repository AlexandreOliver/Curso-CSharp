using System;

class aula04
{
    
    static int num = 10; // Essa variavel pode ser acessada por todos os metodos - Escopo Global
    
    static void Main()
    {
        int num2 = 0; // Essa variavel so é acessivel dentro do escopo Main() - Escopo Local

        Console.WriteLine(num);

    }

}