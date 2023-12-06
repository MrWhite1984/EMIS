using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm
{
    class DataLoader_Supplies
    {
        public static List<string[]> GetAllSupplies()
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
                query = "SELECT * FROM Supplies";
                sqlCommand = new SqlCommand(query, sqlConnection);
                reader = sqlCommand.ExecuteReader();
                data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString().Trim(' ');
                    data[data.Count - 1][6] = reader[6].ToString();
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

        public static Supply GetSupplyByCode(int code)
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
                query = "SELECT * FROM Supplies WHERE Supply_code = @Supply_code";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Supply_code", SqlDbType.Int).Value = code;
                reader = sqlCommand.ExecuteReader();
                data = new string[7];
                while (reader.Read())
                {
                    data[0] = reader[0].ToString();
                    data[1] = reader[1].ToString();
                    data[2] = reader[2].ToString();
                    data[3] = reader[3].ToString();
                    data[4] = reader[4].ToString();
                    data[5] = reader[5].ToString();
                    data[6] = reader[6].ToString();
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
                return new Supply(Convert.ToInt32(data[0]), Convert.ToDateTime(data[1]), data[2], Convert.ToInt32(data[3]), Convert.ToInt32(data[4]), data[5].Trim(whiteSpace), Convert.ToDouble(data[6]));
            }
            else
                return null;
        }
    }
}
