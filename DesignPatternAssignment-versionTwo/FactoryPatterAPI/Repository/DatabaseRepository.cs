
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterAPI
{
    class DatabaseRepository : IRepository
    {
        public void Save(IProduct product)
        {
            Singleton.getSingletonInstance().logger("Inside IRepository->DatabaserRepository->Save(Parameters)" + Environment.NewLine);
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = @"Data Source=TAVDESK154;Initial Catalog=Products;User Id=sa; Password=test123!@#";
                sqlConnection.Open();
                string query = "Insert into "+product.GetType().Name + "(Id,Name,Price,IsBooked) values(@id,@name,@Price,@isBooked)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@id", product.Id));
                sqlCommand.Parameters.Add(new SqlParameter("@name", product.Name));
                sqlCommand.Parameters.Add(new SqlParameter("@Price", product.Price));
                sqlCommand.Parameters.Add(new SqlParameter("@isBooked", product.IsBooked));
                sqlCommand.ExecuteNonQuery();
                Console.WriteLine("Data Saved");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
