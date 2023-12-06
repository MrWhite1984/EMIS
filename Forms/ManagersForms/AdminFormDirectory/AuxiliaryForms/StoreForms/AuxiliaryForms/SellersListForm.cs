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
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.HRForm;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Forms.ManagersForms.AdminFormDirectory.AuxiliaryForms.StoreForms.AuxiliaryForms
{
    public partial class SellersListForm : Form
    {
        List<string> sellers = new List<string>();
        public SellersListForm()
        {
            InitializeComponent();
        }

        private void SellersListForm_Load(object sender, EventArgs e)
        {
            foreach (var seller in DataLoader_Workers.GetUserByJobTitle("Продавец"))
            {
                sellers.Add(seller[0] + " " + seller[1] + " " + seller[2] + " " + seller[3]);
            }
            sellersComboBoxBindingSource.DataSource = sellers;
        }

        private void writeAndCloseButton_Click(object sender, EventArgs e)
        {

            string total = "";
            sellersDataGridView.Rows.Add();
            foreach (DataGridViewRow seller in sellersDataGridView.Rows)
            {
                if (seller.Cells[0].Value != null)
                {
                    total = total + seller.Cells[0].Value.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries)[0] + " ";
                }
            }
            sellersTextBox.Text = total;
            this.Close();
        }
    }
}
