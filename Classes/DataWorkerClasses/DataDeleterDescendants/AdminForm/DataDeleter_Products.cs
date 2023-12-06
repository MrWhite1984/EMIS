using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataDeleterDescendants.AdminForm
{
    class DataDeleter_Products
    {
        public static void DeleteProductFromDB(int productCode)
        {
            SqlConnection sqlConnection = new SqlConnection(Settings.GetSettings().connectionString);
            sqlConnection.Open();
            string query = "DELETE FROM Products WHERE Product_code = @Product_code;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Product_code", SqlDbType.Int).Value = productCode;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
