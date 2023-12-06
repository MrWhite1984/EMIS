using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.HRForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.HRForm;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.HRFormData;

namespace Enterprise_Managment_IS.Forms.HRWorkerFormDirectory.AuxiliaryForms.Workers
{
    public partial class AddWorkerForm : Form
    {
        public AddWorkerForm()
        {
            InitializeComponent();
        }

        private void addWorkerButton_Click(object sender, EventArgs e)
        {
            if (surnameTextBox.Text != "" && nameTextBox.Text != "" && fnameTextBox.Text != "")
            {
                Worker newWorker = new Worker(Convert.ToInt32(idTextBox.Text), surnameTextBox.Text, nameTextBox.Text, fnameTextBox.Text, Convert.ToDateTime(birthDateTimePicker.Value), Convert.ToInt64(phoneTextBox.Text), jobTitleComboBox.Text, Convert.ToDateTime(employmentDateDateTimePicker.Value), Convert.ToDouble(salaryTextBox.Text), Convert.ToInt64(checkingAccountTextBox.Text));
                DataAdder_Workers.AddNewWorkerToDB(newWorker.Id, newWorker);
                this.Close();
            }
        }

        private void AddWorkerForm_Load(object sender, EventArgs e)
        {
            if (DataLoader_Workers.GetAllWorkers().Count != 0)
                idTextBox.Text = (Convert.ToInt32(DataLoader_Workers.GetAllWorkers()[DataLoader_Workers.GetAllWorkers().Count - 1][0]) + 1).ToString();
            else
                idTextBox.Text = "1";
            jobTitleComboBox.Items.AddRange(Settings.GetSettings().comboBoxList["Должность пользователя"].ToArray());
        }
    }
}
