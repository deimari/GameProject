using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IPlayerService
    {
        void Add(Player player);
        void Delete(Player player);
        void Update(Player player);
    }
}
