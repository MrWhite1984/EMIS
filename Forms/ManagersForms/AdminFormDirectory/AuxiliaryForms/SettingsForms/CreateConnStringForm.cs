using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprise_Managment_IS.Forms.AdminFormDirectory.SettingsForms
{
    public partial class CreateConnStringForm : Form
    {
        public CreateConnStringForm()
        {
            InitializeComponent();
        }

        private void createConnStringButton_Click(object sender, EventArgs e)
        {
             CreateConnStringFormData.newConnectionString = $"Data Source={serverNameTextBox.Text};Initial Catalog={dataBaseNameTextBox.Text};Integrated Security=True";
            this.Close();
        }
    }

    static class CreateConnStringFormData
    {
        public static string newConnectionString { get; set; }
    }
}
