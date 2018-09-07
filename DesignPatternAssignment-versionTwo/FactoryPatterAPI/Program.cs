using FactoryPatterAPI;
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
            int option = 0;
            Singleton.getSingletonInstance().logger("In Main" + Environment.NewLine); 
           
            AboutProduct obj = new AboutProduct();
            while (true)
            {
                
                Console.WriteLine("Enter the type of service you want to book\nEnter 'Car' to book car\nEnter 'Hotel' to book Hotel\nEnter 'Airways' to book Airways\nEnter 'Activity' to book Activity\n -1 to exit");
                string desc = Console.ReadLine();
                if (desc=="-1")
                {
                    break;
                }
                IProduct product = obj.GetProduct(desc);
                product.GetTypeOfProduct();
                ProductInventory inventory = new ProductInventory();
                List<IProduct> productList = inventory.GetProductList(desc);
       


                DisplayFareStrategy incrementStrategy = new DisplayFareStrategy();
                for (int i = 0; i < productList.Count; i++)
                {
                    productList[i].Price = incrementStrategy.IncrementFare(productList[i].Price, product.GetType().Name);
                }
                for (int i = 0; i < productList.Count; i++)
                {
                    Console.WriteLine("ID: " + productList[i].Id + "\tName: " + productList[i].Name + "\tPrice: " + productList[i].Price + "\tIsBooked: " + productList[i].IsBooked);
                }

                Console.WriteLine("Enter ID you want to book");
                int id = int.Parse(Console.ReadLine());
                int ProductIndex = productList.FindIndex(x => x.Id == id);

                Console.WriteLine("Enter Repo type:\nPress 1 for Database\nPress 2 for TextFile");
                option = int.Parse(Console.ReadLine());

                RepositoryType RepoType = new RepositoryType();
                IRepository RepoObj = RepoType.GetRepoType(option);

                Console.WriteLine("Enter 1 to Save\nEnter 2 to Book");
                option = int.Parse(Console.ReadLine());
                IProductServices ProServiceObj = new Service();
                switch (option)
                {
                    case 1:
                        {
                            ProServiceObj.Save(productList[ProductIndex], RepoObj);
                            break;
                        }
                    case 2:
                        {
                            ProServiceObj.Book(productList[ProductIndex], RepoObj);
                            break;
                        }
                    default: break;
                }
            }
           
        }
    }
}