using System;
using System.Collections.Generic;

namespace ProjetoProdutos.classes
{
    public class Marcas
    {
        List<Marca> ListaMarcas = new List<Marca>();
        
        public Marca Cadastrar(){
            Marca marca = new Marca();
            Console.Write("Código da marca: ");
            marca.Codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome da marca: ");
            marca.Nome = Console.ReadLine();
            marca.DataCadastro = DateTime.UtcNow;

            ListaMarcas.Add(marca);

            return marca;
        }

        public void Listar(){
            if(ListaMarcas != null){
                foreach(Marca item in ListaMarcas){
                    Console.WriteLine($"{item.Codigo} - {item.Nome} - {item.DataCadastro}");
                }
            } else{
                Console.WriteLine("Lista vazia");
            }
        }

        public void Deletar(){
            int id;
            Console.Write("Digite o código da marca que você deseja excluir: ");
            id = int.Parse(Console.ReadLine());
            Marca marca = ListaMarcas.Find(x => x.Codigo == id);
            ListaMarcas.Remove(marca);
            Console.Write($"Marca {marca.Nome} deletada");
        }
    }
}