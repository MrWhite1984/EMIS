namespace Enterprise_Managment_IS.Forms.DirectorFormDirectory.AuxiliaryForms.ProductsForms
{
    partial class AddProductForm
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
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.productDescriptionLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(12, 9);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(80, 15);
            this.productCodeLabel.TabIndex = 0;
            this.productCodeLabel.Text = "Код продукта";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(12, 36);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(59, 15);
            this.ProductNameLabel.TabIndex = 1;
            this.ProductNameLabel.Text = "Название";
            // 
            // productDescriptionLabel
            // 
            this.productDescriptionLabel.AutoSize = true;
            this.productDescriptionLabel.Location = new System.Drawing.Point(12, 65);
            this.productDescriptionLabel.Name = "productDescriptionLabel";
            this.productDescriptionLabel.Size = new System.Drawing.Size(62, 15);
            this.productDescriptionLabel.TabIndex = 2;
            this.productDescriptionLabel.Text = "Описание";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(12, 242);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(35, 15);
            this.productPriceLabel.TabIndex = 3;
            this.productPriceLabel.Text = "Цена";
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Enabled = false;
            this.productCodeTextBox.Location = new System.Drawing.Point(112, 6);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(324, 23);
            this.productCodeTextBox.TabIndex = 4;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(112, 33);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(324, 23);
            this.productNameTextBox.TabIndex = 5;
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.Location = new System.Drawing.Point(112, 62);
            this.productDescriptionTextBox.Multiline = true;
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(324, 171);
            this.productDescriptionTextBox.TabIndex = 6;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(112, 239);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(324, 23);
            this.productPriceTextBox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(330, 268);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 44);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(447, 322);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.productDescriptionTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productDescriptionLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.productCodeLabel);
            this.Name = "AddProductForm";
            this.Text = "Добавить продукт";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label productCodeLabel;
        private Label ProductNameLabel;
        private Label productDescriptionLabel;
        private Label productPriceLabel;
        private TextBox productCodeTextBox;
        private TextBox productNameTextBox;
        private TextBox productDescriptionTextBox;
        private TextBox productPriceTextBox;
        private Button addButton;
    }
}