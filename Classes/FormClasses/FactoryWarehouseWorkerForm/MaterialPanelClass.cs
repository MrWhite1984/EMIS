using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataDeleterDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher;

namespace Enterprise_Managment_IS.Classes.FormClasses.FactoryWarehouseWorkerForm
{
    class MaterialPanelClass
    {
        public static void addMaterialButton_Click(DataGridView materialsDataGridView)
        {
            AddMaterialForm addMaterialForm = new AddMaterialForm();
            addMaterialForm.ShowDialog();
            DataRefresher.RefreshTable_Materials(materialsDataGridView, DataLoader_Materials.GetAllMaterials());
        }

        public static void deleteMaterialButton_Click(DataGridView materialsDataGridView)
        {
            if (materialsDataGridView.CurrentRow != null)
            {
                int index = materialsDataGridView.CurrentRow.Index;
                DataDeleter_Materials.DeleteMaterialFromDB(Convert.ToInt32(DataLoader_Materials.GetAllMaterials()[index][0]));
            }
            else
            {
                MessageBox.Show("Невозможно удалить материал");
            }
            DataRefresher.RefreshTable_Materials(materialsDataGridView, DataLoader_Materials.GetAllMaterials());
        }

        public static void filterButton_Click(DataGridView materialsDataGridView)
        {
            FilterMaterialForm filterMaterialForm = new FilterMaterialForm
            {
                materialDataGridView = materialsDataGridView
            };
            filterMaterialForm.ShowDialog();
        }
        public static void releaseMaterialButton_Click(DataGridView materialsDataGridView)
        {
            if (Convert.ToInt32(materialsDataGridView[2, materialsDataGridView.CurrentRow.Index].Value) != 0)
            {
                ReleaseMaterialForm releaseMaterialForm = new ReleaseMaterialForm
                {
                    materialCode = Convert.ToInt32(materialsDataGridView[0, materialsDataGridView.CurrentRow.Index].Value)
                };
                releaseMaterialForm.ShowDialog();
                DataRefresher.RefreshTable_Materials(materialsDataGridView, DataLoader_Materials.GetAllMaterials());
            }
            else
            {
                MessageBox.Show("Запрашиваемый материал отсутствует");
            }
        }
    }
}
