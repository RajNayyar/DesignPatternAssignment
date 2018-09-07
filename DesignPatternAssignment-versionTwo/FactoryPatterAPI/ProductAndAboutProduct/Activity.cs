
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    class Activity : IProduct
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Price { get; set; }
        public Boolean IsBooked { get; set; }
        public string GetTypeOfProduct()
        {
            Singleton.getSingletonInstance().logger("Inside IProduct->Activity" + Environment.NewLine);
            return "Activity";
        }
  
    }
}
