using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;
using Enterprise_Managment_IS.Forms.AdminFormDirectory;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.AdminForm
{
    class DataAdder_Users
    {
        public static void AddNewUserToDB(int userCode, User newUser)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Users(User_code, Worker, LogIn, Password) VALUES(@userCode, @worker, @LogIn, @Password);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@userCode", SqlDbType.Int).Value = userCode;
            sqlCommand.Parameters.Add("@worker", SqlDbType.Int).Value = newUser.WorkerCode;
            sqlCommand.Parameters.Add("@LogIn", SqlDbType.VarChar, 30).Value = newUser.Login;
            sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar, 30).Value = newUser.Password;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public static void AddNewUserToDB(int userCode, User newUser, string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Users(User_code, Worker, LogIn, Password) VALUES(@userCode, @worker, @LogIn, @Password);";
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
