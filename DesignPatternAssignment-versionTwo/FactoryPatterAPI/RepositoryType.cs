
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    class RepositoryType
    {
        public IRepository GetRepoType(int option)
        {
            Singleton.getSingletonInstance().logger("Inside RepositoryType" + Environment.NewLine);
            switch (option)
            {
                case 1: return new DatabaseRepository();
                case 2: return new FileRepository();
                default: return null;
            }

        }
    }
}
