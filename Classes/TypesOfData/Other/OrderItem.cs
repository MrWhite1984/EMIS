using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.HRForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.StoreForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.HRForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.StoreForm;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;
using Enterprise_Managment_IS.Classes.TypesOfData.HRFormData;

namespace Enterprise_Managment_IS.Classes.TypesOfData.Other
{
    class OrderItem
    {
        public int code { get; set; }
        public int orderCode { get; set; }
        public string productName { get; set; }
        public int amount { get; set; }
        public bool isProduced { get; set; }
        public bool isLoad { get; set; }
        public bool isReceived { get; set; }
        public OrderItem(string productName, int amount, bool isProduced, bool isLoad, bool isReceived)
        {
            this.productName = productName;
            this.amount = amount;
            this.isProduced = isProduced;
            this.isLoad = isLoad;
            this.isReceived = isReceived;
        }

        [JsonConstructor]
        public OrderItem(int code, int orderCode, string productName, int amount, bool isProduced, bool isLoad, bool isReceived)
        {
            this.code = code;
            this.orderCode = orderCode;
            this.productName = productName;
            this.amount = amount;
            this.isProduced = isProduced;
            this.isLoad = isLoad;
            this.isReceived = isReceived;
        }
        

        public static void WriteOrderItemsToJson(List<OrderItem> orderItems,string store, string fileName)
        {
            File.WriteAllText(Settings.GetSettings().orderListLocation + "/" + fileName, store + "\n" + JsonSerializer.Serialize<List<OrderItem>>(orderItems));
        }

        public static void ExportOrderItemToJson(string filePath)
        {
            filePath = filePath + @"\" + "OrderItem.json";
            File.Create(filePath).Close();
            List<OrderItem> orderItem = new List<OrderItem>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_ProductionOrderItems.GetAllItems())
            {
                orderItem.Add(new OrderItem(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), Convert.ToInt32(data[1].TrimEnd(whiteSpace)), data[2].TrimEnd(whiteSpace), Convert.ToInt32(data[3].TrimEnd(whiteSpace)), Convert.ToBoolean(data[4].TrimEnd(whiteSpace)), Convert.ToBoolean(data[5].TrimEnd(whiteSpace)), Convert.ToBoolean(data[6].TrimEnd(whiteSpace))));
            }            
            var serializedelements = JsonSerializer.Serialize(
                orderItem,
                orderItem.GetType(),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }
        
        public static void ImportOrderItemFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\OrderItem.json";
            List<OrderItem> orderItem = JsonSerializer.Deserialize<List<OrderItem>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < orderItem.Count(); counter++)
            {
                DataAdder_ProductOrderItems.AddNewItemToDB(orderItem[counter], orderItem[counter].code, conString);
            }
        }

        
    }
}
