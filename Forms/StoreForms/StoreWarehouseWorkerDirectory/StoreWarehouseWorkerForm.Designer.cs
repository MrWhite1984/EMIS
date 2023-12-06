namespace Enterprise_Managment_IS.Forms.StoreWarehouseWorkerDirectory
{
    partial class StoreWarehouseWorkerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.productsButton = new System.Windows.Forms.Button();
            this.ordersToFactoryButton = new System.Windows.Forms.Button();
            this.productionOrderPanel = new System.Windows.Forms.Panel();
            this.productionOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.productionOrderToolbar = new System.Windows.Forms.Panel();
            this.createOrder = new System.Windows.Forms.Button();
            this.Order_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Store = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuFlowLayoutPanel.SuspendLayout();
            this.productionOrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionOrderDataGridView)).BeginInit();
            this.productionOrderToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFlowLayoutPanel
            // 
            this.menuFlowLayoutPanel.AutoScroll = true;
            this.menuFlowLayoutPanel.Controls.Add(this.productsButton);
            this.menuFlowLayoutPanel.Controls.Add(this.ordersToFactoryButton);
            this.menuFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.menuFlowLayoutPanel.Name = "menuFlowLayoutPanel";
            this.menuFlowLayoutPanel.Size = new System.Drawing.Size(287, 1041);
            this.menuFlowLayoutPanel.TabIndex = 0;
            // 
            // productsButton
            // 
            this.productsButton.Location = new System.Drawing.Point(3, 3);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(259, 56);
            this.productsButton.TabIndex = 1;
            this.productsButton.Text = "Продукты";
            this.productsButton.UseVisualStyleBackColor = true;
            // 
            // ordersToFactoryButton
            // 
            this.ordersToFactoryButton.Location = new System.Drawing.Point(3, 65);
            this.ordersToFactoryButton.Name = "ordersToFactoryButton";
            this.ordersToFactoryButton.Size = new System.Drawing.Size(259, 56);
            this.ordersToFactoryButton.TabIndex = 0;
            this.ordersToFactoryButton.Text = "Заказы на производство";
            this.ordersToFactoryButton.UseVisualStyleBackColor = true;
            this.ordersToFactoryButton.Click += new System.EventHandler(this.ordersToFactoryButton_Click);
            // 
            // productionOrderPanel
            // 
            this.productionOrderPanel.Controls.Add(this.productionOrderDataGridView);
            this.productionOrderPanel.Controls.Add(this.productionOrderToolbar);
            this.productionOrderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionOrderPanel.Location = new System.Drawing.Point(287, 0);
            this.productionOrderPanel.Name = "productionOrderPanel";
            this.productionOrderPanel.Size = new System.Drawing.Size(1617, 1041);
            this.productionOrderPanel.TabIndex = 1;
            this.productionOrderPanel.Visible = false;
            // 
            // productionOrderDataGridView
            // 
            this.productionOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productionOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_code,
            this.Store,
            this.Order_date});
            this.productionOrderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productionOrderDataGridView.Location = new System.Drawing.Point(0, 59);
            this.productionOrderDataGridView.Name = "productionOrderDataGridView";
            this.productionOrderDataGridView.RowTemplate.Height = 25;
            this.productionOrderDataGridView.Size = new System.Drawing.Size(1617, 982);
            this.productionOrderDataGridView.TabIndex = 1;
            // 
            // productionOrderToolbar
            // 
            this.productionOrderToolbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productionOrderToolbar.Controls.Add(this.createOrder);
            this.productionOrderToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.productionOrderToolbar.Location = new System.Drawing.Point(0, 0);
            this.productionOrderToolbar.Name = "productionOrderToolbar";
            this.productionOrderToolbar.Size = new System.Drawing.Size(1617, 59);
            this.productionOrderToolbar.TabIndex = 0;
            // 
            // createOrder
            // 
            this.createOrder.Location = new System.Drawing.Point(6, 9);
            this.createOrder.Name = "createOrder";
            this.createOrder.Size = new System.Drawing.Size(106, 44);
            this.createOrder.TabIndex = 0;
            this.createOrder.Text = "Создать...";
            this.createOrder.UseVisualStyleBackColor = true;
            this.createOrder.Click += new System.EventHandler(this.createOrder_Click);
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
            // StoreWarehouseWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.productionOrderPanel);
            this.Controls.Add(this.menuFlowLayoutPanel);
            this.Name = "StoreWarehouseWorkerForm";
            this.Text = "EMIS - Кладовщик магазина";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StoreWarehouseWorkerForm_Load);
            this.menuFlowLayoutPanel.ResumeLayout(false);
            this.productionOrderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productionOrderDataGridView)).EndInit();
            this.productionOrderToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel menuFlowLayoutPanel;
        private Button ordersToFactoryButton;
        private Button productsButton;
        private Panel productionOrderPanel;
        private Panel productionOrderToolbar;
        private DataGridView productionOrderDataGridView;
        private Button createOrder;
        private DataGridViewTextBoxColumn Order_code;
        private DataGridViewTextBoxColumn Store;
        private DataGridViewTextBoxColumn Order_date;
    }
}