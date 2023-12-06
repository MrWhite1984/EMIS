using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm
{
    class DataAdder_FactoryProducts
    {
        public static void AddNewFactoryProductsToDB(FactoryProduct product)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Factory_products(ID, Product_code, Amount_of_product) VALUES(@ID, @Product_code, @Amount_of_product);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = product.ID;
            sqlCommand.Parameters.Add("@Product_code", SqlDbType.Int).Value = product.ProductCode;
            sqlCommand.Parameters.Add("@Amount_of_product", SqlDbType.Int).Value = 0;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public static void AddNewFactoryProductsToDB(int productCode, FactoryProduct product, string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Factory_products(ID, Product_code, Amount_of_product) VALUES(@ID, @Product_code, @Amount_of_product);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = product.ID;
            sqlCommand.Parameters.Add("@Product_code", SqlDbType.Int).Value = product.ProductCode;
            sqlCommand.Parameters.Add("@Amount_of_product", SqlDbType.Int).Value = 0;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
