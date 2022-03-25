using System.Collections.Generic;
using EPlayers_ASPNet.Models;

namespace EPlayers_ASPNet.Interfaces
{
    public interface ITeam
    {
        void Create(Team team);
        List<Team> Read();
        void Update(Team team);
        void Delete(int id);
    }
}