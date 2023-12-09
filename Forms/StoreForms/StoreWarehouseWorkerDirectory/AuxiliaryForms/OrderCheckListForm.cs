using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataChangerDescendants.StoreForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.StoreForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher;
using Enterprise_Managment_IS.Classes.TypesOfData.Other;

namespace Enterprise_Managment_IS.Forms.StoreForms.StoreWarehouseWorkerDirectory.AuxiliaryForms
{
    public partial class OrderCheckListForm : Form
    {
        public OrderCheckListForm()
        {
            InitializeComponent();
        }

        private void OrderCheckListForm_Load(object sender, EventArgs e)
        {
            DataRefresher.RefreshTable(orderElementsDataGridView, DataLoader_ProductionOrderItems.GetAllItemsToOrderCheckListFormStore(orderCode));
        }

        private void orderElementsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                OrderItem orderItem = new OrderItem("", 0, false, false, Convert.ToBoolean(orderElementsDataGridView[5, e.RowIndex].Value));
                DataChanger_ProductOrderItems.ChangeOrderItemFromStoreInDB(Convert.ToInt32(orderElementsDataGridView[0, e.RowIndex].Value), orderItem);
            }
        }
    }
}
