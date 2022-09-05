using System;

class Ex04
{
    static void Main()
    {
        int tempo;
    
        String[] vet = Console.ReadLine().Split(" ");
        int inicio = int.Parse(vet[0]);
        int fim = int.Parse(vet[1]);
        
        if (fim > inicio)
            tempo = fim - inicio;
        else
            tempo = 24 - inicio  + fim;
        
        Console.WriteLine("O JOGO DUROU {0} HORA(S)", tempo);
        
    }
}