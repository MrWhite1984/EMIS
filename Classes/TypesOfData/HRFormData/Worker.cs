using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.AdminForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.HRForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.HRForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.StoreForm;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Classes.TypesOfData.HRFormData
{
    class Worker
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string FName { get; set; }
        public DateTime Birth { get; set; }
        public long PhoneNumber { get; set; }
        public string JobTitle { get; set; }
        public DateTime EmploymentDate { get; set; }
        public double Salary { get; set; }
        public long CheckingAccount { get; set; }

        public Worker(int id, string surname, string name, string fName, DateTime birth, long phoneNumber, string jobTitle, DateTime employmentDate, double salary, long checkingAccount)
        {
            Id = id;
            Surname = surname;
            Name = name;
            FName = fName;
            Birth = birth;
            PhoneNumber = phoneNumber;
            JobTitle = jobTitle;
            EmploymentDate = employmentDate;
            Salary = salary;
            CheckingAccount = checkingAccount;
        }

        public static void ExportWorkerToJson(string filePath)
        {
            filePath = filePath + @"\" + "Worker.json";
            File.Create(filePath).Close();
            List<Worker> worker = new List<Worker>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_Workers.GetAllWorkers())
            {
                worker.Add(new Worker(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), data[1].TrimEnd(whiteSpace), data[2].TrimEnd(whiteSpace), data[3].TrimEnd(whiteSpace), Convert.ToDateTime(data[4].TrimEnd(whiteSpace)), Convert.ToInt64(data[5].TrimEnd(whiteSpace)), data[6].TrimEnd(whiteSpace), Convert.ToDateTime(data[7].TrimEnd(whiteSpace)), Convert.ToDouble(data[8].TrimEnd(whiteSpace)), Convert.ToInt64(data[9].TrimEnd(whiteSpace))));
            }
            var serializedelements = JsonSerializer.Serialize(
                worker,
                typeof(List<Worker>),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }
        public static void ImportWorkerFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\Worker.json";
            List<Worker> worker = JsonSerializer.Deserialize<List<Worker>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < worker.Count(); counter++)
            {
                DataAdder_Workers.AddNewWorkerToDB(worker[counter].Id, worker[counter], conString);
            }
        }
    }
}
