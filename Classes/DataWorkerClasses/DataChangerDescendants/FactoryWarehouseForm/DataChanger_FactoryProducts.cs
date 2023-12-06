using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataChangerDescendants.FactoryWarehouseForm
{
    class DataChanger_FactoryProducts
    {
        public static void ChangeAmountFactoryProductsInDB(int productCode, FactoryProduct product)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "UPDATE Factory_products SET  Amount_of_product = @Amount_of_product WHERE ID = @ID;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = productCode;
            sqlCommand.Parameters.Add("@Amount_of_product", SqlDbType.Int).Value = product.AmountOfProduct;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
