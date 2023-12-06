using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Enterprise_Managment_IS.Classes.Other
{
    class Settings
    {
        public string connectionString { get; set; }
        public string orderListLocation { get; set; }
        public Dictionary<string, List<string>> comboBoxList { get; set; }


        public Settings(string connectionString)
        {
            this.connectionString = connectionString;
        }
        [JsonConstructor]
        public Settings(string connectionString,  Dictionary<string, List<string>> comboBoxList, string orderListLocation)
        {
            this.connectionString = connectionString;
            this.comboBoxList = comboBoxList;
            this.orderListLocation = orderListLocation;
        }

        public static Settings GetSettings()
        {
            string path = Directory.GetCurrentDirectory();
            string pathToFile = path + @"\Data\Settings.json";
            try
            {
                var settings = JsonSerializer.Deserialize<Settings>(File.ReadAllText(pathToFile));
                return settings;
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(DirectoryNotFoundException))
                {
                    MessageBox.Show("Ошибка пути к файлу");
                }
                return null;
            }
            
        }
        public void WriteSettings(Settings settings)
        {
            string path = Directory.GetCurrentDirectory();
            string pathToFile = path + @"\Data\Settings.json";
            if (settings.comboBoxList == null)
            {
                return;
            }
            var serializedelements = JsonSerializer.Serialize(
                settings,
                typeof(Settings),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(pathToFile, serializedelements);
        }
    }
}
