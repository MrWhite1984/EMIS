using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataDeleterDescendants;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.AdminForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.StoreForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataRefresher;
using Enterprise_Managment_IS.Classes.FormClasses.AdminForm;
using Enterprise_Managment_IS.Classes.FormClasses.FactoryWarehouseWorkerForm;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Classes.SettingsForm;
using Enterprise_Managment_IS.Forms.AdminFormDirectory;
using Enterprise_Managment_IS.Forms.AdminFormDirectory.SettingsForms;
using Enterprise_Managment_IS.Forms.DirectorFormDirectory;
using Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory;
using Enterprise_Managment_IS.Forms.HRWorkerFormDirectory;
using Enterprise_Managment_IS.Forms.ManagersForms.AdminFormDirectory.AuxiliaryForms.StoreForms;
using Enterprise_Managment_IS.Forms.StoreWarehouseWorkerDirectory;

namespace Enterprise_Managment_IS
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            if (devMode)
                developerPunelButton.Visible = true;
            MainPanels = new List<Panel>()
            {
                userPanel, settingsPanel, developerPanel, storesSettingsPanel, sqlRequestPanel
            };
            DeveloperPanels = new List<Panel>()
            {
                usersFormPanel, developerSettingsPanel
            };
        }

        private void UsersDataButton_Click(object sender, EventArgs e)
        {
            if (Settings.GetSettings().connectionString != "")
            {
                PanelsHandlerClass.HideAllPanels(MainPanels);
                userPanel.Visible = true;
                DataRefresher.RefreshTable_Users(userDataGridView, DataLoader_Users.GetAllUsers());
            }
            else
            {
                MessageBox.Show("Строка подключения пуста");
            }
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            PanelsHandlerClass.HideAllPanels(MainPanels);
            settingsPanel.Visible = true;
            Settings settings = Settings.GetSettings();
            connectionStringTextBox.Text = ConnectionStringHandler.HandleStringForGet(settings.connectionString);
        }
        private void developerPunelButton_Click(object sender, EventArgs e)
        {
            PanelsHandlerClass.HideAllPanels(MainPanels);
            developerPanel.Visible = true;
        }
        private void storesSettingsButton_Click(object sender, EventArgs e)
        {
            PanelsHandlerClass.HideAllPanels(MainPanels);
            storesSettingsPanel.Visible = true;
        }
        private void sqlRequestPanelButton_Click(object sender, EventArgs e)
        {
            PanelsHandlerClass.HideAllPanels(MainPanels);
            sqlRequestPanel.Visible = true;
        }
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //UsersPanel
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            UserPanelClass.AddUserButton_Click(userDataGridView);
        }
        private void ChangeUserButton_Click(object sender, EventArgs e)
        {
            UserPanelClass.ChangeUserButton_Click(userDataGridView);
        }
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            UserPanelClass.DeleteUserButton_Click(userDataGridView);
        }

        //SettingsPanel
        private void ChangeSettings_Click(object sender, EventArgs e)
        {
            SettingsPanelClass.ChangeSettings_Click(connectionStringTextBox, orderListLocationTextBox);
        }
        private void createNewDBButton_Click(object sender, EventArgs e)
        {
            SettingsPanelClass.createNewDBButton_Click();
        }
        private void eportDataFromDataBaseButton_Click(object sender, EventArgs e)
        {
            SettingsPanelClass.eportDataFromDataBaseButton_Click();
        }
        private void exportFromJSONToDB_Click(object sender, EventArgs e)
        {
            SettingsPanelClass.exportFromJSONToDB_Click();
        }
        private void connStringCreateButton_Click(object sender, EventArgs e)
        {
            SettingsPanelClass.connStringCreateButton_Click(connectionStringTextBox);
        }

        //DeveloperPanel
        private void openUsersFormButton_Click(object sender, EventArgs e)
        {
            DeveloperPanelClass.openUsersFormButton_Click(DeveloperPanels, 0);
        }
        private void developerSettingsButton_Click(object sender, EventArgs e)
        {
            DeveloperPanelClass.openUsersFormButton_Click(DeveloperPanels, 1);
        }
        private void dropAllSettingsButton_Click(object sender, EventArgs e)
        {
            Settings settings = Settings.GetSettings();
            settings.connectionString = "";
            settings.WriteSettings(settings);
        }

        //DeveloperPanel_Forms
        private void openFactoryWarehouseWorkerFormButton_Click(object sender, EventArgs e)
        {
            FactoryWarehouseWorkerForm factoryWarehouseWorkerForm = new FactoryWarehouseWorkerForm()
            {
                devMode = true
            };
            factoryWarehouseWorkerForm.ShowDialog();
        }


        private void HRButton_Click(object sender, EventArgs e)
        {
            HRWorkerForm hRWorkerForm = new HRWorkerForm();
            hRWorkerForm.ShowDialog();
        }

        private void OrderListLocationViewButton_Click(object sender, EventArgs e)
        {
            OrderListLocationFolderBrowserDialog.ShowDialog();
            orderListLocationTextBox.Text = OrderListLocationFolderBrowserDialog.SelectedPath;
        }

        private void customizingDropdownListsButton_Click_1(object sender, EventArgs e)
        {
            SettingsPanelClass.customizingDropdownListsButton_Click();
        }

        private void directorFormButton_Click(object sender, EventArgs e)
        {
            DirectorForm directorForm = new DirectorForm();
            directorForm.ShowDialog();
        }

        private void sqlRequestApplyButton_Click(object sender, EventArgs e)
        {
            sqlAnswerLabel.Text = SQLRequestPanel.SelectSQLRequestType(sqlRequestTextTextBox.Text);
        }

        private void openStoreWarehouseWorkerFormButton_Click(object sender, EventArgs e)
        {
            StoreWarehouseWorkerForm storeWarehouseWorkerForm = new StoreWarehouseWorkerForm();
            storeWarehouseWorkerForm.ShowDialog();
        }

        private void storesButton_Click(object sender, EventArgs e)
        {
            storesPanel.Visible = true;
            DataRefresher.RefreshTable(storesDataGridView, DataLoader_Stores.GetAllStores());
        }

        private void addStoreButton_Click(object sender, EventArgs e)
        {
            AddNewStoreForm addNewStoreForm = new AddNewStoreForm();
            addNewStoreForm.ShowDialog();
        }
    }
}
