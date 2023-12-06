namespace Enterprise_Managment_IS.Forms.StoreForms.StoreWarehouseWorkerDirectory.AuxiliaryForms
{
    partial class CreateOrderProductForm
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Toolbar = new System.Windows.Forms.Panel();
            this.createOrder = new System.Windows.Forms.Button();
            this.StoreComboBox = new System.Windows.Forms.ComboBox();
            this.storesComboBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StoreLabel = new System.Windows.Forms.Label();
            this.productOrderItemDataGridView = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productComboBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storesComboBoxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOrderItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productComboBoxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Toolbar
            // 
            this.Toolbar.Controls.Add(this.createOrder);
            this.Toolbar.Controls.Add(this.StoreComboBox);
            this.Toolbar.Controls.Add(this.StoreLabel);
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(800, 55);
            this.Toolbar.TabIndex = 0;
            // 
            // createOrder
            // 
            this.createOrder.Location = new System.Drawing.Point(682, 6);
            this.createOrder.Name = "createOrder";
            this.createOrder.Size = new System.Drawing.Size(106, 44);
            this.createOrder.TabIndex = 2;
            this.createOrder.Text = "Создать";
            this.createOrder.UseVisualStyleBackColor = true;
            this.createOrder.Click += new System.EventHandler(this.createOrder_Click);
            // 
            // StoreComboBox
            // 
            this.StoreComboBox.DataSource = this.storesComboBoxBindingSource;
            this.StoreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StoreComboBox.FormattingEnabled = true;
            this.StoreComboBox.Location = new System.Drawing.Point(3, 27);
            this.StoreComboBox.Name = "StoreComboBox";
            this.StoreComboBox.Size = new System.Drawing.Size(209, 23);
            this.StoreComboBox.TabIndex = 1;
            // 
            // storesComboBoxBindingSource
            // 
            this.storesComboBoxBindingSource.DataSource = typeof(System.Windows.Forms.ComboBox);
            // 
            // StoreLabel
            // 
            this.StoreLabel.AutoSize = true;
            this.StoreLabel.Location = new System.Drawing.Point(3, 9);
            this.StoreLabel.Name = "StoreLabel";
            this.StoreLabel.Size = new System.Drawing.Size(54, 15);
            this.StoreLabel.TabIndex = 0;
            this.StoreLabel.Text = "Магазин";
            // 
            // productOrderItemDataGridView
            // 
            this.productOrderItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productOrderItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.productAmount});
            this.productOrderItemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productOrderItemDataGridView.Location = new System.Drawing.Point(0, 55);
            this.productOrderItemDataGridView.Name = "productOrderItemDataGridView";
            this.productOrderItemDataGridView.RowTemplate.Height = 25;
            this.productOrderItemDataGridView.Size = new System.Drawing.Size(800, 395);
            this.productOrderItemDataGridView.TabIndex = 1;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.DataSource = this.productComboBoxBindingSource;
            this.productName.HeaderText = "Продукт";
            this.productName.Name = "productName";
            // 
            // productComboBoxBindingSource
            // 
            this.productComboBoxBindingSource.DataSource = typeof(System.Windows.Forms.ComboBox);
            // 
            // productAmount
            // 
            this.productAmount.HeaderText = "Количество";
            this.productAmount.Name = "productAmount";
            this.productAmount.Width = 150;
            // 
            // CreateOrderProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productOrderItemDataGridView);
            this.Controls.Add(this.Toolbar);
            this.Name = "CreateOrderProductForm";
            this.Text = "Создать заказ";
            this.Load += new System.EventHandler(this.CreateOrderProductForm_Load);
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storesComboBoxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOrderItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productComboBoxBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        

        private Panel Toolbar;
        private ComboBox StoreComboBox;
        private Label StoreLabel;
        private DataGridView productOrderItemDataGridView;
        private Button createOrder;
        private DataGridViewComboBoxColumn productName;
        private BindingSource productComboBoxBindingSource;
        private DataGridViewTextBoxColumn productAmount;
        private BindingSource storesComboBoxBindingSource;
    }
}