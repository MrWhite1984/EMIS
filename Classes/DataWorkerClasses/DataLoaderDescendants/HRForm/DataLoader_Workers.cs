using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using System.Data;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;
using Enterprise_Managment_IS.Classes.TypesOfData.HRFormData;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.HRForm
{
    class DataLoader_Workers
    {
        public static List<string[]> GetAllWorkers()
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
                query = "SELECT * FROM Workers";
                sqlCommand = new SqlCommand(query, sqlConnection);
                reader = sqlCommand.ExecuteReader();
                data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[10]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                    data[data.Count - 1][9] = reader[9].ToString();
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

        public static Worker GetWorkerByCode(int code)
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
                query = "SELECT * FROM Workers WHERE Worker_code = @Worker_code";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Worker_code", SqlDbType.Int).Value = code;
                reader = sqlCommand.ExecuteReader();
                data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[10]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                    data[data.Count - 1][9] = reader[9].ToString();
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
                return new Worker(Convert.ToInt32(data[0][0]), data[0][1], data[0][2], data[0][3], Convert.ToDateTime(data[0][4]), Convert.ToInt64(data[0][5]), data[0][6], Convert.ToDateTime(data[0][7]), Convert.ToDouble(data[0][8]), Convert.ToInt64(data[0][9]));
            else
                return null;
        }

        public static List<string[]> GetWorkersByJobTitle(string jobTitle)
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
                query = "SELECT * FROM Workers WHERE Job_title = @Job_title";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Job_title", SqlDbType.VarChar, 50).Value = jobTitle;
                reader = sqlCommand.ExecuteReader();
                data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[10]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                    data[data.Count - 1][9] = reader[9].ToString();
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

        public static Worker GetUserBySNF(string SNF)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = null;
            string query = null;
            SqlCommand sqlCommand = null;
            SqlDataReader reader = null;
            List<string[]> data = null;
            var chunks = SNF.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                query = "SELECT * FROM Workers WHERE Surname = @Surname AND Name = @Name AND Fname = @FName";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Surname", SqlDbType.VarChar, 30).Value = chunks[0];
                sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar, 30).Value = chunks[1];
                sqlCommand.Parameters.Add("@FName", SqlDbType.VarChar, 30).Value = chunks[2];
                reader = sqlCommand.ExecuteReader();
                data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[10]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                    data[data.Count - 1][9] = reader[9].ToString();
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
                return new Worker(Convert.ToInt32(data[0][0]), data[0][1], data[0][2], data[0][3], Convert.ToDateTime(data[0][4]), Convert.ToInt64(data[0][5]), data[0][6], Convert.ToDateTime(data[0][7]), Convert.ToDouble(data[0][8]), Convert.ToInt64(data[0][9]));
            else
                return null;
        }

        public static List<string[]> GetUserByJobTitle(string jobTitle)
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
                query = "SELECT * FROM Workers WHERE Job_title = @jobTitle";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@jobTitle", SqlDbType.VarChar, 30).Value = jobTitle;
                reader = sqlCommand.ExecuteReader();
                data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[10]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                    data[data.Count - 1][9] = reader[9].ToString();
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

        //        public static List<string[]> GetUserByBirthday(DateTime birthday)
        //        {
        //            string connectionString = Settings.GetSettings().connectionString;
        //            SqlConnection sqlConnection = null;
        //            string query = null;
        //            SqlCommand sqlCommand = null;
        //            SqlDataReader reader = null;
        //            List<string[]> data = null;
        //            try
        //            {
        //                sqlConnection = new SqlConnection(connectionString);
        //                sqlConnection.Open();
        //                query = "SELECT * FROM Users WHERE Birthday = @Birthday";
        //                sqlCommand = new SqlCommand(query, sqlConnection);
        //                sqlCommand.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = birthday;
        //                reader = sqlCommand.ExecuteReader();
        //                data = new List<string[]>();
        //                while (reader.Read())
        //                {
        //                    data.Add(new string[7]);

        //                    data[data.Count - 1][0] = reader[0].ToString();
        //                    data[data.Count - 1][1] = reader[1].ToString();
        //                    data[data.Count - 1][2] = reader[2].ToString();
        //                    data[data.Count - 1][3] = reader[3].ToString();
        //                    data[data.Count - 1][4] = reader[4].ToString();
        //                    data[data.Count - 1][5] = reader[5].ToString();
        //                    data[data.Count - 1][6] = reader[6].ToString();
        //                }
        //            }
        //            catch (Exception)
        //            {

        //            }
        //            finally
        //            {
        //                reader.Close();
        //                sqlConnection.Close();
        //            }
        //            if (data != null)
        //                return data;
        //            else
        //                return null;
        //        }

        //        public static List<string[]> GetUserByJobTitle(string jobTitle)
        //        {
        //            string connectionString = Settings.GetSettings().connectionString;
        //            SqlConnection sqlConnection = null;
        //            string query = null;
        //            SqlCommand sqlCommand = null;
        //            SqlDataReader reader = null;
        //            List<string[]> data = null;
        //            try
        //            {
        //                sqlConnection = new SqlConnection(connectionString);
        //                sqlConnection.Open();
        //                query = "SELECT * FROM Users WHERE JobTitle = @JobTitle";
        //                sqlCommand = new SqlCommand(query, sqlConnection);
        //                sqlCommand.Parameters.Add("@JobTitle", SqlDbType.DateTime).Value = jobTitle;
        //                reader = sqlCommand.ExecuteReader();
        //                data = new List<string[]>();
        //                while (reader.Read())
        //                {
        //                    data.Add(new string[7]);

        //                    data[data.Count - 1][0] = reader[0].ToString();
        //                    data[data.Count - 1][1] = reader[1].ToString();
        //                    data[data.Count - 1][2] = reader[2].ToString();
        //                    data[data.Count - 1][3] = reader[3].ToString();
        //                    data[data.Count - 1][4] = reader[4].ToString();
        //                    data[data.Count - 1][5] = reader[5].ToString();
        //                    data[data.Count - 1][6] = reader[6].ToString();
        //                }
        //            }
        //            catch (Exception)
        //            {

        //            }
        //            finally
        //            {
        //                reader.Close();
        //                sqlConnection.Close();
        //            }
        //            if (data != null)
        //                return data;
        //            else
        //                return null;
        //        }
    }
}
