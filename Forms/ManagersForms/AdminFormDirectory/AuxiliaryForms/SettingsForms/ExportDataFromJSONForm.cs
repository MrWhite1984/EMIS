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
    public partial class ExportDataFromJSONForm : Form
    {
        public ExportDataFromJSONForm()
        {
            InitializeComponent();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            (string, string) pathAndConnStr = (pathToDirectoryTextBox.Text, connectionStringTextBox.Text);
            Worker.ImportWorkerFromJson(pathAndConnStr.Item1, pathAndConnStr.Item2);
            User.ImportUsersFromJson(pathAndConnStr.Item1, pathAndConnStr.Item2);
            Provider.ImportSuppliesFromJson(pathAndConnStr.Item1, pathAndConnStr.Item2);
            Material.ImportMaterialsFromJson(pathAndConnStr.Item1, pathAndConnStr.Item2);
            Consumable.ImportConsumablesFromJson(pathAndConnStr.Item1, pathAndConnStr.Item2);
            Supply.ImportSuppliesFromJson(pathAndConnStr.Item1, pathAndConnStr.Item2);
            Supply.ImportCanceledSuppliesFromJson(pathAndConnStr.Item1, pathAndConnStr.Item2);
            Supply.ImportConductedSuppliesFromJson(pathAndConnStr.Item1, pathAndConnStr.Item2);
            Product.ImportProductsFromJson(pathAndConnStr.Item1, pathAndConnStr.Item2);
            FactoryProduct.ImportProductsFromJson(pathAndConnStr.Item1, pathAndConnStr.Item2);
            DefectiveFactoryProducts.ImportDefectiveFactoryProductsFromJson(pathAndConnStr.Item1, pathAndConnStr.Item2);
            Store.ImportStoresFromJson(pathAndConnStr.Item1, pathAndConnStr.Item2);
            IssueOfConsumables.ImportIssueOfConsumablesFromJson(pathAndConnStr.Item1, pathAndConnStr.Item2);
            IssueOfMaterials.ImportIssueOfMaterialsFromJson(pathAndConnStr.Item1, pathAndConnStr.Item2);
            OrderFromTheStore.ImportOrderFromTheStoreFromJson(pathAndConnStr.Item1, pathAndConnStr.Item2);
            OrderItem.ImportOrderItemFromJson(pathAndConnStr.Item1, pathAndConnStr.Item2);
            Close();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            pathToDirectoryTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void createConnStrButton_Click(object sender, EventArgs e)
        {
            CreateConnStringForm createConnStringForm = new CreateConnStringForm();
            createConnStringForm.ShowDialog();
            connectionStringTextBox.Text = CreateConnStringFormData.newConnectionString;
        }

    }
}
