using System.Collections.Generic;
using System.IO;

namespace MVC_Jogos.Model
{
    public class Jogos
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/Jogos.csv";

        public Jogos(){
            string folder = PATH.Split("/")[0];
            if(!Directory.Exists(PATH)){
                Directory.CreateDirectory(folder);
            }
            if(!File.Exists(PATH)){
                File.Create(PATH);
            }
        }

        /*
            Esse método é responsável por ler o conteúdo do nosso 'Banco de Dados'. O tipo de retorno é uma lista de jogos porque o método precisa 'mandar' essa lista tratada para que o Controller mande para a View.
        */
        public List<Jogos> Ler(){
            /*
                Aqui é criada uma lista de jogos(objetos), instanciando essa nova classe[criando um objeto dessa classe de lista(List<Jogos>)]
            */
            List<Jogos> listaJogos = new List<Jogos>();
            /*
                Criamos um array de strings chamado 'content', que, cada índice, armazenará uma linha do nosso 'Banco de Dados'.
            */
            string[] content = File.ReadAllLines(PATH);
            /*
                Laço de repetição que percorre o array de strings 'content'. Cada vez que ele passa por um índice(que são formados pelas linhas do 'BD'), ele armazena o conteúdo na variável 'item'
            */
            foreach(string item in content){
                Jogos jogo = new Jogos();
                jogo.Codigo = int.Parse(item.Split(";")[0]);
                jogo.Nome = item.Split(";")[1];
                jogo.Preco = float.Parse(item.Split(";")[2]);
                listaJogos.Add(jogo);
            }
            return listaJogos;
        }

        public void InserirJogo(Jogos jogo){
            string[] content = { PrepararLinhaCSV(jogo) };
            File.AppendAllLines( PATH, content );
        }

        /*
            Esse método formata um objeto do tipo 'Jogos' em uma linha de arquivo CSV 
        */
        public string PrepararLinhaCSV(Jogos jogo){
            return $"{jogo.Codigo};{jogo.Nome};{jogo.Preco}";
        }

    
    }
}