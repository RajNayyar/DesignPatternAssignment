using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace FactoryPatterAPI
    {

        public class Singleton
        {

            private static Singleton singletonInstance;

            private Singleton()
            {
            }

            public static Singleton getSingletonInstance()
            {
                if (null == singletonInstance)
                {
                    Console.WriteLine("singleton created");
                    singletonInstance = new Singleton();
                }
                return singletonInstance;
            }
            public void logger(string message)
            {
                DateTime now = DateTime.Now;
                System.IO.File.AppendAllText(@"C:\LoggerText.txt",now+"--->"+message+Environment.NewLine);
            }
        }
    }


