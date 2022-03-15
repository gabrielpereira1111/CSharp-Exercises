using System;
using System.Collections.Generic;

namespace Interfaces.classes
{
    public class Carrinho : ICarrinho
    {
        List<Produtos> carrinho = new List<Produtos>();
        public void Alterar(int codigo, Produtos novoProduto)
        {
            carrinho.Find(x => x.Codigo == codigo).Nome = novoProduto.Nome;
            carrinho.Find(x => x.Codigo == codigo).Preco = novoProduto.Preco;
        }

        public void Cadastrar(Produtos novoProduto)
        {
            carrinho.Add(novoProduto);
        }

        public void Deletar(Produtos produtos)
        {
            carrinho.Remove(produtos);
        }

        public void Listar()
        {
            if(carrinho != null){
                foreach(Produtos item in carrinho){
                    Console.WriteLine($"{item.Codigo} - {item.Nome} - R$ {item.Preco}");
                }
            } else{
                Console.WriteLine("O seu carrinho está vazio!");
            }
        }
    }
}