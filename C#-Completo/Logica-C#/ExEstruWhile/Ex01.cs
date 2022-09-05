using System;

class Ex01
{
    static void Main()
    {
        int senha = 0;
        
        while (senha != 2002)
        {
            Console.Write("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());
            if (senha != 2002)    
                Console.WriteLine("Senha Invalida");
            
        }

        Console.WriteLine("Acesso Permitido");
    }
}