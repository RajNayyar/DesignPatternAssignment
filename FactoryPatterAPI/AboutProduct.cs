using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    class AboutProduct
    {
        public IProduct GetProduct(string description)
        {
            switch (description)
            {
                case "Car": return new Car();
                case "Air": return new Airways();
                case "Hotel": return new Hotel();
                case "Activity": return new Activity();
                default: return null;
            }

        }

    }
}
