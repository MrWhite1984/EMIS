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

namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Consumables
{
    public partial class AddConsumablesForm : Form
    {
        public AddConsumablesForm()
        {
            InitializeComponent();
            if (DataLoader_Consumables.GetAllConsumables().Count != 0)
                consumableCodeTextBox.Text = (Convert.ToInt32(DataLoader_Consumables.GetAllConsumables()[DataLoader_Consumables.GetAllConsumables().Count - 1][0]) + 1).ToString();
            else
                consumableCodeTextBox.Text = "1";
            foreach (var provider in DataLoader_Providers.GetAllProviders())
            {
                providerComboBox.Items.Add(provider[1]);
            }
        }

        private void addСonsumableButton_Click(object sender, EventArgs e)
        {
            Consumable consumable = new Consumable(Convert.ToInt32(consumableCodeTextBox.Text), consumableNameTextBox.Text, 0, consumableDescriptionTextBox.Text, DataLoader_Providers.GetProviderByName(providerComboBox.Text).ProviderCode);
            DataAdder_Consumables.AddNewConsumableToDB(consumable);
            this.Close();
        }
    }
}
