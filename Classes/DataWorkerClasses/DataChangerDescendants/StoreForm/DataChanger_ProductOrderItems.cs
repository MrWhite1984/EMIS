using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;
using Enterprise_Managment_IS.Classes.TypesOfData.Other;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataChangerDescendants.StoreForm
{
    class DataChanger_ProductOrderItems
    {
        public static void ChangeOrderItemFromFactoryInDB(int itemCode, OrderItem orderItem)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "UPDATE Production_order_elements SET  isProduced = @isProduced, isLoaded = @isLoaded WHERE Element_code = @Element_code;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Element_code", SqlDbType.Int).Value = itemCode;
            sqlCommand.Parameters.Add("@isProduced", SqlDbType.Bit).Value = orderItem.isProduced;
            sqlCommand.Parameters.Add("@isLoaded", SqlDbType.Bit).Value = orderItem.isLoad;
            //sqlCommand.Parameters.Add("@isReceived", SqlDbType.Bit).Value = orderItem.isReceived;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public static void ChangeOrderItemFromStoreInDB(int itemCode, OrderItem orderItem)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "UPDATE Production_order_elements SET  isReceived = @isReceived WHERE Element_code = @Element_code;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@Element_code", SqlDbType.Int).Value = itemCode;
            //sqlCommand.Parameters.Add("@isProduced", SqlDbType.Bit).Value = orderItem.isProduced;
            //sqlCommand.Parameters.Add("@isLoaded", SqlDbType.Bit).Value = orderItem.isLoad;
            sqlCommand.Parameters.Add("@isReceived", SqlDbType.Bit).Value = orderItem.isReceived;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
