namespace Enterprise_Managment_IS
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public bool devMode = false;

        public List<Panel> MainPanels = null;
        public List<Panel> DeveloperPanels = null;

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
            this.usersDataButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.storesSettingsButton = new System.Windows.Forms.Button();
            this.developerPunelButton = new System.Windows.Forms.Button();
            this.sqlRequestPanelButton = new System.Windows.Forms.Button();
            this.userPanel = new System.Windows.Forms.Panel();
            this.usersToolbar = new System.Windows.Forms.Panel();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.UserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLogIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsElementPanel = new System.Windows.Forms.Panel();
            this.OrderListLocationViewButton = new System.Windows.Forms.Button();
            this.orderListLocationTextBox = new System.Windows.Forms.TextBox();
            this.OrderListLocationLabel = new System.Windows.Forms.Label();
            this.connStringCreateButton = new System.Windows.Forms.Button();
            this.connectionStringTextBox = new System.Windows.Forms.TextBox();
            this.connectionStringLabel = new System.Windows.Forms.Label();
            this.settingsToolbar = new System.Windows.Forms.Panel();
            this.exportFromJSONToDB = new System.Windows.Forms.Button();
            this.eportDataFromDataBaseButton = new System.Windows.Forms.Button();
            this.createNewDBButton = new System.Windows.Forms.Button();
            this.changeSettings = new System.Windows.Forms.Button();
            this.developerPanel = new System.Windows.Forms.Panel();
            this.usersFormPanel = new System.Windows.Forms.Panel();
            this.openStoreWarehouseWorkerFormButton = new System.Windows.Forms.Button();
            this.directorFormButton = new System.Windows.Forms.Button();
            this.HRFormButton = new System.Windows.Forms.Button();
            this.openFactoryWarehouseWorkerFormButton = new System.Windows.Forms.Button();
            this.developerSettingsPanel = new System.Windows.Forms.Panel();
            this.customizingDropdownListsButton = new System.Windows.Forms.Button();
            this.customizingDropdownListsLabel = new System.Windows.Forms.Label();
            this.developerMenu = new System.Windows.Forms.Panel();
            this.developerSettingsButton = new System.Windows.Forms.Button();
            this.dropAllSettingsButton = new System.Windows.Forms.Button();
            this.openUsersFormButton = new System.Windows.Forms.Button();
            this.OrderListLocationFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.storesSettingsPanel = new System.Windows.Forms.Panel();
            this.storesPanel = new System.Windows.Forms.Panel();
            this.storesDataGridView = new System.Windows.Forms.DataGridView();
            this.Store_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Store_director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Store_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sellers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storesToolbar = new System.Windows.Forms.Panel();
            this.addStoreButton = new System.Windows.Forms.Button();
            this.storesSettingsToolbar = new System.Windows.Forms.Panel();
            this.warehousesButton = new System.Windows.Forms.Button();
            this.storesButton = new System.Windows.Forms.Button();
            this.sqlRequestPanel = new System.Windows.Forms.Panel();
            this.sqlRequestContentPanel = new System.Windows.Forms.Panel();
            this.sqlRequestBackgroundAnswerPanel = new System.Windows.Forms.Panel();
            this.sqlAnswerLabel = new System.Windows.Forms.Label();
            this.sqlRequestTextTextBox = new System.Windows.Forms.TextBox();
            this.sqlRequestToolBar = new System.Windows.Forms.Panel();
            this.sqlRequestApplyButton = new System.Windows.Forms.Button();
            this.menuFlowLayoutPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.usersToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.settingsPanel.SuspendLayout();
            this.settingsElementPanel.SuspendLayout();
            this.settingsToolbar.SuspendLayout();
            this.developerPanel.SuspendLayout();
            this.usersFormPanel.SuspendLayout();
            this.developerSettingsPanel.SuspendLayout();
            this.developerMenu.SuspendLayout();
            this.storesSettingsPanel.SuspendLayout();
            this.storesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storesDataGridView)).BeginInit();
            this.storesToolbar.SuspendLayout();
            this.storesSettingsToolbar.SuspendLayout();
            this.sqlRequestPanel.SuspendLayout();
            this.sqlRequestContentPanel.SuspendLayout();
            this.sqlRequestBackgroundAnswerPanel.SuspendLayout();
            this.sqlRequestToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFlowLayoutPanel
            // 
            this.menuFlowLayoutPanel.AutoScroll = true;
            this.menuFlowLayoutPanel.AutoScrollMargin = new System.Drawing.Size(1, 0);
            this.menuFlowLayoutPanel.Controls.Add(this.usersDataButton);
            this.menuFlowLayoutPanel.Controls.Add(this.settingsButton);
            this.menuFlowLayoutPanel.Controls.Add(this.storesSettingsButton);
            this.menuFlowLayoutPanel.Controls.Add(this.developerPunelButton);
            this.menuFlowLayoutPanel.Controls.Add(this.sqlRequestPanelButton);
            this.menuFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.menuFlowLayoutPanel.Name = "menuFlowLayoutPanel";
            this.menuFlowLayoutPanel.Size = new System.Drawing.Size(287, 1041);
            this.menuFlowLayoutPanel.TabIndex = 0;
            // 
            // usersDataButton
            // 
            this.usersDataButton.Location = new System.Drawing.Point(3, 3);
            this.usersDataButton.Name = "usersDataButton";
            this.usersDataButton.Size = new System.Drawing.Size(259, 56);
            this.usersDataButton.TabIndex = 1;
            this.usersDataButton.Text = "Пользователи";
            this.usersDataButton.UseVisualStyleBackColor = true;
            this.usersDataButton.Click += new System.EventHandler(this.UsersDataButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(3, 65);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(259, 56);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // storesSettingsButton
            // 
            this.storesSettingsButton.Location = new System.Drawing.Point(3, 127);
            this.storesSettingsButton.Name = "storesSettingsButton";
            this.storesSettingsButton.Size = new System.Drawing.Size(259, 56);
            this.storesSettingsButton.TabIndex = 4;
            this.storesSettingsButton.Text = "Настройка магазинов";
            this.storesSettingsButton.UseVisualStyleBackColor = true;
            this.storesSettingsButton.Click += new System.EventHandler(this.storesSettingsButton_Click);
            // 
            // developerPunelButton
            // 
            this.developerPunelButton.Location = new System.Drawing.Point(3, 189);
            this.developerPunelButton.Name = "developerPunelButton";
            this.developerPunelButton.Size = new System.Drawing.Size(259, 56);
            this.developerPunelButton.TabIndex = 3;
            this.developerPunelButton.Text = "Панель разработчика";
            this.developerPunelButton.UseVisualStyleBackColor = true;
            this.developerPunelButton.Visible = false;
            this.developerPunelButton.Click += new System.EventHandler(this.developerPunelButton_Click);
            // 
            // sqlRequestPanelButton
            // 
            this.sqlRequestPanelButton.Location = new System.Drawing.Point(3, 251);
            this.sqlRequestPanelButton.Name = "sqlRequestPanelButton";
            this.sqlRequestPanelButton.Size = new System.Drawing.Size(259, 56);
            this.sqlRequestPanelButton.TabIndex = 5;
            this.sqlRequestPanelButton.Text = "SQL";
            this.sqlRequestPanelButton.UseVisualStyleBackColor = true;
            this.sqlRequestPanelButton.Click += new System.EventHandler(this.sqlRequestPanelButton_Click);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.usersToolbar);
            this.userPanel.Controls.Add(this.userDataGridView);
            this.userPanel.Location = new System.Drawing.Point(287, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(1617, 1041);
            this.userPanel.TabIndex = 1;
            this.userPanel.Visible = false;
            // 
            // usersToolbar
            // 
            this.usersToolbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usersToolbar.Controls.Add(this.deleteUserButton);
            this.usersToolbar.Controls.Add(this.changeUserButton);
            this.usersToolbar.Controls.Add(this.addUserButton);
            this.usersToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersToolbar.Location = new System.Drawing.Point(0, 0);
            this.usersToolbar.Name = "usersToolbar";
            this.usersToolbar.Size = new System.Drawing.Size(1617, 59);
            this.usersToolbar.TabIndex = 4;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(230, 9);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(106, 44);
            this.deleteUserButton.TabIndex = 2;
            this.deleteUserButton.Text = "Удалить";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // changeUserButton
            // 
            this.changeUserButton.Location = new System.Drawing.Point(118, 9);
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.Size = new System.Drawing.Size(106, 44);
            this.changeUserButton.TabIndex = 1;
            this.changeUserButton.Text = "Изменить...";
            this.changeUserButton.UseVisualStyleBackColor = true;
            this.changeUserButton.Click += new System.EventHandler(this.ChangeUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(6, 9);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(106, 44);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Text = "Добавить...";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserCode,
            this.Worker,
            this.UserLogIn,
            this.UserPassword});
            this.userDataGridView.Location = new System.Drawing.Point(0, 59);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowTemplate.Height = 25;
            this.userDataGridView.Size = new System.Drawing.Size(1617, 982);
            this.userDataGridView.TabIndex = 5;
            // 
            // UserCode
            // 
            this.UserCode.HeaderText = "Код пользователя";
            this.UserCode.Name = "UserCode";
            this.UserCode.ReadOnly = true;
            this.UserCode.Width = 140;
            // 
            // Worker
            // 
            this.Worker.HeaderText = "Рабочий";
            this.Worker.Name = "Worker";
            this.Worker.ReadOnly = true;
            this.Worker.Width = 400;
            // 
            // UserLogIn
            // 
            this.UserLogIn.HeaderText = "Логин пользователя";
            this.UserLogIn.Name = "UserLogIn";
            this.UserLogIn.ReadOnly = true;
            this.UserLogIn.Width = 140;
            // 
            // UserPassword
            // 
            this.UserPassword.HeaderText = "Пароль пользователя";
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.ReadOnly = true;
            this.UserPassword.Width = 140;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.settingsElementPanel);
            this.settingsPanel.Controls.Add(this.settingsToolbar);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel.Location = new System.Drawing.Point(287, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(1617, 1041);
            this.settingsPanel.TabIndex = 6;
            this.settingsPanel.Visible = false;
            // 
            // settingsElementPanel
            // 
            this.settingsElementPanel.AutoScroll = true;
            this.settingsElementPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.settingsElementPanel.Controls.Add(this.OrderListLocationViewButton);
            this.settingsElementPanel.Controls.Add(this.orderListLocationTextBox);
            this.settingsElementPanel.Controls.Add(this.OrderListLocationLabel);
            this.settingsElementPanel.Controls.Add(this.connStringCreateButton);
            this.settingsElementPanel.Controls.Add(this.connectionStringTextBox);
            this.settingsElementPanel.Controls.Add(this.connectionStringLabel);
            this.settingsElementPanel.Location = new System.Drawing.Point(0, 59);
            this.settingsElementPanel.Name = "settingsElementPanel";
            this.settingsElementPanel.Size = new System.Drawing.Size(1617, 982);
            this.settingsElementPanel.TabIndex = 1;
            // 
            // OrderListLocationViewButton
            // 
            this.OrderListLocationViewButton.Location = new System.Drawing.Point(1298, 35);
            this.OrderListLocationViewButton.Name = "OrderListLocationViewButton";
            this.OrderListLocationViewButton.Size = new System.Drawing.Size(179, 23);
            this.OrderListLocationViewButton.TabIndex = 9;
            this.OrderListLocationViewButton.Text = "Обзор";
            this.OrderListLocationViewButton.UseVisualStyleBackColor = true;
            this.OrderListLocationViewButton.Click += new System.EventHandler(this.OrderListLocationViewButton_Click);
            // 
            // orderListLocationTextBox
            // 
            this.orderListLocationTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderListLocationTextBox.Location = new System.Drawing.Point(359, 35);
            this.orderListLocationTextBox.Name = "orderListLocationTextBox";
            this.orderListLocationTextBox.Size = new System.Drawing.Size(933, 23);
            this.orderListLocationTextBox.TabIndex = 8;
            // 
            // OrderListLocationLabel
            // 
            this.OrderListLocationLabel.AutoSize = true;
            this.OrderListLocationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderListLocationLabel.Location = new System.Drawing.Point(6, 38);
            this.OrderListLocationLabel.Name = "OrderListLocationLabel";
            this.OrderListLocationLabel.Size = new System.Drawing.Size(345, 15);
            this.OrderListLocationLabel.TabIndex = 7;
            this.OrderListLocationLabel.Text = "Расположение директории с текстами заказов (сетевой диск)";
            // 
            // connStringCreateButton
            // 
            this.connStringCreateButton.Location = new System.Drawing.Point(1298, 6);
            this.connStringCreateButton.Name = "connStringCreateButton";
            this.connStringCreateButton.Size = new System.Drawing.Size(179, 23);
            this.connStringCreateButton.TabIndex = 6;
            this.connStringCreateButton.Text = "Создать строку по шаблону";
            this.connStringCreateButton.UseVisualStyleBackColor = true;
            this.connStringCreateButton.Click += new System.EventHandler(this.connStringCreateButton_Click);
            // 
            // connectionStringTextBox
            // 
            this.connectionStringTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectionStringTextBox.Location = new System.Drawing.Point(359, 6);
            this.connectionStringTextBox.Name = "connectionStringTextBox";
            this.connectionStringTextBox.Size = new System.Drawing.Size(933, 23);
            this.connectionStringTextBox.TabIndex = 4;
            // 
            // connectionStringLabel
            // 
            this.connectionStringLabel.AutoSize = true;
            this.connectionStringLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectionStringLabel.Location = new System.Drawing.Point(6, 9);
            this.connectionStringLabel.Name = "connectionStringLabel";
            this.connectionStringLabel.Size = new System.Drawing.Size(199, 15);
            this.connectionStringLabel.TabIndex = 1;
            this.connectionStringLabel.Text = "Строка подключения базы данных";
            // 
            // settingsToolbar
            // 
            this.settingsToolbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsToolbar.Controls.Add(this.exportFromJSONToDB);
            this.settingsToolbar.Controls.Add(this.eportDataFromDataBaseButton);
            this.settingsToolbar.Controls.Add(this.createNewDBButton);
            this.settingsToolbar.Controls.Add(this.changeSettings);
            this.settingsToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsToolbar.Location = new System.Drawing.Point(0, 0);
            this.settingsToolbar.Name = "settingsToolbar";
            this.settingsToolbar.Size = new System.Drawing.Size(1617, 59);
            this.settingsToolbar.TabIndex = 0;
            // 
            // exportFromJSONToDB
            // 
            this.exportFromJSONToDB.Location = new System.Drawing.Point(1188, 9);
            this.exportFromJSONToDB.Name = "exportFromJSONToDB";
            this.exportFromJSONToDB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exportFromJSONToDB.Size = new System.Drawing.Size(135, 44);
            this.exportFromJSONToDB.TabIndex = 3;
            this.exportFromJSONToDB.Text = "Импортировать из JSON в БД";
            this.exportFromJSONToDB.UseVisualStyleBackColor = true;
            this.exportFromJSONToDB.Click += new System.EventHandler(this.exportFromJSONToDB_Click);
            // 
            // eportDataFromDataBaseButton
            // 
            this.eportDataFromDataBaseButton.Location = new System.Drawing.Point(1329, 9);
            this.eportDataFromDataBaseButton.Name = "eportDataFromDataBaseButton";
            this.eportDataFromDataBaseButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eportDataFromDataBaseButton.Size = new System.Drawing.Size(135, 44);
            this.eportDataFromDataBaseButton.TabIndex = 2;
            this.eportDataFromDataBaseButton.Text = "Экспортировать БД в JSON";
            this.eportDataFromDataBaseButton.UseVisualStyleBackColor = true;
            this.eportDataFromDataBaseButton.Click += new System.EventHandler(this.eportDataFromDataBaseButton_Click);
            // 
            // createNewDBButton
            // 
            this.createNewDBButton.Location = new System.Drawing.Point(1470, 9);
            this.createNewDBButton.Name = "createNewDBButton";
            this.createNewDBButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.createNewDBButton.Size = new System.Drawing.Size(135, 44);
            this.createNewDBButton.TabIndex = 1;
            this.createNewDBButton.Text = "Развернуть таблицы в новой БД";
            this.createNewDBButton.UseVisualStyleBackColor = true;
            this.createNewDBButton.Click += new System.EventHandler(this.createNewDBButton_Click);
            // 
            // changeSettings
            // 
            this.changeSettings.Location = new System.Drawing.Point(6, 9);
            this.changeSettings.Name = "changeSettings";
            this.changeSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.changeSettings.Size = new System.Drawing.Size(106, 44);
            this.changeSettings.TabIndex = 0;
            this.changeSettings.Text = "Изменить";
            this.changeSettings.UseVisualStyleBackColor = true;
            this.changeSettings.Click += new System.EventHandler(this.ChangeSettings_Click);
            // 
            // developerPanel
            // 
            this.developerPanel.Controls.Add(this.usersFormPanel);
            this.developerPanel.Controls.Add(this.developerSettingsPanel);
            this.developerPanel.Controls.Add(this.developerMenu);
            this.developerPanel.Location = new System.Drawing.Point(287, 0);
            this.developerPanel.Name = "developerPanel";
            this.developerPanel.Size = new System.Drawing.Size(1617, 1041);
            this.developerPanel.TabIndex = 7;
            this.developerPanel.Visible = false;
            // 
            // usersFormPanel
            // 
            this.usersFormPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.usersFormPanel.Controls.Add(this.openStoreWarehouseWorkerFormButton);
            this.usersFormPanel.Controls.Add(this.directorFormButton);
            this.usersFormPanel.Controls.Add(this.HRFormButton);
            this.usersFormPanel.Controls.Add(this.openFactoryWarehouseWorkerFormButton);
            this.usersFormPanel.Location = new System.Drawing.Point(0, 59);
            this.usersFormPanel.Name = "usersFormPanel";
            this.usersFormPanel.Size = new System.Drawing.Size(1617, 982);
            this.usersFormPanel.TabIndex = 1;
            this.usersFormPanel.Visible = false;
            // 
            // openStoreWarehouseWorkerFormButton
            // 
            this.openStoreWarehouseWorkerFormButton.Location = new System.Drawing.Point(342, 6);
            this.openStoreWarehouseWorkerFormButton.Name = "openStoreWarehouseWorkerFormButton";
            this.openStoreWarehouseWorkerFormButton.Size = new System.Drawing.Size(106, 44);
            this.openStoreWarehouseWorkerFormButton.TabIndex = 4;
            this.openStoreWarehouseWorkerFormButton.Text = "Кладовщик магазина";
            this.openStoreWarehouseWorkerFormButton.UseVisualStyleBackColor = true;
            this.openStoreWarehouseWorkerFormButton.Click += new System.EventHandler(this.openStoreWarehouseWorkerFormButton_Click);
            // 
            // directorFormButton
            // 
            this.directorFormButton.Location = new System.Drawing.Point(230, 6);
            this.directorFormButton.Name = "directorFormButton";
            this.directorFormButton.Size = new System.Drawing.Size(106, 44);
            this.directorFormButton.TabIndex = 3;
            this.directorFormButton.Text = "Директор";
            this.directorFormButton.UseVisualStyleBackColor = true;
            this.directorFormButton.Click += new System.EventHandler(this.directorFormButton_Click);
            // 
            // HRFormButton
            // 
            this.HRFormButton.Location = new System.Drawing.Point(118, 6);
            this.HRFormButton.Name = "HRFormButton";
            this.HRFormButton.Size = new System.Drawing.Size(106, 44);
            this.HRFormButton.TabIndex = 2;
            this.HRFormButton.Text = "Отдел кадров";
            this.HRFormButton.UseVisualStyleBackColor = true;
            this.HRFormButton.Click += new System.EventHandler(this.HRButton_Click);
            // 
            // openFactoryWarehouseWorkerFormButton
            // 
            this.openFactoryWarehouseWorkerFormButton.Location = new System.Drawing.Point(6, 6);
            this.openFactoryWarehouseWorkerFormButton.Name = "openFactoryWarehouseWorkerFormButton";
            this.openFactoryWarehouseWorkerFormButton.Size = new System.Drawing.Size(106, 44);
            this.openFactoryWarehouseWorkerFormButton.TabIndex = 1;
            this.openFactoryWarehouseWorkerFormButton.Text = "Рабочий склада";
            this.openFactoryWarehouseWorkerFormButton.UseVisualStyleBackColor = true;
            this.openFactoryWarehouseWorkerFormButton.Click += new System.EventHandler(this.openFactoryWarehouseWorkerFormButton_Click);
            // 
            // developerSettingsPanel
            // 
            this.developerSettingsPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.developerSettingsPanel.Controls.Add(this.customizingDropdownListsButton);
            this.developerSettingsPanel.Controls.Add(this.customizingDropdownListsLabel);
            this.developerSettingsPanel.Location = new System.Drawing.Point(0, 59);
            this.developerSettingsPanel.Name = "developerSettingsPanel";
            this.developerSettingsPanel.Size = new System.Drawing.Size(1617, 982);
            this.developerSettingsPanel.TabIndex = 8;
            this.developerSettingsPanel.Visible = false;
            // 
            // customizingDropdownListsButton
            // 
            this.customizingDropdownListsButton.Location = new System.Drawing.Point(211, 6);
            this.customizingDropdownListsButton.Name = "customizingDropdownListsButton";
            this.customizingDropdownListsButton.Size = new System.Drawing.Size(103, 29);
            this.customizingDropdownListsButton.TabIndex = 7;
            this.customizingDropdownListsButton.Text = "Настроить...";
            this.customizingDropdownListsButton.UseVisualStyleBackColor = true;
            this.customizingDropdownListsButton.Click += new System.EventHandler(this.customizingDropdownListsButton_Click_1);
            // 
            // customizingDropdownListsLabel
            // 
            this.customizingDropdownListsLabel.AutoSize = true;
            this.customizingDropdownListsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customizingDropdownListsLabel.Location = new System.Drawing.Point(6, 14);
            this.customizingDropdownListsLabel.Name = "customizingDropdownListsLabel";
            this.customizingDropdownListsLabel.Size = new System.Drawing.Size(191, 15);
            this.customizingDropdownListsLabel.TabIndex = 6;
            this.customizingDropdownListsLabel.Text = "Настройка выпадающих списков";
            // 
            // developerMenu
            // 
            this.developerMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.developerMenu.Controls.Add(this.developerSettingsButton);
            this.developerMenu.Controls.Add(this.dropAllSettingsButton);
            this.developerMenu.Controls.Add(this.openUsersFormButton);
            this.developerMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.developerMenu.Location = new System.Drawing.Point(0, 0);
            this.developerMenu.Name = "developerMenu";
            this.developerMenu.Size = new System.Drawing.Size(1617, 59);
            this.developerMenu.TabIndex = 0;
            // 
            // developerSettingsButton
            // 
            this.developerSettingsButton.Location = new System.Drawing.Point(118, 9);
            this.developerSettingsButton.Name = "developerSettingsButton";
            this.developerSettingsButton.Size = new System.Drawing.Size(106, 44);
            this.developerSettingsButton.TabIndex = 2;
            this.developerSettingsButton.Text = "Настройки разработчика";
            this.developerSettingsButton.UseVisualStyleBackColor = true;
            this.developerSettingsButton.Click += new System.EventHandler(this.developerSettingsButton_Click);
            // 
            // dropAllSettingsButton
            // 
            this.dropAllSettingsButton.Location = new System.Drawing.Point(1499, 9);
            this.dropAllSettingsButton.Name = "dropAllSettingsButton";
            this.dropAllSettingsButton.Size = new System.Drawing.Size(106, 44);
            this.dropAllSettingsButton.TabIndex = 1;
            this.dropAllSettingsButton.Text = "Сброс всех настроек";
            this.dropAllSettingsButton.UseVisualStyleBackColor = true;
            this.dropAllSettingsButton.Click += new System.EventHandler(this.dropAllSettingsButton_Click);
            // 
            // openUsersFormButton
            // 
            this.openUsersFormButton.Location = new System.Drawing.Point(6, 9);
            this.openUsersFormButton.Name = "openUsersFormButton";
            this.openUsersFormButton.Size = new System.Drawing.Size(106, 44);
            this.openUsersFormButton.TabIndex = 0;
            this.openUsersFormButton.Text = "Открыть формы";
            this.openUsersFormButton.UseVisualStyleBackColor = true;
            this.openUsersFormButton.Click += new System.EventHandler(this.openUsersFormButton_Click);
            // 
            // storesSettingsPanel
            // 
            this.storesSettingsPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.storesSettingsPanel.Controls.Add(this.storesPanel);
            this.storesSettingsPanel.Controls.Add(this.storesSettingsToolbar);
            this.storesSettingsPanel.Location = new System.Drawing.Point(287, 0);
            this.storesSettingsPanel.Name = "storesSettingsPanel";
            this.storesSettingsPanel.Size = new System.Drawing.Size(1617, 1041);
            this.storesSettingsPanel.TabIndex = 8;
            this.storesSettingsPanel.Visible = false;
            // 
            // storesPanel
            // 
            this.storesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.storesPanel.Controls.Add(this.storesDataGridView);
            this.storesPanel.Controls.Add(this.storesToolbar);
            this.storesPanel.Location = new System.Drawing.Point(0, 59);
            this.storesPanel.Name = "storesPanel";
            this.storesPanel.Size = new System.Drawing.Size(1617, 982);
            this.storesPanel.TabIndex = 1;
            this.storesPanel.Visible = false;
            // 
            // storesDataGridView
            // 
            this.storesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Store_code,
            this.Address,
            this.Store_director,
            this.Store_phone,
            this.Sellers,
            this.WarehouseWorker});
            this.storesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.storesDataGridView.Location = new System.Drawing.Point(0, 56);
            this.storesDataGridView.Name = "storesDataGridView";
            this.storesDataGridView.RowTemplate.Height = 25;
            this.storesDataGridView.Size = new System.Drawing.Size(1617, 926);
            this.storesDataGridView.TabIndex = 2;
            // 
            // Store_code
            // 
            this.Store_code.HeaderText = "Код магазина";
            this.Store_code.Name = "Store_code";
            this.Store_code.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "Адрес";
            this.Address.MinimumWidth = 200;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Store_director
            // 
            this.Store_director.HeaderText = "Директор магазина";
            this.Store_director.Name = "Store_director";
            this.Store_director.ReadOnly = true;
            this.Store_director.Width = 250;
            // 
            // Store_phone
            // 
            this.Store_phone.HeaderText = "Телефон магазина";
            this.Store_phone.Name = "Store_phone";
            this.Store_phone.ReadOnly = true;
            this.Store_phone.Width = 150;
            // 
            // Sellers
            // 
            this.Sellers.HeaderText = "Продавцы";
            this.Sellers.Name = "Sellers";
            this.Sellers.ReadOnly = true;
            // 
            // WarehouseWorker
            // 
            this.WarehouseWorker.HeaderText = "Кладовщик";
            this.WarehouseWorker.Name = "WarehouseWorker";
            this.WarehouseWorker.ReadOnly = true;
            this.WarehouseWorker.Width = 250;
            // 
            // storesToolbar
            // 
            this.storesToolbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.storesToolbar.Controls.Add(this.addStoreButton);
            this.storesToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.storesToolbar.Location = new System.Drawing.Point(0, 0);
            this.storesToolbar.Name = "storesToolbar";
            this.storesToolbar.Size = new System.Drawing.Size(1617, 59);
            this.storesToolbar.TabIndex = 1;
            // 
            // addStoreButton
            // 
            this.addStoreButton.Location = new System.Drawing.Point(6, 6);
            this.addStoreButton.Name = "addStoreButton";
            this.addStoreButton.Size = new System.Drawing.Size(106, 44);
            this.addStoreButton.TabIndex = 0;
            this.addStoreButton.Text = "Добавить...";
            this.addStoreButton.UseVisualStyleBackColor = true;
            this.addStoreButton.Click += new System.EventHandler(this.addStoreButton_Click);
            // 
            // storesSettingsToolbar
            // 
            this.storesSettingsToolbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.storesSettingsToolbar.Controls.Add(this.warehousesButton);
            this.storesSettingsToolbar.Controls.Add(this.storesButton);
            this.storesSettingsToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.storesSettingsToolbar.Location = new System.Drawing.Point(0, 0);
            this.storesSettingsToolbar.Name = "storesSettingsToolbar";
            this.storesSettingsToolbar.Size = new System.Drawing.Size(1617, 59);
            this.storesSettingsToolbar.TabIndex = 0;
            // 
            // warehousesButton
            // 
            this.warehousesButton.Location = new System.Drawing.Point(118, 9);
            this.warehousesButton.Name = "warehousesButton";
            this.warehousesButton.Size = new System.Drawing.Size(106, 44);
            this.warehousesButton.TabIndex = 1;
            this.warehousesButton.Text = "Склады";
            this.warehousesButton.UseVisualStyleBackColor = true;
            this.warehousesButton.Visible = false;
            // 
            // storesButton
            // 
            this.storesButton.Location = new System.Drawing.Point(6, 9);
            this.storesButton.Name = "storesButton";
            this.storesButton.Size = new System.Drawing.Size(106, 44);
            this.storesButton.TabIndex = 0;
            this.storesButton.Text = "Магазины";
            this.storesButton.UseVisualStyleBackColor = true;
            this.storesButton.Click += new System.EventHandler(this.storesButton_Click);
            // 
            // sqlRequestPanel
            // 
            this.sqlRequestPanel.Controls.Add(this.sqlRequestContentPanel);
            this.sqlRequestPanel.Controls.Add(this.sqlRequestToolBar);
            this.sqlRequestPanel.Location = new System.Drawing.Point(287, 0);
            this.sqlRequestPanel.Name = "sqlRequestPanel";
            this.sqlRequestPanel.Size = new System.Drawing.Size(1617, 1041);
            this.sqlRequestPanel.TabIndex = 9;
            this.sqlRequestPanel.Visible = false;
            // 
            // sqlRequestContentPanel
            // 
            this.sqlRequestContentPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sqlRequestContentPanel.Controls.Add(this.sqlRequestBackgroundAnswerPanel);
            this.sqlRequestContentPanel.Controls.Add(this.sqlRequestTextTextBox);
            this.sqlRequestContentPanel.Location = new System.Drawing.Point(0, 59);
            this.sqlRequestContentPanel.Name = "sqlRequestContentPanel";
            this.sqlRequestContentPanel.Size = new System.Drawing.Size(1617, 982);
            this.sqlRequestContentPanel.TabIndex = 1;
            // 
            // sqlRequestBackgroundAnswerPanel
            // 
            this.sqlRequestBackgroundAnswerPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sqlRequestBackgroundAnswerPanel.Controls.Add(this.sqlAnswerLabel);
            this.sqlRequestBackgroundAnswerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sqlRequestBackgroundAnswerPanel.Location = new System.Drawing.Point(0, 392);
            this.sqlRequestBackgroundAnswerPanel.Name = "sqlRequestBackgroundAnswerPanel";
            this.sqlRequestBackgroundAnswerPanel.Size = new System.Drawing.Size(1617, 590);
            this.sqlRequestBackgroundAnswerPanel.TabIndex = 1;
            // 
            // sqlAnswerLabel
            // 
            this.sqlAnswerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sqlAnswerLabel.Location = new System.Drawing.Point(0, 0);
            this.sqlAnswerLabel.Name = "sqlAnswerLabel";
            this.sqlAnswerLabel.Size = new System.Drawing.Size(1617, 590);
            this.sqlAnswerLabel.TabIndex = 0;
            // 
            // sqlRequestTextTextBox
            // 
            this.sqlRequestTextTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqlRequestTextTextBox.Location = new System.Drawing.Point(0, 0);
            this.sqlRequestTextTextBox.Multiline = true;
            this.sqlRequestTextTextBox.Name = "sqlRequestTextTextBox";
            this.sqlRequestTextTextBox.Size = new System.Drawing.Size(1617, 386);
            this.sqlRequestTextTextBox.TabIndex = 0;
            // 
            // sqlRequestToolBar
            // 
            this.sqlRequestToolBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sqlRequestToolBar.Controls.Add(this.sqlRequestApplyButton);
            this.sqlRequestToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqlRequestToolBar.Location = new System.Drawing.Point(0, 0);
            this.sqlRequestToolBar.Name = "sqlRequestToolBar";
            this.sqlRequestToolBar.Size = new System.Drawing.Size(1617, 59);
            this.sqlRequestToolBar.TabIndex = 0;
            // 
            // sqlRequestApplyButton
            // 
            this.sqlRequestApplyButton.Location = new System.Drawing.Point(6, 9);
            this.sqlRequestApplyButton.Name = "sqlRequestApplyButton";
            this.sqlRequestApplyButton.Size = new System.Drawing.Size(106, 44);
            this.sqlRequestApplyButton.TabIndex = 0;
            this.sqlRequestApplyButton.Text = "Выполнить";
            this.sqlRequestApplyButton.UseVisualStyleBackColor = true;
            this.sqlRequestApplyButton.Click += new System.EventHandler(this.sqlRequestApplyButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.storesSettingsPanel);
            this.Controls.Add(this.developerPanel);
            this.Controls.Add(this.sqlRequestPanel);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.menuFlowLayoutPanel);
            this.Name = "AdminForm";
            this.Text = "EMIS - Администратор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuFlowLayoutPanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.usersToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsElementPanel.ResumeLayout(false);
            this.settingsElementPanel.PerformLayout();
            this.settingsToolbar.ResumeLayout(false);
            this.developerPanel.ResumeLayout(false);
            this.usersFormPanel.ResumeLayout(false);
            this.developerSettingsPanel.ResumeLayout(false);
            this.developerSettingsPanel.PerformLayout();
            this.developerMenu.ResumeLayout(false);
            this.storesSettingsPanel.ResumeLayout(false);
            this.storesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storesDataGridView)).EndInit();
            this.storesToolbar.ResumeLayout(false);
            this.storesSettingsToolbar.ResumeLayout(false);
            this.sqlRequestPanel.ResumeLayout(false);
            this.sqlRequestContentPanel.ResumeLayout(false);
            this.sqlRequestContentPanel.PerformLayout();
            this.sqlRequestBackgroundAnswerPanel.ResumeLayout(false);
            this.sqlRequestToolBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel menuFlowLayoutPanel;
        private Button usersDataButton;
        private Button settingsButton;
        private Panel userPanel;
        private Panel usersToolbar;
        private Button deleteUserButton;
        private Button changeUserButton;
        private Button addUserButton;
        private DataGridView userDataGridView;
        private Panel settingsPanel;
        private Panel settingsToolbar;
        private Button changeSettings;
        private Panel settingsElementPanel;
        private TextBox connectionStringTextBox;
        private Label connectionStringLabel;
        private Button createNewDBButton;
        private Button eportDataFromDataBaseButton;
        private Button exportFromJSONToDB;
        private Button connStringCreateButton;
        private Button developerPunelButton;
        private Panel developerPanel;
        private Panel developerMenu;
        private Panel usersFormPanel;
        private Button openFactoryWarehouseWorkerFormButton;
        private Button HRFormButton;
        private DataGridViewTextBoxColumn UserCode;
        private DataGridViewTextBoxColumn Worker;
        private DataGridViewTextBoxColumn UserLogIn;
        private DataGridViewTextBoxColumn UserPassword;
        private Button dropAllSettingsButton;
        private Button openUsersFormButton;
        private Button OrderListLocationViewButton;
        private TextBox orderListLocationTextBox;
        private Label OrderListLocationLabel;
        private Button customizingDropdownListsButton;
        private Label customizingDropdownListsLabel;
        private FolderBrowserDialog OrderListLocationFolderBrowserDialog;
        private Button developerSettingsButton;
        private Panel developerSettingsPanel;
        private Button storesSettingsButton;
        private Panel storesSettingsPanel;
        private Panel storesPanel;
        private Panel storesToolbar;
        private Panel storesSettingsToolbar;
        private DataGridView storesDataGridView;
        private DataGridViewTextBoxColumn Store_code;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Store_director;
        private DataGridViewTextBoxColumn Store_phone;
        private DataGridViewTextBoxColumn Sellers;
        private DataGridViewTextBoxColumn WarehouseWorker;
        private Button warehousesButton;
        private Button storesButton;
        private Button directorFormButton;
        private Button sqlRequestPanelButton;
        private Panel sqlRequestPanel;
        private Panel sqlRequestContentPanel;
        private Panel sqlRequestToolBar;
        private Button sqlRequestApplyButton;
        private Panel sqlRequestBackgroundAnswerPanel;
        private Label sqlAnswerLabel;
        private TextBox sqlRequestTextTextBox;
        private Button openStoreWarehouseWorkerFormButton;
        private Button addStoreButton;
    }
}