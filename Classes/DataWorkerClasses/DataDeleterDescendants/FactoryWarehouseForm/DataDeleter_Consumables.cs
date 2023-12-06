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
    class DataDeleter_Consumables
    {
        public static void DeleteConsumableFromDB(int consumableCode)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "DELETE FROM Consumables WHERE Consumable_code = @Consumable_code;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Consumable_code", SqlDbType.Int).Value = consumableCode;
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch(SqlException sqlEx)
            {
                MessageBox.Show("Невозможно удалить расходник из-за смежных записей.\nДля удаления обратитесь к администратору");
            }
            finally
            {
                sqlConnection.Close();
            }
            
        }
    }
}
