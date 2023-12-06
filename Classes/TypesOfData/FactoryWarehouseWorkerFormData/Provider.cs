using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;

namespace Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData
{
    class Provider
    {
        public int ProviderCode { get; set; }
        public string ProviderName { get; set; }
        public string ProviderAddress { get; set; }
        public string ProviderDescription { get; set; }

        public Provider(int providerCode, string providerName, string providerAddress, string providerDescription)
        {
            ProviderCode = providerCode;
            ProviderName = providerName;
            ProviderAddress = providerAddress;
            ProviderDescription = providerDescription;
        }

        public static void ExportProvidersToJson(string filePath)
        {
            filePath = filePath + @"\" + "Providers.json";
            File.Create(filePath).Close();
            List<Provider> providers = new List<Provider>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_Providers.GetAllProviders())
            {
                providers.Add(new Provider(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), data[1].TrimEnd(whiteSpace), data[2].TrimEnd(whiteSpace), data[3].TrimEnd(whiteSpace)));
            }
            var serializedelements = JsonSerializer.Serialize(
                providers,
                typeof(List<Provider>),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }
        public static void ImpportSuppliesFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\Providers.json";
            List<Provider> providers = JsonSerializer.Deserialize<List<Provider>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < providers.Count(); counter++)
            {
                Provider provider = providers[counter];
                provider.ProviderCode = counter + 1;
                DataAdder_Providers.AddNewProviderToDB(provider.ProviderCode, provider, conString);
            }
        }
    }
}
