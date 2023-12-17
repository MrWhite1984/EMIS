namespace Enterprise_Managment_IS.Forms.AdminFormDirectory
{
    partial class NewDBCreaterForm
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
            this.connectionStringLabel = new System.Windows.Forms.Label();
            this.connectionStringTextBox = new System.Windows.Forms.TextBox();
            this.connStringCreateButton = new System.Windows.Forms.Button();
            this.createNewDBButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectionStringLabel
            // 
            this.connectionStringLabel.AutoSize = true;
            this.connectionStringLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectionStringLabel.Location = new System.Drawing.Point(12, 9);
            this.connectionStringLabel.Name = "connectionStringLabel";
            this.connectionStringLabel.Size = new System.Drawing.Size(125, 15);
            this.connectionStringLabel.TabIndex = 0;
            this.connectionStringLabel.Text = "Строка подключения";
            // 
            // connectionStringTextBox
            // 
            this.connectionStringTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectionStringTextBox.Location = new System.Drawing.Point(143, 6);
            this.connectionStringTextBox.Name = "connectionStringTextBox";
            this.connectionStringTextBox.Size = new System.Drawing.Size(433, 23);
            this.connectionStringTextBox.TabIndex = 1;
            // 
            // connStringCreateButton
            // 
            this.connStringCreateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connStringCreateButton.Location = new System.Drawing.Point(582, 6);
            this.connStringCreateButton.Name = "connStringCreateButton";
            this.connStringCreateButton.Size = new System.Drawing.Size(106, 23);
            this.connStringCreateButton.TabIndex = 2;
            this.connStringCreateButton.Text = "По шаблону...";
            this.connStringCreateButton.UseVisualStyleBackColor = true;
            this.connStringCreateButton.Click += new System.EventHandler(this.connStringCreateButton_Click);
            // 
            // createNewDBButton
            // 
            this.createNewDBButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createNewDBButton.Location = new System.Drawing.Point(582, 35);
            this.createNewDBButton.Name = "createNewDBButton";
            this.createNewDBButton.Size = new System.Drawing.Size(106, 44);
            this.createNewDBButton.TabIndex = 3;
            this.createNewDBButton.Text = "Создать";
            this.createNewDBButton.UseVisualStyleBackColor = true;
            this.createNewDBButton.Click += new System.EventHandler(this.createNewDBButton_Click);
            // 
            // NewDBCreaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(699, 90);
            this.Controls.Add(this.createNewDBButton);
            this.Controls.Add(this.connStringCreateButton);
            this.Controls.Add(this.connectionStringTextBox);
            this.Controls.Add(this.connectionStringLabel);
            this.Name = "NewDBCreaterForm";
            this.Text = "Развернуть новую базу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label connectionStringLabel;
        private TextBox connectionStringTextBox;
        private Button connStringCreateButton;
        private Button createNewDBButton;
    }
}