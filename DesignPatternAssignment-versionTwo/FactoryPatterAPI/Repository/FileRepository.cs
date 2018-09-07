
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    class FileRepository : IRepository
    {
        public void Save(IProduct product)
        {
            Singleton.getSingletonInstance().logger("Inside IRepository->FileRepository->Save(Parameters)" + Environment.NewLine);
            DateTime now = DateTime.Now;
            File.AppendAllText(@"C:\HotelDB.txt",now + "-----> Product Type: " + product.GetType().Name + " Product Id: " + product.Id + " Product Name: " + product.Name + " Price: " + product.Price + " Booked:" + product.IsBooked + Environment.NewLine);
        }
    }
}
