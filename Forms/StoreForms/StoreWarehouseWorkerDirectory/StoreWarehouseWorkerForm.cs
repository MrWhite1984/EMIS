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
using Enterprise_Managment_IS.Classes.FormClasses.FactoryWarehouseWorkerForm;
using Enterprise_Managment_IS.Forms.StoreForms.StoreWarehouseWorkerDirectory.AuxiliaryForms;

namespace Enterprise_Managment_IS.Forms.StoreWarehouseWorkerDirectory
{
    public partial class StoreWarehouseWorkerForm : Form
    {
        public StoreWarehouseWorkerForm()
        {
            InitializeComponent();
        }
        private void StoreWarehouseWorkerForm_Load(object sender, EventArgs e)
        {
            panels = new List<Panel>()
            {
                productionOrderPanel
            };
        }

        private void ordersToFactoryButton_Click(object sender, EventArgs e)
        {
            PanelsHandlerClass.HideAllPanels(panels);
            productionOrderPanel.Visible = true;
            DataRefresher.RefreshTable_ProductOrders(productionOrderDataGridView, DataLoader_ProductsOrders.GetAllProductsOrders());
        }

        private void createOrder_Click(object sender, EventArgs e)
        {
            CreateOrderProductForm createOrderProductForm = new CreateOrderProductForm();
            createOrderProductForm.ShowDialog();
            DataRefresher.RefreshTable_ProductOrders(productionOrderDataGridView, DataLoader_ProductsOrders.GetAllProductsOrders());
        }

        private void StoreWarehouseWorkerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!devMode)
            {
                Application.Exit();
            }
        }
    }
}
