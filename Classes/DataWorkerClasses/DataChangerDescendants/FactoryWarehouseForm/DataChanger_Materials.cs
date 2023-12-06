using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataChangerDescendants.FactoryWarehouseForm
{
    class DataChanger_Materials
    {
        public static void ChangeMaterialInDB(int materialCode, Material material)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "UPDATE Materials SET  Amount_of_material = @AmountOfMaterial WHERE Material_code = @materialCode;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@materialCode", SqlDbType.Int).Value = materialCode;
            sqlCommand.Parameters.Add("@AmountOfMaterial", SqlDbType.VarChar, 30).Value = material.AmountOfMaterial;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public static void ApplyASupply(Material material, Supply supply)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "UPDATE Materials SET  Amount_of_material = @AmountOfMaterial WHERE Material_code = @materialCode;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@materialCode", SqlDbType.Int).Value = material.CodeMaterial;
            sqlCommand.Parameters.Add("@AmountOfMaterial", SqlDbType.VarChar, 30).Value = material.AmountOfMaterial + supply.AmountOfMaterial;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
