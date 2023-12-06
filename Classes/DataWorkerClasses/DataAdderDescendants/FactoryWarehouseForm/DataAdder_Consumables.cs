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
    class DataAdder_Consumables
    {
        public static void AddNewConsumableToDB(Consumable consumable)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Consumables(Consumable_code, Consumable_name, Amount_of_consumable, Consumable_description, Provider_code) VALUES(@Consumable_code, @Consumable_name, @Amount_of_consumable, @Consumable_description, @provider);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Consumable_code", SqlDbType.Int).Value = consumable.ConsumableCode;
            sqlCommand.Parameters.Add("@Consumable_name", SqlDbType.VarChar, 60).Value = consumable.ConsumableName;
            sqlCommand.Parameters.Add("@Amount_of_consumable", SqlDbType.Int).Value = consumable.AmountOfConsumable;
            sqlCommand.Parameters.Add("@Consumable_description", SqlDbType.VarChar, 250).Value = consumable.ConsumableDescription;
            sqlCommand.Parameters.Add("@provider", SqlDbType.Int).Value = consumable.Provider;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public static void AddNewConsumableToDB(Consumable consumable, string conStr)
        {
            SqlConnection sqlConnection = new SqlConnection(conStr);
            sqlConnection.Open();
            string query = "INSERT INTO Consumables(Consumable_code, Consumable_name, Amount_of_consumable, Consumable_description, Provider_code) VALUES(@Consumable_code, @Consumable_name, @Amount_of_consumable, @Consumable_description, @provider);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Consumable_code", SqlDbType.Int).Value = consumable.ConsumableCode;
            sqlCommand.Parameters.Add("@Consumable_name", SqlDbType.VarChar, 60).Value = consumable.ConsumableName;
            sqlCommand.Parameters.Add("@Amount_of_consumable", SqlDbType.Int).Value = consumable.AmountOfConsumable;
            sqlCommand.Parameters.Add("@Consumable_description", SqlDbType.VarChar, 250).Value = consumable.ConsumableDescription;
            sqlCommand.Parameters.Add("@provider", SqlDbType.Int).Value = consumable.Provider;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
