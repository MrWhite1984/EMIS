using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataDeleterDescendants.HRForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.HRForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher;
using Enterprise_Managment_IS.Classes.FormClasses.FactoryWarehouseWorkerForm;
using Enterprise_Managment_IS.Forms.HRWorkerFormDirectory.AuxiliaryForms.Workers;

namespace Enterprise_Managment_IS.Forms.HRWorkerFormDirectory
{
    public partial class HRWorkerForm : Form
    {
        public HRWorkerForm()
        {
            InitializeComponent();
        }
        private void HRWorkerForm_Load(object sender, EventArgs e)
        {
            panels = new List<Panel>
            {
                workersPanel
            };
        }
        private void workersButton_Click(object sender, EventArgs e)
        {
            PanelsHandlerClass.HideAllPanels(panels);
            workersPanel.Visible = true;
            DataRefresher.RefreshTable(workersDataGridView, DataLoader_Workers.GetAllWorkers());
        }

        private void addWorkerButton_Click(object sender, EventArgs e)
        {
            AddWorkerForm addWorkerForm = new AddWorkerForm();
            addWorkerForm.ShowDialog();
            DataRefresher.RefreshTable(workersDataGridView, DataLoader_Workers.GetAllWorkers());
        }

        private void deleteWorkerButton_Click(object sender, EventArgs e)
        {
            int index = workersDataGridView.CurrentRow.Index;
            DataDeleter_Workers.DeleteWorkerFromDB(Convert.ToInt32(DataLoader_Workers.GetAllWorkers()[index][0]));
            DataRefresher.RefreshTable(workersDataGridView, DataLoader_Workers.GetAllWorkers());
        }
    }
}
