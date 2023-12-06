using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.StoreForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.DirectorForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.StoreForm;
using Enterprise_Managment_IS.Classes.TypesOfData.ForMultipleForm;
using Enterprise_Managment_IS.Classes.TypesOfData.Other;

namespace Enterprise_Managment_IS.Forms.StoreForms.StoreWarehouseWorkerDirectory.AuxiliaryForms
{
    public partial class CreateOrderProductForm : Form
    {
        List<string> products = new List<string>();
        List<string> stores = new List<string>();
        public CreateOrderProductForm()
        {
            InitializeComponent();
        }
        private void CreateOrderProductForm_Load(object sender, EventArgs e)
        {
            foreach (var product in DataLoader_Products.GetAllProducts())
            {
                products.Add(product[0] + " " + product[1]);
            }
            productComboBoxBindingSource.DataSource = products;
            foreach (var store in DataLoader_Stores.GetAllStores())
            {
                stores.Add(store[0] + " " + store[1]);
            }
            storesComboBoxBindingSource.DataSource = stores;
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            DataAdder_ProductOrders.AddNewOrderToDB(Convert.ToInt32(StoreComboBox.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]));
            int orderCode = DataLoader_ProductsOrders.GetAllProductsOrders().Count();
            foreach (DataGridViewRow items in productOrderItemDataGridView.Rows)
            {
                if (items.Cells[0].Value != null)
                {
                    DataAdder_ProductOrderItems.AddNewItemToDB(new OrderItem(items.Cells[0].Value.ToString(), Convert.ToInt32(items.Cells[1].Value), false, false, false), orderCode);
                }
            }
            this.Close();
        }

    }
}
