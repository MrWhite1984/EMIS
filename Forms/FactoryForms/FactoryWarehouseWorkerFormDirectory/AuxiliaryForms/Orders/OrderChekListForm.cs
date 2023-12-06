using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.StoreForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher;

namespace Enterprise_Managment_IS.Forms.FactoryForms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Orders
{
    public partial class OrderChekListForm : Form
    {
        public OrderChekListForm()
        {
            InitializeComponent();
        }

        private void OrderChekListForm_Load(object sender, EventArgs e)
        {
            DataRefresher.RefreshTable(orderListDataGridView, DataLoader_ProductionOrderItems.GetAllItemsToOrderCheckListForm(orderCode));
        }
    }
}
