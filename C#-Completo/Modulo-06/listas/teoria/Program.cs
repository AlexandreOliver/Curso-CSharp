using System;
using System.Collections.Generic;
// Necessario para usar listas

namespace teoria
{
    class Program
    {
        static void Main(string[] args)
        {
        //  List<Tipo> nome = new List<Tipo>()
        
            List<string> lista = new List<string>();
       //   Declaração        e    Instanciamento

            List<string> lista2 = new List<string>
            {"Maria", "james", "Igor"};

        //  Adicionar Elementos na lista -- Add
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Jonas");
            lista.Add("Albenes");
            lista.Add("Matheus");
            lista.Add("Daniel");

            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
        //  Adicionar Elementos por indice -- Insert
            lista.Insert(2, "Marco");

        //  Mostrar o Tamanho da lista -- Count
            Console.WriteLine("Tamanho da Lista: " + lista.Count);

        //  Pesquisar na lista a primeira ocorrencia -- Find
            string s1 = lista.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro elemento comecando com A: " + s1);
        //  Pesquisar na lista a ultima ocorrencia -- FindLast
            s1 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo elemento comecando com A: "+ s1);
        //  Encontrar Primeira Posição -- FindIndex
            int posi = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira Posicao 'A' " + posi);
        //  Encontrar Ultima Posicao -- FindLastIndex
            posi = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima Posicao 'A' " + posi);
        //  Filtrar a lista dado um predicado -- FindAll
            List<string> NewLista = lista.FindAll(x => x.Length == 5);
            
            foreach (string obj in NewLista)
            {
                Console.WriteLine(obj);
            }

        //  Remover elemento especifico da lista -- Remove
            lista.Remove("Alex");
            
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
        //  Remover elementos com algo em comum -- RemoveAll
            lista.RemoveAll(x => x[0].Equals("M"));

            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
        //  Remover elemento pela posicao -- RemoveAt
            lista.RemoveAt(2);

            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
        //  Remover elementos de uma faixa -- RemoveRange
            lista.RemoveRange(2, 2);

            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
