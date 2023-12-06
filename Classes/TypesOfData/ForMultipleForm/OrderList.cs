using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;

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
    }
}
