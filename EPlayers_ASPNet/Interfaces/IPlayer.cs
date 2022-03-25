using System.Collections.Generic;
using EPlayers_ASPNet.Models;

namespace EPlayers_ASPNet.Interfaces
{
    public interface IPlayer
    {
        void Create(Player player);
        List<Player> Read();
        void Update(Player player);
        void Delete(int id);
    }
}