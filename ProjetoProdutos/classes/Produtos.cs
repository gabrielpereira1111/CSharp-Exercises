using System;
using System.Collections.Generic;

namespace ProjetoProdutos.classes
{
    public class Produtos
    {
        
        List<Produto> ListaProdutos = new List<Produto>();

        public void Cadastrar(){
            Produto produto = new Produto();
            Marcas marcas = new Marcas();

            Console.Write("Digite o código do produto: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            produto.NomeProduto = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            produto.Preco = float.Parse(Console.ReadLine());

            produto.DataCadastro = DateTime.UtcNow;

            produto.Marca = marcas.Cadastrar(); 

            ListaProdutos.Add(produto);
        }

        public void Listar(){
            if(ListaProdutos != null){
                foreach(Produto item in ListaProdutos){
                    Console.WriteLine($"{item.Codigo} - {item.NomeProduto} - {item.Preco} - {item.DataCadastro} - {item.Marca.Nome}");
                }
            } else {
                Console.WriteLine("Lista vazia!");
            }
        }

        public void Deletar(){
            Console.Write("Digite o código do produto que você deseja excluir: ");
            int id = int.Parse(Console.ReadLine());

            Produto produtoDeletado = ListaProdutos.Find(x => x.Codigo == id);
            ListaProdutos.Remove(produtoDeletado);
        }
    }
}