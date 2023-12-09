using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.AdminForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.StoreForm;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Classes.TypesOfData.ForMultipleForm
{
    class OrderList
    {
        public string ProductName { get; set; }
        public int AmountOfProductInOrder { get; set; }
        public int AmountOfProductInShipment { get; set; }
        public int OrderExecutorCode { get; set; }
        public bool AtWork { get; set; }

        public OrderList (string productName, int amountOfProductInOrder, int amountOfProductInShipment, int orderExecutorCode, bool atWork)
        {
            ProductName = productName;
            AmountOfProductInOrder = amountOfProductInOrder;
            AmountOfProductInShipment = amountOfProductInShipment;
            OrderExecutorCode = orderExecutorCode;
            AtWork = atWork;
        }
        public static OrderList GetOrderList(string fileName)
        {
            string path = Settings.GetSettings().orderListLocation + fileName;
            try
            {
                var orderList = JsonSerializer.Deserialize<OrderList>(File.ReadAllText(path));
                return orderList;
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(DirectoryNotFoundException))
                {
                    MessageBox.Show("Ошибка пути к файлу");
                }
                return null;
            }

        }
        public void WriteOrderList(OrderList orderList, string fileName)
        {
            string path = Settings.GetSettings().orderListLocation + fileName;
            var serializedelements = JsonSerializer.Serialize(
                orderList,
                typeof(OrderList),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(path, serializedelements);
        }

        public static void ExportOrderListToJson(string filePath)
        {
            filePath = filePath + @"\" + "OrderList.json";
            File.Create(filePath).Close();
            List<OrderList> orderList = new List<OrderList>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_Stores.GetAllStores())
            {
                //orderList.Add(new OrderList(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), data[1].TrimEnd(whiteSpace), Convert.ToInt32(data[2].TrimEnd(whiteSpace)), Convert.ToInt32(data[3].TrimEnd(whiteSpace)), data[4].TrimEnd(whiteSpace), Convert.ToInt32(data[5].TrimEnd(whiteSpace))));
            }
            var serializedelements = JsonSerializer.Serialize(
                orderList,
                typeof(List<OrderList>),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }
        public static void ImpportStoresFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\Stores.json";
            List<OrderList> orderList = JsonSerializer.Deserialize<List<OrderList>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < orderList.Count(); counter++)
            {
                //DataAdder_OrderList.AddNewStoreToDB(orderList[counter], conString);
            }
        }
    }
}
