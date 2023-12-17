namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Consumables
{
    partial class AddConsumablesForm
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
            this.consumableCodeLabel = new System.Windows.Forms.Label();
            this.consumableNameLabel = new System.Windows.Forms.Label();
            this.consumableDescriptionLabel = new System.Windows.Forms.Label();
            this.providerLabel = new System.Windows.Forms.Label();
            this.consumableCodeTextBox = new System.Windows.Forms.TextBox();
            this.consumableNameTextBox = new System.Windows.Forms.TextBox();
            this.consumableDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.providerComboBox = new System.Windows.Forms.ComboBox();
            this.addСonsumableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // consumableCodeLabel
            // 
            this.consumableCodeLabel.AutoSize = true;
            this.consumableCodeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consumableCodeLabel.Location = new System.Drawing.Point(12, 9);
            this.consumableCodeLabel.Name = "consumableCodeLabel";
            this.consumableCodeLabel.Size = new System.Drawing.Size(94, 15);
            this.consumableCodeLabel.TabIndex = 0;
            this.consumableCodeLabel.Text = "Код расходника";
            // 
            // consumableNameLabel
            // 
            this.consumableNameLabel.AutoSize = true;
            this.consumableNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consumableNameLabel.Location = new System.Drawing.Point(12, 38);
            this.consumableNameLabel.Name = "consumableNameLabel";
            this.consumableNameLabel.Size = new System.Drawing.Size(126, 15);
            this.consumableNameLabel.TabIndex = 1;
            this.consumableNameLabel.Text = "Название расходника";
            // 
            // consumableDescriptionLabel
            // 
            this.consumableDescriptionLabel.AutoSize = true;
            this.consumableDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consumableDescriptionLabel.Location = new System.Drawing.Point(12, 67);
            this.consumableDescriptionLabel.Name = "consumableDescriptionLabel";
            this.consumableDescriptionLabel.Size = new System.Drawing.Size(129, 15);
            this.consumableDescriptionLabel.TabIndex = 2;
            this.consumableDescriptionLabel.Text = "Описание расходника";
            // 
            // providerLabel
            // 
            this.providerLabel.AutoSize = true;
            this.providerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.providerLabel.Location = new System.Drawing.Point(12, 236);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(70, 15);
            this.providerLabel.TabIndex = 3;
            this.providerLabel.Text = "Поставщик";
            // 
            // consumableCodeTextBox
            // 
            this.consumableCodeTextBox.Enabled = false;
            this.consumableCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consumableCodeTextBox.Location = new System.Drawing.Point(243, 6);
            this.consumableCodeTextBox.Name = "consumableCodeTextBox";
            this.consumableCodeTextBox.Size = new System.Drawing.Size(545, 23);
            this.consumableCodeTextBox.TabIndex = 4;
            // 
            // consumableNameTextBox
            // 
            this.consumableNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consumableNameTextBox.Location = new System.Drawing.Point(243, 35);
            this.consumableNameTextBox.Name = "consumableNameTextBox";
            this.consumableNameTextBox.Size = new System.Drawing.Size(545, 23);
            this.consumableNameTextBox.TabIndex = 5;
            // 
            // consumableDescriptionTextBox
            // 
            this.consumableDescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consumableDescriptionTextBox.Location = new System.Drawing.Point(243, 64);
            this.consumableDescriptionTextBox.Multiline = true;
            this.consumableDescriptionTextBox.Name = "consumableDescriptionTextBox";
            this.consumableDescriptionTextBox.Size = new System.Drawing.Size(545, 163);
            this.consumableDescriptionTextBox.TabIndex = 6;
            // 
            // providerComboBox
            // 
            this.providerComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.providerComboBox.FormattingEnabled = true;
            this.providerComboBox.Location = new System.Drawing.Point(243, 233);
            this.providerComboBox.Name = "providerComboBox";
            this.providerComboBox.Size = new System.Drawing.Size(545, 23);
            this.providerComboBox.TabIndex = 7;
            // 
            // addСonsumableButton
            // 
            this.addСonsumableButton.Location = new System.Drawing.Point(682, 262);
            this.addСonsumableButton.Name = "addСonsumableButton";
            this.addСonsumableButton.Size = new System.Drawing.Size(106, 44);
            this.addСonsumableButton.TabIndex = 8;
            this.addСonsumableButton.Text = "Добавить";
            this.addСonsumableButton.UseVisualStyleBackColor = true;
            this.addСonsumableButton.Click += new System.EventHandler(this.addСonsumableButton_Click);
            // 
            // AddConsumablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.addСonsumableButton);
            this.Controls.Add(this.providerComboBox);
            this.Controls.Add(this.consumableDescriptionTextBox);
            this.Controls.Add(this.consumableNameTextBox);
            this.Controls.Add(this.consumableCodeTextBox);
            this.Controls.Add(this.providerLabel);
            this.Controls.Add(this.consumableDescriptionLabel);
            this.Controls.Add(this.consumableNameLabel);
            this.Controls.Add(this.consumableCodeLabel);
            this.Name = "AddConsumablesForm";
            this.Text = "Добавить расходник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label consumableCodeLabel;
        private Label consumableNameLabel;
        private Label consumableDescriptionLabel;
        private Label providerLabel;
        private TextBox consumableCodeTextBox;
        private TextBox consumableNameTextBox;
        private TextBox consumableDescriptionTextBox;
        private ComboBox providerComboBox;
        private Button addСonsumableButton;
    }
}