using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm
{
    class DataAdder_DefectiveFactoryProducts
    {
        public static void AddNewDefectiveFactoryProductsToDB(FactoryProduct product, string description)
        {
            SqlConnection sqlConnection = new SqlConnection(Settings.GetSettings().connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Defective_factory_products(ID, Product_code, Amount_of_product, Description_of_defect, Date_added) VALUES(@ID, @Product_code, @Amount_of_product, @Description_of_defect, @Date_added);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = DataLoader_DefectiveFactoryProducts.GetAllDefectiveFactoryProducts().Count + 1;
            sqlCommand.Parameters.Add("@Product_code", SqlDbType.Int).Value = product.ProductCode;
            sqlCommand.Parameters.Add("@Amount_of_product", SqlDbType.Int).Value = 1;
            sqlCommand.Parameters.Add("@Description_of_defect", SqlDbType.VarChar, 300).Value = description;
            sqlCommand.Parameters.Add("@Date_added", SqlDbType.DateTime).Value = DateTime.Now;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public static void AddNewDefectiveFactoryProductsToDB(int productCode, (FactoryProduct, string, DateTime) values, string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Defective_factory_products(ID, Product_code, Amount_of_product, Description_of_defect, Date_added) VALUES(@ID, @Product_code, @Amount_of_product, @Description_of_defect, @Date_added);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = DataLoader_DefectiveFactoryProducts.GetAllDefectiveFactoryProducts().Count + 1;
            sqlCommand.Parameters.Add("@Product_code", SqlDbType.Int).Value = values.Item1.ProductCode;
            sqlCommand.Parameters.Add("@Amount_of_product", SqlDbType.Int).Value = 1;
            sqlCommand.Parameters.Add("@Description_of_defect", SqlDbType.VarChar, 300).Value = values.Item2;
            sqlCommand.Parameters.Add("@Date_added", SqlDbType.DateTime).Value = values.Item3;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }


    }
}
