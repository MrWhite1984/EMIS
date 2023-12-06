using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.HRForm;

namespace Enterprise_Managment_IS.Forms.ManagersForms.AdminFormDirectory.AuxiliaryForms.StoreForms
{
    public partial class AddNewStoreForm : Form
    {
        public AddNewStoreForm()
        {
            InitializeComponent();
        }

        private void AddNewStoreForm_Load(object sender, EventArgs e)
        {
            var workers = DataLoader_Workers.GetWorkersByJobTitle("Директор магазина");
            List<string> FullName = new List<string>();
            foreach (var worker in workers)
            {
                FullName.Add(worker[0] + " " + worker[1] + " " + worker[2] + " " + worker[3]);
            }
            storeDirectorComboBox.Items.AddRange(FullName.ToArray());
            workers.Clear();
            workers = DataLoader_Workers.GetWorkersByJobTitle("Кладовщик магазина");
            FullName.Clear();
            foreach (var worker in workers)
            {
                FullName.Add(worker[0] + " " + worker[1] + " " + worker[2] + " " + worker[3]);
            }
            warehouseWorkerComboBox.Items.AddRange(FullName.ToArray());
        }
    }
}
