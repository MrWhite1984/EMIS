using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataDeleterDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;
using Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Providers;

namespace Enterprise_Managment_IS.Classes.FormClasses.FactoryWarehouseWorkerForm
{
    class ProviderPanelClass
    {
        public static void addProviderButton_Click(DataGridView providerDataGridView)
        {
            AddProviderForm addProviderForm = new AddProviderForm();
            addProviderForm.ShowDialog();
            DataRefresher.RefreshTable(providerDataGridView, DataLoader_Providers.GetAllProviders());
        }
        public static void changeButton_Click(DataGridView providerDataGridView)
        {
            ChangeProviderForm changeProviderForm = new ChangeProviderForm();
            changeProviderForm.index = providerDataGridView.CurrentRow.Index;
            changeProviderForm.ShowDialog();
            DataRefresher.RefreshTable(providerDataGridView, DataLoader_Providers.GetAllProviders());
        }
        public static void deleteProviderButton_Click(DataGridView providerDataGridView)
        {
            Provider provider = DataLoader_Providers.GetProviderByCode(Convert.ToInt32(providerDataGridView[0, providerDataGridView.CurrentRow.Index].Value));
            if ((DataLoader_Materials.GetMaterialsByProvider(provider.ProviderCode).Count() == 0) && DataLoader_Consumables.GetConsumableByProvider(provider.ProviderCode).Count() == 0)
            {
                DataDeleter_Providers.DeleteProviderFromDB(provider.ProviderCode);
            }
            else
            {
                MessageBox.Show("В базе хранятся материалы или расходники с таким поставщиком");
            }
            DataRefresher.RefreshTable(providerDataGridView, DataLoader_Providers.GetAllProviders());
        }
    }
}
