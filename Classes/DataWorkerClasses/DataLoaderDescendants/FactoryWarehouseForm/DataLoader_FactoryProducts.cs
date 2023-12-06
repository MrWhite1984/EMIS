using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm
{
    class DataLoader_FactoryProducts
    {
        public static List<string[]> GetAllFactoryProducts()
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
                query = "SELECT * FROM Factory_products";
                sqlCommand = new SqlCommand(query, sqlConnection);
                reader = sqlCommand.ExecuteReader();
                data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[3]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
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

        public static FactoryProduct GetFactoryProductByCode(int code)
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
                query = "SELECT * FROM Factory_products WHERE ID = @ID";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = code;
                reader = sqlCommand.ExecuteReader();
                data = new string[3];
                while (reader.Read())
                {
                    data[0] = reader[0].ToString();
                    data[1] = reader[1].ToString();
                    data[2] = reader[2].ToString();
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
                return new FactoryProduct(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]), Convert.ToInt32(data[2]));
            else
                return null;
        }
    }
}
