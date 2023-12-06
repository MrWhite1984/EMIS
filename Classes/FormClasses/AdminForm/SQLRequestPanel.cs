using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;

namespace Enterprise_Managment_IS.Classes.FormClasses.AdminForm
{
    class SQLRequestPanel
    {
        public static string SelectSQLRequestType(string requestText)
        {
            var chanks = requestText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string returnText = "";
            if (chanks[0].ToLower() == "select")
                returnText = "Невозможно выполнить запрос на выборку";
            else
                returnText = ExecuteRequestType_2(requestText);
            return returnText;
        }

        private static string ExecuteRequestType_2(string requestText)
        {
            SqlConnection sqlConnection = new SqlConnection(Settings.GetSettings().connectionString);
            sqlConnection.Open();
            string query = requestText;
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            try
            {
                sqlCommand.ExecuteNonQuery();
                return "Успешно";
            }
            catch(SqlException exMes)
            {
                return exMes.Message;
            }
            finally
            {
                sqlConnection.Close();
            }

            
        }

    }
}
