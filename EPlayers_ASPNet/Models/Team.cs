using System.Collections.Generic;
using System.IO;
using EPlayers_ASPNet.Interfaces;

namespace EPlayers_ASPNet.Models
{
    public class Team : EPlayersBase , ITeam
    {

        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        const string PATH = "Database/Team.csv";

        public Team()
        {
            CreateDatabase(PATH);
        }

        public string PrepareLine(Team team){
            return $"{team.TeamId};{team.Name};{team.Image}"; 
        }

        public void Create(Team team)
        {
            string[] line = { PrepareLine(team) };
            File.AppendAllLines(PATH, line);
        }

        public void Delete(int id)
        {
            List<string> lines = ReadCSV(PATH);
            lines.RemoveAll(x => x.Split(";")[0] == id.ToString());
            WriteLineCSV(PATH, lines);
        }

        public List<Team> Read()
        {
            List<Team> teams = new List<Team>();
            string[] lines = File.ReadAllLines(PATH);
            foreach(var item in lines){
                Team team = new Team();
                team.TeamId = int.Parse(item.Split(";")[0]);
                team.Name = item.Split(";")[1];
                team.Image = item.Split(";")[2];
                teams.Add(team);
            }
            return teams;
        }

        public void Update(Team team)
        {
            List<string> lines = ReadCSV(PATH);
            lines.RemoveAll(x => x.Split(";")[0] == team.TeamId.ToString());
            lines.Add(PrepareLine(team));
            WriteLineCSV(PATH, lines);
        }
    }
}