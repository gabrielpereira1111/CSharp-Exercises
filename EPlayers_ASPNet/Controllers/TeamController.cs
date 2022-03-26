using EPlayers_ASPNet.Models;
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
        
    }
}