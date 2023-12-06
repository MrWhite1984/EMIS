using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.DirectorForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Products
{
    public partial class FilterProductForm : Form
    {
        public FilterProductForm()
        {
            InitializeComponent();
        }


        private void applyButton_Click(object sender, EventArgs e)
        {
            if(filterTextTextBox.Text != "")
            {
                List<FactoryProduct> products = new List<FactoryProduct>();
                List<string[]> strings2 = DataLoader_Products.GetProductsByPartOfName(filterTextTextBox.Text);                
                string[] data = new string[3];
                List<string[]> strings3 = new List<string[]>();
                foreach (var product in strings2)
                {
                    products.Add(DataLoader_FactoryProducts.GetFactoryProductByCode(Convert.ToInt32(product[0])));
                }
                foreach (var product in products)
                {
                    var s = new string[3];
                    s[0] = product.ID.ToString();
                    s[1] = product.ProductCode + " " + DataLoader_Products.GetProductByCode(product.ProductCode).ProductName;
                    s[2] = product.AmountOfProduct.ToString();
                    strings3.Add(s);
                }
                DataRefresher.RefreshTable(productDataGridView, strings3);
            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DataRefresher.RefreshTable_FactoryProduct(productDataGridView, DataLoader_FactoryProducts.GetAllFactoryProducts());
            Close();
        }
    }
}
