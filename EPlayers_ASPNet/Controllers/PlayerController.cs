using EPlayers_ASPNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EPlayers_ASPNet.Controllers
{
    [Route("Player")]
    public class PlayerController : Controller
    {
        Player player = new Player();
        /*
            Para exibir os times disponíveis em um Select na View, nós precisamos ler o conteúdo no arquivo CSV(DB) de 'Team'
            Instanciamos a classe para podermos utilizar o método Read()
         */
        Team team = new Team();

        
        public IActionResult Index(){
            /*
                A ViewBag serve para tornar os dados do back-end para a View('front')
            */

            /*
                Aqui criamos uma ViewBag chamada 'Player' para armazenar os dados existentes no arquivo CSV de Player
            */
            ViewBag.Player = player.Read();
            /*
                ViewBag criada para armazenar os dados no arquivo CSV de Team
            */
            ViewBag.Team = team.Read();
            return View();
        }

        [Route("Create")]
        public IActionResult Create(IFormCollection form){
            Player newPlayer = new Player();

            newPlayer.PlayerId = int.Parse(form["PlayerId"]);
            newPlayer.Name = form["Name"];
            newPlayer.TeamId = int.Parse(form["TeamId"]);
            newPlayer.Email = form["Email"];
            newPlayer.Password = form["Password"];

            player.Create(newPlayer);
            ViewBag.Player = player.Read();
            return LocalRedirect("~/Player");
        }

        [Route("{id}")]
        public IActionResult Delete(int id){
            player.Delete(id);
            ViewBag.Player = player.Read();
            return LocalRedirect("~/Player");
        }
    }
}