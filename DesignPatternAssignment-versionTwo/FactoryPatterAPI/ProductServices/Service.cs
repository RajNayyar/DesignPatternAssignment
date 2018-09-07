
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    class Service : IProductServices
    {
        public bool IsBooked { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSaved { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Book(IProduct product, IRepository RepoObj)
        {
            Singleton.getSingletonInstance().logger("Inside IProductServices->Service->Book(Parameters)" + Environment.NewLine);
            product.IsBooked = true;
            RepoObj.Save(product);
        }

        public void Save(IProduct product, IRepository RepoObj)
        {
            Singleton.getSingletonInstance().logger("Inside IProductServices->Service->Save(Parameters)" + Environment.NewLine);
            RepoObj.Save(product); 
        }
    }
}
