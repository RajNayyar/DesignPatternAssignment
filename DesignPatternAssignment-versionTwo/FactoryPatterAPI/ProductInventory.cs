
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
            new Car() {Id=1, Name="Car1", Price = 5000, IsBooked=false },
            new Car() {Id=2, Name="Car2", Price = 5000, IsBooked=false },
            new Car() {Id=3, Name="Car3", Price = 5000, IsBooked=false },
        };

            List<IProduct> Hotel = new List<IProduct>()
        {
            new Hotel() {Id=1, Name="Hotel1", Price = 5000, IsBooked=false },
            new Hotel() {Id=2, Name="Hotel2", Price = 5000, IsBooked=false },
            new Hotel() {Id=3, Name="Hotel3", Price = 5000, IsBooked=false },
        };

            List<IProduct> Activity = new List<IProduct>()
        {
            new Activity() {Id=1, Name="Activity1", Price = 5000, IsBooked=false },
            new Activity() {Id=2, Name="Activity2", Price = 5000, IsBooked=false },
            new Activity() {Id=3, Name="Activity3", Price = 5000, IsBooked=false },
        };

            List<IProduct> Airways = new List<IProduct>()
        {
            new Airways() {Id=1, Name="Air1", Price = 5000, IsBooked=false },
            new Airways() {Id=2, Name="Air2", Price = 5000, IsBooked=false },
            new Airways() {Id=3, Name="Air3", Price = 5000, IsBooked=false },
        };

            public List<IProduct> GetProductList(string choice)
            {
            Singleton.getSingletonInstance().logger("Inside GetProductList" + Environment.NewLine);
            switch (choice)
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


