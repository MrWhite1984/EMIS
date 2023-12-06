using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataChangerDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.AdminForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Products
{
    public partial class SendFactoryProductToDefectiveForm : Form
    {
        public SendFactoryProductToDefectiveForm()
        {
            InitializeComponent();
        }

        private void SendFactoryProductToDefectiveButton_Click(object sender, EventArgs e)
        {
            FactoryProduct product = DataLoader_FactoryProducts.GetFactoryProductByCode(Convert.ToInt32(DataLoader_FactoryProducts.GetAllFactoryProducts()[productCode][0]));
            if (product.AmountOfProduct > 0)
            {
                product.AmountOfProduct--;
                DataChanger_FactoryProducts.ChangeAmountFactoryProductsInDB(product.ID, product);
                product.AmountOfProduct = 1;
                DataAdder_DefectiveFactoryProducts.AddNewDefectiveFactoryProductsToDB(DataLoader_FactoryProducts.GetFactoryProductByCode(product.ID), descriptionOfTheDefectTextBox.Text);
            }
            else
            {
                MessageBox.Show("Продукт отсутствует на складе");
            }
            this.Close();
        }
    }
}
