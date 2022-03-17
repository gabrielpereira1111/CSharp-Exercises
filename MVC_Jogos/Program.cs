using System;
using MVC_Jogos.Controller;
using MVC_Jogos.Model;

namespace MVC_Jogos
{
    class Program
    {
        static void Main(string[] args)
        {
            JogosController jogosController = new JogosController();
            for(int contador = 0; contador < 3; contador++){
                jogosController.Cadastrar();
                Console.WriteLine();
            }
            jogosController.Listar();
        }
    }
}
