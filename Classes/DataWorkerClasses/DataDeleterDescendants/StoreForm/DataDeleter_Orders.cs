
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataDeleterDescendants.StoreForm
{
    class DataDeleter_Orders
    {
        public static void DeleteOrderFromDB(int orderCode)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "DELETE FROM Order_from_the_store WHERE Order_code = @Order_code;" +
                "DELETE FROM Production_order_elements WHERE Order_code = @Order_code;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Order_code", SqlDbType.Int).Value = orderCode;
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("");
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
