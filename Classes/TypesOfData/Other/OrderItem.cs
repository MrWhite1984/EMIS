using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Classes.TypesOfData.Other
{
    class OrderItem
    {
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

        public static void WriteOrderItemsToJson(List<OrderItem> orderItems,string store, string fileName)
        {
            File.WriteAllText(Settings.GetSettings().orderListLocation + "/" + fileName, store + "\n" + JsonSerializer.Serialize<List<OrderItem>>(orderItems));
        }
    }
}
