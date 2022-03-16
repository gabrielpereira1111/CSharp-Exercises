using System;
using MVC_Produtos.Controller;
using MVC_Produtos.Model;
using MVC_Produtos.View;

namespace MVC_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController pc = new ProdutoController();
            pc.CadastrarProduto();
            Console.WriteLine();
            pc.Mostrar();
        }
    }
}
