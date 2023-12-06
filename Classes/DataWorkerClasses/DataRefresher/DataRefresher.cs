using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.DirectorForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.HRForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.StoreForm;

namespace Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher
{
    class DataRefresher
    {
        public static void RefreshTable(DataGridView dataGridView, List<string[]> data)
        {
            dataGridView.Rows.Clear();

            foreach (string[] partOfData in data)
            {
                dataGridView.Rows.Add(partOfData);
            }
        }
        public static void RefreshTable_Supplies(DataGridView dataGridView, List<string[]> data)
        {
            dataGridView.Rows.Clear();

            foreach (string[] partOfData in data)
            {
                if (partOfData[5] == "Материалы")
                {
                    partOfData[4] = DataLoader_Providers.GetProviderByCode(Convert.ToInt32(partOfData[4])).ProviderName;
                }
                else
                {
                    partOfData[4] = DataLoader_Providers.GetProviderByCode(Convert.ToInt32(partOfData[4])).ProviderName;
                }
            }
            foreach (string[] partOfData in data)
            {
                dataGridView.Rows.Add(partOfData);
            }
        }
        public static void RefreshTable_Materials(DataGridView dataGridView, List<string[]> data)
        {
            dataGridView.Rows.Clear();

            foreach (string[] partOfData in data)
            {
                partOfData[4] = DataLoader_Providers.GetProviderByCode(Convert.ToInt32(partOfData[4])).ProviderName;
            }
            foreach (string[] partOfData in data)
            {
                dataGridView.Rows.Add(partOfData);
            }
        }
        public static void RefreshTable_Users(DataGridView dataGridView, List<string[]> data)
        {
            dataGridView.Rows.Clear();

            foreach (string[] partOfData in data)
            {
                partOfData[1] = partOfData[1] + " " + DataLoader_Workers.GetWorkerByCode(Convert.ToInt32(partOfData[1])).Surname + " " + DataLoader_Workers.GetWorkerByCode(Convert.ToInt32(partOfData[1])).Name + " " + DataLoader_Workers.GetWorkerByCode(Convert.ToInt32(partOfData[1])).FName;
            }
            foreach (string[] partOfData in data)
            {
                dataGridView.Rows.Add(partOfData);
            }
        }
        public static void RefreshTable_FactoryProduct(DataGridView dataGridView, List<string[]> data)
        {
            dataGridView.Rows.Clear();

            foreach (string[] partOfData in data)
            {
                partOfData[1] = partOfData[1] + " " + DataLoader_Products.GetProductByCode(Convert.ToInt32(partOfData[1])).ProductName;
            }
            foreach (string[] partOfData in data)
            {
                dataGridView.Rows.Add(partOfData);
            }
        }
        public static void RefreshTable_ProductOrders(DataGridView dataGridView, List<string[]> data)
        {
            dataGridView.Rows.Clear();

            foreach (string[] partOfData in data)
            {
                partOfData[1] = partOfData[1] + " " + DataLoader_Stores.GetStoreByCode(Convert.ToInt32(partOfData[1]))[0][1];// DataLoader_Products.GetProductByCode(Convert.ToInt32(partOfData[1])).ProductName;
            }
            foreach (string[] partOfData in data)
            {
                dataGridView.Rows.Add(partOfData);
            }
        }
    }
}
