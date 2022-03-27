using EPlayers_ASPNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace EPlayers_ASPNet.Controllers
{
    [Route("News")]
    public class NewsController : Controller
    {
        News news = new News(); 

        [Route("Read")]
        public IActionResult Index(){
            ViewBag.News = news.Read();
            return View();
        }
    
    }
}