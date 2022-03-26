using System;
using EPlayers_ASPNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EPlayers_ASPNet.Controllers
{
    /*
        Cria uma rota chamada 'Match', que é o mesmo nome do recurso utilizado, e atribui à toda classe
        Fica assim - Exemplo: http://localhost:5000/Match
    */
    [Route("Match")]
    public class MatchController : Controller
    {
        Match match = new Match();

        /*
            Subrota -> http://localhost:5000/Match/Read
        */
        [Route("Read")]
        /*
            Método que referencia o arquivo(Index.cshtml) criado no diretório desse recurso;
            IActionResult é o tipo de método que sempre retorna uma ação(Status Code, telas, info, ...)
            O método retorna a prpria View
        */
        public IActionResult Index(){
            /*
                A ViewBag(armazena informações) 'pegará' o conteúdo do DB de Match
            */
            ViewBag.Match = match.Read();
            return View();
        }

        [Route("Create")]
        public IActionResult Create(IFormCollection form){
            Match newMatch = new Match();
            newMatch.MatchId = int.Parse(form["MatchId"]);
            newMatch.PlayerOneId = int.Parse(form["PlayerOneId"]);
            newMatch.PlayerTwoId = int.Parse(form["PlayerTwoId"]);
            newMatch.StartHour = DateTime.Parse(form["StartHour"]);
            newMatch.EndHour = DateTime.Parse(form["EndHour"]);

            match.Create(newMatch);
            /*
                Lê novamente para atualizar automaticamente quando criado uma nova partida
            */
            ViewBag.Match = match.Read();

            return LocalRedirect("~/Match/Read");
        }
        
    }
}