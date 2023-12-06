using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataChangerDescendants.AdminForm
{
    class DataChanger_Products
    {
        public static void ChangeProductInDB(int productCode, Product product)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "UPDATE Products SET Product_description = @Product_description, Product_price = @Product_price WHERE Product_code = @Product_code;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Product_code", SqlDbType.Int).Value = productCode;
            sqlCommand.Parameters.Add("@Product_description", SqlDbType.VarChar, 500).Value = product.ProductDescription;
            sqlCommand.Parameters.Add("@Product_price", SqlDbType.Float).Value = product.ProductPrice;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
