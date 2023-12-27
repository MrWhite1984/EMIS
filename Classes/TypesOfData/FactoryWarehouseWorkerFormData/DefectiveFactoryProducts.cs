using System.Text.Json;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;

namespace Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData
{
    class DefectiveFactoryProducts
    {
        public int ID { get; set; }
        public int ProductCode { get; set; }
        public int AmountOfProduct { get; set; }
        public string defect { get; set; }
        public DateTime date { get; set; }
        public DefectiveFactoryProducts(int id, int productCode, int amountOfProduct, string defect, DateTime date)
        {
            ID = id;
            ProductCode = productCode;
            AmountOfProduct = amountOfProduct;
            this.defect = defect;
            this.date = date;
        }
        public static void ExportDefectiveFactoryProductsToJson(string filePath)
        {
            filePath = filePath + @"\" + "DefectiveFactoryProducts.json";
            File.Create(filePath).Close();
            List<DefectiveFactoryProducts> products = new List<DefectiveFactoryProducts>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_DefectiveFactoryProducts.GetAllDefectiveFactoryProducts())
            {
                products.Add(new DefectiveFactoryProducts(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), Convert.ToInt32(data[1].TrimEnd(whiteSpace)), Convert.ToInt32(data[2].TrimEnd(whiteSpace)), data[3].TrimEnd(whiteSpace), Convert.ToDateTime(data[4].TrimEnd(whiteSpace))));
            }
            var serializedelements = JsonSerializer.Serialize(
                products,
                typeof(List<DefectiveFactoryProducts>),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }
        public static void ImportDefectiveFactoryProductsFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\DefectiveFactoryProducts.json";
            List<DefectiveFactoryProducts> products = JsonSerializer.Deserialize<List<DefectiveFactoryProducts>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < products.Count(); counter++)
            {
                DataAdder_DefectiveFactoryProducts.AddNewDefectiveFactoryProductsToDB(counter + 1, products[counter], conString);
            }
        }
    }
}
