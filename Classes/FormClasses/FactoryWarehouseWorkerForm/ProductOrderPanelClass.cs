using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Forms.FactoryForms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Orders;

namespace Enterprise_Managment_IS.Classes.FormClasses.FactoryWarehouseWorkerForm
{
    class ProductOrderPanelClass
    {
        public static void showOrderInfo(DataGridView dataGridView)
        {
            //string path = dataGridView[1, dataGridView.CurrentRow.Index].Value.ToString();
            OrderChekListForm orderChekListForm = new OrderChekListForm();
            orderChekListForm.orderCode = Convert.ToInt32(dataGridView[0, dataGridView.CurrentRow.Index].Value);
            orderChekListForm.ShowDialog();
        }
    }
}
