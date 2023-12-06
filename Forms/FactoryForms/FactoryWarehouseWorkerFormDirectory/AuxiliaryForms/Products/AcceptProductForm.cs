using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataChangerDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Products
{
    public partial class AcceptProductForm : Form
    {
        public AcceptProductForm()
        {
            InitializeComponent();
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            FactoryProduct product = DataLoader_FactoryProducts.GetFactoryProductByCode(productCode);
            if (product != null)
            {
                if (quantityTextBox.Text != "")
                {
                    product.AmountOfProduct += Convert.ToInt32(quantityTextBox.Text);
                    DataChanger_FactoryProducts.ChangeAmountFactoryProductsInDB(productCode, product);
                    Close();
                }
                else
                {
                    MessageBox.Show("Введите количество");
                }
            }
            Close();
        }
    }
}
