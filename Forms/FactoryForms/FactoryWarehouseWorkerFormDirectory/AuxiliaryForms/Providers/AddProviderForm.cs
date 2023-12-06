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

namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Providers
{
    public partial class AddProviderForm : Form
    {
        public AddProviderForm()
        {
            InitializeComponent();
            if (DataLoader_Providers.GetAllProviders().Count != 0)
                providerCodeTextBox.Text = (Convert.ToInt32(DataLoader_Providers.GetAllProviders()[DataLoader_Providers.GetAllProviders().Count - 1][0]) + 1).ToString();
            else
                providerCodeTextBox.Text = "1";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider(0, providerNameTextBox.Text, providerAddressTextBox.Text, providerDescriptionTextBox.Text);
            DataAdder_Providers.AddNewProviderToDB(Convert.ToInt32(providerCodeTextBox.Text), provider);
            this.Close();
        }
    }
}
