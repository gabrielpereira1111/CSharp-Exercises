using System;
using Compras.classes;

namespace Compras
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos p = new Produtos(1,"Doritos",10);
            Produtos p2 = new Produtos(2,"Coca-Cola",5);
            Produtos p3 = new Produtos(3,"Pringles",15);
            Produtos p4 = new Produtos(4,"Ketchup",2);

            Carrinho c = new Carrinho();
            c.AdicionarCarrinho(p);
            c.AdicionarCarrinho(p2);
            c.AdicionarCarrinho(p3);
            c.AdicionarCarrinho(p4);

            c.ListarProdutos();

            Console.WriteLine($"O valor total do carrinho é: {c.VerificarValor()}");

            c.AlterarItem(2, new Produtos(5, "Pepsi", 4.956f));
            c.ListarProdutos();

        }
    }
}
