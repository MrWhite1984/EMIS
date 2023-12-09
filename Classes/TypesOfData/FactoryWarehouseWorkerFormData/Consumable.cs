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
    class Consumable
    {
        public int ConsumableCode { get; set; }
        public string ConsumableName { get; set; }
        public int AmountOfConsumable { get; set; }
        public string ConsumableDescription { get; set; }
        public int Provider { get; set; }

        public Consumable(int ConsumableCode, string ConsumableName, int AmountOfConsumable, string ConsumableDescription, int provider)
        {
            this.ConsumableCode = ConsumableCode;
            this.ConsumableName = ConsumableName;
            this.AmountOfConsumable = AmountOfConsumable;
            this.ConsumableDescription = ConsumableDescription;
            Provider = provider;
        }

        public static void ExportConsumablesToJson(string filePath)
        {
            filePath = filePath + @"\" + "Consumables.json";
            File.Create(filePath).Close();
            List<Consumable> consumables = new List<Consumable>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_Consumables.GetAllConsumables())
            {
                consumables.Add(new Consumable(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), data[1].TrimEnd(whiteSpace), Convert.ToInt32(data[2].TrimEnd(whiteSpace)), data[3].TrimEnd(whiteSpace), Convert.ToInt32(data[4])));
            }
            var serializedelements = JsonSerializer.Serialize(
                consumables,
                typeof(List<Consumable>),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }
        public static void ImportConsumablesFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\Consumables.json";
            List<Consumable> consumables = JsonSerializer.Deserialize<List<Consumable>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < consumables.Count(); counter++)
            {
                Consumable consumable = consumables[counter];
                consumable.ConsumableCode = counter + 1;
                DataAdder_Consumables.AddNewConsumableToDB(consumable, conString);
            }
        }
    }
}
