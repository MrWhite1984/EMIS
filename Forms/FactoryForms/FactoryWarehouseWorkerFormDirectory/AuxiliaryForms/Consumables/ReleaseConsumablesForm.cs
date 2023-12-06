using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataChangerDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.HRForm;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;

namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Consumables
{
    public partial class ReleaseConsumablesForm : Form
    {
        public ReleaseConsumablesForm()
        {
            InitializeComponent();
        }

        private void releaseButton_Click(object sender, EventArgs e)
        {
            Consumable consumable = DataLoader_Consumables.GetConsumableByCode(consumableCode);
            if (consumable != null)
            {
                if (consumable.AmountOfConsumable >= Convert.ToInt32(quantityTextBox.Text))
                {
                    consumable.AmountOfConsumable -= Convert.ToInt32(quantityTextBox.Text);
                    DataChanger_Consumables.ChangeConsumableInDB(consumableCode, consumable);
                    int issueCode = 0;
                    if (DataLoader_IssueOfConsumables.GetAllIssueConsumables().Count > 0)
                    {
                        issueCode = DataLoader_IssueOfConsumables.GetAllIssueConsumables().Count + 1;
                    }
                    else
                        issueCode = 1;
                    IssueOfConsumables issue = new IssueOfConsumables(issueCode, consumableCode, Convert.ToInt32(workerComboBox.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]), DateTime.Now);
                    DataAdder_IssueOfConsumables.AddNewIssueConsumableToDB(issue);
                    Close();
                }
                else
                {
                    MessageBox.Show("Недостаточно материала");
                }
            }
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void ReleaseConsumablesForm_Load(object sender, EventArgs e)
        {
            List<string[]> strings = DataLoader_Workers.GetUserByJobTitle("Рабочий производства");
            List<string> workersString = new List<string>();
            foreach (var worker in strings)
            {
                workersString.Add(worker[0] + " " + worker[1] + " " + worker[2] + " " + worker[3]);
            }
            workerComboBox.Items.AddRange(workersString.ToArray());
        }
    }
}
