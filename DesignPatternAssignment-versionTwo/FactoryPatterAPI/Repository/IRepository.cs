using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    public interface IRepository
    {
      void Save(IProduct product);
    }
}
