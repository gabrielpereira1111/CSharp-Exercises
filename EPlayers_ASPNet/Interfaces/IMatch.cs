using System.Collections.Generic;
using EPlayers_ASPNet.Models;

namespace EPlayers_ASPNet.Interfaces
{
    public interface IMatch
    {
        void Create(Match match);
        List<Match> Read();
        void Update(Match match);
        void Delete(int id);
    }
}