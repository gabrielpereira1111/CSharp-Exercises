using System.Collections.Generic;
using System.IO;
using EPlayers_ASPNet.Interfaces;

namespace EPlayers_ASPNet.Models
{
    public class Player : EPlayersBase , IPlayer
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int TeamId { get; set; }
        const string PATH = "Database/Player.csv";

        public Player()
        {
            CreateDatabase(PATH);
        }

        public string Prepare(Player player){
            return $"{player.PlayerId};{player.Name};{player.TeamId}";
        }

        public void Create(Player player)
        {
            string[] lines = { Prepare(player) };
            File.AppendAllLines( PATH , lines );
        }

        public void Delete(int id)
        {
            List<string> content = ReadCSV(PATH);
            content.RemoveAll(x => x.Split(";")[0] == id.ToString());
            WriteLineCSV( PATH , content );
        }

        public List<Player> Read()
        {
            List<Player> playerList = new List<Player>();
            string[] content = File.ReadAllLines(PATH);
            foreach (var item in content)
            {
                Player player = new Player();
                player.PlayerId = int.Parse(item.Split(";")[0]);
                player.Name = item.Split(";")[1];
                player.TeamId = int.Parse(item.Split(";")[2]);
            }
            return playerList;
        }

        public void Update(Player player)
        {
            List<string> content = ReadCSV(PATH);
            content.RemoveAll(x => x.Split(";")[0] == player.PlayerId.ToString());
            content.Add( Prepare(player) );
            WriteLineCSV( PATH , content );
        }
    }
}