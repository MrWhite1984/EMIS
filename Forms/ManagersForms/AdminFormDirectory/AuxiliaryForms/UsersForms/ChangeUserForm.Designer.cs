using Enterprise_Managment_IS.Classes.Other;

namespace Enterprise_Managment_IS.Forms.AdminFormDirectory
{
    partial class ChangeUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        public int index { get; set; }
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
            this.userCodeLabel = new System.Windows.Forms.Label();
            this.userCodeTextBox = new System.Windows.Forms.TextBox();
            this.userLogInTextBox = new System.Windows.Forms.TextBox();
            this.userLogInLabel = new System.Windows.Forms.Label();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.workerCodeLabel = new System.Windows.Forms.Label();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.jobTitleComboBox = new System.Windows.Forms.ComboBox();
            this.workerCodeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // userCodeLabel
            // 
            this.userCodeLabel.AutoSize = true;
            this.userCodeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userCodeLabel.Location = new System.Drawing.Point(12, 9);
            this.userCodeLabel.Name = "userCodeLabel";
            this.userCodeLabel.Size = new System.Drawing.Size(105, 15);
            this.userCodeLabel.TabIndex = 0;
            this.userCodeLabel.Text = "Код пользователя";
            // 
            // userCodeTextBox
            // 
            this.userCodeTextBox.Enabled = false;
            this.userCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userCodeTextBox.Location = new System.Drawing.Point(164, 6);
            this.userCodeTextBox.Name = "userCodeTextBox";
            this.userCodeTextBox.Size = new System.Drawing.Size(260, 23);
            this.userCodeTextBox.TabIndex = 1;
            // 
            // userLogInTextBox
            // 
            this.userLogInTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLogInTextBox.Location = new System.Drawing.Point(164, 93);
            this.userLogInTextBox.Name = "userLogInTextBox";
            this.userLogInTextBox.Size = new System.Drawing.Size(260, 23);
            this.userLogInTextBox.TabIndex = 2;
            // 
            // userLogInLabel
            // 
            this.userLogInLabel.AutoSize = true;
            this.userLogInLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLogInLabel.Location = new System.Drawing.Point(12, 96);
            this.userLogInLabel.Name = "userLogInLabel";
            this.userLogInLabel.Size = new System.Drawing.Size(119, 15);
            this.userLogInLabel.TabIndex = 3;
            this.userLogInLabel.Text = "Логин пользователя";
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPasswordLabel.Location = new System.Drawing.Point(12, 125);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(127, 15);
            this.userPasswordLabel.TabIndex = 4;
            this.userPasswordLabel.Text = "Пароль пользователя";
            // 
            // workerCodeLabel
            // 
            this.workerCodeLabel.AutoSize = true;
            this.workerCodeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.workerCodeLabel.Location = new System.Drawing.Point(12, 67);
            this.workerCodeLabel.Name = "workerCodeLabel";
            this.workerCodeLabel.Size = new System.Drawing.Size(59, 15);
            this.workerCodeLabel.TabIndex = 5;
            this.workerCodeLabel.Text = "Работник";
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPasswordTextBox.Location = new System.Drawing.Point(164, 122);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(260, 23);
            this.userPasswordTextBox.TabIndex = 13;
            // 
            // changeUserButton
            // 
            this.changeUserButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeUserButton.Location = new System.Drawing.Point(318, 151);
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.Size = new System.Drawing.Size(106, 44);
            this.changeUserButton.TabIndex = 17;
            this.changeUserButton.Text = "Изменить";
            this.changeUserButton.UseVisualStyleBackColor = true;
            this.changeUserButton.Click += new System.EventHandler(this.changeUserButton_Click);
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Location = new System.Drawing.Point(12, 38);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(69, 15);
            this.jobTitleLabel.TabIndex = 18;
            this.jobTitleLabel.Text = "Должность";
            // 
            // jobTitleComboBox
            // 
            this.jobTitleComboBox.FormattingEnabled = true;
            this.jobTitleComboBox.Location = new System.Drawing.Point(164, 35);
            this.jobTitleComboBox.Name = "jobTitleComboBox";
            this.jobTitleComboBox.Size = new System.Drawing.Size(260, 23);
            this.jobTitleComboBox.TabIndex = 19;
            // 
            // workerCodeComboBox
            // 
            this.workerCodeComboBox.FormattingEnabled = true;
            this.workerCodeComboBox.Location = new System.Drawing.Point(164, 64);
            this.workerCodeComboBox.Name = "workerCodeComboBox";
            this.workerCodeComboBox.Size = new System.Drawing.Size(260, 23);
            this.workerCodeComboBox.TabIndex = 20;
            // 
            // ChangeUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 208);
            this.Controls.Add(this.workerCodeComboBox);
            this.Controls.Add(this.jobTitleComboBox);
            this.Controls.Add(this.jobTitleLabel);
            this.Controls.Add(this.changeUserButton);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(this.workerCodeLabel);
            this.Controls.Add(this.userPasswordLabel);
            this.Controls.Add(this.userLogInLabel);
            this.Controls.Add(this.userLogInTextBox);
            this.Controls.Add(this.userCodeTextBox);
            this.Controls.Add(this.userCodeLabel);
            this.Name = "ChangeUserForm";
            this.Text = "Изменить пользователя";
            this.Load += new System.EventHandler(this.ChangeUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label userCodeLabel;
        private TextBox userCodeTextBox;
        private TextBox userLogInTextBox;
        private Label userLogInLabel;
        private Label userPasswordLabel;
        private Label workerCodeLabel;
        private TextBox userPasswordTextBox;
        private Button changeUserButton;
        private Label jobTitleLabel;
        private ComboBox jobTitleComboBox;
        private ComboBox workerCodeComboBox;
    }
}