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
    class IssueOfMaterials
    {
        public int Id { get; set; }
        public int MaterialCode { get; set; }
        public int WorkerCode { get; set; }
        public DateTime IssueDate { get; set; }

        public IssueOfMaterials (int id, int materialCode, int workerCode, DateTime issueDate)
        {
            Id = id;
            MaterialCode = materialCode;
            WorkerCode = workerCode;
            IssueDate = issueDate;
        }

        public static void ExportIssueOfMaterialsToJson(string filePath)
        {
            filePath = filePath + @"\" + "IssueOfMaterials.json";
            File.Create(filePath).Close();
            List<IssueOfMaterials> issueOfMaterials = new List<IssueOfMaterials>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_IssueOfMaterials.GetAllIssueMaterials())
            {
                issueOfMaterials.Add(new IssueOfMaterials(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), Convert.ToInt32(data[1].TrimEnd(whiteSpace)), Convert.ToInt32(data[2].TrimEnd(whiteSpace)), Convert.ToDateTime(data[3].TrimEnd(whiteSpace))));
            }
            var serializedelements = JsonSerializer.Serialize(
                issueOfMaterials,
                typeof(List<IssueOfMaterials>),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }
        public static void ImportIssueOfMaterialsFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\IssueOfMaterials.json";
            List<IssueOfMaterials> issueOfMaterials = JsonSerializer.Deserialize<List<IssueOfMaterials>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < issueOfMaterials.Count(); counter++)
            {
                DataAdder_IssueOfMaterials.AddNewIssueMaterialToDB(issueOfMaterials[counter], conString);
            }
        }
    }
}
