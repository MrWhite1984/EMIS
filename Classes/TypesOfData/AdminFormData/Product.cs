using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.DirectorForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.DirectorForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData
{
    class Product
    {
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        

        public Product(int productCode, string productName, string productDescription, decimal productPrice)
        {
            ProductCode = productCode;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductPrice = productPrice;
        }

        public static void ExportProductsToJson(string filePath)
        {
            filePath = filePath + @"\" + "Products.json";
            File.Create(filePath).Close();
            List<Product> products = new List<Product>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_Products.GetAllProducts())
            {
                products.Add(new Product(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), data[1].TrimEnd(whiteSpace), data[2].TrimEnd(whiteSpace), Convert.ToDecimal(data[3].TrimEnd(whiteSpace))));
            }
            var serializedelements = JsonSerializer.Serialize(
                products,
                typeof(List<Product>),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }
        public static void ImportProductsFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\Products.json";
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < products.Count(); counter++)
            {
                DataAdder_Products.AddNewProductsToDB(counter + 1, products[counter], conString);
            }
        }
    }
}
