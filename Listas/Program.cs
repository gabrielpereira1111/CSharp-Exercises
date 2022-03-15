using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto(){
                Codigo = 1,
                Nome = "Coca-Cola",
                Preco = 10.99f
            });

            produtos.Add(new Produto(2, "Pepsi", 9.50f));

            Produto p = new Produto(3, "Doritos", 16.99f);

            produtos.Add(p);

            foreach(Produto item in produtos){
                Console.WriteLine($"{item.Nome} - R$ {item.Preco}");
            }

            produtos.RemoveAt(2);

            foreach(Produto item in produtos){
                Console.WriteLine($"{item.Nome} - R$ {item.Preco}");
            }
        }
    }
}
