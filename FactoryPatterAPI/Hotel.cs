using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    class Hotel : IProduct
    {
        public void Book()
        {
            Console.WriteLine("Booking Hotel");
        }

        public string GetTypeOfProduct()
        {
            return "Hotel";
        }

        public void Save()
        {
            Console.WriteLine("Saving Hotel");
        }
    }
}
