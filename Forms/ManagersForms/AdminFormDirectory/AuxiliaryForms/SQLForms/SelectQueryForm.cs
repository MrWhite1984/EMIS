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

namespace Enterprise_Managment_IS.Forms.ManagersForms.AdminFormDirectory.AuxiliaryForms.SQLForms
{
    public partial class SelectQueryForm : Form
    {
        public SelectQueryForm()
        {
            InitializeComponent();
        }

        private void createTableQueryButton_Click(object sender, EventArgs e)
        {
            queryTextBox.Text = NewDBCreaterClass.ShowCreateTablesQuery();
            this.Close();
        }

        private void createTriggerQueryButton_Click(object sender, EventArgs e)
        {
            queryTextBox.Text = NewDBCreaterClass.ShowCreateTriggerQuery();
            this.Close();
        }
    }
}
