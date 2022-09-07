using System;

namespace encapsulamento
{
    class Program
    {
        static void Main()
        {
            Produto x = new Produto("ALHO", 12,45);

            Console.WriteLine(x.GetNome());
            x.SetNome("ARROZ");
            Console.WriteLine(x.GetNome());

        }
    }
    
    class Produto
    {
        // O encapsulamento define que todos os atributos de uma classe precisam ser privadas e para cada
        // atributo deve existir os metodos Get e Set.
        private string _nome;
        private double _preco;
        private int _quantidade;
 
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
        }
        
        public Produto() 
        { _quantidade = 0; }

        public string GetNome()
        { return _nome; }

        public void SetNome(string nome)
        { 
            if (nome != null && nome.Length > 1)
                _nome = nome;    
        }

        public string GetPreco()
        { return _preco; }

        public string GetQuantidade()
        { return _quantidade; }

        public double ValorTotalEmEstoque() 
        { return _preco * _quantidade; }

        public void AdicionarProdutos(int quantidade) 
        { _quantidade += quantidade; }

    }
}