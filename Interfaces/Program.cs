using System;
using Interfaces.classes;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos p = new Produtos(1, "Doritos", 9.99f);
            Produtos p2 = new Produtos();
            p2.Codigo = 2;
            p2.Nome = "Ruffles";
            p2.Preco = 5.99f;

            Carrinho c = new Carrinho();
            c.Cadastrar(p);
            c.Cadastrar(p2);

            Console.WriteLine($"Carrinho:");
            c.Listar();

            Produtos p3 = new Produtos(3, "Cebolitos", 2.99f);
            c.Alterar(1, p3);
            Console.WriteLine($"Carrinho 2:");
            c.Listar();

            c.Deletar(p2);
            Console.WriteLine($"Carrinho 3:");
            c.Listar();
            
        }
    }
}
