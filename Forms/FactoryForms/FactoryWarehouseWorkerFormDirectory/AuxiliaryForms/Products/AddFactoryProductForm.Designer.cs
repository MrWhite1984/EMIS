using Enterprise_Managment_IS.Classes.TypesOfData.ForMultipleForm;

namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Products
{
    partial class AddFactoryProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public int productCode;

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
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productCodeLabel.Location = new System.Drawing.Point(12, 9);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(80, 15);
            this.productCodeLabel.TabIndex = 0;
            this.productCodeLabel.Text = "Код продукта";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameLabel.Location = new System.Drawing.Point(12, 38);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(112, 15);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Название продукта";
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Enabled = false;
            this.productCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productCodeTextBox.Location = new System.Drawing.Point(143, 6);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(545, 23);
            this.productCodeTextBox.TabIndex = 3;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(582, 64);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(106, 44);
            this.addProductButton.TabIndex = 6;
            this.addProductButton.Text = "Добавить";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Location = new System.Drawing.Point(143, 35);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(545, 23);
            this.productNameComboBox.TabIndex = 7;
            // 
            // AddFactoryProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(700, 119);
            this.Controls.Add(this.productNameComboBox);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productCodeLabel);
            this.Name = "AddFactoryProductForm";
            this.Text = "Добавить продукт";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label productCodeLabel;
        private Label productNameLabel;
        private TextBox productCodeTextBox;
        private Button addProductButton;
        private ComboBox productNameComboBox;
    }
}