using System.Collections.Generic;
using System.IO;
using EPlayers_ASPNet.Interfaces;

namespace EPlayers_ASPNet.Models
{
    public class News : EPlayersBase , INews
    {
        
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        const string PATH = "Database/News.csv";

        public News()
        {
            CreateDatabase(PATH);
        }

        public string Prepare(News news){
            return $"{news.NewsId};{news.Title};{news.Text};{news.Image}";
        }

        public void Create(News news)
        {
            string[] newLine = { Prepare(news) };
            File.AppendAllLines(PATH, newLine);
        }

        public List<News> Read()
        {
            List<News> newsList = new List<News>();
            string[] content = File.ReadAllLines(PATH);
            foreach(var item in content){
                News news = new News();
                news.NewsId = int.Parse(item.Split(";")[0]);
                news.Title = item.Split(";")[1];
                news.Text = item.Split(";")[2];
                news.Image = item.Split(";")[3];
                newsList.Add(news);
            }
            return newsList;
        }

        public void Update(News news)
        {
            List<string> lines = ReadCSV(PATH);
            lines.RemoveAll(x => x.Split(";")[0] == news.NewsId.ToString());
            lines.Add(Prepare(news));
            WriteLineCSV(PATH, lines);
        }

        public void Delete(int id)
        {
            List<string> lines = ReadCSV(PATH);
            lines.RemoveAll(x => x.Split(";")[0] == id.ToString());
            WriteLineCSV(PATH, lines);
        }
    }
}