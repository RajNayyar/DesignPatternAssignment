using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    class Program
    {
        static void Main(string[] args)
        { 
            AboutProduct obj = new AboutProduct();
            string desc = Console.ReadLine();
            IProduct product = obj.GetProduct(desc);
            product.GetTypeOfProduct();
            product.Book();
            product.Save();
            Console.ReadKey();
        }
    }
}