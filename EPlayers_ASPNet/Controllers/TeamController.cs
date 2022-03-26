using EPlayers_ASPNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EPlayers_ASPNet.Controllers
{
    [Route("Team")]
    public class TeamController : Controller
    {
        Team team = new Team();

        [Route("Read")]
        public IActionResult Index(){
            ViewBag.Team = team.Read();
            return View();
        }

        [Route("Create")]
        public IActionResult Create(IFormCollection form){
            Team newTeam = new Team();

            newTeam.TeamId = int.Parse(form["TeamId"]);
            newTeam.Name = form["Name"];
            newTeam.Image = form["Image"];

            team.Create(newTeam);
            ViewBag.Team = team.Read();
            return LocalRedirect("~/Team/Read");
        }
        
    }
}