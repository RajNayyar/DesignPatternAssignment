using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    class Car : IProduct
    {
        public string GetTypeOfProduct()
        {
            return "Car";
        }
        public void Book()
        {
            Console.WriteLine("Booking Cars");
        }

        public void Save()
        {
            Console.WriteLine("Saving Car");
        }
    }
}
