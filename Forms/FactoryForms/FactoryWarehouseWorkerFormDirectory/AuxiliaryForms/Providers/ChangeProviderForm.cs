using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataChangerDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.TypesOfData;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Providers
{
    public partial class ChangeProviderForm : Form
    {
        public ChangeProviderForm()
        {
            InitializeComponent();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            DataChanger_Providers.ChangeProviderInDB(Convert.ToInt32(providerCodeTextBox.Text), new Provider(0, providerNameTextBox.Text, providerAddressTextBox.Text, providerDescriptionTextBox.Text));
            this.Close();
        }

        private void ChangeProviderForm_Load(object sender, EventArgs e)
        {
            List<string[]> providers = DataLoader_Providers.GetAllProviders();
            providerCodeTextBox.Text = providers[index][0].TrimEnd(' ');
            providerNameTextBox.Text = providers[index][1].TrimEnd(' ');
            providerAddressTextBox.Text = providers[index][2].TrimEnd(' ');
            providerDescriptionTextBox.Text = providers[index][3].TrimEnd(' ');
        }
    }
}
