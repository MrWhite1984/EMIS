namespace Enterprise_Managment_IS.Forms.StoreForms.StoreWarehouseWorkerDirectory.AuxiliaryForms
{
    partial class OrderCheckListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public int orderCode = -1;

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
            this.orderElementsDataGridView = new System.Windows.Forms.DataGridView();
            this.Element_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Element_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isProduced = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isLoaded = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isDelivered = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderElementsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderElementsDataGridView
            // 
            this.orderElementsDataGridView.AllowUserToAddRows = false;
            this.orderElementsDataGridView.AllowUserToDeleteRows = false;
            this.orderElementsDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.orderElementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderElementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Element_code,
            this.Element_name,
            this.Amount,
            this.isProduced,
            this.isLoaded,
            this.isDelivered});
            this.orderElementsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orderElementsDataGridView.Location = new System.Drawing.Point(0, 58);
            this.orderElementsDataGridView.Name = "orderElementsDataGridView";
            this.orderElementsDataGridView.RowTemplate.Height = 25;
            this.orderElementsDataGridView.Size = new System.Drawing.Size(800, 392);
            this.orderElementsDataGridView.TabIndex = 0;
            this.orderElementsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderElementsDataGridView_CellValueChanged);
            // 
            // Element_code
            // 
            this.Element_code.HeaderText = "Код";
            this.Element_code.Name = "Element_code";
            this.Element_code.ReadOnly = true;
            // 
            // Element_name
            // 
            this.Element_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Element_name.HeaderText = "Название";
            this.Element_name.Name = "Element_name";
            this.Element_name.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Количество";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // isProduced
            // 
            this.isProduced.HeaderText = "Произведено";
            this.isProduced.Name = "isProduced";
            this.isProduced.ReadOnly = true;
            this.isProduced.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isProduced.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // isLoaded
            // 
            this.isLoaded.HeaderText = "Загружено";
            this.isLoaded.Name = "isLoaded";
            this.isLoaded.ReadOnly = true;
            this.isLoaded.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isLoaded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // isDelivered
            // 
            this.isDelivered.HeaderText = "Доставлено";
            this.isDelivered.Name = "isDelivered";
            this.isDelivered.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isDelivered.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OrderCheckListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderElementsDataGridView);
            this.Name = "OrderCheckListForm";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.OrderCheckListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderElementsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView orderElementsDataGridView;
        private DataGridViewTextBoxColumn Element_code;
        private DataGridViewTextBoxColumn Element_name;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewCheckBoxColumn isProduced;
        private DataGridViewCheckBoxColumn isLoaded;
        private DataGridViewCheckBoxColumn isDelivered;
    }
}