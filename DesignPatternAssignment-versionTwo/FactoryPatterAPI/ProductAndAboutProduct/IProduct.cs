﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    public interface IProduct
    {
        int Id { get; }
        string Name { get; set; }
        int Price { get; set; }
        Boolean IsBooked { get; set; }
        string GetTypeOfProduct();
        
    }
}
