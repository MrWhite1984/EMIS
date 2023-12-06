using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataChangerDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataDeleterDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher;

namespace Enterprise_Managment_IS.Classes.FormClasses.FactoryWarehouseWorkerForm
{
    class SupplyPanelClass
    {
        public static void createSupplyButton_Click(DataGridView suppliesDataGridView)
        {
            CreateSupplyForm createSupplyForm = new CreateSupplyForm();
            createSupplyForm.ShowDialog();
            DataRefresher.RefreshTable_Supplies(suppliesDataGridView, DataLoader_Supplies.GetAllSupplies());
        }
        public static void applyASupplyButton_Click(DataGridView suppliesDataGridView)
        {
            if (suppliesDataGridView.CurrentRow != null)
            {
                int index = suppliesDataGridView.CurrentRow.Index;
                Supply supply = DataLoader_Supplies.GetSupplyByCode(Convert.ToInt32(suppliesDataGridView[0, index].Value));
                if (suppliesDataGridView[5, index].Value.ToString() == "Материалы")
                {
                    Material material = DataLoader_Materials.GetMaterialsByName(suppliesDataGridView[2, index].Value.ToString());
                    DataChanger_Materials.ApplyASupply(material, supply);
                    DataAdder_ConductedSupplies.AddNewConductedSuppliesToDB(supply);
                }
                else
                {
                    Consumable consumable = DataLoader_Consumables.GetConsumableByName(suppliesDataGridView[2, index].Value.ToString());
                    DataChanger_Consumables.ApplyASupply(consumable, supply);
                    DataAdder_ConductedSupplies.AddNewConductedSuppliesToDB(supply);
                }
                DataDeleter_Supplies.DeleteSupplyFromDB(supply.SuplyCode);
                DataRefresher.RefreshTable_Supplies(suppliesDataGridView, DataLoader_Supplies.GetAllSupplies());
            }
        }
        public static void cancelSupplyButton_Click(DataGridView suppliesDataGridView)
        {
            if (suppliesDataGridView.CurrentRow != null)
            {
                int index = suppliesDataGridView.CurrentRow.Index;
                Supply supply = DataLoader_Supplies.GetSupplyByCode(Convert.ToInt32(suppliesDataGridView[0, index].Value));
                DataAdder_CanceledSupplies.AddNewCanceledSuppliesToDB(supply);
                DataDeleter_Supplies.DeleteSupplyFromDB(supply.SuplyCode);
                DataRefresher.RefreshTable_Supplies(suppliesDataGridView, DataLoader_Supplies.GetAllSupplies());
            }
        }
    }
}
