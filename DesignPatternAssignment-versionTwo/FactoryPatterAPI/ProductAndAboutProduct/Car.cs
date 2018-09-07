
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    class Car : IProduct
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Price { get; set; }
        public Boolean IsBooked { get; set; }
        public string GetTypeOfProduct()
        {
            Singleton.getSingletonInstance().logger("Inside IProduct->Car" + Environment.NewLine);
            return "Car";
        }
   
    }
}
