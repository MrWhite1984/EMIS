using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm
{
    class DataAdder_IssueOfConsumables
    {
        public static void AddNewIssueConsumableToDB(IssueOfConsumables issue)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Issue_of_consumables(Id, Consumable_code, Worker_code, Issue_date) VALUES(@Id, @Consumable_code, @Worker_code, @Issue_date);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = issue.Id;
            sqlCommand.Parameters.Add("@Consumable_code", SqlDbType.Int).Value = issue.ConsumableCode;
            sqlCommand.Parameters.Add("@Worker_code", SqlDbType.Int).Value = issue.WorkerCode;
            sqlCommand.Parameters.Add("@Issue_date", SqlDbType.DateTime).Value = issue.IssueDate;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public static void AddNewIssueConsumableToDB(IssueOfConsumables issue, string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Issue_of_consumables(Id, Consumable_code, Worker_code, Issue_date) VALUES(@Id, @Consumable_code, @Worker_code, @Issue_date);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Id", SqlDbType.Int).Value = issue.Id;
            sqlCommand.Parameters.Add("@Consumable_code", SqlDbType.Int).Value = issue.ConsumableCode;
            sqlCommand.Parameters.Add("@Worker_code", SqlDbType.Int).Value = issue.WorkerCode;
            sqlCommand.Parameters.Add("@Issue_date", SqlDbType.DateTime).Value = issue.IssueDate;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
