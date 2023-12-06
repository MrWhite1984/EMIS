using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataAdderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.DataWorkerClasses.DataLoaderDescendants.FactoryWarehouseForm;
using Enterprise_Managment_IS.Classes.TypesOfData.FactoryWarehouseWorkerFormData;
using Microsoft.VisualBasic.Devices;

namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms
{
    public partial class CreateSupplyForm : Form
    {
        List<string> materialsList = new List<string>();
        List<string> consumablesList = new List<string>();
        public CreateSupplyForm()
        {
            InitializeComponent();
            
            foreach (var material in DataLoader_Materials.GetAllMaterials())
            {
                materialsList.Add(material[1]);
            }
            foreach (var consumable in DataLoader_Consumables.GetAllConsumables())
            {
                consumablesList.Add(consumable[1]);
            }
            selectMaterialOrConsumablesComboBox.Items.AddRange(materialsList.ToArray());
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Supply supply = null;
            if (selectSupplyTypeRadioButton1.Checked)
                supply = new Supply(0, DateTime.Now, selectMaterialOrConsumablesComboBox.Text, Convert.ToInt32(enterQuantityTextBox.Text), DataLoader_Materials.GetMaterialsByName(selectMaterialOrConsumablesComboBox.Text).Provider, "Материалы", Convert.ToDouble(sumTextBox.Text));
            else
                supply = new Supply(0, DateTime.Now, selectMaterialOrConsumablesComboBox.Text, Convert.ToInt32(enterQuantityTextBox.Text), DataLoader_Consumables.GetConsumableByName(selectMaterialOrConsumablesComboBox.Text).Provider, "Расходники", Convert.ToDouble(sumTextBox.Text));
            DataAdder_Supplies.AddNewSuppliesToDB(supply);
            Close();
        }

        private void selectSupplyTypeRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (selectSupplyTypeRadioButton1.Checked)
            {
                selectMaterialOrConsumablesComboBox.Items.Clear();
                selectMaterialOrConsumablesComboBox.Items.AddRange(materialsList.ToArray());
            }
        }
        private void selectSupplyTypeRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (selectSupplyTypeRadioButton2.Checked)
            {
                selectMaterialOrConsumablesComboBox.Items.Clear();
                selectMaterialOrConsumablesComboBox.Items.AddRange(consumablesList.ToArray());
            }
        }

        private void enterQuantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void sumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
                e.Handled = true;
        }
    }
}
