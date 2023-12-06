using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm
{
    class DataAdder_Providers
    {
        public static void AddNewProviderToDB(int providerCode, Provider provider)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Providers(Provider_code, Provider_name, Provider_address, Provider_description) VALUES(@Provider_code, @Provider_name, @Provider_address, @Provider_description);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Provider_code", SqlDbType.Int).Value = providerCode;
            sqlCommand.Parameters.Add("@Provider_name", SqlDbType.VarChar, 70).Value = provider.ProviderName;
            sqlCommand.Parameters.Add("@Provider_address", SqlDbType.VarChar, 70).Value = provider.ProviderAddress;
            sqlCommand.Parameters.Add("@Provider_description", SqlDbType.VarChar, 250).Value = provider.ProviderDescription;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public static void AddNewProviderToDB(int providerCode, Provider provider, string conStr)
        {
            SqlConnection sqlConnection = new SqlConnection(conStr);
            sqlConnection.Open();
            string query = "INSERT INTO Providers(Provider_code, Provider_name, Provider_address, Provider_description) VALUES(@Provider_code, @Provider_name, @Provider_address, @Provider_description);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Provider_code", SqlDbType.Int).Value = providerCode;
            sqlCommand.Parameters.Add("@Provider_name", SqlDbType.VarChar, 70).Value = provider.ProviderName;
            sqlCommand.Parameters.Add("@Provider_address", SqlDbType.VarChar, 70).Value = provider.ProviderAddress;
            sqlCommand.Parameters.Add("@Provider_description", SqlDbType.VarChar, 250).Value = provider.ProviderDescription;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
