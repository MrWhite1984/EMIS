namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Products
{
    partial class SendFactoryProductToDefectiveForm
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
            this.descriptionOfTheDefectLabel = new System.Windows.Forms.Label();
            this.descriptionOfTheDefectTextBox = new System.Windows.Forms.TextBox();
            this.SendFactoryProductToDefectiveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionOfTheDefectLabel
            // 
            this.descriptionOfTheDefectLabel.AutoSize = true;
            this.descriptionOfTheDefectLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionOfTheDefectLabel.Location = new System.Drawing.Point(12, 9);
            this.descriptionOfTheDefectLabel.Name = "descriptionOfTheDefectLabel";
            this.descriptionOfTheDefectLabel.Size = new System.Drawing.Size(109, 15);
            this.descriptionOfTheDefectLabel.TabIndex = 0;
            this.descriptionOfTheDefectLabel.Text = "Описание дефекта";
            // 
            // descriptionOfTheDefectTextBox
            // 
            this.descriptionOfTheDefectTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionOfTheDefectTextBox.Location = new System.Drawing.Point(127, 6);
            this.descriptionOfTheDefectTextBox.Multiline = true;
            this.descriptionOfTheDefectTextBox.Name = "descriptionOfTheDefectTextBox";
            this.descriptionOfTheDefectTextBox.Size = new System.Drawing.Size(440, 210);
            this.descriptionOfTheDefectTextBox.TabIndex = 1;
            // 
            // SendFactoryProductToDefectiveButton
            // 
            this.SendFactoryProductToDefectiveButton.Location = new System.Drawing.Point(461, 222);
            this.SendFactoryProductToDefectiveButton.Name = "SendFactoryProductToDefectiveButton";
            this.SendFactoryProductToDefectiveButton.Size = new System.Drawing.Size(106, 44);
            this.SendFactoryProductToDefectiveButton.TabIndex = 2;
            this.SendFactoryProductToDefectiveButton.Text = "В брак";
            this.SendFactoryProductToDefectiveButton.UseVisualStyleBackColor = true;
            this.SendFactoryProductToDefectiveButton.Click += new System.EventHandler(this.SendFactoryProductToDefectiveButton_Click);
            // 
            // SendFactoryProductToDefectiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(580, 278);
            this.Controls.Add(this.SendFactoryProductToDefectiveButton);
            this.Controls.Add(this.descriptionOfTheDefectTextBox);
            this.Controls.Add(this.descriptionOfTheDefectLabel);
            this.Name = "SendFactoryProductToDefectiveForm";
            this.Text = "Отбраковка продукта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label descriptionOfTheDefectLabel;
        private TextBox descriptionOfTheDefectTextBox;
        private Button SendFactoryProductToDefectiveButton;
    }
}