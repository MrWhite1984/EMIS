using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataDeleterDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher;
using Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Consumables;

namespace Enterprise_Managment_IS.Classes.FormClasses.FactoryWarehouseWorkerForm
{
    internal class DefectiveProductPanelClass
    {
        public static void sendTheProductForProcessingButton_Click(DataGridView defectiveProductDataGridView)
        {
            if (defectiveProductDataGridView.CurrentRow != null)
            {
                int index = defectiveProductDataGridView.CurrentRow.Index;
                DataDeleter_DefectiveFactoryProducts.DeleteDefectiveFactoryProductFromDB(Convert.ToInt32(DataLoader_DefectiveFactoryProducts.GetAllDefectiveFactoryProducts()[index][0]));
            }
            else
            {
                MessageBox.Show("Невозможно удалить материал");
            }
            DataRefresher.RefreshTable_FactoryProduct(defectiveProductDataGridView, DataLoader_DefectiveFactoryProducts.GetAllDefectiveFactoryProducts());            
        }
    }
}
