
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
   
      

       public class ProductInventory
        {
            List<IProduct> Car = new List<IProduct>()
            { 
            new Car() {Id=1, Name="Suzuki", Price = 5000, IsBooked=false },
            new Car() {Id=2, Name="Honda", Price = 6000, IsBooked=false },
            new Car() {Id=3, Name="Mazda", Price = 7000, IsBooked=false },
        };

            List<IProduct> Hotel = new List<IProduct>()
        {
            new Hotel() {Id=1, Name="Hyatt", Price = 5000, IsBooked=false },
            new Hotel() {Id=2, Name="Lalit", Price = 5000, IsBooked=false },
            new Hotel() {Id=3, Name="Mountview", Price = 5000, IsBooked=false },
        };

            List<IProduct> Activity = new List<IProduct>()
        {
            new Activity() {Id=1, Name="Activity1", Price = 5000, IsBooked=false },
            new Activity() {Id=2, Name="Activity2", Price = 5000, IsBooked=false },
            new Activity() {Id=3, Name="Activity3", Price = 5000, IsBooked=false },
        };

            List<IProduct> Airways = new List<IProduct>()
        {
            new Airways() {Id=1, Name="Lufthansa", Price = 5000, IsBooked=false },
            new Airways() {Id=2, Name="Air India", Price = 5000, IsBooked=false },
            new Airways() {Id=3, Name="Indigo", Price = 5000, IsBooked=false },
        };

            public List<IProduct> GetProductList(string option)
            {
            Singleton.getSingletonInstance().logger("Inside GetProductList" + Environment.NewLine);
            switch (option)
                {
                    case "Airways": return this.Airways;
                    case "Activity": return this.Activity;
                    case "Car": return this.Car;
                    case "Hotel": return this.Hotel;
                }
                return null;
            }
        }
    }


