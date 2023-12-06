namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms
{
    partial class CreateSupplyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.selectMaterialOrConsumablesLabel = new System.Windows.Forms.Label();
            this.enterQuantityLabel = new System.Windows.Forms.Label();
            this.selectMaterialOrConsumablesComboBox = new System.Windows.Forms.ComboBox();
            this.enterQuantityTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.selectSupplyTypeRadioButton1 = new System.Windows.Forms.RadioButton();
            this.selectSupplyTypeRadioButton2 = new System.Windows.Forms.RadioButton();
            this.sumLabel = new System.Windows.Forms.Label();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectMaterialOrConsumablesLabel
            // 
            this.selectMaterialOrConsumablesLabel.AutoSize = true;
            this.selectMaterialOrConsumablesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectMaterialOrConsumablesLabel.Location = new System.Drawing.Point(12, 9);
            this.selectMaterialOrConsumablesLabel.Name = "selectMaterialOrConsumablesLabel";
            this.selectMaterialOrConsumablesLabel.Size = new System.Drawing.Size(64, 15);
            this.selectMaterialOrConsumablesLabel.TabIndex = 0;
            this.selectMaterialOrConsumablesLabel.Text = "Выберите ";
            // 
            // enterQuantityLabel
            // 
            this.enterQuantityLabel.AutoSize = true;
            this.enterQuantityLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterQuantityLabel.Location = new System.Drawing.Point(12, 38);
            this.enterQuantityLabel.Name = "enterQuantityLabel";
            this.enterQuantityLabel.Size = new System.Drawing.Size(117, 15);
            this.enterQuantityLabel.TabIndex = 1;
            this.enterQuantityLabel.Text = "Введите количество";
            // 
            // selectMaterialOrConsumablesComboBox
            // 
            this.selectMaterialOrConsumablesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectMaterialOrConsumablesComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectMaterialOrConsumablesComboBox.FormattingEnabled = true;
            this.selectMaterialOrConsumablesComboBox.Location = new System.Drawing.Point(143, 6);
            this.selectMaterialOrConsumablesComboBox.Name = "selectMaterialOrConsumablesComboBox";
            this.selectMaterialOrConsumablesComboBox.Size = new System.Drawing.Size(681, 23);
            this.selectMaterialOrConsumablesComboBox.TabIndex = 2;
            // 
            // enterQuantityTextBox
            // 
            this.enterQuantityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterQuantityTextBox.Location = new System.Drawing.Point(143, 35);
            this.enterQuantityTextBox.Name = "enterQuantityTextBox";
            this.enterQuantityTextBox.Size = new System.Drawing.Size(681, 23);
            this.enterQuantityTextBox.TabIndex = 3;
            this.enterQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterQuantityTextBox_KeyPress);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(813, 93);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(106, 44);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // selectSupplyTypeRadioButton1
            // 
            this.selectSupplyTypeRadioButton1.AutoSize = true;
            this.selectSupplyTypeRadioButton1.Checked = true;
            this.selectSupplyTypeRadioButton1.Location = new System.Drawing.Point(830, 6);
            this.selectSupplyTypeRadioButton1.Name = "selectSupplyTypeRadioButton1";
            this.selectSupplyTypeRadioButton1.Size = new System.Drawing.Size(89, 19);
            this.selectSupplyTypeRadioButton1.TabIndex = 5;
            this.selectSupplyTypeRadioButton1.TabStop = true;
            this.selectSupplyTypeRadioButton1.Text = "Материалы";
            this.selectSupplyTypeRadioButton1.UseVisualStyleBackColor = true;
            this.selectSupplyTypeRadioButton1.CheckedChanged += new System.EventHandler(this.selectSupplyTypeRadioButton1_CheckedChanged);
            // 
            // selectSupplyTypeRadioButton2
            // 
            this.selectSupplyTypeRadioButton2.AutoSize = true;
            this.selectSupplyTypeRadioButton2.Location = new System.Drawing.Point(830, 31);
            this.selectSupplyTypeRadioButton2.Name = "selectSupplyTypeRadioButton2";
            this.selectSupplyTypeRadioButton2.Size = new System.Drawing.Size(90, 19);
            this.selectSupplyTypeRadioButton2.TabIndex = 6;
            this.selectSupplyTypeRadioButton2.Text = "Расходники";
            this.selectSupplyTypeRadioButton2.UseVisualStyleBackColor = true;
            this.selectSupplyTypeRadioButton2.CheckedChanged += new System.EventHandler(this.selectSupplyTypeRadioButton2_CheckedChanged);
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumLabel.Location = new System.Drawing.Point(12, 67);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(89, 15);
            this.sumLabel.TabIndex = 7;
            this.sumLabel.Text = "Введите сумму";
            // 
            // sumTextBox
            // 
            this.sumTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumTextBox.Location = new System.Drawing.Point(143, 64);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(681, 23);
            this.sumTextBox.TabIndex = 8;
            this.sumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sumTextBox_KeyPress);
            // 
            // CreateSupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 148);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.selectSupplyTypeRadioButton2);
            this.Controls.Add(this.selectSupplyTypeRadioButton1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.enterQuantityTextBox);
            this.Controls.Add(this.selectMaterialOrConsumablesComboBox);
            this.Controls.Add(this.enterQuantityLabel);
            this.Controls.Add(this.selectMaterialOrConsumablesLabel);
            this.Name = "CreateSupplyForm";
            this.Text = "Создать поставку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label selectMaterialOrConsumablesLabel;
        private Label enterQuantityLabel;
        private ComboBox selectMaterialOrConsumablesComboBox;
        private TextBox enterQuantityTextBox;
        private Button createButton;
        private RadioButton selectSupplyTypeRadioButton1;
        private RadioButton selectSupplyTypeRadioButton2;
        private Label sumLabel;
        private TextBox sumTextBox;
    }
}