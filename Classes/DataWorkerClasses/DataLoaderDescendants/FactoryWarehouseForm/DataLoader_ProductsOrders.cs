using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;
using Enterprise_Managment_IS.Classes.TypesOfData.ForMultipleForm;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm
{
    class DataLoader_ProductsOrders
    {
        public static List<string[]> GetAllProductsOrders()
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
                query = "SELECT * FROM Order_from_the_store";
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

        //public static List<string[]> GetFactoryProductsByPartOfName(string partOfName)
        //{
        //    string connectionString = Settings.GetSettings().connectionString;
        //    SqlConnection sqlConnection = null;
        //    string query = null;
        //    SqlCommand sqlCommand = null;
        //    SqlDataReader reader = null;
        //    List<string[]> data = null;
        //    try
        //    {
        //        sqlConnection = new SqlConnection(connectionString);
        //        sqlConnection.Open();
        //        query = $"SELECT * FROM Factory_products WHERE  Product_name LIKE '%{partOfName}%'";
        //        sqlCommand = new SqlCommand(query, sqlConnection);
        //        reader = sqlCommand.ExecuteReader();
        //        data = new List<string[]>();
        //        while (reader.Read())
        //        {
        //            data.Add(new string[4]);

        //            data[data.Count - 1][0] = reader[0].ToString();
        //            data[data.Count - 1][1] = reader[1].ToString();
        //            data[data.Count - 1][2] = reader[2].ToString();
        //            data[data.Count - 1][3] = reader[3].ToString();
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    finally
        //    {
        //        reader.Close();
        //        sqlConnection.Close();
        //    }
        //    if (data != null)
        //        return data;
        //    else
        //        return null;
        //}

        //public static Material GetMaterialsByName(string name)
        //{
        //    string connectionString = Settings.GetSettings().connectionString;
        //    SqlConnection sqlConnection = null;
        //    string query = null;
        //    SqlCommand sqlCommand = null;
        //    SqlDataReader reader = null;
        //    List<string[]> data = null;
        //    try
        //    {
        //        sqlConnection = new SqlConnection(connectionString);
        //        sqlConnection.Open();
        //        query = $"SELECT * FROM Factory_products WHERE  Material_name = @name";
        //        sqlCommand = new SqlCommand(query, sqlConnection);
        //        sqlCommand.Parameters.AddWithValue("@name", name);
        //        reader = sqlCommand.ExecuteReader();
        //        data = new List<string[]>();
        //        while (reader.Read())
        //        {
        //            data.Add(new string[5]);

        //            data[data.Count - 1][0] = reader[0].ToString();
        //            data[data.Count - 1][1] = reader[1].ToString();
        //            data[data.Count - 1][2] = reader[2].ToString();
        //            data[data.Count - 1][3] = reader[3].ToString();
        //            data[data.Count - 1][4] = reader[4].ToString();
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    finally
        //    {
        //        reader.Close();
        //        sqlConnection.Close();
        //    }
        //    if (data[0] != null)
        //    {
        //        Material material = new Material(Convert.ToInt32(data[0][0]), data[0][1], Convert.ToInt32(data[0][2]), data[0][3], Convert.ToInt32(data[0][4]));
        //        return material;
        //    }
        //    else
        //        return null;
        //}

        //public static Product GetFactoryProductByCode(int code)
        //{
        //    string connectionString = Settings.GetSettings().connectionString;
        //    SqlConnection sqlConnection = null;
        //    string query = null;
        //    SqlCommand sqlCommand = null;
        //    SqlDataReader reader = null;
        //    string[] data = null;
        //    try
        //    {
        //        sqlConnection = new SqlConnection(connectionString);
        //        sqlConnection.Open();
        //        query = "SELECT * FROM Factory_products WHERE Product_code = @Product_code";
        //        sqlCommand = new SqlCommand(query, sqlConnection);
        //        sqlCommand.Parameters.Add("@Product_code", SqlDbType.Int).Value = code;
        //        reader = sqlCommand.ExecuteReader();
        //        data = new string[4];
        //        while (reader.Read())
        //        {
        //            data[0] = reader[0].ToString();
        //            data[1] = reader[1].ToString();
        //            data[2] = reader[2].ToString();
        //            data[3] = reader[3].ToString();
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    finally
        //    {
        //        reader.Close();
        //        sqlConnection.Close();
        //    }
        //    if (data[0] != null)
        //        return new Product(Convert.ToInt32(data[0]), data[1], Convert.ToInt32(data[2]), data[3]);
        //    else
        //        return null;
        //}
    }
}
