using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms
{
    public partial class AddMaterialForm : Form
    {
        public AddMaterialForm()
        {
            InitializeComponent();            
        }
        private void AddMaterialForm_Load(object sender, EventArgs e)
        {
            if (DataLoader_Materials.GetAllMaterials().Count != 0)
                materialCodeTextBox.Text = (Convert.ToInt32(DataLoader_Materials.GetAllMaterials()[DataLoader_Materials.GetAllMaterials().Count - 1][0]) + 1).ToString();
            else
                materialCodeTextBox.Text = "1";
            foreach (var provider in DataLoader_Providers.GetAllProviders())
            {
                providerComboBox.Items.Add(provider[1]);
            }
        }

        private void addMaterialButton_Click(object sender, EventArgs e)
        {
            if (materialNameComboBox.Text == "")
            {
                MessageBox.Show("Введите название материала");
            }
            else if(providerComboBox.Text == "")
            {
                MessageBox.Show("Выберите поставщика");
            }
            else
            {
                Material newMaterial = new Material(Convert.ToInt32(materialCodeTextBox.Text), materialNameComboBox.Text, 0, materialDescriptionTextBox.Text, DataLoader_Providers.GetProviderByName(providerComboBox.Text).ProviderCode);
                DataAdder_Materials.AddNewMaterialToDB(newMaterial);
                this.Close();
            }
        }

        
    }
}
