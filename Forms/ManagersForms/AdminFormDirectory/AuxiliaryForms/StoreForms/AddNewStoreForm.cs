using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.AdminForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.HRForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.StoreForm;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Forms.ManagersForms.AdminFormDirectory.AuxiliaryForms.StoreForms
{
    public partial class AddNewStoreForm : Form
    {
        public AddNewStoreForm()
        {
            InitializeComponent();
            storeCodeTextBox.Text = (DataLoader_Stores.GetAllStores().Count + 1).ToString();
        }

        List<Seller> sellers = new List<Seller>();

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

        private void addButton_Click(object sender, EventArgs e)
        {
            Store store = new Store(Convert.ToInt32(storeCodeTextBox.Text), storeAddressTextBox.Text, Convert.ToInt32(storeDirectorComboBox.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]), Convert.ToInt32(phoneTextBox.Text), sellers, Convert.ToInt32(warehouseWorkerComboBox.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]));
            DataAdder_Stores.AddNewStoreToDB(store);
        }

        private void openSellersFormButton_Click(object sender, EventArgs e)
        {

        }
    }
}
