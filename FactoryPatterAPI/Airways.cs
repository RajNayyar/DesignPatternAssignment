using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    class Airways : IProduct
    {

        public string GetTypeOfProduct()
        {
            return "Air product";
        }
        public void Book()
        {
            Console.WriteLine("Booking Airways");
        }

        public void Save()
        {
            Console.WriteLine("Saving Airways");
        }
    }
}
