using System.IO;
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
            
            if(form.Files.Count > 0){
                var file = form.Files[0];
                /* Esse 'Directory.GetCurrentDirectory()' devolve o valor em string localhost:5000 */
                /* O .Combine() junta essas duas strings */
                var folder = Path.Combine( Directory.GetCurrentDirectory() , "wwwroot/img/Team" );

                if(!Directory.Exists(folder)){
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine( Directory.GetCurrentDirectory() , "wwwroot/img" , folder , file.FileName );

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                newTeam.Image = file.FileName;
            } else{
                newTeam.Image = "padrao.png";
            }

            team.Create(newTeam);
            ViewBag.Team = team.Read();
            return LocalRedirect("~/Team/Read");
        }
        
    }
}