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

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.DirectorForm
{
    class DataAdder_Products
    {
        public static void AddNewProductsToDB(Product product)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Products(Product_code, Product_name, Product_description, Product_price) VALUES(@Product_code, @Product_name, @Product_description, @Product_price);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Product_code", SqlDbType.Int).Value = product.ProductCode;
            sqlCommand.Parameters.Add("@Product_name", SqlDbType.VarChar, 70).Value = product.ProductName;
            sqlCommand.Parameters.Add("@Product_description", SqlDbType.VarChar, 250).Value = product.ProductDescription;
            sqlCommand.Parameters.Add("@Product_price", SqlDbType.Float).Value = product.ProductPrice;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public static void AddNewProductsToDB(int productCode, Product product, string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Products(Product_code, Product_name, Product_description, Product_price) VALUES(@Product_code, @Product_name, @Product_description, @Product_price);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Product_code", SqlDbType.Int).Value = product.ProductCode;
            sqlCommand.Parameters.Add("@Product_name", SqlDbType.VarChar, 70).Value = product.ProductName;
            sqlCommand.Parameters.Add("@Product_description", SqlDbType.VarChar, 250).Value = product.ProductDescription;
            sqlCommand.Parameters.Add("@Product_price", SqlDbType.Float).Value = product.ProductPrice;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
