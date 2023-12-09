using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using System.Data;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.AdminForm
{
    class DataLoader_Users
    {
        public static List<string[]> GetAllUsers()
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = null;
            string query = null;
            SqlCommand sqlCommand = null;
            SqlDataReader reader = null;
            List<string[]> data = null;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                query = "SELECT * FROM Users";
                sqlCommand = new SqlCommand(query, sqlConnection);
                reader = sqlCommand.ExecuteReader();
                data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
            if (data != null)
                return data;
            else
                return null;
        }

        public static User GetUserByCode(int code)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = null;
            string query = null;
            SqlCommand sqlCommand = null;
            SqlDataReader reader = null;
            string[] data = null;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                query = "SELECT * FROM Users WHERE User_code = @userCode";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@userCode", SqlDbType.Int).Value = code;
                reader = sqlCommand.ExecuteReader();
                data = new string[4];
                while (reader.Read())
                {
                    data[0] = reader[0].ToString();
                    data[1] = reader[1].ToString();
                    data[2] = reader[2].ToString();
                    data[3] = reader[3].ToString();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
            if (data[0] != null)
                return new User(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]), data[2].Trim(' '), data[3].Trim(' '));
            else
                return null;
        }

        public static User GetUserByLogIn(string logIn)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = null;
            string query = null;
            SqlCommand sqlCommand = null;
            SqlDataReader reader = null;
            string[] data = null;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                query = "SELECT * FROM Users WHERE LogIn = @LogIn";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@LogIn", SqlDbType.VarChar, 30).Value = logIn;
                reader = sqlCommand.ExecuteReader();
                data = new string[4];
                while (reader.Read())
                {
                    data[0] = reader[0].ToString();
                    data[1] = reader[1].ToString();
                    data[2] = reader[2].ToString();
                    data[3] = reader[3].ToString();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
            if (data[0] != null)
            {
                char whiteSpace = ' ';
                return new User(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]), data[2].Trim(whiteSpace), data[3].Trim(whiteSpace));
            }
            else
                return null;
        }
        public static List<string[]> GetUserByPassword(string password)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = null;
            string query = null;
            SqlCommand sqlCommand = null;
            SqlDataReader reader = null;
            List<string[]> data = null;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                query = "SELECT * FROM Users WHERE Password = @Password";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar, 30).Value = password;
                reader = sqlCommand.ExecuteReader();
                data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
            if (data != null)
                return data;
            else
                return null;
        }

        public static User GetUserByLogInAndPassword(string logIn, string password)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = null;
            string query = null;
            SqlCommand sqlCommand = null;
            SqlDataReader reader = null;
            string[] data = null;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                query = "SELECT * FROM Users WHERE LogIn = @LogIn AND Password = @Password";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@LogIn", SqlDbType.VarChar, 30).Value = logIn;
                sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar, 30).Value = password;
                reader = sqlCommand.ExecuteReader();
                data = new string[4];
                while (reader.Read())
                {
                    data[0] = reader[0].ToString();
                    data[1] = reader[1].ToString();
                    data[2] = reader[2].ToString();
                    data[3] = reader[3].ToString();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
            if (data[0] != null)
            {
                return new User(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]), data[2].Trim(' '), data[3].Trim(' '));
            }
            else
                return null;
        }

        public static List<string[]> GetUserByWorkerCode(int code)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = null;
            string query = null;
            SqlCommand sqlCommand = null;
            SqlDataReader reader = null;
            List<string[]> data = null;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                query = "SELECT * FROM Users WHERE Worker = @workerCode";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@workerCode", SqlDbType.Int).Value = code;
                reader = sqlCommand.ExecuteReader();
                data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[4]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                reader.Close();
                sqlConnection.Close();
            }
            if (data != null)
                return data;
            else
                return null;
        }
    }
}
