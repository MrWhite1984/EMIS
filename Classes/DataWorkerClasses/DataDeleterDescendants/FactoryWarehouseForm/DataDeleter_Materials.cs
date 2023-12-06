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
    class DataDeleter_Materials
    {
        public static void DeleteMaterialFromDB(int materialCode)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "DELETE FROM Materials WHERE Material_code = @Material_code;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Material_code", SqlDbType.Int).Value = materialCode;
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно удалить материал из-за смежных записей.\nДля удаления обратитесь к администратору");
            }
            finally
            {
                sqlConnection.Close();
            }
            
        }
    }
}
