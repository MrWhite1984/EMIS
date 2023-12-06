namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory
{
    partial class FactoryWarehouseWorkerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        List<Panel> panels = null;

        public int storeCode;

        public bool devMode = false;

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
            this.materialsButton = new System.Windows.Forms.Button();
            this.suppliesButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.shippingButton = new System.Windows.Forms.Button();
            this.equipmentConsumablesButton = new System.Windows.Forms.Button();
            this.defectiveProductsButton = new System.Windows.Forms.Button();
            this.providersButton = new System.Windows.Forms.Button();
            this.materialsPanel = new System.Windows.Forms.Panel();
            this.materialsDataGridView = new System.Windows.Forms.DataGridView();
            this.Material_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_of_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsToolbar = new System.Windows.Forms.Panel();
            this.filterButton = new System.Windows.Forms.Button();
            this.releaseMaterialButton = new System.Windows.Forms.Button();
            this.deleteMaterialButton = new System.Windows.Forms.Button();
            this.addMaterialButton = new System.Windows.Forms.Button();
            this.suppliesPanel = new System.Windows.Forms.Panel();
            this.suppliesDataGridView = new System.Windows.Forms.DataGridView();
            this.Supply_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supply_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supply_list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_of_supply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provider_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supply_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supply_sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliesToolbar = new System.Windows.Forms.Panel();
            this.generateConductedSuppliesReportButton = new System.Windows.Forms.Button();
            this.generateActiveSuppliesReportButton = new System.Windows.Forms.Button();
            this.generateCanceledSuppliesReportButton = new System.Windows.Forms.Button();
            this.SelectTypeOfSuppliesLabel = new System.Windows.Forms.Label();
            this.SelectTypeOfSuppliesComboBox = new System.Windows.Forms.ComboBox();
            this.cancelSupplyButton = new System.Windows.Forms.Button();
            this.applyASupplyButton = new System.Windows.Forms.Button();
            this.createSupplyButton = new System.Windows.Forms.Button();
            this.consumablePanel = new System.Windows.Forms.Panel();
            this.consumableDataGridView = new System.Windows.Forms.DataGridView();
            this.Consumable_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumable_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_of_consumable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumable_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumable_provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumableToolbar = new System.Windows.Forms.Panel();
            this.filterConsumableButton = new System.Windows.Forms.Button();
            this.releaseConsumableButton = new System.Windows.Forms.Button();
            this.deleteConsumableButton = new System.Windows.Forms.Button();
            this.addConsumableButton = new System.Windows.Forms.Button();
            this.providerPanel = new System.Windows.Forms.Panel();
            this.providerDataGridView = new System.Windows.Forms.DataGridView();
            this.ProviderCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provider_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provider_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provider_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerToolbar = new System.Windows.Forms.Panel();
            this.deleteProviderButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.addProviderButton = new System.Windows.Forms.Button();
            this.productPanel = new System.Windows.Forms.Panel();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.Product_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_of_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productToolbar = new System.Windows.Forms.Panel();
            this.sendToDefectiveButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.acceptProductsButton = new System.Windows.Forms.Button();
            this.filterProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.defectiveProductPanel = new System.Windows.Forms.Panel();
            this.defectiveProductToolbar = new System.Windows.Forms.Panel();
            this.sendTheProductForProcessingButton = new System.Windows.Forms.Button();
            this.defectiveProductDataGridView = new System.Windows.Forms.DataGridView();
            this.Defective_product_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Defective_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOfDefectiveProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_of_defect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_added_defective_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionOrderPanel = new System.Windows.Forms.Panel();
            this.productionOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.Order_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Store = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuFlowLayoutPanel.SuspendLayout();
            this.materialsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).BeginInit();
            this.materialsToolbar.SuspendLayout();
            this.suppliesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesDataGridView)).BeginInit();
            this.suppliesToolbar.SuspendLayout();
            this.consumablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consumableDataGridView)).BeginInit();
            this.consumableToolbar.SuspendLayout();
            this.providerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providerDataGridView)).BeginInit();
            this.providerToolbar.SuspendLayout();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.productToolbar.SuspendLayout();
            this.defectiveProductPanel.SuspendLayout();
            this.defectiveProductToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defectiveProductDataGridView)).BeginInit();
            this.productionOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionOrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuFlowLayoutPanel
            // 
            this.menuFlowLayoutPanel.AutoScroll = true;
            this.menuFlowLayoutPanel.Controls.Add(this.materialsButton);
            this.menuFlowLayoutPanel.Controls.Add(this.suppliesButton);
            this.menuFlowLayoutPanel.Controls.Add(this.productButton);
            this.menuFlowLayoutPanel.Controls.Add(this.ordersButton);
            this.menuFlowLayoutPanel.Controls.Add(this.shippingButton);
            this.menuFlowLayoutPanel.Controls.Add(this.equipmentConsumablesButton);
            this.menuFlowLayoutPanel.Controls.Add(this.defectiveProductsButton);
            this.menuFlowLayoutPanel.Controls.Add(this.providersButton);
            this.menuFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.menuFlowLayoutPanel.Name = "menuFlowLayoutPanel";
            this.menuFlowLayoutPanel.Size = new System.Drawing.Size(287, 1041);
            this.menuFlowLayoutPanel.TabIndex = 0;
            // 
            // materialsButton
            // 
            this.materialsButton.Location = new System.Drawing.Point(3, 3);
            this.materialsButton.Name = "materialsButton";
            this.materialsButton.Size = new System.Drawing.Size(259, 56);
            this.materialsButton.TabIndex = 0;
            this.materialsButton.Text = "Материалы";
            this.materialsButton.UseVisualStyleBackColor = true;
            this.materialsButton.Click += new System.EventHandler(this.materialsButton_Click);
            // 
            // suppliesButton
            // 
            this.suppliesButton.Location = new System.Drawing.Point(3, 65);
            this.suppliesButton.Name = "suppliesButton";
            this.suppliesButton.Size = new System.Drawing.Size(259, 56);
            this.suppliesButton.TabIndex = 1;
            this.suppliesButton.Text = "Поставки";
            this.suppliesButton.UseVisualStyleBackColor = true;
            this.suppliesButton.Click += new System.EventHandler(this.suppliesButton_Click);
            // 
            // productButton
            // 
            this.productButton.Location = new System.Drawing.Point(3, 127);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(259, 56);
            this.productButton.TabIndex = 2;
            this.productButton.Text = "Продукт";
            this.productButton.UseVisualStyleBackColor = true;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(3, 189);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(259, 56);
            this.ordersButton.TabIndex = 3;
            this.ordersButton.Text = "Заказы";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // shippingButton
            // 
            this.shippingButton.Location = new System.Drawing.Point(3, 251);
            this.shippingButton.Name = "shippingButton";
            this.shippingButton.Size = new System.Drawing.Size(259, 56);
            this.shippingButton.TabIndex = 4;
            this.shippingButton.Text = "Отгрузка продукта";
            this.shippingButton.UseVisualStyleBackColor = true;
            // 
            // equipmentConsumablesButton
            // 
            this.equipmentConsumablesButton.Location = new System.Drawing.Point(3, 313);
            this.equipmentConsumablesButton.Name = "equipmentConsumablesButton";
            this.equipmentConsumablesButton.Size = new System.Drawing.Size(259, 56);
            this.equipmentConsumablesButton.TabIndex = 5;
            this.equipmentConsumablesButton.Text = "Расходники для оборудования";
            this.equipmentConsumablesButton.UseVisualStyleBackColor = true;
            this.equipmentConsumablesButton.Click += new System.EventHandler(this.equipmentConsumablesButton_Click);
            // 
            // defectiveProductsButton
            // 
            this.defectiveProductsButton.Location = new System.Drawing.Point(3, 375);
            this.defectiveProductsButton.Name = "defectiveProductsButton";
            this.defectiveProductsButton.Size = new System.Drawing.Size(259, 56);
            this.defectiveProductsButton.TabIndex = 6;
            this.defectiveProductsButton.Text = "Бракованные продукты";
            this.defectiveProductsButton.UseVisualStyleBackColor = true;
            this.defectiveProductsButton.Click += new System.EventHandler(this.defectiveProductsButton_Click);
            // 
            // providersButton
            // 
            this.providersButton.Location = new System.Drawing.Point(3, 437);
            this.providersButton.Name = "providersButton";
            this.providersButton.Size = new System.Drawing.Size(259, 56);
            this.providersButton.TabIndex = 7;
            this.providersButton.Text = "Поставщики";
            this.providersButton.UseVisualStyleBackColor = true;
            this.providersButton.Click += new System.EventHandler(this.providersButton_Click);
            // 
            // materialsPanel
            // 
            this.materialsPanel.Controls.Add(this.materialsDataGridView);
            this.materialsPanel.Controls.Add(this.materialsToolbar);
            this.materialsPanel.Location = new System.Drawing.Point(287, 0);
            this.materialsPanel.Name = "materialsPanel";
            this.materialsPanel.Size = new System.Drawing.Size(1617, 1041);
            this.materialsPanel.TabIndex = 1;
            this.materialsPanel.Visible = false;
            // 
            // materialsDataGridView
            // 
            this.materialsDataGridView.AllowUserToAddRows = false;
            this.materialsDataGridView.AllowUserToDeleteRows = false;
            this.materialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Material_code,
            this.Material_name,
            this.Amount_of_material,
            this.Material_description,
            this.Provider});
            this.materialsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialsDataGridView.Location = new System.Drawing.Point(0, 59);
            this.materialsDataGridView.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.materialsDataGridView.Name = "materialsDataGridView";
            this.materialsDataGridView.RowTemplate.Height = 25;
            this.materialsDataGridView.Size = new System.Drawing.Size(1617, 982);
            this.materialsDataGridView.TabIndex = 1;
            // 
            // Material_code
            // 
            this.Material_code.HeaderText = "Код материала";
            this.Material_code.Name = "Material_code";
            this.Material_code.ReadOnly = true;
            // 
            // Material_name
            // 
            this.Material_name.HeaderText = "Название материала";
            this.Material_name.Name = "Material_name";
            this.Material_name.ReadOnly = true;
            this.Material_name.Width = 300;
            // 
            // Amount_of_material
            // 
            this.Amount_of_material.HeaderText = "Количество материала";
            this.Amount_of_material.Name = "Amount_of_material";
            this.Amount_of_material.ReadOnly = true;
            this.Amount_of_material.Width = 150;
            // 
            // Material_description
            // 
            this.Material_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Material_description.HeaderText = "Описание материала";
            this.Material_description.Name = "Material_description";
            this.Material_description.ReadOnly = true;
            // 
            // Provider
            // 
            this.Provider.HeaderText = "Поставщик";
            this.Provider.Name = "Provider";
            this.Provider.ReadOnly = true;
            this.Provider.Width = 200;
            // 
            // materialsToolbar
            // 
            this.materialsToolbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialsToolbar.Controls.Add(this.filterButton);
            this.materialsToolbar.Controls.Add(this.releaseMaterialButton);
            this.materialsToolbar.Controls.Add(this.deleteMaterialButton);
            this.materialsToolbar.Controls.Add(this.addMaterialButton);
            this.materialsToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialsToolbar.Location = new System.Drawing.Point(0, 0);
            this.materialsToolbar.Name = "materialsToolbar";
            this.materialsToolbar.Size = new System.Drawing.Size(1617, 59);
            this.materialsToolbar.TabIndex = 0;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(230, 9);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(106, 44);
            this.filterButton.TabIndex = 2;
            this.filterButton.Text = "Фильтр...";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // releaseMaterialButton
            // 
            this.releaseMaterialButton.Location = new System.Drawing.Point(118, 9);
            this.releaseMaterialButton.Name = "releaseMaterialButton";
            this.releaseMaterialButton.Size = new System.Drawing.Size(106, 44);
            this.releaseMaterialButton.TabIndex = 1;
            this.releaseMaterialButton.Text = "Выдать материал";
            this.releaseMaterialButton.UseVisualStyleBackColor = true;
            this.releaseMaterialButton.Click += new System.EventHandler(this.releaseMaterialButton_Click);
            // 
            // deleteMaterialButton
            // 
            this.deleteMaterialButton.Location = new System.Drawing.Point(1499, 9);
            this.deleteMaterialButton.Name = "deleteMaterialButton";
            this.deleteMaterialButton.Size = new System.Drawing.Size(106, 44);
            this.deleteMaterialButton.TabIndex = 3;
            this.deleteMaterialButton.Text = "Удалить";
            this.deleteMaterialButton.UseVisualStyleBackColor = true;
            this.deleteMaterialButton.Click += new System.EventHandler(this.deleteMaterialButton_Click);
            // 
            // addMaterialButton
            // 
            this.addMaterialButton.Location = new System.Drawing.Point(6, 9);
            this.addMaterialButton.Name = "addMaterialButton";
            this.addMaterialButton.Size = new System.Drawing.Size(106, 44);
            this.addMaterialButton.TabIndex = 0;
            this.addMaterialButton.Text = "Добавить...";
            this.addMaterialButton.UseVisualStyleBackColor = true;
            this.addMaterialButton.Click += new System.EventHandler(this.addMaterialButton_Click);
            // 
            // suppliesPanel
            // 
            this.suppliesPanel.Controls.Add(this.suppliesDataGridView);
            this.suppliesPanel.Controls.Add(this.suppliesToolbar);
            this.suppliesPanel.Location = new System.Drawing.Point(287, 0);
            this.suppliesPanel.Name = "suppliesPanel";
            this.suppliesPanel.Size = new System.Drawing.Size(1617, 1041);
            this.suppliesPanel.TabIndex = 2;
            this.suppliesPanel.Visible = false;
            // 
            // suppliesDataGridView
            // 
            this.suppliesDataGridView.AllowUserToAddRows = false;
            this.suppliesDataGridView.AllowUserToDeleteRows = false;
            this.suppliesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Supply_code,
            this.Supply_date,
            this.Supply_list,
            this.Amount_of_supply,
            this.Provider_code,
            this.Supply_type,
            this.Supply_sum});
            this.suppliesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliesDataGridView.Location = new System.Drawing.Point(0, 59);
            this.suppliesDataGridView.Name = "suppliesDataGridView";
            this.suppliesDataGridView.RowTemplate.Height = 25;
            this.suppliesDataGridView.Size = new System.Drawing.Size(1617, 982);
            this.suppliesDataGridView.TabIndex = 1;
            // 
            // Supply_code
            // 
            this.Supply_code.HeaderText = "Код поставки";
            this.Supply_code.Name = "Supply_code";
            this.Supply_code.ReadOnly = true;
            // 
            // Supply_date
            // 
            this.Supply_date.HeaderText = "Дата заказа";
            this.Supply_date.Name = "Supply_date";
            this.Supply_date.ReadOnly = true;
            this.Supply_date.Width = 250;
            // 
            // Supply_list
            // 
            this.Supply_list.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Supply_list.HeaderText = "Название поставляемого";
            this.Supply_list.Name = "Supply_list";
            this.Supply_list.ReadOnly = true;
            // 
            // Amount_of_supply
            // 
            this.Amount_of_supply.HeaderText = "Количество поставляемого";
            this.Amount_of_supply.Name = "Amount_of_supply";
            this.Amount_of_supply.ReadOnly = true;
            this.Amount_of_supply.Width = 150;
            // 
            // Provider_code
            // 
            this.Provider_code.HeaderText = "Поставщик";
            this.Provider_code.Name = "Provider_code";
            this.Provider_code.ReadOnly = true;
            this.Provider_code.Width = 300;
            // 
            // Supply_type
            // 
            this.Supply_type.HeaderText = "Тип поставляемого";
            this.Supply_type.Name = "Supply_type";
            this.Supply_type.ReadOnly = true;
            this.Supply_type.Width = 150;
            // 
            // Supply_sum
            // 
            this.Supply_sum.HeaderText = "Сумма поставки";
            this.Supply_sum.Name = "Supply_sum";
            this.Supply_sum.ReadOnly = true;
            // 
            // suppliesToolbar
            // 
            this.suppliesToolbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suppliesToolbar.Controls.Add(this.generateConductedSuppliesReportButton);
            this.suppliesToolbar.Controls.Add(this.generateActiveSuppliesReportButton);
            this.suppliesToolbar.Controls.Add(this.generateCanceledSuppliesReportButton);
            this.suppliesToolbar.Controls.Add(this.SelectTypeOfSuppliesLabel);
            this.suppliesToolbar.Controls.Add(this.SelectTypeOfSuppliesComboBox);
            this.suppliesToolbar.Controls.Add(this.cancelSupplyButton);
            this.suppliesToolbar.Controls.Add(this.applyASupplyButton);
            this.suppliesToolbar.Controls.Add(this.createSupplyButton);
            this.suppliesToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.suppliesToolbar.Location = new System.Drawing.Point(0, 0);
            this.suppliesToolbar.Name = "suppliesToolbar";
            this.suppliesToolbar.Size = new System.Drawing.Size(1617, 59);
            this.suppliesToolbar.TabIndex = 0;
            // 
            // generateConductedSuppliesReportButton
            // 
            this.generateConductedSuppliesReportButton.Location = new System.Drawing.Point(544, 9);
            this.generateConductedSuppliesReportButton.Name = "generateConductedSuppliesReportButton";
            this.generateConductedSuppliesReportButton.Size = new System.Drawing.Size(106, 44);
            this.generateConductedSuppliesReportButton.TabIndex = 7;
            this.generateConductedSuppliesReportButton.Text = "Создать отчет";
            this.generateConductedSuppliesReportButton.UseVisualStyleBackColor = true;
            this.generateConductedSuppliesReportButton.Click += new System.EventHandler(this.generateConductedSuppliesReportButton_Click);
            // 
            // generateActiveSuppliesReportButton
            // 
            this.generateActiveSuppliesReportButton.Location = new System.Drawing.Point(544, 9);
            this.generateActiveSuppliesReportButton.Name = "generateActiveSuppliesReportButton";
            this.generateActiveSuppliesReportButton.Size = new System.Drawing.Size(106, 44);
            this.generateActiveSuppliesReportButton.TabIndex = 6;
            this.generateActiveSuppliesReportButton.Text = "Создать отчет";
            this.generateActiveSuppliesReportButton.UseVisualStyleBackColor = true;
            this.generateActiveSuppliesReportButton.Click += new System.EventHandler(this.generateActiveSuppliesReportButton_Click);
            // 
            // generateCanceledSuppliesReportButton
            // 
            this.generateCanceledSuppliesReportButton.Location = new System.Drawing.Point(544, 9);
            this.generateCanceledSuppliesReportButton.Name = "generateCanceledSuppliesReportButton";
            this.generateCanceledSuppliesReportButton.Size = new System.Drawing.Size(106, 44);
            this.generateCanceledSuppliesReportButton.TabIndex = 5;
            this.generateCanceledSuppliesReportButton.Text = "Создать отчет";
            this.generateCanceledSuppliesReportButton.UseVisualStyleBackColor = true;
            this.generateCanceledSuppliesReportButton.Click += new System.EventHandler(this.generateCanceledSuppliesReportButton_Click);
            // 
            // SelectTypeOfSuppliesLabel
            // 
            this.SelectTypeOfSuppliesLabel.AutoSize = true;
            this.SelectTypeOfSuppliesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTypeOfSuppliesLabel.Location = new System.Drawing.Point(230, 9);
            this.SelectTypeOfSuppliesLabel.Name = "SelectTypeOfSuppliesLabel";
            this.SelectTypeOfSuppliesLabel.Size = new System.Drawing.Size(59, 15);
            this.SelectTypeOfSuppliesLabel.TabIndex = 4;
            this.SelectTypeOfSuppliesLabel.Text = "Поставки";
            // 
            // SelectTypeOfSuppliesComboBox
            // 
            this.SelectTypeOfSuppliesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectTypeOfSuppliesComboBox.FormattingEnabled = true;
            this.SelectTypeOfSuppliesComboBox.Location = new System.Drawing.Point(230, 30);
            this.SelectTypeOfSuppliesComboBox.Name = "SelectTypeOfSuppliesComboBox";
            this.SelectTypeOfSuppliesComboBox.Size = new System.Drawing.Size(308, 23);
            this.SelectTypeOfSuppliesComboBox.TabIndex = 3;
            this.SelectTypeOfSuppliesComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectTypeOfSuppliesComboBox_SelectedIndexChanged);
            // 
            // cancelSupplyButton
            // 
            this.cancelSupplyButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelSupplyButton.Location = new System.Drawing.Point(1499, 9);
            this.cancelSupplyButton.Name = "cancelSupplyButton";
            this.cancelSupplyButton.Size = new System.Drawing.Size(106, 44);
            this.cancelSupplyButton.TabIndex = 2;
            this.cancelSupplyButton.Text = "Отменить поставку";
            this.cancelSupplyButton.UseVisualStyleBackColor = true;
            this.cancelSupplyButton.Click += new System.EventHandler(this.cancelSupplyButton_Click);
            // 
            // applyASupplyButton
            // 
            this.applyASupplyButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.applyASupplyButton.Location = new System.Drawing.Point(118, 9);
            this.applyASupplyButton.Name = "applyASupplyButton";
            this.applyASupplyButton.Size = new System.Drawing.Size(106, 44);
            this.applyASupplyButton.TabIndex = 1;
            this.applyASupplyButton.Text = "Провести";
            this.applyASupplyButton.UseVisualStyleBackColor = true;
            this.applyASupplyButton.Click += new System.EventHandler(this.applyASupplyButton_Click);
            // 
            // createSupplyButton
            // 
            this.createSupplyButton.Location = new System.Drawing.Point(6, 9);
            this.createSupplyButton.Name = "createSupplyButton";
            this.createSupplyButton.Size = new System.Drawing.Size(106, 44);
            this.createSupplyButton.TabIndex = 0;
            this.createSupplyButton.Text = "Создать...";
            this.createSupplyButton.UseVisualStyleBackColor = true;
            this.createSupplyButton.Click += new System.EventHandler(this.createSupplyButton_Click);
            // 
            // consumablePanel
            // 
            this.consumablePanel.Controls.Add(this.consumableDataGridView);
            this.consumablePanel.Controls.Add(this.consumableToolbar);
            this.consumablePanel.Location = new System.Drawing.Point(287, 0);
            this.consumablePanel.Name = "consumablePanel";
            this.consumablePanel.Size = new System.Drawing.Size(1617, 1041);
            this.consumablePanel.TabIndex = 2;
            this.consumablePanel.Visible = false;
            // 
            // consumableDataGridView
            // 
            this.consumableDataGridView.AllowUserToAddRows = false;
            this.consumableDataGridView.AllowUserToDeleteRows = false;
            this.consumableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consumableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Consumable_code,
            this.Consumable_name,
            this.Amount_of_consumable,
            this.Consumable_description,
            this.Consumable_provider});
            this.consumableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consumableDataGridView.Location = new System.Drawing.Point(0, 59);
            this.consumableDataGridView.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.consumableDataGridView.Name = "consumableDataGridView";
            this.consumableDataGridView.RowTemplate.Height = 25;
            this.consumableDataGridView.Size = new System.Drawing.Size(1617, 982);
            this.consumableDataGridView.TabIndex = 2;
            // 
            // Consumable_code
            // 
            this.Consumable_code.HeaderText = "Код расходника";
            this.Consumable_code.Name = "Consumable_code";
            this.Consumable_code.ReadOnly = true;
            // 
            // Consumable_name
            // 
            this.Consumable_name.HeaderText = "Название расходника";
            this.Consumable_name.Name = "Consumable_name";
            this.Consumable_name.ReadOnly = true;
            this.Consumable_name.Width = 300;
            // 
            // Amount_of_consumable
            // 
            this.Amount_of_consumable.HeaderText = "Количество расходника";
            this.Amount_of_consumable.Name = "Amount_of_consumable";
            this.Amount_of_consumable.ReadOnly = true;
            this.Amount_of_consumable.Width = 150;
            // 
            // Consumable_description
            // 
            this.Consumable_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Consumable_description.HeaderText = "Описание расходника";
            this.Consumable_description.Name = "Consumable_description";
            this.Consumable_description.ReadOnly = true;
            // 
            // Consumable_provider
            // 
            this.Consumable_provider.HeaderText = "Поставщик";
            this.Consumable_provider.Name = "Consumable_provider";
            this.Consumable_provider.ReadOnly = true;
            this.Consumable_provider.Width = 200;
            // 
            // consumableToolbar
            // 
            this.consumableToolbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consumableToolbar.Controls.Add(this.filterConsumableButton);
            this.consumableToolbar.Controls.Add(this.releaseConsumableButton);
            this.consumableToolbar.Controls.Add(this.deleteConsumableButton);
            this.consumableToolbar.Controls.Add(this.addConsumableButton);
            this.consumableToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.consumableToolbar.Location = new System.Drawing.Point(0, 0);
            this.consumableToolbar.Name = "consumableToolbar";
            this.consumableToolbar.Size = new System.Drawing.Size(1617, 59);
            this.consumableToolbar.TabIndex = 1;
            // 
            // filterConsumableButton
            // 
            this.filterConsumableButton.Location = new System.Drawing.Point(230, 9);
            this.filterConsumableButton.Name = "filterConsumableButton";
            this.filterConsumableButton.Size = new System.Drawing.Size(106, 44);
            this.filterConsumableButton.TabIndex = 3;
            this.filterConsumableButton.Text = "Фильтр...";
            this.filterConsumableButton.UseVisualStyleBackColor = true;
            this.filterConsumableButton.Click += new System.EventHandler(this.filterConsumableButton_Click);
            // 
            // releaseConsumableButton
            // 
            this.releaseConsumableButton.Location = new System.Drawing.Point(118, 9);
            this.releaseConsumableButton.Name = "releaseConsumableButton";
            this.releaseConsumableButton.Size = new System.Drawing.Size(106, 44);
            this.releaseConsumableButton.TabIndex = 1;
            this.releaseConsumableButton.Text = "Выдать расходник";
            this.releaseConsumableButton.UseVisualStyleBackColor = true;
            this.releaseConsumableButton.Click += new System.EventHandler(this.releaseConsumableButton_Click);
            // 
            // deleteConsumableButton
            // 
            this.deleteConsumableButton.Location = new System.Drawing.Point(1499, 9);
            this.deleteConsumableButton.Name = "deleteConsumableButton";
            this.deleteConsumableButton.Size = new System.Drawing.Size(106, 44);
            this.deleteConsumableButton.TabIndex = 4;
            this.deleteConsumableButton.Text = "Удалить";
            this.deleteConsumableButton.UseVisualStyleBackColor = true;
            this.deleteConsumableButton.Click += new System.EventHandler(this.deleteConsumableButton_Click);
            // 
            // addConsumableButton
            // 
            this.addConsumableButton.Location = new System.Drawing.Point(6, 9);
            this.addConsumableButton.Name = "addConsumableButton";
            this.addConsumableButton.Size = new System.Drawing.Size(106, 44);
            this.addConsumableButton.TabIndex = 0;
            this.addConsumableButton.Text = "Добавить...";
            this.addConsumableButton.UseVisualStyleBackColor = true;
            this.addConsumableButton.Click += new System.EventHandler(this.addConsumableButton_Click);
            // 
            // providerPanel
            // 
            this.providerPanel.Controls.Add(this.providerDataGridView);
            this.providerPanel.Controls.Add(this.providerToolbar);
            this.providerPanel.Location = new System.Drawing.Point(287, 0);
            this.providerPanel.Name = "providerPanel";
            this.providerPanel.Size = new System.Drawing.Size(1617, 1041);
            this.providerPanel.TabIndex = 3;
            this.providerPanel.Visible = false;
            // 
            // providerDataGridView
            // 
            this.providerDataGridView.AllowUserToAddRows = false;
            this.providerDataGridView.AllowUserToDeleteRows = false;
            this.providerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.providerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProviderCode,
            this.Provider_name,
            this.Provider_address,
            this.Provider_description});
            this.providerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.providerDataGridView.Location = new System.Drawing.Point(0, 59);
            this.providerDataGridView.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.providerDataGridView.Name = "providerDataGridView";
            this.providerDataGridView.RowTemplate.Height = 25;
            this.providerDataGridView.Size = new System.Drawing.Size(1617, 982);
            this.providerDataGridView.TabIndex = 3;
            // 
            // ProviderCode
            // 
            this.ProviderCode.HeaderText = "Код поставщика";
            this.ProviderCode.Name = "ProviderCode";
            this.ProviderCode.ReadOnly = true;
            // 
            // Provider_name
            // 
            this.Provider_name.HeaderText = "Название поставщика";
            this.Provider_name.Name = "Provider_name";
            this.Provider_name.ReadOnly = true;
            this.Provider_name.Width = 300;
            // 
            // Provider_address
            // 
            this.Provider_address.HeaderText = "Адрес поставщика";
            this.Provider_address.Name = "Provider_address";
            this.Provider_address.ReadOnly = true;
            this.Provider_address.Width = 300;
            // 
            // Provider_description
            // 
            this.Provider_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Provider_description.HeaderText = "Описание поставщика";
            this.Provider_description.Name = "Provider_description";
            this.Provider_description.ReadOnly = true;
            // 
            // providerToolbar
            // 
            this.providerToolbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.providerToolbar.Controls.Add(this.deleteProviderButton);
            this.providerToolbar.Controls.Add(this.changeButton);
            this.providerToolbar.Controls.Add(this.addProviderButton);
            this.providerToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.providerToolbar.Location = new System.Drawing.Point(0, 0);
            this.providerToolbar.Name = "providerToolbar";
            this.providerToolbar.Size = new System.Drawing.Size(1617, 59);
            this.providerToolbar.TabIndex = 0;
            // 
            // deleteProviderButton
            // 
            this.deleteProviderButton.Location = new System.Drawing.Point(1499, 9);
            this.deleteProviderButton.Name = "deleteProviderButton";
            this.deleteProviderButton.Size = new System.Drawing.Size(106, 44);
            this.deleteProviderButton.TabIndex = 6;
            this.deleteProviderButton.Text = "Удалить";
            this.deleteProviderButton.UseVisualStyleBackColor = true;
            this.deleteProviderButton.Click += new System.EventHandler(this.deleteProviderButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(118, 9);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(106, 44);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Изменить...";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addProviderButton
            // 
            this.addProviderButton.Location = new System.Drawing.Point(6, 9);
            this.addProviderButton.Name = "addProviderButton";
            this.addProviderButton.Size = new System.Drawing.Size(106, 44);
            this.addProviderButton.TabIndex = 4;
            this.addProviderButton.Text = "Добавить...";
            this.addProviderButton.UseVisualStyleBackColor = true;
            this.addProviderButton.Click += new System.EventHandler(this.addProviderButton_Click);
            // 
            // productPanel
            // 
            this.productPanel.Controls.Add(this.productDataGridView);
            this.productPanel.Controls.Add(this.productToolbar);
            this.productPanel.Location = new System.Drawing.Point(287, 0);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(1617, 1041);
            this.productPanel.TabIndex = 4;
            this.productPanel.Visible = false;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_code,
            this.Product_name,
            this.Amount_of_product});
            this.productDataGridView.Location = new System.Drawing.Point(0, 59);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowTemplate.Height = 25;
            this.productDataGridView.Size = new System.Drawing.Size(1617, 982);
            this.productDataGridView.TabIndex = 1;
            // 
            // Product_code
            // 
            this.Product_code.HeaderText = "Код продукта";
            this.Product_code.Name = "Product_code";
            this.Product_code.ReadOnly = true;
            // 
            // Product_name
            // 
            this.Product_name.HeaderText = "Название продукта";
            this.Product_name.Name = "Product_name";
            this.Product_name.ReadOnly = true;
            this.Product_name.Width = 300;
            // 
            // Amount_of_product
            // 
            this.Amount_of_product.HeaderText = "Количество продукта";
            this.Amount_of_product.Name = "Amount_of_product";
            this.Amount_of_product.ReadOnly = true;
            this.Amount_of_product.Width = 150;
            // 
            // productToolbar
            // 
            this.productToolbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productToolbar.Controls.Add(this.sendToDefectiveButton);
            this.productToolbar.Controls.Add(this.deleteProductButton);
            this.productToolbar.Controls.Add(this.acceptProductsButton);
            this.productToolbar.Controls.Add(this.filterProductButton);
            this.productToolbar.Controls.Add(this.addProductButton);
            this.productToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.productToolbar.Location = new System.Drawing.Point(0, 0);
            this.productToolbar.Name = "productToolbar";
            this.productToolbar.Size = new System.Drawing.Size(1617, 59);
            this.productToolbar.TabIndex = 0;
            // 
            // sendToDefectiveButton
            // 
            this.sendToDefectiveButton.Location = new System.Drawing.Point(342, 9);
            this.sendToDefectiveButton.Name = "sendToDefectiveButton";
            this.sendToDefectiveButton.Size = new System.Drawing.Size(106, 44);
            this.sendToDefectiveButton.TabIndex = 5;
            this.sendToDefectiveButton.Text = "Отправить в бракованные";
            this.sendToDefectiveButton.UseVisualStyleBackColor = true;
            this.sendToDefectiveButton.Click += new System.EventHandler(this.sendToDefectiveButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(1499, 9);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(106, 44);
            this.deleteProductButton.TabIndex = 4;
            this.deleteProductButton.Text = "Удалить";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // acceptProductsButton
            // 
            this.acceptProductsButton.Location = new System.Drawing.Point(230, 9);
            this.acceptProductsButton.Name = "acceptProductsButton";
            this.acceptProductsButton.Size = new System.Drawing.Size(106, 44);
            this.acceptProductsButton.TabIndex = 3;
            this.acceptProductsButton.Text = "Принять...";
            this.acceptProductsButton.UseVisualStyleBackColor = true;
            this.acceptProductsButton.Click += new System.EventHandler(this.acceptProductsButton_Click);
            // 
            // filterProductButton
            // 
            this.filterProductButton.Location = new System.Drawing.Point(118, 9);
            this.filterProductButton.Name = "filterProductButton";
            this.filterProductButton.Size = new System.Drawing.Size(106, 44);
            this.filterProductButton.TabIndex = 2;
            this.filterProductButton.Text = "Фильтр...";
            this.filterProductButton.UseVisualStyleBackColor = true;
            this.filterProductButton.Click += new System.EventHandler(this.filterProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(6, 9);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(106, 44);
            this.addProductButton.TabIndex = 1;
            this.addProductButton.Text = "Добавить...";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // defectiveProductPanel
            // 
            this.defectiveProductPanel.Controls.Add(this.defectiveProductToolbar);
            this.defectiveProductPanel.Controls.Add(this.defectiveProductDataGridView);
            this.defectiveProductPanel.Location = new System.Drawing.Point(287, 0);
            this.defectiveProductPanel.Name = "defectiveProductPanel";
            this.defectiveProductPanel.Size = new System.Drawing.Size(1617, 1041);
            this.defectiveProductPanel.TabIndex = 2;
            this.defectiveProductPanel.Visible = false;
            // 
            // defectiveProductToolbar
            // 
            this.defectiveProductToolbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.defectiveProductToolbar.Controls.Add(this.sendTheProductForProcessingButton);
            this.defectiveProductToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.defectiveProductToolbar.Location = new System.Drawing.Point(0, 0);
            this.defectiveProductToolbar.Name = "defectiveProductToolbar";
            this.defectiveProductToolbar.Size = new System.Drawing.Size(1617, 59);
            this.defectiveProductToolbar.TabIndex = 1;
            // 
            // sendTheProductForProcessingButton
            // 
            this.sendTheProductForProcessingButton.Location = new System.Drawing.Point(6, 9);
            this.sendTheProductForProcessingButton.Name = "sendTheProductForProcessingButton";
            this.sendTheProductForProcessingButton.Size = new System.Drawing.Size(106, 44);
            this.sendTheProductForProcessingButton.TabIndex = 1;
            this.sendTheProductForProcessingButton.Text = "На переработку";
            this.sendTheProductForProcessingButton.UseVisualStyleBackColor = true;
            this.sendTheProductForProcessingButton.Click += new System.EventHandler(this.sendTheProductForProcessingButton_Click);
            // 
            // defectiveProductDataGridView
            // 
            this.defectiveProductDataGridView.AllowUserToAddRows = false;
            this.defectiveProductDataGridView.AllowUserToDeleteRows = false;
            this.defectiveProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.defectiveProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Defective_product_code,
            this.Defective_product_name,
            this.AmountOfDefectiveProduct,
            this.Description_of_defect,
            this.Date_added_defective_product});
            this.defectiveProductDataGridView.Location = new System.Drawing.Point(0, 59);
            this.defectiveProductDataGridView.Name = "defectiveProductDataGridView";
            this.defectiveProductDataGridView.RowTemplate.Height = 25;
            this.defectiveProductDataGridView.Size = new System.Drawing.Size(1617, 982);
            this.defectiveProductDataGridView.TabIndex = 0;
            // 
            // Defective_product_code
            // 
            this.Defective_product_code.HeaderText = "Код продукта";
            this.Defective_product_code.Name = "Defective_product_code";
            this.Defective_product_code.ReadOnly = true;
            // 
            // Defective_product_name
            // 
            this.Defective_product_name.HeaderText = "Название продукта";
            this.Defective_product_name.Name = "Defective_product_name";
            this.Defective_product_name.ReadOnly = true;
            this.Defective_product_name.Width = 300;
            // 
            // AmountOfDefectiveProduct
            // 
            this.AmountOfDefectiveProduct.HeaderText = "Количество";
            this.AmountOfDefectiveProduct.Name = "AmountOfDefectiveProduct";
            this.AmountOfDefectiveProduct.ReadOnly = true;
            // 
            // Description_of_defect
            // 
            this.Description_of_defect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description_of_defect.HeaderText = "Описание дефекта";
            this.Description_of_defect.Name = "Description_of_defect";
            this.Description_of_defect.ReadOnly = true;
            // 
            // Date_added_defective_product
            // 
            this.Date_added_defective_product.HeaderText = "Дата добавления";
            this.Date_added_defective_product.Name = "Date_added_defective_product";
            this.Date_added_defective_product.ReadOnly = true;
            this.Date_added_defective_product.Width = 200;
            // 
            // productionOrderPanel
            // 
            this.productionOrderPanel.Controls.Add(this.productionOrderDataGridView);
            this.productionOrderPanel.Location = new System.Drawing.Point(287, 0);
            this.productionOrderPanel.Name = "productionOrderPanel";
            this.productionOrderPanel.Size = new System.Drawing.Size(1617, 1041);
            this.productionOrderPanel.TabIndex = 2;
            this.productionOrderPanel.Visible = false;
            // 
            // productionOrderDataGridView
            // 
            this.productionOrderDataGridView.AllowUserToAddRows = false;
            this.productionOrderDataGridView.AllowUserToDeleteRows = false;
            this.productionOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productionOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_code,
            this.Store,
            this.Order_date});
            this.productionOrderDataGridView.Location = new System.Drawing.Point(0, 59);
            this.productionOrderDataGridView.Name = "productionOrderDataGridView";
            this.productionOrderDataGridView.RowTemplate.Height = 25;
            this.productionOrderDataGridView.Size = new System.Drawing.Size(1617, 982);
            this.productionOrderDataGridView.TabIndex = 0;
            this.productionOrderDataGridView.Click += new System.EventHandler(this.productionOrderDataGridView_Click);
            // 
            // Order_code
            // 
            this.Order_code.HeaderText = "Код заказа";
            this.Order_code.Name = "Order_code";
            this.Order_code.ReadOnly = true;
            // 
            // Store
            // 
            this.Store.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Store.HeaderText = "Магазин";
            this.Store.Name = "Store";
            this.Store.ReadOnly = true;
            // 
            // Order_date
            // 
            this.Order_date.HeaderText = "Дата заказа";
            this.Order_date.Name = "Order_date";
            this.Order_date.ReadOnly = true;
            this.Order_date.Width = 250;
            // 
            // FactoryWarehouseWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.suppliesPanel);
            this.Controls.Add(this.productionOrderPanel);
            this.Controls.Add(this.consumablePanel);
            this.Controls.Add(this.providerPanel);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.defectiveProductPanel);
            this.Controls.Add(this.materialsPanel);
            this.Controls.Add(this.menuFlowLayoutPanel);
            this.MaximizeBox = false;
            this.Name = "FactoryWarehouseWorkerForm";
            this.Text = "EMIS - Кладовщик производства";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FactoryWarehouseWorkerForm_FormClosed);
            this.Load += new System.EventHandler(this.FactoryWarehouseWorkerForm_Load);
            this.menuFlowLayoutPanel.ResumeLayout(false);
            this.materialsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).EndInit();
            this.materialsToolbar.ResumeLayout(false);
            this.suppliesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suppliesDataGridView)).EndInit();
            this.suppliesToolbar.ResumeLayout(false);
            this.suppliesToolbar.PerformLayout();
            this.consumablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.consumableDataGridView)).EndInit();
            this.consumableToolbar.ResumeLayout(false);
            this.providerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.providerDataGridView)).EndInit();
            this.providerToolbar.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.productToolbar.ResumeLayout(false);
            this.defectiveProductPanel.ResumeLayout(false);
            this.defectiveProductToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.defectiveProductDataGridView)).EndInit();
            this.productionOrderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productionOrderDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel menuFlowLayoutPanel;
        private Button materialsButton;
        private Panel materialsPanel;
        private Panel materialsToolbar;
        private DataGridView materialsDataGridView;
        private Button addMaterialButton;
        private Button suppliesButton;
        private Button productButton;
        private Button shippingButton;
        private Button equipmentConsumablesButton;
        private Button defectiveProductsButton;
        private Button deleteMaterialButton;
        private Button releaseMaterialButton;
        private Button filterButton;
        private Button ordersButton;
        private Panel suppliesPanel;
        private DataGridView suppliesDataGridView;
        private Panel suppliesToolbar;
        private Button createSupplyButton;
        private DataGridViewTextBoxColumn Material_code;
        private DataGridViewTextBoxColumn Material_name;
        private DataGridViewTextBoxColumn Amount_of_material;
        private DataGridViewTextBoxColumn Material_description;
        private DataGridViewTextBoxColumn Provider;
        private Button applyASupplyButton;
        private Button cancelSupplyButton;
        private Panel consumablePanel;
        private Panel consumableToolbar;
        private Button filterConsumableButton;
        private Button releaseConsumableButton;
        private Button deleteConsumableButton;
        private Button addConsumableButton;
        private DataGridView consumableDataGridView;
        private DataGridViewTextBoxColumn Consumable_code;
        private DataGridViewTextBoxColumn Consumable_name;
        private DataGridViewTextBoxColumn Amount_of_consumable;
        private DataGridViewTextBoxColumn Consumable_description;
        private DataGridViewTextBoxColumn Consumable_provider;
        private Button providersButton;
        private Panel providerPanel;
        private DataGridView providerDataGridView;
        private DataGridViewTextBoxColumn ProviderCode;
        private DataGridViewTextBoxColumn Provider_name;
        private DataGridViewTextBoxColumn Provider_address;
        private DataGridViewTextBoxColumn Provider_description;
        private Panel providerToolbar;
        private Button addProviderButton;
        private Button changeButton;
        private Button deleteProviderButton;
        private Panel productPanel;
        private Panel productToolbar;
        private DataGridView productDataGridView;
        private Button addProductButton;
        private Button filterProductButton;
        private Button acceptProductsButton;
        private DataGridViewTextBoxColumn Supply_code;
        private DataGridViewTextBoxColumn Supply_date;
        private DataGridViewTextBoxColumn Supply_list;
        private DataGridViewTextBoxColumn Amount_of_supply;
        private DataGridViewTextBoxColumn Provider_code;
        private DataGridViewTextBoxColumn Supply_type;
        private DataGridViewTextBoxColumn Supply_sum;
        private Button deleteProductButton;
        private Button sendToDefectiveButton;
        private Panel defectiveProductPanel;
        private DataGridView defectiveProductDataGridView;
        private Panel defectiveProductToolbar;
        private Button sendTheProductForProcessingButton;
        private Panel productionOrderPanel;
        private DataGridView productionOrderDataGridView;
        private DataGridViewTextBoxColumn Defective_product_code;
        private DataGridViewTextBoxColumn Defective_product_name;
        private DataGridViewTextBoxColumn AmountOfDefectiveProduct;
        private DataGridViewTextBoxColumn Description_of_defect;
        private DataGridViewTextBoxColumn Date_added_defective_product;
        private DataGridViewTextBoxColumn Product_code;
        private DataGridViewTextBoxColumn Product_name;
        private DataGridViewTextBoxColumn Amount_of_product;
        private Label SelectTypeOfSuppliesLabel;
        private ComboBox SelectTypeOfSuppliesComboBox;
        private DataGridViewTextBoxColumn Order_code;
        private DataGridViewTextBoxColumn Store;
        private DataGridViewTextBoxColumn Order_date;
        private Button generateCanceledSuppliesReportButton;
        private FolderBrowserDialog reportFolderBrowserDialog;
        private Button generateActiveSuppliesReportButton;
        private Button generateConductedSuppliesReportButton;
    }
}