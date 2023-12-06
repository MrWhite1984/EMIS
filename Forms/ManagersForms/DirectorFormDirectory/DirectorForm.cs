using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.DirectorForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher;
using Enterprise_Managment_IS.Classes.FormClasses.FactoryWarehouseWorkerForm;
using Enterprise_Managment_IS.Forms.DirectorFormDirectory.AuxiliaryForms.ProductsForms;

namespace Enterprise_Managment_IS.Forms.DirectorFormDirectory
{
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();
        }

        private void DirectorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!devMode)
            {
                Application.Exit();
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            DataRefresher.RefreshTable(productDataGridView, DataLoader_Products.GetAllProducts());
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            PanelsHandlerClass.HideAllPanels(panels);
            productsPanel.Visible = true;
            DataRefresher.RefreshTable(productDataGridView, DataLoader_Products.GetAllProducts());
        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {
            panels = new List<Panel>()
            {
                productsPanel
            };
        }

        
    }
}
