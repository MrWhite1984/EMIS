using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.AdminForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.AdminForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.HRForm;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;

namespace Enterprise_Managment_IS.Forms.AdminFormDirectory
{
    public partial class AddNewUserForm : Form
    {
        public AddNewUserForm()
        {
            InitializeComponent();
        }

        private void AddNewUserForm_Load(object sender, EventArgs e)
        {
            if (DataLoader_Users.GetAllUsers().Count != 0)
                userCodeTextBox.Text = (Convert.ToInt32(DataLoader_Users.GetAllUsers()[DataLoader_Users.GetAllUsers().Count - 1][0]) + 1).ToString();
            else
                userCodeTextBox.Text = "1";
            userJobTitleComboBox.Items.Clear();
            workerComboBox.Items.Clear();
            userJobTitleComboBox.Items.AddRange(Settings.GetSettings().comboBoxList["Должность пользователя"].ToArray());
            
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if(userLogInTextBox.Text != "" && userPasswordTextBox.Text != "" && userJobTitleComboBox.Text != "")
            {
                User user = DataLoader_Users.GetUserByLogIn(userLogInTextBox.Text);
                if (user != null)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует");
                }
                else
                {
                    User newUser = new User(Convert.ToInt32(userCodeTextBox.Text), Convert.ToInt32(workerComboBox.Text.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0]), userLogInTextBox.Text, userPasswordTextBox.Text);
                    DataAdder_Users.AddNewUserToDB((Convert.ToInt32(userCodeTextBox.Text)), newUser);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Не все данные заполнены");
            }
        }

        private void userLogInTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(userLogInTextBox.Text))
            {
                e.Cancel = true;
                userLogInTextBox.Focus();
                errorProvider.SetError(userLogInTextBox, "Поле \"Логин\" не должно быть пустым");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(userLogInTextBox, null);
            }
        }

        private void userPasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(userPasswordTextBox.Text))
            {
                e.Cancel = true;
                userPasswordTextBox.Focus();
                errorProvider.SetError(userPasswordTextBox, "Поле \"Пароль\" не должно быть пустым");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(userPasswordTextBox, null);
            }
        }

        private void userJobTitleComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            workerComboBox.Items.Clear();
            workerComboBox.Text = "";
            List<string> snf = new List<string>();
            foreach (var worker in DataLoader_Workers.GetUserByJobTitle(userJobTitleComboBox.Text))
            {
                string s = "";
                s = worker[0] + " " + worker[1] + " " + worker[2] + " " + worker[3];
                snf.Add(s);
            }
            workerComboBox.Items.AddRange(snf.ToArray());
        }
    }
}
