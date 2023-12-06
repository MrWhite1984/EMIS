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
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.DirectorForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Products
{
    public partial class AddFactoryProductForm : Form
    {
        public AddFactoryProductForm()
        {
            InitializeComponent();
        }
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            if (DataLoader_FactoryProducts.GetAllFactoryProducts().Count != 0)
                productCodeTextBox.Text = (Convert.ToInt32(DataLoader_FactoryProducts.GetAllFactoryProducts()[DataLoader_FactoryProducts.GetAllFactoryProducts().Count - 1][0]) + 1).ToString();
            else
                productCodeTextBox.Text = "1";
            List<string> products = new List<string>();
            foreach (var product in DataLoader_Products.GetAllProducts())
            {
                products.Add(product[0] + " " + product[1]);
            }
            productNameComboBox.Items.AddRange(products.ToArray());
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            if (productNameComboBox.Text == "")
            {
                MessageBox.Show("Введите название продукта");
            }
            else
            {
                if (CodeChecker(Convert.ToInt32(productNameComboBox.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]), DataLoader_FactoryProducts.GetAllFactoryProducts()))
                {
                    MessageBox.Show("Этот продукт уже существует в базе");
                }
                else
                {
                    FactoryProduct product = new FactoryProduct(Convert.ToInt32(productCodeTextBox.Text), Convert.ToInt32(productNameComboBox.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]), 0);
                    DataAdder_FactoryProducts.AddNewFactoryProductsToDB(product);
                    this.Close();
                }
            }
        }

        private bool CodeChecker(int code, List<string[]> strings)
        {
            if (strings.Count > 0)
            {
                foreach (var item in strings)
                {
                    if (Convert.ToInt32(item[1]) == code)
                        return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        
    }
}
