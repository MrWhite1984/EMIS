using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;

namespace Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData
{
    class Supply
    {
        public int SuplyCode { get; set; }
        public DateTime SupplyDate { get; set; }
        public string Material { get; set; }
        public int AmountOfMaterial { get; set; }
        public int Provider { get; set; }
        public string SupplyType { get; set; }
        public double SupplySum { get; set; }

        public Supply(int suplyCode, DateTime supplyDate, string material, int amountOfMaterial, int provider, string supplyType, double supplySum)
        {
            this.SuplyCode = suplyCode;
            this.SupplyDate = supplyDate;
            this.Material = material;
            this.AmountOfMaterial = amountOfMaterial;
            this.Provider = provider;
            this.SupplyType = supplyType;
            SupplySum = supplySum;
        }
        public static void ExportSuppliesToJson(string filePath)
        {
            filePath = filePath + @"\" + "Supplies.json";
            File.Create(filePath).Close();
            List<Supply> supplies = new List<Supply>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_Supplies.GetAllSupplies())
            {
                supplies.Add(new Supply(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), Convert.ToDateTime(data[1]), data[2].TrimEnd(whiteSpace), Convert.ToInt32(data[3].TrimEnd(whiteSpace)), Convert.ToInt32(data[4]), data[5].TrimEnd(whiteSpace), Convert.ToDouble(data[6])));
            }
            var serializedelements = JsonSerializer.Serialize(
                supplies,
                typeof(List<Supply>),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }
        public static void ImportSuppliesFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\Supplies.json";
            List<Supply> supplies = JsonSerializer.Deserialize<List<Supply>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < supplies.Count(); counter++)
            {
                DataAdder_Supplies.AddNewSuppliesImportToDB(supplies[counter], conString);
            }
        }

        public static void ExportCanceledSuppliesToJson(string filePath)
        {
            filePath = filePath + @"\" + "CanceledSupplies.json";
            File.Create(filePath).Close();
            List<Supply> supplies = new List<Supply>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_CanceledSupplies.GetAllCanceledSupplies())
            {
                supplies.Add(new Supply(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), Convert.ToDateTime(data[1]), data[2].TrimEnd(whiteSpace), Convert.ToInt32(data[3].TrimEnd(whiteSpace)), Convert.ToInt32(data[4]), data[5].TrimEnd(whiteSpace), Convert.ToDouble(data[6])));
            }
            var serializedelements = JsonSerializer.Serialize(
                supplies,
                typeof(List<Supply>),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }
        public static void ImportCanceledSuppliesFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\CanceledSupplies.json";
            List<Supply> supplies = JsonSerializer.Deserialize<List<Supply>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < supplies.Count(); counter++)
            {
                DataAdder_CanceledSupplies.AddNewCanceledSuppliesToDB(supplies[counter], conString);
            }
        }

        public static void ExportConductedSuppliesToJson(string filePath)
        {
            filePath = filePath + @"\" + "ConductedSupplies.json";
            File.Create(filePath).Close();
            List<Supply> supplies = new List<Supply>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_ConductedSupplies.GetAllConductedSupplies())
            {
                supplies.Add(new Supply(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), Convert.ToDateTime(data[1]), data[2].TrimEnd(whiteSpace), Convert.ToInt32(data[3].TrimEnd(whiteSpace)), Convert.ToInt32(data[4]), data[5].TrimEnd(whiteSpace), Convert.ToDouble(data[6])));
            }
            var serializedelements = JsonSerializer.Serialize(
                supplies,
                typeof(List<Supply>),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }
        public static void ImportConductedSuppliesFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\ConductedSupplies.json";
            List<Supply> supplies = JsonSerializer.Deserialize<List<Supply>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < supplies.Count(); counter++)
            {
                DataAdder_ConductedSupplies.AddNewConductedSuppliesToDB(supplies[counter], conString);
            }
        }
    }
}
