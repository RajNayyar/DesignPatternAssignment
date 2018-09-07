
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    class AboutProduct
    {
        public IProduct GetProduct(string product)
        {
            Singleton.getSingletonInstance().logger("Inside AboutProduct" + Environment.NewLine);
            Assembly assembly = Assembly.GetExecutingAssembly();
            var productType = assembly.GetTypes().FirstOrDefault(t => t.Name == product);
            return (IProduct)Activator.CreateInstance(productType);

        }

    }
}
