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
using Enterprise_Managment_IS.Classes.TypesOfData.HRFormData;
using Enterprise_Managment_IS.Classes.TypesOfData.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.StoreForm;

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
            string pathToSave = specifyThePathToTheSaveLocationTextBox.Text + @"\" + directoryNameTextBox.Text;
            Directory.CreateDirectory(pathToSave);
            Product.ExportProductsToJson(pathToSave);
            Store.ExportStoresToJson(pathToSave);
            User.ExportUsersToJson(pathToSave);
            Consumable.ExportConsumablesToJson(pathToSave);
            FactoryProduct.ExportProductsToJson(pathToSave);
            DefectiveFactoryProducts.ExportDefectiveFactoryProductsToJson(pathToSave);
            IssueOfConsumables.ExportIssueOfConsumablesToJson(pathToSave);
            IssueOfMaterials.ExportIssueOfMaterialsToJson(pathToSave);
            Material.ExportMaterialsToJson(pathToSave);
            Provider.ExportProvidersToJson(pathToSave);
            Supply.ExportSuppliesToJson(pathToSave);
            Supply.ExportCanceledSuppliesToJson(pathToSave);
            Supply.ExportConductedSuppliesToJson(pathToSave);
            Worker.ExportWorkerToJson(pathToSave);
            OrderFromTheStore.ExportOrderFromTheStoreToJson(pathToSave);
            OrderItem.ExportOrderItemToJson(pathToSave);
            Close();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            specifyThePathToTheSaveLocationTextBox.Text = folderBrowserDialog.SelectedPath;
        }
    }
}
