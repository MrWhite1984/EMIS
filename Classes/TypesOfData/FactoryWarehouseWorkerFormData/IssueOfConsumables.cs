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
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData
{
    class IssueOfConsumables
    {
        public int Id { get; set; }
        public int ConsumableCode { get; set; }
        public int WorkerCode { get; set; }
        public DateTime IssueDate { get; set; }

        public IssueOfConsumables(int id, int consumableCode, int workerCode, DateTime issueDate)
        {
            Id = id;
            ConsumableCode = consumableCode;
            WorkerCode = workerCode;
            IssueDate = issueDate;
        }

        public static void ExportIssueOfConsumablesToJson(string filePath)
        {
            filePath = filePath + @"\" + "IssueOfConsumables.json";
            File.Create(filePath).Close();
            List<IssueOfConsumables> issueOfConsumables = new List<IssueOfConsumables>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_IssueOfConsumables.GetAllIssueConsumables())
            {
                issueOfConsumables.Add(new IssueOfConsumables(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), Convert.ToInt32(data[1].TrimEnd(whiteSpace)), Convert.ToInt32(data[2].TrimEnd(whiteSpace)), Convert.ToDateTime(data[3].TrimEnd(whiteSpace))));
            }
            var serializedelements = JsonSerializer.Serialize(
                issueOfConsumables,
                typeof(List<IssueOfConsumables>),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }
        public static void ImportIssueOfConsumablesFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\IssueOfConsumables.json";
            List<IssueOfConsumables> issueOfConsumables = JsonSerializer.Deserialize<List<IssueOfConsumables>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < issueOfConsumables.Count(); counter++)
            {
                DataAdder_IssueOfConsumables.AddNewIssueConsumableToDB(issueOfConsumables[counter], conString);
            }
        }
    }
}
