using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.AdminForm
{
    class DataAdder_Stores
    {
        public static void AddNewStoreToDB(Store store)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Stores VALUES(@storeCode, @storeAddress, @directorCode, @phone, @sellers, @warehouseWorkerCode);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@storeCode", SqlDbType.Int).Value = store.id;
            sqlCommand.Parameters.Add("@storeAddress", SqlDbType.VarChar, 70).Value = store.address;
            sqlCommand.Parameters.Add("@directorCode", SqlDbType.Int).Value = store.directorCode;
            sqlCommand.Parameters.Add("@phone", SqlDbType.BigInt).Value = store.phone;
            sqlCommand.Parameters.Add("@sellers", SqlDbType.VarChar, 30).Value = store.sellers;
            sqlCommand.Parameters.Add("@warehouseWorkerCode", SqlDbType.Int).Value = store.warehouseWorkerCode;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public static void AddNewStoreToDB(Store store, string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Stores VALUES(@storeCode, @storeAddress, @directorCode, @phone, @sellers, @warehouseWorkerCode);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@storeCode", SqlDbType.Int).Value = store.id;
            sqlCommand.Parameters.Add("@storeAddress", SqlDbType.VarChar, 70).Value = store.address;
            sqlCommand.Parameters.Add("@directorCode", SqlDbType.Int).Value = store.directorCode;
            sqlCommand.Parameters.Add("@phone", SqlDbType.BigInt).Value = store.phone;
            sqlCommand.Parameters.Add("@sellers", SqlDbType.VarChar, 30).Value = store.sellers;
            sqlCommand.Parameters.Add("@warehouseWorkerCode", SqlDbType.Int).Value = store.warehouseWorkerCode;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
