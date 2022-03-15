using System;
using ProjetoProdutos.classes;

namespace ProjetoProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Marcas marcas = new Marcas();

            // for(int i = 0; i < 4; i++){
            //     marcas.Cadastrar();
            //     Console.WriteLine();
            // }
            // Console.WriteLine();
            // marcas.Listar();
            // Console.WriteLine();
            // marcas.Deletar();

            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine();


            Produtos p = new Produtos();

            for(int i = 0; i < 2; i++){
                p.Cadastrar();
                Console.WriteLine();
            }

            p.Listar();
        }
    }
}
