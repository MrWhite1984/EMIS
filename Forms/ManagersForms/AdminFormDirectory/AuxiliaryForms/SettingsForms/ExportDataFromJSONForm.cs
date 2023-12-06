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
    public partial class ExportDataFromJSONForm : Form
    {
        public ExportDataFromJSONForm()
        {
            InitializeComponent();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            User.ImpportUsersFromJson(pathToDirectoryTextBox.Text, connectionStringTextBox.Text);
            Material.ImpportMaterialsFromJson(pathToDirectoryTextBox.Text, connectionStringTextBox.Text);
            Consumable.ImpportConsumablesFromJson(pathToDirectoryTextBox.Text, connectionStringTextBox.Text);
            Supply.ImpportSuppliesFromJson(pathToDirectoryTextBox.Text, connectionStringTextBox.Text);
            Supply.ImpportSuppliesFromJson(pathToDirectoryTextBox.Text, connectionStringTextBox.Text);
            Supply.ImpportSuppliesFromJson(pathToDirectoryTextBox.Text, connectionStringTextBox.Text);
            Provider.ImpportSuppliesFromJson(pathToDirectoryTextBox.Text, connectionStringTextBox.Text);
            Product.ImpportProductsFromJson(pathToDirectoryTextBox.Text, connectionStringTextBox.Text);
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
