using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.DirectorForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData
{
    class FactoryProduct
    {
        public int ID { get; set; }
        public int ProductCode { get; set; }
        public int AmountOfProduct { get; set; }
        public FactoryProduct (int id, int productCode, int amountOfProduct)
        {
            ID = id;
            ProductCode = productCode;
            AmountOfProduct = amountOfProduct;
        }

        public static void ExportProductsToJson(string filePath)
        {
            filePath = filePath + @"\" + "FactoryProducts.json";
            File.Create(filePath).Close();
            List<FactoryProduct> products = new List<FactoryProduct>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_FactoryProducts.GetAllFactoryProducts())
            {
                products.Add(new FactoryProduct(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), Convert.ToInt32(data[1].TrimEnd(whiteSpace)), Convert.ToInt32(data[2].TrimEnd(whiteSpace))));
            }
            var serializedelements = JsonSerializer.Serialize(
                products,
                typeof(List<FactoryProduct>),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }
        public static void ImportProductsFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\FactoryProducts.json";
            List<FactoryProduct> products = JsonSerializer.Deserialize<List<FactoryProduct>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < products.Count(); counter++)
            {
                DataAdder_FactoryProducts.AddNewFactoryProductsToDB(counter + 1, products[counter], conString);
            }
        }

        
    }
}
