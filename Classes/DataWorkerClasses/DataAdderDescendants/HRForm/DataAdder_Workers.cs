using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;
using Enterprise_Managment_IS.Classes.TypesOfData.HRFormData;
using Enterprise_Managment_IS.Forms.AdminFormDirectory;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.HRForm
{
    class DataAdder_Workers
    {
        public static void AddNewWorkerToDB(int workerCode, Worker worker)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Workers(Worker_code, Surname, Name, Fname, Birth, Phone_number, Job_title, Emploement_date, Salary, Checking_account) VALUES(@Worker_code, @Surname, @Name, @Fname, @Birth, @Phone_number, @Job_title, @Emploement_date, @Salary, @Checking_account);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Worker_code", SqlDbType.Int).Value = workerCode;
            sqlCommand.Parameters.Add("@Surname", SqlDbType.VarChar, 30).Value = worker.Surname;
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar, 30).Value = worker.Name;
            sqlCommand.Parameters.Add("@Fname", SqlDbType.VarChar, 30).Value = worker.FName;
            sqlCommand.Parameters.Add("@Birth", SqlDbType.Date).Value = worker.Birth;
            sqlCommand.Parameters.Add("@Phone_number", SqlDbType.BigInt).Value = worker.PhoneNumber;
            sqlCommand.Parameters.Add("@Job_title", SqlDbType.VarChar, 50).Value = worker.JobTitle;
            sqlCommand.Parameters.Add("@Emploement_date", SqlDbType.Date).Value = worker.EmploymentDate;
            sqlCommand.Parameters.Add("@Salary", SqlDbType.Float).Value = worker.Salary;
            sqlCommand.Parameters.Add("@Checking_account", SqlDbType.BigInt).Value = worker.CheckingAccount;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public static void AddNewWorkerToDB(int workerCode, Worker worker, string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Workers(Worker_code, Surname, Name, Fname, Birth, Phone_number, Job_title, Emploement_date, Salary, Checking_account) VALUES(@Worker_code, @Surname, @Name, @Fname, @Birth, @Phone_number, @Job_title, @Emploement_date, @Salary, @Checking_account);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Worker_code", SqlDbType.Int).Value = workerCode;
            sqlCommand.Parameters.Add("@Surname", SqlDbType.VarChar, 30).Value = worker.Surname;
            sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar, 30).Value = worker.Name;
            sqlCommand.Parameters.Add("@Fname", SqlDbType.VarChar, 30).Value = worker.FName;
            sqlCommand.Parameters.Add("@Birth", SqlDbType.Date).Value = worker.Birth;
            sqlCommand.Parameters.Add("@Phone_number", SqlDbType.BigInt).Value = worker.PhoneNumber;
            sqlCommand.Parameters.Add("@Job_title", SqlDbType.VarChar, 50).Value = worker.JobTitle;
            sqlCommand.Parameters.Add("@Emploement_date", SqlDbType.Date).Value = worker.EmploymentDate;
            sqlCommand.Parameters.Add("@Salary", SqlDbType.Float).Value = worker.Salary;
            sqlCommand.Parameters.Add("@Checking_account", SqlDbType.BigInt).Value = worker.CheckingAccount;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        //public static void AddNewUserToDB(int userCode, User newUser, string connectionString)
        //{
        //    SqlConnection sqlConnection = new SqlConnection(connectionString);
        //    sqlConnection.Open();
        //    string query = "INSERT INTO Users(Code_user, LogIn, Password, User_surname, User_name, Birthday, JobTitle) VALUES(@userCode, @LogIn, @Password, @UserSurname, @UserName, @DateOfBirth, @JobTitle);";
        //    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
        //    sqlCommand.Parameters.Add("@userCode", SqlDbType.Int).Value = userCode;
        //    sqlCommand.Parameters.Add("@LogIn", SqlDbType.VarChar, 30).Value = newUser.LogIn;
        //    sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar, 30).Value = newUser.Password;
        //    sqlCommand.Parameters.Add("@UserSurname", SqlDbType.VarChar, 30).Value = newUser.UserSurname;
        //    sqlCommand.Parameters.Add("@UserName", SqlDbType.VarChar, 30).Value = newUser.UserName;
        //    sqlCommand.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = newUser.DateOfBirth;
        //    sqlCommand.Parameters.Add("@JobTitle", SqlDbType.VarChar, 30).Value = newUser.JobTitle;
        //    sqlCommand.ExecuteNonQuery();

        //    sqlConnection.Close();
        //}
    }
}
