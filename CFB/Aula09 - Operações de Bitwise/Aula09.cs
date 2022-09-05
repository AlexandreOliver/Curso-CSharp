using System;

class Aula09
{
    static void Main()
    {
        /* Operação de Bitwise 
           Desloca os 5 ultimos digitos binarios de um valor para a direita ou para a esquerda

             (<<n) Dobra
             (>>n) Diminui pela metade

             n. numero de vezes que a operação é feita.
        */ 

        int n = 10;

        // Dobro o Valor
        n = n<<1;

        Console.WriteLine("Valor dobrado(<<): " + n);
        
        n = 10;
        n = n>>1;

        Console.WriteLine("Valor tirado a metade(>>): " + n);

    }
}