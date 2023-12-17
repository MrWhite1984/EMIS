namespace Enterprise_Managment_IS.Forms.AdminFormDirectory.SettingsForms
{
    partial class CreateConnStringForm
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
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.dataBaseNameLabel = new System.Windows.Forms.Label();
            this.dataBaseNameTextBox = new System.Windows.Forms.TextBox();
            this.createConnStringButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serverNameLabel.Location = new System.Drawing.Point(12, 9);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(78, 15);
            this.serverNameLabel.TabIndex = 0;
            this.serverNameLabel.Text = "Имя сервера";
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serverNameTextBox.Location = new System.Drawing.Point(137, 6);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(371, 23);
            this.serverNameTextBox.TabIndex = 1;
            // 
            // dataBaseNameLabel
            // 
            this.dataBaseNameLabel.AutoSize = true;
            this.dataBaseNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataBaseNameLabel.Location = new System.Drawing.Point(12, 38);
            this.dataBaseNameLabel.Name = "dataBaseNameLabel";
            this.dataBaseNameLabel.Size = new System.Drawing.Size(105, 15);
            this.dataBaseNameLabel.TabIndex = 2;
            this.dataBaseNameLabel.Text = "Имя базы данных";
            // 
            // dataBaseNameTextBox
            // 
            this.dataBaseNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataBaseNameTextBox.Location = new System.Drawing.Point(137, 35);
            this.dataBaseNameTextBox.Name = "dataBaseNameTextBox";
            this.dataBaseNameTextBox.Size = new System.Drawing.Size(371, 23);
            this.dataBaseNameTextBox.TabIndex = 3;
            // 
            // createConnStringButton
            // 
            this.createConnStringButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createConnStringButton.Location = new System.Drawing.Point(402, 64);
            this.createConnStringButton.Name = "createConnStringButton";
            this.createConnStringButton.Size = new System.Drawing.Size(106, 44);
            this.createConnStringButton.TabIndex = 4;
            this.createConnStringButton.Text = "Создать";
            this.createConnStringButton.UseVisualStyleBackColor = true;
            this.createConnStringButton.Click += new System.EventHandler(this.createConnStringButton_Click);
            // 
            // CreateConnStringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(520, 118);
            this.Controls.Add(this.createConnStringButton);
            this.Controls.Add(this.dataBaseNameTextBox);
            this.Controls.Add(this.dataBaseNameLabel);
            this.Controls.Add(this.serverNameTextBox);
            this.Controls.Add(this.serverNameLabel);
            this.Name = "CreateConnStringForm";
            this.Text = "Создать строку подключения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label serverNameLabel;
        private TextBox serverNameTextBox;
        private Label dataBaseNameLabel;
        private TextBox dataBaseNameTextBox;
        private Button createConnStringButton;
    }
}