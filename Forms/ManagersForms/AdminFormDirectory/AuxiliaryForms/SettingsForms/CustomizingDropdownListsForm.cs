using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enterprise_Managment_IS.Classes.Other;

namespace Enterprise_Managment_IS.Forms.AdminFormDirectory.SettingsForms
{
    public partial class CustomizingDropdownListsForm : Form
    {
        Settings settings = null;
        public CustomizingDropdownListsForm()
        {
            InitializeComponent();
        }
        private void CustomizingDropdownListsForm_Load(object sender, EventArgs e)
        {
            settings = Settings.GetSettings();
            selectComboBoxComboBox.Items.AddRange(settings.comboBoxList.Keys.ToArray<string>());
        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            if(selectComboBoxComboBox.Text != "")
            {
                if (dataForChangingTextBox.Text != "")
                {
                    settings = Settings.GetSettings();
                    List<string> data = settings.comboBoxList[selectComboBoxComboBox.Text];
                    if (!data.Any(o => o == dataForChangingTextBox.Text))
                    {
                        data.Add(dataForChangingTextBox.Text);
                        settings.comboBoxList[selectComboBoxComboBox.Text] = data;
                        settings.WriteSettings(settings);
                    }
                    else
                    {
                        MessageBox.Show("Такие данные уже есть в списке");
                    }                                      
                }
                else
                {
                    MessageBox.Show("Введите данные для добавления");
                }
            }
            else
            {
                MessageBox.Show("Выберите список");
            }
        }

        private void deleteDataButton_Click(object sender, EventArgs e)
        {
            
            if (selectComboBoxComboBox.Text != "")
            {
                if (dataForChangingTextBox.Text != "")
                {
                    settings = Settings.GetSettings();
                    List<string> data = settings.comboBoxList[selectComboBoxComboBox.Text];
                    if (data.Any(o => o == dataForChangingTextBox.Text))
                    {
                        data.Remove(dataForChangingTextBox.Text);
                        settings.comboBoxList[selectComboBoxComboBox.Text] = data;
                        settings.WriteSettings(settings);
                    }
                    else
                    {
                        MessageBox.Show("Такие данные отсутствуют в списке");
                    }
                }
                else
                {
                    MessageBox.Show("Введите данные для удаления");
                }
            }
            else
            {
                MessageBox.Show("Выберите список");
            }
        }

        private void selectComboBoxComboBox_TextChanged(object sender, EventArgs e)
        {
            settings = Settings.GetSettings();
            dataForChangingTextBox.Items.AddRange(settings.comboBoxList[selectComboBoxComboBox.Text].ToArray());
        }

        
    }
}
