using System;

namespace EPlayers_ASPNet.Models
{
    public class Match
    {
        
        public int MatchId { get; set; }
        public int PlayerOneId { get; set; }
        public int PlayerTwoId { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime EndHour { get; set; }

        public Match(){
            StartHour = DateTime.UtcNow;
            EndHour = StartHour.AddMinutes(30);
        }
        
    }
}