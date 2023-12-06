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
    class DataDeleter_DefectiveFactoryProducts
    {
        public static void DeleteDefectiveFactoryProductFromDB(int productCode)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "DELETE FROM Defective_factory_products WHERE ID = @ID;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = productCode;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
