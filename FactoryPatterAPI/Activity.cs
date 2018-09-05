using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    class Activity : IProduct
    {
        public string GetTypeOfProduct()
        {
            return "Activity";
        }
        public void Book()
        {
            Console.WriteLine("Booking Activity");
        }

        public void Save()
        {
            Console.WriteLine("Saving Activity");
        }
    }
}
