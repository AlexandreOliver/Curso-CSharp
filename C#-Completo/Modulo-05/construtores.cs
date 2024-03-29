using System;
using System.Globalization;
namespace Course 
{
    class Program {
        static void Main(string[] args) 
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            /* Com os construtores todas as vezes que instanciar um objeto vou precisar fornecer os parametros */
            Produto p = new Produto(nome, preco, quantidade);
            
            Produto q = new Produto();

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Construtores, obriga a definição dos atributos na hora de instanciar
        public Produto(string nome, double preco, int quantidade) 
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        // *******************************
        public double ValorTotalEmEstoque() 
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) 
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) 
        {
            Quantidade -= quantidade;
        }

        public override string ToString() 
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}