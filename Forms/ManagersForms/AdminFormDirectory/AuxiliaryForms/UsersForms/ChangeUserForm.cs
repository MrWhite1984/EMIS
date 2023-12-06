using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataChangerDescendants.AdminForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.AdminForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.HRForm;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Forms.AdminFormDirectory
{
    public partial class ChangeUserForm : Form
    {
        public ChangeUserForm()
        {
            InitializeComponent();
        }


        private void ChangeUserForm_Load(object sender, EventArgs e)
        {
            List<string[]> users = DataLoader_Users.GetAllUsers();
            char whiteSpace = ' ';
            userCodeTextBox.Text = users[index][0].TrimEnd(whiteSpace);
            userLogInTextBox.Text = users[index][2].TrimEnd(whiteSpace);
            userPasswordTextBox.Text = users[index][3].TrimEnd(whiteSpace);
            jobTitleComboBox.Items.Clear();
            jobTitleComboBox.Items.AddRange(Settings.GetSettings().comboBoxList["Должность пользователя"].ToArray());
            jobTitleComboBox.Text = DataLoader_Workers.GetWorkerByCode(Convert.ToInt32(users[index][1])).JobTitle;
            workerCodeComboBox.Items.Clear();
            workerCodeComboBox.Text = "";
            List<string> snf = new List<string>();
            foreach (var worker in DataLoader_Workers.GetUserByJobTitle(jobTitleComboBox.Text))
            {
                string s = "";
                s = worker[0] + " " + worker[1] + " " + worker[2] + " " + worker[3];
                snf.Add(s);
            }
            workerCodeComboBox.Items.AddRange(snf.ToArray());
            workerCodeComboBox.Text = users[index][1] + " " + DataLoader_Workers.GetWorkerByCode(Convert.ToInt32(users[index][1])).Surname + " " + DataLoader_Workers.GetWorkerByCode(Convert.ToInt32(users[index][1])).Name + " " + DataLoader_Workers.GetWorkerByCode(Convert.ToInt32(users[index][1])).FName;
        }

        private void changeUserButton_Click(object sender, EventArgs e)
        {
            User user = new User(Convert.ToInt32(userCodeTextBox.Text), Convert.ToInt32(workerCodeComboBox.Text.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0]), userLogInTextBox.Text, userPasswordTextBox.Text);
            DataChanger_Users.ChangeUserInDB(Convert.ToInt32(userCodeTextBox.Text), user);
            this.Close();
        }
    }
}
