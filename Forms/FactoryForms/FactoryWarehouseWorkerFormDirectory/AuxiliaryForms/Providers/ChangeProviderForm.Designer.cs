namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Providers
{
    partial class ChangeProviderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public int index = 0;

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
            this.providerCodeLabel = new System.Windows.Forms.Label();
            this.providerNameLabel = new System.Windows.Forms.Label();
            this.providerAddressLabel = new System.Windows.Forms.Label();
            this.providerDescriptionLabel = new System.Windows.Forms.Label();
            this.providerCodeTextBox = new System.Windows.Forms.TextBox();
            this.providerNameTextBox = new System.Windows.Forms.TextBox();
            this.providerAddressTextBox = new System.Windows.Forms.TextBox();
            this.providerDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // providerCodeLabel
            // 
            this.providerCodeLabel.AutoSize = true;
            this.providerCodeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.providerCodeLabel.Location = new System.Drawing.Point(12, 9);
            this.providerCodeLabel.Name = "providerCodeLabel";
            this.providerCodeLabel.Size = new System.Drawing.Size(97, 15);
            this.providerCodeLabel.TabIndex = 0;
            this.providerCodeLabel.Text = "Код поставщика";
            // 
            // providerNameLabel
            // 
            this.providerNameLabel.AutoSize = true;
            this.providerNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.providerNameLabel.Location = new System.Drawing.Point(12, 38);
            this.providerNameLabel.Name = "providerNameLabel";
            this.providerNameLabel.Size = new System.Drawing.Size(129, 15);
            this.providerNameLabel.TabIndex = 1;
            this.providerNameLabel.Text = "Название поставщика";
            // 
            // providerAddressLabel
            // 
            this.providerAddressLabel.AutoSize = true;
            this.providerAddressLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.providerAddressLabel.Location = new System.Drawing.Point(12, 67);
            this.providerAddressLabel.Name = "providerAddressLabel";
            this.providerAddressLabel.Size = new System.Drawing.Size(110, 15);
            this.providerAddressLabel.TabIndex = 2;
            this.providerAddressLabel.Text = "Адрес поставщика";
            // 
            // providerDescriptionLabel
            // 
            this.providerDescriptionLabel.AutoSize = true;
            this.providerDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.providerDescriptionLabel.Location = new System.Drawing.Point(12, 96);
            this.providerDescriptionLabel.Name = "providerDescriptionLabel";
            this.providerDescriptionLabel.Size = new System.Drawing.Size(132, 15);
            this.providerDescriptionLabel.TabIndex = 3;
            this.providerDescriptionLabel.Text = "Описание поставщика";
            // 
            // providerCodeTextBox
            // 
            this.providerCodeTextBox.Enabled = false;
            this.providerCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.providerCodeTextBox.Location = new System.Drawing.Point(161, 6);
            this.providerCodeTextBox.Name = "providerCodeTextBox";
            this.providerCodeTextBox.Size = new System.Drawing.Size(545, 23);
            this.providerCodeTextBox.TabIndex = 4;
            // 
            // providerNameTextBox
            // 
            this.providerNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.providerNameTextBox.Location = new System.Drawing.Point(161, 35);
            this.providerNameTextBox.Name = "providerNameTextBox";
            this.providerNameTextBox.Size = new System.Drawing.Size(545, 23);
            this.providerNameTextBox.TabIndex = 5;
            // 
            // providerAddressTextBox
            // 
            this.providerAddressTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.providerAddressTextBox.Location = new System.Drawing.Point(161, 64);
            this.providerAddressTextBox.Name = "providerAddressTextBox";
            this.providerAddressTextBox.Size = new System.Drawing.Size(545, 23);
            this.providerAddressTextBox.TabIndex = 6;
            // 
            // providerDescriptionTextBox
            // 
            this.providerDescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.providerDescriptionTextBox.Location = new System.Drawing.Point(161, 93);
            this.providerDescriptionTextBox.Multiline = true;
            this.providerDescriptionTextBox.Name = "providerDescriptionTextBox";
            this.providerDescriptionTextBox.Size = new System.Drawing.Size(545, 159);
            this.providerDescriptionTextBox.TabIndex = 7;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(600, 258);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(106, 44);
            this.changeButton.TabIndex = 8;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // ChangeProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(717, 312);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.providerDescriptionTextBox);
            this.Controls.Add(this.providerAddressTextBox);
            this.Controls.Add(this.providerNameTextBox);
            this.Controls.Add(this.providerCodeTextBox);
            this.Controls.Add(this.providerDescriptionLabel);
            this.Controls.Add(this.providerAddressLabel);
            this.Controls.Add(this.providerNameLabel);
            this.Controls.Add(this.providerCodeLabel);
            this.Name = "ChangeProviderForm";
            this.Text = "Изменить поставщика";
            this.Load += new System.EventHandler(this.ChangeProviderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label providerCodeLabel;
        private Label providerNameLabel;
        private Label providerAddressLabel;
        private Label providerDescriptionLabel;
        private TextBox providerCodeTextBox;
        private TextBox providerNameTextBox;
        private TextBox providerAddressTextBox;
        private TextBox providerDescriptionTextBox;
        private Button changeButton;
    }
}