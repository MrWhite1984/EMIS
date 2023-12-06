namespace Enterprise_Managment_IS.Forms.AdminFormDirectory.SettingsForms
{
    partial class ExportDataFromJSONForm
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
            this.pathToDirectoryLabel = new System.Windows.Forms.Label();
            this.connectionStringLabel = new System.Windows.Forms.Label();
            this.pathToDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.connectionStringTextBox = new System.Windows.Forms.TextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.createConnStrButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathToDirectoryLabel
            // 
            this.pathToDirectoryLabel.AutoSize = true;
            this.pathToDirectoryLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathToDirectoryLabel.Location = new System.Drawing.Point(12, 9);
            this.pathToDirectoryLabel.Name = "pathToDirectoryLabel";
            this.pathToDirectoryLabel.Size = new System.Drawing.Size(192, 15);
            this.pathToDirectoryLabel.TabIndex = 0;
            this.pathToDirectoryLabel.Text = "Укажите путь к месту сохранения";
            // 
            // connectionStringLabel
            // 
            this.connectionStringLabel.AutoSize = true;
            this.connectionStringLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectionStringLabel.Location = new System.Drawing.Point(12, 38);
            this.connectionStringLabel.Name = "connectionStringLabel";
            this.connectionStringLabel.Size = new System.Drawing.Size(125, 15);
            this.connectionStringLabel.TabIndex = 1;
            this.connectionStringLabel.Text = "Строка подключения";
            // 
            // pathToDirectoryTextBox
            // 
            this.pathToDirectoryTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathToDirectoryTextBox.Location = new System.Drawing.Point(221, 6);
            this.pathToDirectoryTextBox.Name = "pathToDirectoryTextBox";
            this.pathToDirectoryTextBox.Size = new System.Drawing.Size(339, 23);
            this.pathToDirectoryTextBox.TabIndex = 2;
            // 
            // connectionStringTextBox
            // 
            this.connectionStringTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectionStringTextBox.Location = new System.Drawing.Point(221, 35);
            this.connectionStringTextBox.Name = "connectionStringTextBox";
            this.connectionStringTextBox.Size = new System.Drawing.Size(339, 23);
            this.connectionStringTextBox.TabIndex = 3;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(566, 64);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(106, 44);
            this.importButton.TabIndex = 4;
            this.importButton.Text = "Импорт";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(566, 6);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(106, 23);
            this.viewButton.TabIndex = 5;
            this.viewButton.Text = "Обзор...";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // createConnStrButton
            // 
            this.createConnStrButton.Location = new System.Drawing.Point(566, 35);
            this.createConnStrButton.Name = "createConnStrButton";
            this.createConnStrButton.Size = new System.Drawing.Size(106, 23);
            this.createConnStrButton.TabIndex = 6;
            this.createConnStrButton.Text = "Шаблон...";
            this.createConnStrButton.UseVisualStyleBackColor = true;
            this.createConnStrButton.Click += new System.EventHandler(this.createConnStrButton_Click);
            // 
            // ExportDataFromJSONForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 117);
            this.Controls.Add(this.createConnStrButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.connectionStringTextBox);
            this.Controls.Add(this.pathToDirectoryTextBox);
            this.Controls.Add(this.connectionStringLabel);
            this.Controls.Add(this.pathToDirectoryLabel);
            this.Name = "ExportDataFromJSONForm";
            this.Text = "Импортировать данные в базу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label pathToDirectoryLabel;
        private Label connectionStringLabel;
        private TextBox pathToDirectoryTextBox;
        private TextBox connectionStringTextBox;
        private Button importButton;
        private Button viewButton;
        private FolderBrowserDialog folderBrowserDialog;
        private Button createConnStrButton;
    }
}