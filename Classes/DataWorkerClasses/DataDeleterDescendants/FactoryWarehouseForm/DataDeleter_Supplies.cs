using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataDeleterDescendants.FactoryWarehouseForm
{
    class DataDeleter_Supplies
    {
        public static void DeleteSupplyFromDB(int supplyCode)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "DELETE FROM Supplies WHERE Supply_code = @supplyCode;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@supplyCode", SqlDbType.Int).Value = supplyCode;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
