namespace Enterprise_Managment_IS.Forms.AdminFormDirectory.SettingsForms
{
    partial class ExportDataFromDataBaseForm
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
            this.exportButton = new System.Windows.Forms.Button();
            this.specifyThePathToTheSaveLocationLabel = new System.Windows.Forms.Label();
            this.specifyThePathToTheSaveLocationTextBox = new System.Windows.Forms.TextBox();
            this.directoryNameLabel = new System.Windows.Forms.Label();
            this.directoryNameTextBox = new System.Windows.Forms.TextBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(552, 68);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(106, 44);
            this.exportButton.TabIndex = 0;
            this.exportButton.Text = "Экспорт";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // specifyThePathToTheSaveLocationLabel
            // 
            this.specifyThePathToTheSaveLocationLabel.AutoSize = true;
            this.specifyThePathToTheSaveLocationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.specifyThePathToTheSaveLocationLabel.Location = new System.Drawing.Point(12, 9);
            this.specifyThePathToTheSaveLocationLabel.Name = "specifyThePathToTheSaveLocationLabel";
            this.specifyThePathToTheSaveLocationLabel.Size = new System.Drawing.Size(192, 15);
            this.specifyThePathToTheSaveLocationLabel.TabIndex = 1;
            this.specifyThePathToTheSaveLocationLabel.Text = "Укажите путь к месту сохранения";
            // 
            // specifyThePathToTheSaveLocationTextBox
            // 
            this.specifyThePathToTheSaveLocationTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.specifyThePathToTheSaveLocationTextBox.Location = new System.Drawing.Point(210, 9);
            this.specifyThePathToTheSaveLocationTextBox.Name = "specifyThePathToTheSaveLocationTextBox";
            this.specifyThePathToTheSaveLocationTextBox.Size = new System.Drawing.Size(339, 23);
            this.specifyThePathToTheSaveLocationTextBox.TabIndex = 2;
            // 
            // directoryNameLabel
            // 
            this.directoryNameLabel.AutoSize = true;
            this.directoryNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.directoryNameLabel.Location = new System.Drawing.Point(12, 41);
            this.directoryNameLabel.Name = "directoryNameLabel";
            this.directoryNameLabel.Size = new System.Drawing.Size(95, 15);
            this.directoryNameLabel.TabIndex = 3;
            this.directoryNameLabel.Text = "Название папки";
            // 
            // directoryNameTextBox
            // 
            this.directoryNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.directoryNameTextBox.Location = new System.Drawing.Point(210, 38);
            this.directoryNameTextBox.Name = "directoryNameTextBox";
            this.directoryNameTextBox.Size = new System.Drawing.Size(339, 23);
            this.directoryNameTextBox.TabIndex = 4;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(552, 9);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(106, 23);
            this.viewButton.TabIndex = 5;
            this.viewButton.Text = "Обзор...";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // ExportDataFromDataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 119);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.directoryNameTextBox);
            this.Controls.Add(this.directoryNameLabel);
            this.Controls.Add(this.specifyThePathToTheSaveLocationTextBox);
            this.Controls.Add(this.specifyThePathToTheSaveLocationLabel);
            this.Controls.Add(this.exportButton);
            this.Name = "ExportDataFromDataBaseForm";
            this.Text = "Экспортировать данные из базы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exportButton;
        private Label specifyThePathToTheSaveLocationLabel;
        private TextBox specifyThePathToTheSaveLocationTextBox;
        private Label directoryNameLabel;
        private TextBox directoryNameTextBox;
        private Button viewButton;
        private FolderBrowserDialog folderBrowserDialog;
    }
}