﻿using System;
using System.Globalization;

namespace Produto2
{
    class Program
    {
        
            static void Main(string[] args)
            {
                //Produto p = new Produto("TV", 1000.0, 10);
                Console.WriteLine("Entre os dados do produto qq um:");
                Console.Write("Nome: ");
                string Nome = Console.ReadLine();
                Console.Write("Preço: ");
                double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //Console.Write("Quantidade no estoque: ");
                //int Quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(Nome, Preco /*, Quantidade*/);

            Produto p2 = new Produto();

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
    }
    

