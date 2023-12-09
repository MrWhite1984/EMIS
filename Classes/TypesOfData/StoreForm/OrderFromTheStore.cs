
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.StoreForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Classes.TypesOfData.StoreForm
{
    class OrderFromTheStore
    {
        public int orderCode { get; set; }
        public int store { get; set; }
        public DateTime date { get; set; }
        public OrderFromTheStore(int orderCode, int store, DateTime date)
        {
            this.orderCode = orderCode;
            this.store = store;
            this.date = date;
        }
        public static void ExportOrderFromTheStoreToJson(string filePath)
        {
            filePath = filePath + @"\" + "OrderFromTheStore.json";
            File.Create(filePath).Close();
            List<OrderFromTheStore> orderFromTheStore = new List<OrderFromTheStore>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_ProductsOrders.GetAllProductsOrders())
            {
                orderFromTheStore.Add(new OrderFromTheStore(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), Convert.ToInt32(data[1].TrimEnd(whiteSpace)), Convert.ToDateTime(data[2].TrimEnd(whiteSpace))));
            }
            var serializedelements = JsonSerializer.Serialize(
                orderFromTheStore,
                typeof(List<OrderFromTheStore>),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }
        public static void ImportOrderFromTheStoreFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\OrderFromTheStore.json";
            List<OrderFromTheStore> orderFromTheStore = JsonSerializer.Deserialize<List<OrderFromTheStore>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < orderFromTheStore.Count(); counter++)
            {
                DataAdder_ProductOrders.AddNewOrderToDB(orderFromTheStore[counter], conString);
            }
        }
    }
}
