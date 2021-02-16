using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Add(Sale sale)
        {
            Console.WriteLine("Sale added.");
        }

        public void Delete(Sale sale)
        {
            Console.WriteLine("Sale deleted.");
        }

        public void Update(Sale sale)
        {
            Console.WriteLine("Sale updated.");
        }
    }
}
