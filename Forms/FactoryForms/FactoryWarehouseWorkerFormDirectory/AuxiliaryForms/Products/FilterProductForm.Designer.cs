namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Products
{
    partial class FilterProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public DataGridView productDataGridView = null;

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
            this.filterTextLabel = new System.Windows.Forms.Label();
            this.filterTextTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filterTextLabel
            // 
            this.filterTextLabel.AutoSize = true;
            this.filterTextLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterTextLabel.Location = new System.Drawing.Point(12, 9);
            this.filterTextLabel.Name = "filterTextLabel";
            this.filterTextLabel.Size = new System.Drawing.Size(129, 15);
            this.filterTextLabel.TabIndex = 0;
            this.filterTextLabel.Text = "Текст для фильтрации";
            // 
            // filterTextTextBox
            // 
            this.filterTextTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterTextTextBox.Location = new System.Drawing.Point(147, 6);
            this.filterTextTextBox.Name = "filterTextTextBox";
            this.filterTextTextBox.Size = new System.Drawing.Size(530, 23);
            this.filterTextTextBox.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(459, 35);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 44);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Сбросить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(571, 35);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(106, 44);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // FilterProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(689, 91);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.filterTextTextBox);
            this.Controls.Add(this.filterTextLabel);
            this.Name = "FilterProductForm";
            this.Text = "Фильтровать продукты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label filterTextLabel;
        private TextBox filterTextTextBox;
        private Button cancelButton;
        private Button applyButton;
    }
}