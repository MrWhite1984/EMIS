namespace Enterprise_Managment_IS.Forms.AdminFormDirectory.SettingsForms
{
    partial class CustomizingDropdownListsForm
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
            this.selectComboBoxComboBox = new System.Windows.Forms.ComboBox();
            this.selectComboBoxNameLabel = new System.Windows.Forms.Label();
            this.dataForChangingLabel = new System.Windows.Forms.Label();
            this.addDataButton = new System.Windows.Forms.Button();
            this.deleteDataButton = new System.Windows.Forms.Button();
            this.dataForChangingTextBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // selectComboBoxComboBox
            // 
            this.selectComboBoxComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectComboBoxComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectComboBoxComboBox.FormattingEnabled = true;
            this.selectComboBoxComboBox.Location = new System.Drawing.Point(202, 6);
            this.selectComboBoxComboBox.Name = "selectComboBoxComboBox";
            this.selectComboBoxComboBox.Size = new System.Drawing.Size(474, 23);
            this.selectComboBoxComboBox.TabIndex = 0;
            this.selectComboBoxComboBox.TextChanged += new System.EventHandler(this.selectComboBoxComboBox_TextChanged);
            // 
            // selectComboBoxNameLabel
            // 
            this.selectComboBoxNameLabel.AutoSize = true;
            this.selectComboBoxNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectComboBoxNameLabel.Location = new System.Drawing.Point(12, 9);
            this.selectComboBoxNameLabel.Name = "selectComboBoxNameLabel";
            this.selectComboBoxNameLabel.Size = new System.Drawing.Size(181, 15);
            this.selectComboBoxNameLabel.TabIndex = 1;
            this.selectComboBoxNameLabel.Text = "Выберите выпадающий список";
            // 
            // dataForChangingLabel
            // 
            this.dataForChangingLabel.AutoSize = true;
            this.dataForChangingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataForChangingLabel.Location = new System.Drawing.Point(12, 38);
            this.dataForChangingLabel.Name = "dataForChangingLabel";
            this.dataForChangingLabel.Size = new System.Drawing.Size(136, 15);
            this.dataForChangingLabel.TabIndex = 2;
            this.dataForChangingLabel.Text = "Данные для изменений";
            // 
            // addDataButton
            // 
            this.addDataButton.Location = new System.Drawing.Point(458, 64);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(106, 44);
            this.addDataButton.TabIndex = 4;
            this.addDataButton.Text = "Добавить";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // deleteDataButton
            // 
            this.deleteDataButton.Location = new System.Drawing.Point(570, 64);
            this.deleteDataButton.Name = "deleteDataButton";
            this.deleteDataButton.Size = new System.Drawing.Size(106, 44);
            this.deleteDataButton.TabIndex = 5;
            this.deleteDataButton.Text = "Удалить";
            this.deleteDataButton.UseVisualStyleBackColor = true;
            this.deleteDataButton.Click += new System.EventHandler(this.deleteDataButton_Click);
            // 
            // dataForChangingTextBox
            // 
            this.dataForChangingTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataForChangingTextBox.FormattingEnabled = true;
            this.dataForChangingTextBox.Location = new System.Drawing.Point(202, 35);
            this.dataForChangingTextBox.Name = "dataForChangingTextBox";
            this.dataForChangingTextBox.Size = new System.Drawing.Size(474, 23);
            this.dataForChangingTextBox.TabIndex = 6;
            // 
            // CustomizingDropdownListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 118);
            this.Controls.Add(this.dataForChangingTextBox);
            this.Controls.Add(this.deleteDataButton);
            this.Controls.Add(this.addDataButton);
            this.Controls.Add(this.dataForChangingLabel);
            this.Controls.Add(this.selectComboBoxNameLabel);
            this.Controls.Add(this.selectComboBoxComboBox);
            this.Name = "CustomizingDropdownListsForm";
            this.Text = "Настроить выпадающие списки";
            this.Load += new System.EventHandler(this.CustomizingDropdownListsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox selectComboBoxComboBox;
        private Label selectComboBoxNameLabel;
        private Label dataForChangingLabel;
        private Button addDataButton;
        private Button deleteDataButton;
        private ComboBox dataForChangingTextBox;
    }
}