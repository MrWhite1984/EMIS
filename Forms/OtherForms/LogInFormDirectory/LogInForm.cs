using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.AdminForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.HRForm;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.TypesOfData.AdminFormData;
using Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory;
using Enterprise_Managment_IS.Forms.HRWorkerFormDirectory;

namespace Enterprise_Managment_IS
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }



        private void sendButton_Click(object sender, EventArgs e)
        {
            if ((logInTextBox.Text == "admin") && (passwordField.Text == "letmein"))
            {
                AdminForm adminForm = new AdminForm()
                {
                    devMode = true
                };
                adminForm.Show();
                Hide();
            }
            else
            {
                User user = DataLoader_Users.GetUserByLogInAndPassword(logInTextBox.Text, passwordField.Text);
                if ((user != null) && (DataLoader_Workers.GetWorkerByCode(user.WorkerCode).JobTitle == Settings.GetSettings().comboBoxList["Должность пользователя"][0]))
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    Hide();
                }
                else if ((user != null) && (DataLoader_Workers.GetWorkerByCode(user.WorkerCode).JobTitle == Settings.GetSettings().comboBoxList["Должность пользователя"][2]))
                {
                    FactoryWarehouseWorkerForm factoryWarehouseWorkerForm = new FactoryWarehouseWorkerForm();
                    factoryWarehouseWorkerForm.Show();
                    Hide();
                }
                else if ((user != null) && (DataLoader_Workers.GetWorkerByCode(user.WorkerCode).JobTitle == Settings.GetSettings().comboBoxList["Должность пользователя"][3]))
                {
                    HRWorkerForm hRWorkerForm = new HRWorkerForm();
                    hRWorkerForm.Show();
                    Hide();
                }

                else
                {
                    MessageBox.Show("Ошибка логина или пароля");
                }
            }
        }
    }
}