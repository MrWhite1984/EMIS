using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.AdminForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.DirectorForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.StoreForm;

namespace Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData
{
    class Store
    {
        public int id { get; set; }
        public string address { get; set; }
        public int directorCode { get; set; }
        public int phone { get; set; }
        public string sellers { get; set; }
        public int warehouseWorkerCode { get; set; }
        public Store(int id, string address, int directorCode, int phone, string sellers, int warehouseWorkerCode)
        {
            this.id = id;
            this.address = address;
            this.directorCode = directorCode;
            this.phone = phone;
            this.sellers = sellers;
            this.warehouseWorkerCode = warehouseWorkerCode;
        }


        public static void ExportStoresToJson(string filePath)
        {
            filePath = filePath + @"\" + "Stores.json";
            File.Create(filePath).Close();
            List<Store> stores = new List<Store>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_Stores.GetAllStores())
            {
                stores.Add(new Store(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), data[1].TrimEnd(whiteSpace), Convert.ToInt32(data[2].TrimEnd(whiteSpace).Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]), Convert.ToInt32(data[3].TrimEnd(whiteSpace)), data[4].TrimEnd(whiteSpace), Convert.ToInt32(data[5].TrimEnd(whiteSpace).Split(' ', StringSplitOptions.RemoveEmptyEntries)[0])));
            }
            var serializedelements = JsonSerializer.Serialize(
                stores,
                typeof(List<Store>),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }
        public static void ImportStoresFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\Stores.json";
            List<Store> stores = JsonSerializer.Deserialize<List<Store>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < stores.Count(); counter++)
            {
                DataAdder_Stores.AddNewStoreToDB(stores[counter], conString);
            }
        }
    }
}
