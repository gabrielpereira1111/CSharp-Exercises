using System;
using System.Collections.Generic;
using MVC_Jogos.Model;

namespace MVC_Jogos.View
{
    public class JogosView
    {
        public void ListarTodos(List<Jogos> listaJogos){
            foreach(Jogos item in listaJogos){
                Console.WriteLine($"Código: {item.Codigo} | Nome: {item.Nome} | Preço: R${item.Preco}");   
            }
        }

        
        public Jogos InserirJogo(){
            Jogos jogo = new Jogos();
            Console.Write($"Código do jogo: ");
            jogo.Codigo = int.Parse(Console.ReadLine());
            Console.Write($"Nome do jogo: ");
            jogo.Nome = Console.ReadLine();
            Console.Write($"Preço do jogo: ");
            jogo.Preco = float.Parse(Console.ReadLine());
            return jogo;
        }
    }
}