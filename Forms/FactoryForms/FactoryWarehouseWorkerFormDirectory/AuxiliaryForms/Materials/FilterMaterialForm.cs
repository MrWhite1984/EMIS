using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher;

namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms
{
    public partial class FilterMaterialForm : Form
    {
        public FilterMaterialForm()
        {
            InitializeComponent();
            List<string[]> providers = DataLoader_Providers.GetAllProviders();
            foreach (string[] provider in providers)
            {
                textToFilterComboBox.Items.Add(provider[1]);
            }
            
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (filterParametrRadioButton1.Checked)
            {
                DataRefresher.RefreshTable_Materials(materialDataGridView, DataLoader_Materials.GetMaterialsByPartOfName(textToFilterTextBox.Text));
            }
            else
            {
                DataRefresher.RefreshTable_Materials(materialDataGridView, DataLoader_Materials.GetMaterialsByProvider(Convert.ToInt32(DataLoader_Providers.GetProviderByName(textToFilterComboBox.Text).ProviderCode)));
            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DataRefresher.RefreshTable_Materials(materialDataGridView, DataLoader_Materials.GetAllMaterials());
            Close();
        }

        private void filterParametrRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (filterParametrRadioButton1.Checked)
            {
                textToFilterTextBox.Visible = true;
                textToFilterComboBox.Visible = false;
            }
            if (!filterParametrRadioButton1.Checked)
            {
                textToFilterTextBox.Visible = false;
                textToFilterComboBox.Visible = true;
            }
        }
    }
}
