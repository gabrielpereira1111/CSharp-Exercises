using System.IO;
using EPlayers_ASPNet.Models;
using Microsoft.AspNetCore.Http;
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

        [Route("Create")]
        public IActionResult Create(IFormCollection form){
            News newNews = new News();
            newNews.NewsId = int.Parse(form["NewsId"]);
            newNews.Title = form["Title"];
            newNews.Text = form["Text"];

            if(form.Files.Count > 0){
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory() , "wwwroot/img/News");
                if(!Directory.Exists(folder)){
                    Directory.CreateDirectory(folder);
                }
                var path = Path.Combine(Directory.GetCurrentDirectory() , "wwwroot/img" , folder , file.FileName);

                using (var stream = new FileStream(path , FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                newNews.Image = file.FileName;
            } else {
                newNews.Image = "padrao.png";
            }

            news.Create(newNews);
            ViewBag.News = news.Read();

            return LocalRedirect("~/News/Read");
        }

        [Route("Delete")]
        public IActionResult Delete(int id){
            news.Delete(id);
            ViewBag.News = news.Read();
            return LocalRedirect("~/News/Read");
        }
    }
}