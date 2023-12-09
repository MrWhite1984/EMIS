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
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataChangerDescendants.StoreForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.StoreForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher;
using Enterprise_Managment_IS.Classes.TypesOfData.Other;

namespace Enterprise_Managment_IS.Forms.FactoryForms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Orders
{
    public partial class OrderChekListForm : Form
    {
        List<int> changedRows = new List<int>();
        public OrderChekListForm()
        {
            InitializeComponent();
        }

        private void OrderChekListForm_Load(object sender, EventArgs e)
        {
            DataRefresher.RefreshTable(orderListDataGridView, DataLoader_ProductionOrderItems.GetAllItemsToOrderCheckListForm(orderCode));
        }




        private void orderListDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                OrderItem orderItem = new OrderItem("", 0, Convert.ToBoolean(orderListDataGridView[3, e.RowIndex].Value), Convert.ToBoolean(orderListDataGridView[4, e.RowIndex].Value), false);
                DataChanger_ProductOrderItems.ChangeOrderItemFromFactoryInDB(Convert.ToInt32(orderListDataGridView[0, e.RowIndex].Value), orderItem);
            }
        }

    }
}
