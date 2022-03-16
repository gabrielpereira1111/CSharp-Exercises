using System.Collections.Generic;
using System.IO;

namespace MVC_Produtos.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH = "Database/Produto.csv";

        public Produto(){
            string folder = PATH.Split("/")[0];
            if(!Directory.Exists(PATH)){
                Directory.CreateDirectory(folder);
            }
            if(!File.Exists(PATH)){
                File.Create(PATH);
            }
        }

        public List<Produto> Ler(){
            List<Produto> listaProdutos = new List<Produto>();

            string[] lines = File.ReadAllLines(PATH);

            foreach(string item in lines){
                string[] atributos = item.Split(";");

                Produto produto = new Produto();
                produto.Codigo = int.Parse(atributos[0]);
                produto.Nome = atributos[1];
                produto.Preco = float.Parse(atributos[2]); 

                listaProdutos.Add(produto);
            }

            return listaProdutos;
        }

        public void InserirProduto(Produto produto){
            string[] novoProduto = {FormarLinhaCSV(produto)};
            File.AppendAllLines(PATH, novoProduto);
        }

        public string FormarLinhaCSV(Produto produto){
            return $"{produto.Codigo};{produto.Nome};{produto.Preco}";
        }
    }
}