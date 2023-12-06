using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataChangerDescendants.FactoryWarehouseForm
{
    class DataChanger_Consumables
    {
        public static void ChangeConsumableInDB(int consumableCode, Consumable consumable)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "UPDATE Consumables SET  Amount_of_consumable = @AmountOfConsumable WHERE Consumable_code = @Consumable_code;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Consumable_code", SqlDbType.Int).Value = consumableCode;
            sqlCommand.Parameters.Add("@AmountOfConsumable", SqlDbType.VarChar, 30).Value = consumable.AmountOfConsumable;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public static void ApplyASupply(Consumable consumable, Supply supply)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "UPDATE Consumables SET  Amount_of_consumable = @AmountOfConsumable WHERE Consumable_code = @consumableCode;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@consumableCode", SqlDbType.Int).Value = consumable.ConsumableCode;
            sqlCommand.Parameters.Add("@AmountOfConsumable", SqlDbType.VarChar, 30).Value = consumable.AmountOfConsumable + supply.AmountOfMaterial;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
