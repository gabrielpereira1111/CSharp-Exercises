using System;
using Construtor_02.classes;

namespace Construtor_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.Codigo = 1;
            p.Nome = "Coca-Cola";
            p.Descricao = "Refrigerante";
            p.Estoque = 1000;

            Console.WriteLine($" {p.Codigo} - {p.Nome} - {p.Descricao} - {p.Estoque} ");

            Produto p2 = new Produto(2);
            p2.Nome = "Pepsi";
            p2.Descricao = "Refrigerante";
            p2.Estoque = 50;

            Console.WriteLine($" {p2.Codigo} - {p2.Nome} - {p2.Descricao} - {p2.Estoque} ");

            Produto p3 = new Produto(3,"Fanta","Refrigerante de laranja",200);

            Console.WriteLine($" {p3.Codigo} - {p3.Nome} - {p3.Descricao} - {p3.Estoque} ");

        }
    }
}
