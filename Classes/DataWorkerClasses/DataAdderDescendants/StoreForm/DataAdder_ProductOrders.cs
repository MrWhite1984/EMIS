using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.HRFormData;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.StoreForm
{
    class DataAdder_ProductOrders
    {
        public static void AddNewOrderToDB(int storeCode)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Order_from_the_store VALUES(@Order_code, @Store, @Order_date);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            int orderCode = DataLoader_ProductsOrders.GetAllProductsOrders().Count() + 1;
            sqlCommand.Parameters.Add("@Order_code", SqlDbType.Int).Value = orderCode;
            sqlCommand.Parameters.Add("@Store", SqlDbType.Int).Value = storeCode;
            sqlCommand.Parameters.Add("@Order_date", SqlDbType.DateTime).Value = DateTime.Now;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
