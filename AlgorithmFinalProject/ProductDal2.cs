using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmFinalProject
{
    public class ProductDal2
    {
        public DataTable GetAll2()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=EMarketing;integrated security=true");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products where Kategori LIKE '%bilgisayar%'", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;

        }
        public DataTable GetAll3()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=EMarketing;integrated security=true");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products where Kategori LIKE '%cep%'", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;

        }
        public DataTable GetAll4()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=EMarketing;integrated security=true");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products where Kategori LIKE '%tablet%'", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;

        }
    }
}
