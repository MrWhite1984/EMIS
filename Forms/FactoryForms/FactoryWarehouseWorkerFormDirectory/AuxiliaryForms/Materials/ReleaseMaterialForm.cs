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

namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms
{
    public partial class ReleaseMaterialForm : Form
    {
        public ReleaseMaterialForm()
        {
            InitializeComponent();
        }

        private void releaseButton_Click(object sender, EventArgs e)
        {
            Material material = DataLoader_Materials.GetMaterialByCode(materialCode);
            if (material != null)
            {
                if(material.AmountOfMaterial >= Convert.ToInt32(quantityTextBox.Text))
                {
                    material.AmountOfMaterial -= Convert.ToInt32(quantityTextBox.Text);
                    DataChanger_Materials.ChangeMaterialInDB(materialCode, material);
                    int issueCode = 0;
                    if (DataLoader_IssueOfMaterials.GetAllIssueMaterials().Count > 0)
                    {
                        issueCode = DataLoader_IssueOfMaterials.GetAllIssueMaterials().Count + 1;
                    }
                    else
                        issueCode = 1;
                    IssueOfMaterials issue = new IssueOfMaterials(issueCode, materialCode, Convert.ToInt32(workerСomboBox.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]), DateTime.Now);
                    DataAdder_IssueOfMaterials.AddNewIssueMaterialToDB(issue);
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

        private void ReleaseMaterialForm_Load(object sender, EventArgs e)
        {
            List<string[]> strings = DataLoader_Workers.GetUserByJobTitle("Рабочий производства");
            List<string> workersString = new List<string>();
            foreach (var worker in strings)
            {
                workersString.Add(worker[0] + " " + worker[1] + " " + worker[2] + " " + worker[3]);
            }
            workerСomboBox.Items.AddRange(workersString.ToArray());
        }
    }
}
