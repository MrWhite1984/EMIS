using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataChangerDescendants.AdminForm
{
    class DataChanger_Users
    {
        public static void ChangeUserInDB(int userCode, User newUser)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "UPDATE Users SET  Worker = @worker, LogIn = @LogIn, Password = @Password WHERE User_code = @userCode;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@userCode", SqlDbType.Int).Value = userCode;
            sqlCommand.Parameters.Add("@worker", SqlDbType.Int).Value = newUser.WorkerCode;
            sqlCommand.Parameters.Add("@LogIn", SqlDbType.VarChar, 30).Value = newUser.Login;
            sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar, 30).Value = newUser.Password;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
