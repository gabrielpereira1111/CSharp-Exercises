using System;
using System.Collections.Generic;

namespace Compras.classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produtos> produtos = new List<Produtos>();

        public void AdicionarCarrinho(Produtos produto){
            produtos.Add(produto);
        }

        public void RemoverProduto(Produtos produto){
            produtos.Remove(produto);
        }

        public void ListarProdutos(){
            if(produtos != null){
                foreach(Produtos item in produtos){
                    Console.WriteLine($"{item.Codigo} - {item.Nome} - R$ {item.Preco.ToString("n2")}");
                }
            } else{
                Console.WriteLine("Seu carrinho está vazio!");
            }
        }

        public float VerificarValor(){
            foreach (Produtos item in produtos)
            {
                ValorTotal = ValorTotal+item.Preco;
            }
            return ValorTotal;
        }
        
        public void AlterarItem(int codigo, Produtos novoProduto){
            produtos.Find(p => p.Codigo == codigo).Nome = novoProduto.Nome;
            produtos.Find(p => p.Codigo == codigo).Preco = novoProduto.Preco;
        }
        
    }
}