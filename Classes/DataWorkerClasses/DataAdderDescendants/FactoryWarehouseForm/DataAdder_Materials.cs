using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm
{
    class DataAdder_Materials
    {
        public static void AddNewMaterialToDB(Material material)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Materials(Material_code, Material_name, Amount_of_material, Material_description, Provider_code) VALUES(@material_code, @material_name, @amount_of_material, @material_description, @provider);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@material_code", SqlDbType.Int).Value = material.CodeMaterial;
            sqlCommand.Parameters.Add("@material_name", SqlDbType.VarChar, 60).Value = material.MaterialName;
            sqlCommand.Parameters.Add("@amount_of_material", SqlDbType.Int).Value = material.AmountOfMaterial;
            sqlCommand.Parameters.Add("@material_description", SqlDbType.VarChar, 250).Value = material.MaterialDescription;
            sqlCommand.Parameters.Add("@provider", SqlDbType.Int).Value = material.Provider;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public static void AddNewMaterialToDB(int materialCode, Material material, string connectionString)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO Materials(Material_code, Material_name, Amount_of_material, Material_description, Provider_code) VALUES(@material_code, @material_name, @amount_of_material, @material_description, @provider);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.Add("@material_code", SqlDbType.Int).Value = material.CodeMaterial;
            sqlCommand.Parameters.Add("@material_name", SqlDbType.VarChar, 60).Value = material.MaterialName;
            sqlCommand.Parameters.Add("@amount_of_material", SqlDbType.Int).Value = material.AmountOfMaterial;
            sqlCommand.Parameters.Add("@material_description", SqlDbType.VarChar, 250).Value = material.MaterialDescription;
            sqlCommand.Parameters.Add("@provider", SqlDbType.Int).Value = material.Provider;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
