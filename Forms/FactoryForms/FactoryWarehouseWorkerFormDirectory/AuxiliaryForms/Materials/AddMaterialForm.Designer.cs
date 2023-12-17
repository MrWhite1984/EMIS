using Enterprise_Managment_IS.Classes.Other;

namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms
{
    partial class AddMaterialForm
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
            this.materialCodeLabel = new System.Windows.Forms.Label();
            this.materialNameLabel = new System.Windows.Forms.Label();
            this.MaterialDescriptionLabel = new System.Windows.Forms.Label();
            this.materialCodeTextBox = new System.Windows.Forms.TextBox();
            this.materialNameComboBox = new System.Windows.Forms.ComboBox();
            this.materialDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.addMaterialButton = new System.Windows.Forms.Button();
            this.providerLabel = new System.Windows.Forms.Label();
            this.providerComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // materialCodeLabel
            // 
            this.materialCodeLabel.AutoSize = true;
            this.materialCodeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialCodeLabel.Location = new System.Drawing.Point(12, 9);
            this.materialCodeLabel.Name = "materialCodeLabel";
            this.materialCodeLabel.Size = new System.Drawing.Size(89, 15);
            this.materialCodeLabel.TabIndex = 0;
            this.materialCodeLabel.Text = "Код материала";
            // 
            // materialNameLabel
            // 
            this.materialNameLabel.AutoSize = true;
            this.materialNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialNameLabel.Location = new System.Drawing.Point(12, 38);
            this.materialNameLabel.Name = "materialNameLabel";
            this.materialNameLabel.Size = new System.Drawing.Size(121, 15);
            this.materialNameLabel.TabIndex = 1;
            this.materialNameLabel.Text = "Название материала";
            // 
            // MaterialDescriptionLabel
            // 
            this.MaterialDescriptionLabel.AutoSize = true;
            this.MaterialDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaterialDescriptionLabel.Location = new System.Drawing.Point(12, 67);
            this.MaterialDescriptionLabel.Name = "MaterialDescriptionLabel";
            this.MaterialDescriptionLabel.Size = new System.Drawing.Size(124, 15);
            this.MaterialDescriptionLabel.TabIndex = 3;
            this.MaterialDescriptionLabel.Text = "Описание материала";
            // 
            // materialCodeTextBox
            // 
            this.materialCodeTextBox.Enabled = false;
            this.materialCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialCodeTextBox.Location = new System.Drawing.Point(243, 6);
            this.materialCodeTextBox.Name = "materialCodeTextBox";
            this.materialCodeTextBox.Size = new System.Drawing.Size(545, 23);
            this.materialCodeTextBox.TabIndex = 4;
            // 
            // materialNameComboBox
            // 
            this.materialNameComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialNameComboBox.FormattingEnabled = true;
            this.materialNameComboBox.Location = new System.Drawing.Point(243, 35);
            this.materialNameComboBox.Name = "materialNameComboBox";
            this.materialNameComboBox.Size = new System.Drawing.Size(545, 23);
            this.materialNameComboBox.TabIndex = 5;
            // 
            // materialDescriptionTextBox
            // 
            this.materialDescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialDescriptionTextBox.Location = new System.Drawing.Point(243, 64);
            this.materialDescriptionTextBox.Multiline = true;
            this.materialDescriptionTextBox.Name = "materialDescriptionTextBox";
            this.materialDescriptionTextBox.Size = new System.Drawing.Size(545, 156);
            this.materialDescriptionTextBox.TabIndex = 7;
            // 
            // addMaterialButton
            // 
            this.addMaterialButton.Location = new System.Drawing.Point(682, 255);
            this.addMaterialButton.Name = "addMaterialButton";
            this.addMaterialButton.Size = new System.Drawing.Size(106, 44);
            this.addMaterialButton.TabIndex = 11;
            this.addMaterialButton.Text = "Добавить";
            this.addMaterialButton.UseVisualStyleBackColor = true;
            this.addMaterialButton.Click += new System.EventHandler(this.addMaterialButton_Click);
            // 
            // providerLabel
            // 
            this.providerLabel.AutoSize = true;
            this.providerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.providerLabel.Location = new System.Drawing.Point(12, 229);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(70, 15);
            this.providerLabel.TabIndex = 9;
            this.providerLabel.Text = "Поставщик";
            // 
            // providerComboBox
            // 
            this.providerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.providerComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.providerComboBox.FormattingEnabled = true;
            this.providerComboBox.Location = new System.Drawing.Point(243, 226);
            this.providerComboBox.Name = "providerComboBox";
            this.providerComboBox.Size = new System.Drawing.Size(545, 23);
            this.providerComboBox.TabIndex = 10;
            // 
            // AddMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 312);
            this.Controls.Add(this.providerComboBox);
            this.Controls.Add(this.providerLabel);
            this.Controls.Add(this.addMaterialButton);
            this.Controls.Add(this.materialDescriptionTextBox);
            this.Controls.Add(this.materialNameComboBox);
            this.Controls.Add(this.materialCodeTextBox);
            this.Controls.Add(this.MaterialDescriptionLabel);
            this.Controls.Add(this.materialNameLabel);
            this.Controls.Add(this.materialCodeLabel);
            this.Name = "AddMaterialForm";
            this.Text = "Добавить материал";
            this.Load += new System.EventHandler(this.AddMaterialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label materialCodeLabel;
        private Label materialNameLabel;
        private Label MaterialDescriptionLabel;
        private TextBox materialCodeTextBox;
        private ComboBox materialNameComboBox;
        private TextBox materialDescriptionTextBox;
        private Button addMaterialButton;
        private Label providerLabel;
        private ComboBox providerComboBox;
    }
}