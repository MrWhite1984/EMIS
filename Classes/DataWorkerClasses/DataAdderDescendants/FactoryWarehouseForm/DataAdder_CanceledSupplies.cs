﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm
{
    class DataAdder_CanceledSupplies
    {
        public static void AddNewCanceledSuppliesToDB(Supply supply)
        {
            string connectionString = Settings.GetSettings().connectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = "INSERT INTO CanceledSupplies(Supply_code, Supply_date, Material, Amount_of_material, Provider_code, Supply_type, Supply_sum) VALUES(@Supply_code, @Supply_date, @Supply_list, @AmountOfMaterial, @Provider_code, @Supply_type, @Supply_sum);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            if (DataLoader_CanceledSupplies.GetAllCanceledSupplies().Count != 0)
                sqlCommand.Parameters.Add("@Supply_code", SqlDbType.Int).Value = Convert.ToInt32(DataLoader_CanceledSupplies.GetAllCanceledSupplies()[DataLoader_CanceledSupplies.GetAllCanceledSupplies().Count - 1][0]) + 1;
            else
                sqlCommand.Parameters.Add("@Supply_code", SqlDbType.Int).Value = 1;
            sqlCommand.Parameters.Add("@Supply_date", SqlDbType.DateTime).Value = supply.SupplyDate;
            sqlCommand.Parameters.Add("@Supply_list", SqlDbType.VarChar, 70).Value = supply.Material;
            sqlCommand.Parameters.Add("@AmountOfMaterial", SqlDbType.Int).Value = supply.AmountOfMaterial;
            sqlCommand.Parameters.Add("@Provider_code", SqlDbType.Int).Value = supply.Provider;
            sqlCommand.Parameters.Add("@Supply_type", SqlDbType.VarChar, 50).Value = supply.SupplyType;
            sqlCommand.Parameters.Add("@Supply_sum", SqlDbType.Float).Value = supply.SupplySum;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public static void AddNewCanceledSuppliesToDB(Supply supply, string conStr)
        {
            SqlConnection sqlConnection = new SqlConnection(conStr);
            sqlConnection.Open();
            string query = "INSERT INTO CanceledSupplies(Supply_code, Supply_date, Material, Amount_of_material, Provider_code, Supply_type, Supply_sum) VALUES(@Supply_code, @Supply_date, @Supply_list, @AmountOfMaterial, @Provider_code, @Supply_type, @Supply_sum);";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            if (DataLoader_CanceledSupplies.GetAllCanceledSupplies().Count != 0)
                sqlCommand.Parameters.Add("@Supply_code", SqlDbType.Int).Value = Convert.ToInt32(DataLoader_CanceledSupplies.GetAllCanceledSupplies()[DataLoader_CanceledSupplies.GetAllCanceledSupplies().Count - 1][0]) + 1;
            else
                sqlCommand.Parameters.Add("@Supply_code", SqlDbType.Int).Value = 1;
            sqlCommand.Parameters.Add("@Supply_date", SqlDbType.DateTime).Value = supply.SupplyDate;
            sqlCommand.Parameters.Add("@Supply_list", SqlDbType.VarChar, 70).Value = supply.Material;
            sqlCommand.Parameters.Add("@AmountOfMaterial", SqlDbType.Int).Value = supply.AmountOfMaterial;
            sqlCommand.Parameters.Add("@Provider_code", SqlDbType.Int).Value = supply.Provider;
            sqlCommand.Parameters.Add("@Supply_type", SqlDbType.VarChar, 50).Value = supply.SupplyType;
            sqlCommand.Parameters.Add("@Supply_sum", SqlDbType.Float).Value = supply.SupplySum;
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
