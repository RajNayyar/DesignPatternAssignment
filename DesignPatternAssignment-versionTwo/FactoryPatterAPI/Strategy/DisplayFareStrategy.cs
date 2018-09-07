
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    public class DisplayFareStrategy
    {
        public int IncrementFare(int currentFare, string Type)
        {
            Singleton.getSingletonInstance().logger("Inside DisplayFareStrategy->IncrementFare" + Environment.NewLine);
            if (Type == "Car")
            return Convert.ToInt32(currentFare + (0.1) * currentFare); 
            else if(Type=="Airways")
                return Convert.ToInt32(currentFare + (0.2) * currentFare);
            else if(Type=="Activity")
                return Convert.ToInt32(currentFare + (0.3) * currentFare);
            else
                return Convert.ToInt32(currentFare + (0.4) * currentFare);
        }

       
    }
}
