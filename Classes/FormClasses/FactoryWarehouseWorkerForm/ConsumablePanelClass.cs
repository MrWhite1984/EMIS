using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms;
using Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Consumables;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataDeleterDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher;

namespace Enterprise_Managment_IS.Classes.FormClasses.FactoryWarehouseWorkerForm
{
    class ConsumablePanelClass
    {
        public static void addConsumableButton_Click(DataGridView consumablesDataGridView)
        {
            AddConsumablesForm addConsumablesForm = new AddConsumablesForm();
            addConsumablesForm.ShowDialog();
            DataRefresher.RefreshTable_Materials(consumablesDataGridView, DataLoader_Consumables.GetAllConsumables());
        }
        public static void releaseConsumableButton_Click(DataGridView consumablesDataGridView)
        {
            if (Convert.ToInt32(consumablesDataGridView[2, consumablesDataGridView.CurrentRow.Index].Value) != 0)
            {
                ReleaseConsumablesForm releaseConsumableForm = new ReleaseConsumablesForm
                {
                    consumableCode = Convert.ToInt32(consumablesDataGridView[0, consumablesDataGridView.CurrentRow.Index].Value)
                };
                releaseConsumableForm.ShowDialog();
                DataRefresher.RefreshTable_Materials(consumablesDataGridView, DataLoader_Consumables.GetAllConsumables());
            }
            else
            {
                MessageBox.Show("Запрашиваемый расходник отсутствует");
            }
        }
        public static void filterConsumableButton_Click(DataGridView consumablesDataGridView)
        {
            FilterConsumableForm filterConsumableForm = new FilterConsumableForm
            {
                consumableDataGridView = consumablesDataGridView
            };
            filterConsumableForm.ShowDialog();
        }
        public static void deleteConsumableButton_Click(DataGridView consumableDataGridView)
        {
            if (consumableDataGridView.CurrentRow != null)
            {
                DataDeleter_Consumables.DeleteConsumableFromDB(Convert.ToInt32(DataLoader_Consumables.GetAllConsumables()[consumableDataGridView.CurrentRow.Index][0]));
            }
            else
            {
                MessageBox.Show("Невозможно удалить материал");
            }
            DataRefresher.RefreshTable_Materials(consumableDataGridView, DataLoader_Consumables.GetAllConsumables());
        }
    }
}
