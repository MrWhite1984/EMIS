namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Consumables
{
    partial class FilterConsumableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public DataGridView consumableDataGridView = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textToFilterLabel = new System.Windows.Forms.Label();
            this.textToFilterTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.textToFilterComboBox = new System.Windows.Forms.ComboBox();
            this.filterParametrRadioButton1 = new System.Windows.Forms.RadioButton();
            this.filterParametrRadioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textToFilterLabel
            // 
            this.textToFilterLabel.AutoSize = true;
            this.textToFilterLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textToFilterLabel.Location = new System.Drawing.Point(12, 9);
            this.textToFilterLabel.Name = "textToFilterLabel";
            this.textToFilterLabel.Size = new System.Drawing.Size(129, 15);
            this.textToFilterLabel.TabIndex = 0;
            this.textToFilterLabel.Text = "Текст для фильтрации";
            // 
            // textToFilterTextBox
            // 
            this.textToFilterTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textToFilterTextBox.Location = new System.Drawing.Point(147, 7);
            this.textToFilterTextBox.Name = "textToFilterTextBox";
            this.textToFilterTextBox.Size = new System.Drawing.Size(566, 23);
            this.textToFilterTextBox.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(612, 55);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 44);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Сбросить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(724, 55);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(106, 44);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // textToFilterComboBox
            // 
            this.textToFilterComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textToFilterComboBox.FormattingEnabled = true;
            this.textToFilterComboBox.Location = new System.Drawing.Point(147, 6);
            this.textToFilterComboBox.Name = "textToFilterComboBox";
            this.textToFilterComboBox.Size = new System.Drawing.Size(566, 23);
            this.textToFilterComboBox.TabIndex = 6;
            this.textToFilterComboBox.Visible = false;
            // 
            // filterParametrRadioButton1
            // 
            this.filterParametrRadioButton1.AutoSize = true;
            this.filterParametrRadioButton1.Checked = true;
            this.filterParametrRadioButton1.Location = new System.Drawing.Point(719, 5);
            this.filterParametrRadioButton1.Name = "filterParametrRadioButton1";
            this.filterParametrRadioButton1.Size = new System.Drawing.Size(80, 19);
            this.filterParametrRadioButton1.TabIndex = 7;
            this.filterParametrRadioButton1.TabStop = true;
            this.filterParametrRadioButton1.Text = "По имени";
            this.filterParametrRadioButton1.UseVisualStyleBackColor = true;
            this.filterParametrRadioButton1.CheckedChanged += new System.EventHandler(this.filterParametrRadioButton1_CheckedChanged);
            // 
            // filterParametrRadioButton2
            // 
            this.filterParametrRadioButton2.AutoSize = true;
            this.filterParametrRadioButton2.Location = new System.Drawing.Point(719, 30);
            this.filterParametrRadioButton2.Name = "filterParametrRadioButton2";
            this.filterParametrRadioButton2.Size = new System.Drawing.Size(111, 19);
            this.filterParametrRadioButton2.TabIndex = 8;
            this.filterParametrRadioButton2.Text = "По поставщику";
            this.filterParametrRadioButton2.UseVisualStyleBackColor = true;
            // 
            // FilterConsumableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(838, 111);
            this.Controls.Add(this.filterParametrRadioButton2);
            this.Controls.Add(this.filterParametrRadioButton1);
            this.Controls.Add(this.textToFilterComboBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.textToFilterTextBox);
            this.Controls.Add(this.textToFilterLabel);
            this.Name = "FilterConsumableForm";
            this.Text = "Фильтровать расходники";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label textToFilterLabel;
        private TextBox textToFilterTextBox;
        private Button cancelButton;
        private Button applyButton;
        private ComboBox textToFilterComboBox;
        private RadioButton filterParametrRadioButton1;
        private RadioButton filterParametrRadioButton2;
    }
}