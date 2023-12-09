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
    class Material
    {
        public int CodeMaterial { get; set; }
        public string MaterialName { get; set; }
        public int AmountOfMaterial { get; set; }
        public string MaterialDescription { get; set; }
        public int Provider { get; set; }

        public Material(int codeMaterial, string materialName, int amountOfMaterial, string materialDescription, int provider)
        {
            CodeMaterial = codeMaterial;
            MaterialName = materialName;
            AmountOfMaterial = amountOfMaterial;
            MaterialDescription = materialDescription;
            Provider = provider;
        }

        public static void ExportMaterialsToJson(string filePath)
        {
            filePath = filePath + @"\" + "Materials.json";
            File.Create(filePath).Close();
            List<Material> materials = new List<Material>();
            char whiteSpace = ' ';
            foreach (var data in DataLoader_Materials.GetAllMaterials())
            {
                materials.Add(new Material(Convert.ToInt32(data[0].TrimEnd(whiteSpace)), data[1].TrimEnd(whiteSpace), Convert.ToInt32(data[2].TrimEnd(whiteSpace)), data[3].TrimEnd(whiteSpace), Convert.ToInt32(data[4])));
            }
            var serializedelements = JsonSerializer.Serialize(
                materials,
                typeof(List<Material>),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

            File.WriteAllText(filePath, serializedelements);
        }
        public static void ImportMaterialsFromJson(string filePath, string conString)
        {
            filePath = filePath + @"\Materials.json";
            List<Material> materials = JsonSerializer.Deserialize<List<Material>>(File.ReadAllText(filePath));
            for (int counter = 0; counter < materials.Count(); counter++)
            {
                DataAdder_Materials.AddNewMaterialToDB(counter + 1, materials[counter], conString);
            }
        }

        public static Material GetMaterialByName(string materialName, List<string[]> materials)
        {
            foreach (string[] material in materials)
            {
                if (material[1] == materialName)
                {
                    return new Material(Convert.ToInt32(material[0]), material[1], Convert.ToInt32(material[2]), material[3], Convert.ToInt32(material[4]));
                }
            }
            return null;
        }

        public static string MaterialsInSupply(string materialName, int amountOfMaterial, List<string[]> materials)
        {
            Material material = GetMaterialByName(materialName, materials);
            return $"{material.CodeMaterial}<{amountOfMaterial}>";
        }
    }
}
