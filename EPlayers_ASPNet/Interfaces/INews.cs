using System.Collections.Generic;
using EPlayers_ASPNet.Models;

namespace EPlayers_ASPNet.Interfaces
{
    public interface INews
    {
        void Create(News news);
        List<News> Read();
        void Update(News news);
        void Delete(int id);
    }
}