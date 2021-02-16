using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void Add(Sale sale);
        void Update(Sale sale);
        void Delete(Sale sale);
    }
}
