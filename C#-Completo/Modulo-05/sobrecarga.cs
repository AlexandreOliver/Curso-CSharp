using System;
using System.Globalization;

namespace sobrecarga
{
    class Program
    {
        static void Main()
        {
            /* Sobrecarga é um conceito em que a classe 
            me permite ter varios construtores com para-
            metros diferentes */

            // Objeto com 3 argumentos
            Produto x = new Produto("Arroz", 12.90, 15);
            // Objeto com 2 argumentos
            Produto y = new Produto("Feijao", 15.50);
            // Objeto com nenhum argumento
            Produto z = new Produto();

        }
    }

    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Construtor de 3 argumentos  
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Sobrecarga: Mais um construtor agora de 2 argumentos 
        public Produto(string nome, double preco) : this() // reaproveita o construtor de 0 argumentos, onde e definido Quantidade = 0.
        {
            Nome = nome;
            Preco = preco;
            // quantidade recebe 0 por padrao
        }
        
        // Mais um Construtor agora de 0 argumentos
        public Produto() { Quantidade = 0;}


    }
}