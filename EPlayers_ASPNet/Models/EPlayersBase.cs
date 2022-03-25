using System.Collections.Generic;
using System.IO;

namespace EPlayers_ASPNet.Models
{
    public class EPlayersBase
    {
        public void CreateDatabase(string path){
            string folder = path.Split("/")[0];
            if(!Directory.Exists(folder)){
                Directory.CreateDirectory(folder);
            }
            if(!File.Exists(path)){
                File.Create(path);
            }
        }

        public List<string> ReadCSV(string path){
            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine()) != null){
                    lines.Add(line);
                } 
            }
            return lines;
        }  

        public void WriteLineCSV(string path, List<string> stringList){
            using (StreamWriter sw = new StreamWriter(path)){
                foreach(var item in stringList){
                    sw.Write(item + '\n');
                }   
            }
        }
    }
}