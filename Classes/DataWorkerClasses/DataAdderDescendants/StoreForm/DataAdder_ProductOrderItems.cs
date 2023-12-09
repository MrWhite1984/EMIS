using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.HRFormData;
using Enterprise_Managment_IS.Classes.TypesOfData.Other;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.StoreForm;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.StoreForm
{
    class DataAdder_ProductOrderItems
    {
        public static void AddNewItemToDB(OrderItem orderItem, int orderCode)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Production_order_elements VALUES(@Element_code, @Order_code, @Product_code, @Amount, @isProduced, @isLoded, @isReceived);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            int code = DataLoader_ProductionOrderItems.GetAllItems().Count() + 1;
            sqlCommand.Parameters.Add("@Element_code", SqlDbType.Int).Value = code;
            sqlCommand.Parameters.Add("@Order_code", SqlDbType.Int).Value = orderCode;
            sqlCommand.Parameters.Add("@Product_code", SqlDbType.Int).Value = Convert.ToInt32(orderItem.productName.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
            sqlCommand.Parameters.Add("@Amount", SqlDbType.Int).Value = orderItem.amount;
            sqlCommand.Parameters.Add("@isProduced", SqlDbType.Bit).Value = false;
            sqlCommand.Parameters.Add("@isLoded", SqlDbType.Bit).Value = false;
            sqlCommand.Parameters.Add("@isReceived", SqlDbType.Bit).Value = false;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public static void AddNewItemToDB(OrderItem orderItem, int orderCode, string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Production_order_elements VALUES(@Element_code, @Order_code, @Product_code, @Amount, @isProduced, @isLoded, @isReceived);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Element_code", SqlDbType.Int).Value = orderItem.code;
            sqlCommand.Parameters.Add("@Order_code", SqlDbType.Int).Value = orderItem.orderCode;
            sqlCommand.Parameters.Add("@Product_code", SqlDbType.Int).Value = Convert.ToInt32(orderItem.productName.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
            sqlCommand.Parameters.Add("@Amount", SqlDbType.Int).Value = orderItem.amount;
            sqlCommand.Parameters.Add("@isProduced", SqlDbType.Bit).Value = false;
            sqlCommand.Parameters.Add("@isLoded", SqlDbType.Bit).Value = false;
            sqlCommand.Parameters.Add("@isReceived", SqlDbType.Bit).Value = false;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
