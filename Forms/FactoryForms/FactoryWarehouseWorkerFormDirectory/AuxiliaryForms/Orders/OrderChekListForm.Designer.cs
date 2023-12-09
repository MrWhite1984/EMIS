namespace Enterprise_Managment_IS.Forms.FactoryForms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms.Orders
{
    partial class OrderChekListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public int orderCode = 0;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderListDataGridView = new System.Windows.Forms.DataGridView();
            this.Item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderListItemLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isProduced = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isLoad = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 55);
            this.panel1.TabIndex = 0;
            // 
            // orderListDataGridView
            // 
            this.orderListDataGridView.AllowUserToAddRows = false;
            this.orderListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_code,
            this.OrderListItemLabel,
            this.AmountItem,
            this.isProduced,
            this.isLoad});
            this.orderListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderListDataGridView.Location = new System.Drawing.Point(0, 55);
            this.orderListDataGridView.Name = "orderListDataGridView";
            this.orderListDataGridView.RowTemplate.Height = 25;
            this.orderListDataGridView.Size = new System.Drawing.Size(717, 323);
            this.orderListDataGridView.TabIndex = 1;
            this.orderListDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderListDataGridView_CellValueChanged);
            // 
            // Item_code
            // 
            this.Item_code.HeaderText = "Код";
            this.Item_code.Name = "Item_code";
            this.Item_code.ReadOnly = true;
            // 
            // OrderListItemLabel
            // 
            this.OrderListItemLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderListItemLabel.FillWeight = 151.8716F;
            this.OrderListItemLabel.HeaderText = "Название";
            this.OrderListItemLabel.MinimumWidth = 270;
            this.OrderListItemLabel.Name = "OrderListItemLabel";
            this.OrderListItemLabel.ReadOnly = true;
            // 
            // AmountItem
            // 
            this.AmountItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AmountItem.FillWeight = 48.12833F;
            this.AmountItem.HeaderText = "Количество";
            this.AmountItem.MinimumWidth = 3;
            this.AmountItem.Name = "AmountItem";
            this.AmountItem.ReadOnly = true;
            // 
            // isProduced
            // 
            this.isProduced.HeaderText = "Произведено";
            this.isProduced.Name = "isProduced";
            // 
            // isLoad
            // 
            this.isLoad.HeaderText = "Загружено";
            this.isLoad.Name = "isLoad";
            // 
            // OrderChekListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 378);
            this.Controls.Add(this.orderListDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "OrderChekListForm";
            this.Text = "OrderChekListForm";
            this.Load += new System.EventHandler(this.OrderChekListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView orderListDataGridView;
        private DataGridViewTextBoxColumn Item_code;
        private DataGridViewTextBoxColumn OrderListItemLabel;
        private DataGridViewTextBoxColumn AmountItem;
        private DataGridViewCheckBoxColumn isProduced;
        private DataGridViewCheckBoxColumn isLoad;
    }
}