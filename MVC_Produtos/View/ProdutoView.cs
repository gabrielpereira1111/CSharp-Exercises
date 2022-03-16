using System;
using System.Collections.Generic;
using MVC_Produtos.Model;

namespace MVC_Produtos.View
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produto){
            foreach(Produto item in produto){
                Console.WriteLine($"Código: {item.Codigo} | Nome: {item.Nome} | Preço: {item.Preco}");
                Console.WriteLine();
            }
        }

        public Produto Cadastrar(){
            Produto p = new Produto();
            Console.Write($"Digite o código do produto: ");
            p.Codigo = int.Parse(Console.ReadLine());
            Console.Write($"Digite o nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.Write($"Digite o preço do produto: ");
            p.Preco = float.Parse(Console.ReadLine());
            return p;
        }
    }
}