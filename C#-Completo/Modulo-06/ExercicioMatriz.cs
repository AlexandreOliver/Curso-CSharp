using System;
using System.Collections.Generic;

namespace Mod6
{
    class ExercicioMatriz
    {
        static void Main()
        {
            Console.Write("Digite as dimenções da Matriz: ");
            string[] usr = Console.ReadLine().Split(" ");
            int linhas = int.Parse(usr[0]);
            int colunas = int.Parse(usr[1]);

            int[,] matriz = new int[linhas, colunas];
            Console.WriteLine("Matriz Criada.");

            Console.WriteLine("Forneça os Dados:");
            for (int linha = 0; linha < linhas; linha++)
            {
                usr = Console.ReadLine().Split(" ");
                for (int coluna = 0; coluna < colunas; coluna++)
                {
                    matriz[linha, coluna] = int.Parse(usr[coluna]);
                    //Console.WriteLine("A");
                }
            }
            Console.WriteLine("Dados Gravados.");

            Console.Write("Numero que deseja consultar: ");
            int num = int.Parse(Console.ReadLine());
            for (int linha = 0; linha < linhas; linha++)
            {
                for (int coluna = 0; coluna < colunas; coluna++)
                {
                    if (num == matriz[linha, coluna])
                    {
                        Console.WriteLine($"Numero Encontrado aqui: {linha},{coluna}:");
                        if (coluna == 0 & linha == 0)
                        {
                            Console.WriteLine($"Right: {matriz[linha, coluna+1]}");
                            Console.WriteLine($"Down: {matriz[linha+1,coluna]}");
                        }
                        else if (coluna == 0)
                        {
                            Console.WriteLine($"Right: {matriz[linha, coluna+1]}");
                            Console.WriteLine($"Down: {matriz[linha+1, coluna]}");
                            Console.WriteLine($"Up: {matriz[linha-1, coluna]}");
                        }
                        else if (linha == 0)
                        {
                            Console.WriteLine($"Right: {matriz[linha, coluna+1]}");
                            Console.WriteLine($"Down: {matriz[linha+1, coluna]}");
                            Console.WriteLine($"Left: {matriz[linha, coluna-1]}");
                        }
                        else if (coluna == colunas-1)
                        {
                            Console.WriteLine($"Down: {matriz[linha+1, coluna]}");
                            Console.WriteLine($"Up: {matriz[linha-1, coluna]}");
                            Console.WriteLine($"Left: {matriz[linha, coluna-1]}");
                        }
                        else if (linha == linhas-1)
                        {
                            Console.WriteLine($"Right: {matriz[linha, coluna+1]}");
                            Console.WriteLine($"Up: {matriz[linha-1, coluna]}");
                            Console.WriteLine($"Left: {matriz[linha, coluna-1]}");
                        }
                        else if (coluna == colunas-1 & linha == linhas-1)
                        {
                            Console.WriteLine($"Up: {matriz[linha-1, coluna]}");
                            Console.WriteLine($"Left: {matriz[linha, coluna-1]}");
                        }
                        else
                        {
                            Console.WriteLine($"Right: {matriz[linha, coluna+1]}");
                            Console.WriteLine($"Down: {matriz[linha+1, coluna]}");
                            Console.WriteLine($"Up: {matriz[linha-1, coluna]}");
                            Console.WriteLine($"Left: {matriz[linha, coluna-1]}");
                        }
                    }
                }
            }
        }
    }
}