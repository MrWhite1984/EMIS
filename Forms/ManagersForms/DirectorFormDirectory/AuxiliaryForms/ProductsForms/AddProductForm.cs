using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.DirectorForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.DirectorForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Forms.DirectorFormDirectory.AuxiliaryForms.ProductsForms
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            if (DataLoader_Products.GetAllProducts().Count != 0)
                productCodeTextBox.Text = (Convert.ToInt32(DataLoader_Products.GetAllProducts()[DataLoader_Products.GetAllProducts().Count - 1][0]) + 1).ToString();
            else
                productCodeTextBox.Text = "1";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string sPrice = "";
            if (productPriceTextBox.Text.Split('.', StringSplitOptions.RemoveEmptyEntries).Length > 1)
            {
                sPrice = productPriceTextBox.Text.Split('.', StringSplitOptions.RemoveEmptyEntries)[0] + ',' + productPriceTextBox.Text.Split('.', StringSplitOptions.RemoveEmptyEntries)[1];
            }
            else
            {
                sPrice = productPriceTextBox.Text;
            }
            decimal price = Convert.ToDecimal(sPrice);
            DataAdder_Products.AddNewProductsToDB(new Product(Convert.ToInt32(productCodeTextBox.Text), productNameTextBox.Text, productDescriptionTextBox.Text, price));
            this.Close();
        }
    }
}
