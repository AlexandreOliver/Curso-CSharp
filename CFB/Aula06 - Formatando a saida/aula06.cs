using System;

class Aula06
{
    static void Main()
    {
        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.3;
        string produto = "Pastel";

        valorVenda = valorCompra + (lucro * valorCompra);

//      Formatando Saida
        Console.WriteLine("Produto.........:{0,15}", produto);// o 15 aumenta o espaço de impressão
        Console.WriteLine("Val.Compra......:{0,15:c}", valorCompra); // O 'c' converte o numero para a base monetaria
        Console.WriteLine("Lucro...........:{0,15:p}", lucro); // O 'p' coloca o numero em Porcentagem
        Console.WriteLine("Val.Venda.......:{0,15:c}", valorVenda);

    }
}