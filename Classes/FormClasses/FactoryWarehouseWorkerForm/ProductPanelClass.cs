using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Products;
using Enterprise_Managment_IS.Classes.TypesOfData.ForMultipleForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataChangerDescendants;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataDeleterDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher;

namespace Enterprise_Managment_IS.Classes.FormClasses.FactoryWarehouseWorkerForm
{
    class ProductPanelClass
    {
        public static void addProductButton_Click(DataGridView productDataGridView)
        {
            AddFactoryProductForm addProductForm = new AddFactoryProductForm();
            addProductForm.ShowDialog();
            DataRefresher.RefreshTable_FactoryProduct(productDataGridView, DataLoader_FactoryProducts.GetAllFactoryProducts());
        }
        public static void filterProductButton_Click(DataGridView productDataGridView)
        {
            FilterProductForm filterProductForm = new FilterProductForm()
            {
                productDataGridView = productDataGridView
            };
            filterProductForm.ShowDialog();
        }
        public static void acceptProductsButton_Click(DataGridView productDataGridView)
        {
            AcceptProductForm acceptProductForm = new AcceptProductForm();
            acceptProductForm.productCode = Convert.ToInt32(productDataGridView[0, productDataGridView.CurrentRow.Index].Value);
            acceptProductForm.ShowDialog();
            DataRefresher.RefreshTable_FactoryProduct(productDataGridView, DataLoader_FactoryProducts.GetAllFactoryProducts());
        }

        public static void deleteProductButton_Click(DataGridView productDataGridView)
        {
            if (productDataGridView.CurrentRow != null)
            {
                int index = productDataGridView.CurrentRow.Index;
                DataDeleter_FactoryProducts.DeleteFactoryProductFromDB(Convert.ToInt32(DataLoader_FactoryProducts.GetAllFactoryProducts()[index][0]));
            }
            else
            {
                MessageBox.Show("Невозможно удалить продукт");
            }
            DataRefresher.RefreshTable_FactoryProduct(productDataGridView, DataLoader_FactoryProducts.GetAllFactoryProducts());
        }

        public static void sendToDefectiveButton_Click(DataGridView productDataGridView)
        {
            if (productDataGridView.CurrentRow != null)
            {
                int index = productDataGridView.CurrentRow.Index;
                SendFactoryProductToDefectiveForm sendFactoryProductForm = new SendFactoryProductToDefectiveForm()
                {
                    productCode = index
                };
                sendFactoryProductForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Невозможно отправить в брак продукт");
            }
            DataRefresher.RefreshTable_FactoryProduct(productDataGridView, DataLoader_FactoryProducts.GetAllFactoryProducts());
        }
    }
}
