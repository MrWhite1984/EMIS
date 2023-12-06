using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataDeleterDescendants.HRForm
{
    class DataDeleter_Workers
    {
        public static void DeleteWorkerFromDB(int workerCode)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "DELETE FROM Workers WHERE Worker_code = @workerCode;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@workerCode", SqlDbType.Int).Value = workerCode;
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch(SqlException sqlEx)
            {
                MessageBox.Show("Невозможно удалить работника из-за смежных записей.\nДля удаления обратитесь к администратору");
            }
            finally
            {
                sqlConnection.Close();
            }

            
        }
    }
}
