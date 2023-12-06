namespace Enterprise_Managment_IS.Forms.HRWorkerFormDirectory
{
    partial class HRWorkerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public bool devMode = false;

        List<Panel> panels = null;

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
            this.menuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.workersButton = new System.Windows.Forms.Button();
            this.workersPanel = new System.Windows.Forms.Panel();
            this.workersDataGridView = new System.Windows.Forms.DataGridView();
            this.Worker_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Job_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emploement_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checking_account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersToolbar = new System.Windows.Forms.Panel();
            this.deleteWorkerButton = new System.Windows.Forms.Button();
            this.filterWorkerButton = new System.Windows.Forms.Button();
            this.changeWorkerButton = new System.Windows.Forms.Button();
            this.addWorkerButton = new System.Windows.Forms.Button();
            this.menuFlowLayoutPanel.SuspendLayout();
            this.workersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).BeginInit();
            this.workersToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFlowLayoutPanel
            // 
            this.menuFlowLayoutPanel.Controls.Add(this.workersButton);
            this.menuFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.menuFlowLayoutPanel.Name = "menuFlowLayoutPanel";
            this.menuFlowLayoutPanel.Size = new System.Drawing.Size(287, 1041);
            this.menuFlowLayoutPanel.TabIndex = 0;
            // 
            // workersButton
            // 
            this.workersButton.Location = new System.Drawing.Point(3, 3);
            this.workersButton.Name = "workersButton";
            this.workersButton.Size = new System.Drawing.Size(259, 56);
            this.workersButton.TabIndex = 0;
            this.workersButton.Text = "Работники";
            this.workersButton.UseVisualStyleBackColor = true;
            this.workersButton.Click += new System.EventHandler(this.workersButton_Click);
            // 
            // workersPanel
            // 
            this.workersPanel.Controls.Add(this.workersDataGridView);
            this.workersPanel.Controls.Add(this.workersToolbar);
            this.workersPanel.Location = new System.Drawing.Point(287, 0);
            this.workersPanel.Name = "workersPanel";
            this.workersPanel.Size = new System.Drawing.Size(1617, 1041);
            this.workersPanel.TabIndex = 1;
            this.workersPanel.Visible = false;
            // 
            // workersDataGridView
            // 
            this.workersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Worker_code,
            this.Surname,
            this.workerName,
            this.Fname,
            this.Birth,
            this.Phone_number,
            this.Job_title,
            this.Emploement_date,
            this.Salary,
            this.Checking_account});
            this.workersDataGridView.Location = new System.Drawing.Point(0, 59);
            this.workersDataGridView.Name = "workersDataGridView";
            this.workersDataGridView.RowTemplate.Height = 25;
            this.workersDataGridView.Size = new System.Drawing.Size(1617, 982);
            this.workersDataGridView.TabIndex = 1;
            // 
            // Worker_code
            // 
            this.Worker_code.HeaderText = "Код";
            this.Worker_code.Name = "Worker_code";
            this.Worker_code.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Width = 150;
            // 
            // workerName
            // 
            this.workerName.HeaderText = "Имя";
            this.workerName.Name = "workerName";
            this.workerName.ReadOnly = true;
            this.workerName.Width = 150;
            // 
            // Fname
            // 
            this.Fname.HeaderText = "Отчество";
            this.Fname.Name = "Fname";
            this.Fname.ReadOnly = true;
            this.Fname.Width = 150;
            // 
            // Birth
            // 
            this.Birth.HeaderText = "Дата рождения";
            this.Birth.Name = "Birth";
            this.Birth.ReadOnly = true;
            this.Birth.Width = 150;
            // 
            // Phone_number
            // 
            this.Phone_number.HeaderText = "Номер телефона";
            this.Phone_number.Name = "Phone_number";
            this.Phone_number.ReadOnly = true;
            this.Phone_number.Width = 150;
            // 
            // Job_title
            // 
            this.Job_title.HeaderText = "Должность";
            this.Job_title.Name = "Job_title";
            this.Job_title.ReadOnly = true;
            this.Job_title.Width = 150;
            // 
            // Emploement_date
            // 
            this.Emploement_date.HeaderText = "Дата принятия на работу";
            this.Emploement_date.Name = "Emploement_date";
            this.Emploement_date.ReadOnly = true;
            this.Emploement_date.Width = 150;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Зарплата";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Width = 150;
            // 
            // Checking_account
            // 
            this.Checking_account.HeaderText = "Рассчетный счет";
            this.Checking_account.Name = "Checking_account";
            this.Checking_account.ReadOnly = true;
            this.Checking_account.Width = 150;
            // 
            // workersToolbar
            // 
            this.workersToolbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.workersToolbar.Controls.Add(this.deleteWorkerButton);
            this.workersToolbar.Controls.Add(this.filterWorkerButton);
            this.workersToolbar.Controls.Add(this.changeWorkerButton);
            this.workersToolbar.Controls.Add(this.addWorkerButton);
            this.workersToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.workersToolbar.Location = new System.Drawing.Point(0, 0);
            this.workersToolbar.Name = "workersToolbar";
            this.workersToolbar.Size = new System.Drawing.Size(1617, 59);
            this.workersToolbar.TabIndex = 0;
            // 
            // deleteWorkerButton
            // 
            this.deleteWorkerButton.Location = new System.Drawing.Point(1499, 9);
            this.deleteWorkerButton.Name = "deleteWorkerButton";
            this.deleteWorkerButton.Size = new System.Drawing.Size(106, 44);
            this.deleteWorkerButton.TabIndex = 3;
            this.deleteWorkerButton.Text = "Удалить";
            this.deleteWorkerButton.UseVisualStyleBackColor = true;
            this.deleteWorkerButton.Click += new System.EventHandler(this.deleteWorkerButton_Click);
            // 
            // filterWorkerButton
            // 
            this.filterWorkerButton.Location = new System.Drawing.Point(230, 9);
            this.filterWorkerButton.Name = "filterWorkerButton";
            this.filterWorkerButton.Size = new System.Drawing.Size(106, 44);
            this.filterWorkerButton.TabIndex = 2;
            this.filterWorkerButton.Text = "Фильтровать...";
            this.filterWorkerButton.UseVisualStyleBackColor = true;
            // 
            // changeWorkerButton
            // 
            this.changeWorkerButton.Location = new System.Drawing.Point(118, 9);
            this.changeWorkerButton.Name = "changeWorkerButton";
            this.changeWorkerButton.Size = new System.Drawing.Size(106, 44);
            this.changeWorkerButton.TabIndex = 1;
            this.changeWorkerButton.Text = "Изменить...";
            this.changeWorkerButton.UseVisualStyleBackColor = true;
            // 
            // addWorkerButton
            // 
            this.addWorkerButton.Location = new System.Drawing.Point(6, 9);
            this.addWorkerButton.Name = "addWorkerButton";
            this.addWorkerButton.Size = new System.Drawing.Size(106, 44);
            this.addWorkerButton.TabIndex = 0;
            this.addWorkerButton.Text = "Добавить...";
            this.addWorkerButton.UseVisualStyleBackColor = true;
            this.addWorkerButton.Click += new System.EventHandler(this.addWorkerButton_Click);
            // 
            // HRWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.workersPanel);
            this.Controls.Add(this.menuFlowLayoutPanel);
            this.Name = "HRWorkerForm";
            this.Text = "EMIS - Отдел кадров";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HRWorkerForm_FormClosed);
            this.Load += new System.EventHandler(this.HRWorkerForm_Load);
            this.menuFlowLayoutPanel.ResumeLayout(false);
            this.workersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).EndInit();
            this.workersToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel menuFlowLayoutPanel;
        private Button workersButton;
        private Panel workersPanel;
        private Panel workersToolbar;
        private DataGridView workersDataGridView;
        private DataGridViewTextBoxColumn Worker_code;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn workerName;
        private DataGridViewTextBoxColumn Fname;
        private DataGridViewTextBoxColumn Birth;
        private DataGridViewTextBoxColumn Phone_number;
        private DataGridViewTextBoxColumn Job_title;
        private DataGridViewTextBoxColumn Emploement_date;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn Checking_account;
        private Button addWorkerButton;
        private Button deleteWorkerButton;
        private Button filterWorkerButton;
        private Button changeWorkerButton;
    }
}