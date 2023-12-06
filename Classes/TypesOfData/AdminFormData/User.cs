using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.AdminForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.AdminForm;

namespace Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData
{
    class User
    {
        public int Id { get; set; }
        public int WorkerCode { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }



        public User (int id, int workerCode, string logIn, string password)
        {
            Id = id;
            WorkerCode = workerCode;
            Login = logIn;
            Password = password;
        }

        public static void ExportUsersToJson(string filePath)
        {
            filePath = filePath + @"\" + "Users.json";
            File.Create(filePath).Close();
            List<User> users = new List<User>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_Users.GetAllUsers())
            {
                users.Add(new User(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), Convert.ToInt32(data[1].TrimEnd(whiteSpace)), data[2].TrimEnd(whiteSpace), data[3].TrimEnd(whiteSpace)));
            }
            var serializedelements = JsonSerializer.Serialize(
                users,
                typeof(List<User>),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }

        public static void ImpportUsersFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\Users.json";
            List<User> users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < users.Count(); counter++)
            {
                DataAdder_Users.AddNewUserToDB(counter + 1, users[counter], conString);
            }
        }

        [JsonConstructor]
        public User(int workerCode, string logIn, string password)
        {
            WorkerCode = workerCode;
            Login = logIn;
            Password = password;
        }

    }
}
