using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.DirectorForm
{
    class DataLoader_Products
    {
        public static List<string[]> GetAllProducts()
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = null;
            string query = null;
            SqlCommand sqlCommand = null;
            SqlDataReader reader = null;
            List<string[]> data = null;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                query = "SELECT * FROM Products";
                sqlCommand = new SqlCommand(query, sqlConnection);
                reader = sqlCommand.ExecuteReader();
                data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
            if (data != null)
                return data;
            else
                return null;
        }

        public static List<string[]> GetProductsByPartOfName(string partOfName)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = null;
            string query = null;
            SqlCommand sqlCommand = null;
            SqlDataReader reader = null;
            List<string[]> data = null;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                query = $"SELECT * FROM Products WHERE  Product_name LIKE '%{partOfName}%'";
                sqlCommand = new SqlCommand(query, sqlConnection);
                reader = sqlCommand.ExecuteReader();
                data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
            if (data != null)
                return data;
            else
                return null;
        }

        public static Product GetProductByCode(int code)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = null;
            string query = null;
            SqlCommand sqlCommand = null;
            SqlDataReader reader = null;
            string[] data = null;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                query = "SELECT * FROM Products WHERE Product_code = @Product_code";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Product_code", SqlDbType.Int).Value = code;
                reader = sqlCommand.ExecuteReader();
                data = new string[4];
                while (reader.Read())
                {
                    data[0] = reader[0].ToString();
                    data[1] = reader[1].ToString();
                    data[2] = reader[2].ToString();
                    data[3] = reader[3].ToString();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
            if (data[0] != null)
                return new Product(Convert.ToInt32(data[0]), data[1], data[2], Convert.ToDecimal(data[3]));
            else
                return null;
        }
    }
}
