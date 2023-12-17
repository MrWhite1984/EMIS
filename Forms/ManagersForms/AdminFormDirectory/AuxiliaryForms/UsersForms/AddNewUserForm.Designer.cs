using Enterprise_Managment_IS.Classes.Other;

namespace Enterprise_Managment_IS.Forms.AdminFormDirectory
{
    partial class AddNewUserForm
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
            this.components = new System.ComponentModel.Container();
            this.userCodeLabel = new System.Windows.Forms.Label();
            this.userCodeTextBox = new System.Windows.Forms.TextBox();
            this.workerLabel = new System.Windows.Forms.Label();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.userLogInTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.workerComboBox = new System.Windows.Forms.ComboBox();
            this.userJobTitleComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            this.userCodeTextBox.Location = new System.Drawing.Point(139, 6);
            this.userCodeTextBox.Name = "userCodeTextBox";
            this.userCodeTextBox.Size = new System.Drawing.Size(260, 23);
            this.userCodeTextBox.TabIndex = 1;
            // 
            // workerLabel
            // 
            this.workerLabel.AutoSize = true;
            this.workerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.workerLabel.Location = new System.Drawing.Point(12, 38);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(45, 15);
            this.workerLabel.TabIndex = 2;
            this.workerLabel.Text = "Форма";
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPasswordLabel.Location = new System.Drawing.Point(12, 67);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(84, 15);
            this.userPasswordLabel.TabIndex = 4;
            this.userPasswordLabel.Text = "Пользователь";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(12, 96);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(41, 15);
            this.loginLabel.TabIndex = 6;
            this.loginLabel.Text = "Логин";
            // 
            // userLogInTextBox
            // 
            this.userLogInTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLogInTextBox.Location = new System.Drawing.Point(139, 93);
            this.userLogInTextBox.Name = "userLogInTextBox";
            this.userLogInTextBox.Size = new System.Drawing.Size(260, 23);
            this.userLogInTextBox.TabIndex = 7;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(12, 125);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(49, 15);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Пароль";
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userPasswordTextBox.Location = new System.Drawing.Point(139, 122);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(260, 23);
            this.userPasswordTextBox.TabIndex = 9;
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addUserButton.Location = new System.Drawing.Point(293, 151);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(106, 44);
            this.addUserButton.TabIndex = 16;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // workerComboBox
            // 
            this.workerComboBox.FormattingEnabled = true;
            this.workerComboBox.Location = new System.Drawing.Point(139, 64);
            this.workerComboBox.Name = "workerComboBox";
            this.workerComboBox.Size = new System.Drawing.Size(260, 23);
            this.workerComboBox.TabIndex = 18;
            // 
            // userJobTitleComboBox
            // 
            this.userJobTitleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userJobTitleComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userJobTitleComboBox.FormattingEnabled = true;
            this.userJobTitleComboBox.Location = new System.Drawing.Point(139, 35);
            this.userJobTitleComboBox.Name = "userJobTitleComboBox";
            this.userJobTitleComboBox.Size = new System.Drawing.Size(260, 23);
            this.userJobTitleComboBox.TabIndex = 15;
            this.userJobTitleComboBox.SelectedValueChanged += new System.EventHandler(this.userJobTitleComboBox_SelectedValueChanged);
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(409, 204);
            this.Controls.Add(this.workerComboBox);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.userJobTitleComboBox);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userLogInTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.userPasswordLabel);
            this.Controls.Add(this.workerLabel);
            this.Controls.Add(this.userCodeTextBox);
            this.Controls.Add(this.userCodeLabel);
            this.Name = "AddNewUserForm";
            this.Text = "Добавить пользователя";
            this.Load += new System.EventHandler(this.AddNewUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label userCodeLabel;
        private TextBox userCodeTextBox;
        private Label workerLabel;
        private Label userPasswordLabel;
        private Label loginLabel;
        private TextBox userLogInTextBox;
        private Label passwordLabel;
        private TextBox userPasswordTextBox;
        private Button addUserButton;
        private ErrorProvider errorProvider;
        private ComboBox workerComboBox;
        private ComboBox userJobTitleComboBox;
    }
}