using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    interface IProductServices
    {
        Boolean IsBooked { get; set; }
        Boolean IsSaved { get; set; }
        void Save(IProduct product,IRepository RepoObj);

        void Book(IProduct product, IRepository RepoObj);

    }
}
