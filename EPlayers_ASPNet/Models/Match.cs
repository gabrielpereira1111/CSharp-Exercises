using System;
using System.Collections.Generic;
using System.IO;
using EPlayers_ASPNet.Interfaces;

namespace EPlayers_ASPNet.Models
{
    public class Match : EPlayersBase , IMatch
    {
        
        public int MatchId { get; set; }
        public int PlayerOneId { get; set; }
        public int PlayerTwoId { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime EndHour { get; set; }
        const string PATH = "Database/Match.csv";

        public Match(){
            CreateDatabase(PATH);
        }

        public string Prepare(Match match){
            return $"{match.MatchId};{match.PlayerOneId};{match.PlayerTwoId};{match.StartHour};{match.EndHour}";
        }

        public void Create(Match match)
        {
            string[] line = { Prepare(match) };
            File.AppendAllLines( PATH , line );
        }

        public List<Match> Read()
        {
            List<Match> matchList = new List<Match>();
            string[] content = File.ReadAllLines(PATH);
            foreach (var item in content)
            {
                Match match = new Match();
                match.MatchId = int.Parse(item.Split(";")[0]);
                match.PlayerOneId = int.Parse(item.Split(";")[1]);
                match.PlayerTwoId = int.Parse(item.Split(";")[2]);
                match.StartHour = DateTime.Parse(item.Split(";")[3]);
                match.EndHour = DateTime.Parse(item.Split(";")[4]);
                matchList.Add(match);
            }
            return matchList;
        }

        public void Update(Match match)
        {
            List<string> content = ReadCSV(PATH);
            content.RemoveAll(x => x.Split(";")[0] == match.MatchId.ToString());
            content.Add( Prepare(match) );
            WriteLineCSV( PATH , content );
        }

        public void Delete(int id)
        {
            List<string> content = ReadCSV(PATH);
            content.RemoveAll(x => x.Split(";")[0] == id.ToString());
            WriteLineCSV( PATH , content );
        }
    }
}