using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Forms.AdminFormDirectory.SettingsForms
{
    public partial class ExportDataFromDataBaseForm : Form
    {
        public ExportDataFromDataBaseForm()
        {
            InitializeComponent();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(specifyThePathToTheSaveLocationTextBox.Text + @"\" + directoryNameTextBox.Text);
            User.ExportUsersToJson(specifyThePathToTheSaveLocationTextBox.Text + @"\" + directoryNameTextBox.Text);
            Material.ExportMaterialsToJson(specifyThePathToTheSaveLocationTextBox.Text +@"\" + directoryNameTextBox.Text);
            Consumable.ExportConsumablesToJson(specifyThePathToTheSaveLocationTextBox.Text + @"\" + directoryNameTextBox.Text);
            Supply.ExportSuppliesToJson(specifyThePathToTheSaveLocationTextBox.Text + @"\" + directoryNameTextBox.Text);
            Supply.ExportCanceledSuppliesToJson(specifyThePathToTheSaveLocationTextBox.Text + @"\" + directoryNameTextBox.Text);
            Supply.ExportSuppliesToJson(specifyThePathToTheSaveLocationTextBox.Text + @"\" + directoryNameTextBox.Text);
            Provider.ExportProvidersToJson(specifyThePathToTheSaveLocationTextBox.Text + @"\" + directoryNameTextBox.Text);
            Product.ExportProductsToJson(specifyThePathToTheSaveLocationTextBox.Text + @"\" + directoryNameTextBox.Text);

            Close();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            specifyThePathToTheSaveLocationTextBox.Text = folderBrowserDialog.SelectedPath;
        }
    }
}
