using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise_Managment_IS.Classes.Other;
using Enterprise_Managment_IS.Forms.AdminFormDirectory;
using Enterprise_Managment_IS.Forms.AdminFormDirectory.SettingsForms;

namespace Enterprise_Managment_IS.Classes.FormClasses.AdminForm
{
    class SettingsPanelClass
    {
        public static void ChangeSettings_Click(TextBox connectionStringTextBox, TextBox orderListLocation)
        {
            Settings lastSet = Settings.GetSettings();
            Settings settings = new Settings(ConnectionStringHandler.HandleStringForWrite(connectionStringTextBox.Text), lastSet.comboBoxList, orderListLocation.Text);
            settings.WriteSettings(settings);
        }
        public static void createNewDBButton_Click()
        {
            NewDBCreaterForm newDBCreaterForm = new NewDBCreaterForm();
            newDBCreaterForm.ShowDialog();
        }
        public static void eportDataFromDataBaseButton_Click()
        {
            ExportDataFromDataBaseForm exportDataFromDataBaseForm = new ExportDataFromDataBaseForm();
            exportDataFromDataBaseForm.ShowDialog();
        }
        public static void exportFromJSONToDB_Click()
        {
            ExportDataFromJSONForm exportDataFromJSONForm = new ExportDataFromJSONForm();
            exportDataFromJSONForm.ShowDialog();
        }
        public static void customizingDropdownListsButton_Click()
        {
            CustomizingDropdownListsForm customizingDropdownListsForm = new CustomizingDropdownListsForm();
            customizingDropdownListsForm.ShowDialog();
        }
        public static void connStringCreateButton_Click(TextBox connectionStringTextBox)
        {
            CreateConnStringForm createConnStringForm = new CreateConnStringForm();
            createConnStringForm.ShowDialog();
            connectionStringTextBox.Text = CreateConnStringFormData.newConnectionString;
        }
    }
}
