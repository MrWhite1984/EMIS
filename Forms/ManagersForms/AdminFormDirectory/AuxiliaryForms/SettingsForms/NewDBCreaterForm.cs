using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.SettingsForm;
using Enterprise_Managment_IS.Forms.AdminFormDirectory.SettingsForms;

namespace Enterprise_Managment_IS.Forms.AdminFormDirectory
{
    public partial class NewDBCreaterForm : Form
    {
        public NewDBCreaterForm()
        {
            InitializeComponent();
        }

        private void connStringCreateButton_Click(object sender, EventArgs e)
        {
            CreateConnStringForm createConnStringForm = new CreateConnStringForm();
            createConnStringForm.ShowDialog();
            connectionStringTextBox.Text = CreateConnStringFormData.newConnectionString;
        }

        private void createNewDBButton_Click(object sender, EventArgs e)
        {
            NewDBCreaterClass.expandAllTablesInTheNewDatabase(connectionStringTextBox.Text);
            this.Close();
        }
    }
}
