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

        // Devolve uma lista de jogos para quem chamar esse método
        public List<Jogos> Ler(){
            List<Jogos> listaJogos = new List<Jogos>();
            string[] content = File.ReadAllLines(PATH);
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

        // Método que converte um objeto do tipo 'jogo' em string
        public string PrepararLinhaCSV(Jogos jogo){
            return $"{jogo.Codigo};{jogo.Nome};{jogo.Preco}";
        }

    
    }
}