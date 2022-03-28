using System.Collections.Generic;
using EPlayers_ASPNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EPlayers_ASPNet.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        [TempData]
        public string Message { get; set; }
        
        
        Player player = new Player();
        public IActionResult Index(){
            return View();
        }

        [Route("In")]
        public IActionResult In(IFormCollection form){
            List<string> CSV = player.ReadCSV(player.PATH);
            var logged = CSV.Find(
                x =>
                    x.Split(";")[3] == form["Email"] &&
                    x.Split(";")[4] == form["Password"]
            );

            if(logged != null){
                HttpContext.Session.SetString("_userName", logged.Split(";")[1]);
                return LocalRedirect("~/");
            }

            Message = "Email e/ou senha inválidos";
            return LocalRedirect("~/Login");
        }

        [Route("Out")]
        public IActionResult Out(){
            HttpContext.Session.Remove("_userName");
            return LocalRedirect("~/");
        }
    }
}