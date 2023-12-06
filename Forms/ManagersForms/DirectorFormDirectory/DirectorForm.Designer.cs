namespace Enterprise_Managment_IS.Forms.DirectorFormDirectory
{
    partial class DirectorForm
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
            this.productsButton = new System.Windows.Forms.Button();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.Product_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsToolbar = new System.Windows.Forms.Panel();
            this.addProductButton = new System.Windows.Forms.Button();
            this.menuFlowLayoutPanel.SuspendLayout();
            this.productsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.productsToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFlowLayoutPanel
            // 
            this.menuFlowLayoutPanel.Controls.Add(this.productsButton);
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
            this.productsButton.TabIndex = 0;
            this.productsButton.Text = "Продукты";
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // productsPanel
            // 
            this.productsPanel.Controls.Add(this.productDataGridView);
            this.productsPanel.Controls.Add(this.productsToolbar);
            this.productsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsPanel.Location = new System.Drawing.Point(287, 0);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(1617, 1041);
            this.productsPanel.TabIndex = 1;
            this.productsPanel.Visible = false;
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_code,
            this.Product_name,
            this.Product_description,
            this.Product_price});
            this.productDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDataGridView.Location = new System.Drawing.Point(0, 59);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowTemplate.Height = 25;
            this.productDataGridView.Size = new System.Drawing.Size(1617, 982);
            this.productDataGridView.TabIndex = 1;
            // 
            // Product_code
            // 
            this.Product_code.HeaderText = "Код";
            this.Product_code.Name = "Product_code";
            this.Product_code.ReadOnly = true;
            // 
            // Product_name
            // 
            this.Product_name.HeaderText = "Название";
            this.Product_name.Name = "Product_name";
            this.Product_name.ReadOnly = true;
            this.Product_name.Width = 300;
            // 
            // Product_description
            // 
            this.Product_description.HeaderText = "Описание";
            this.Product_description.Name = "Product_description";
            this.Product_description.ReadOnly = true;
            this.Product_description.Width = 600;
            // 
            // Product_price
            // 
            this.Product_price.HeaderText = "Цена";
            this.Product_price.Name = "Product_price";
            this.Product_price.ReadOnly = true;
            this.Product_price.Width = 130;
            // 
            // productsToolbar
            // 
            this.productsToolbar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productsToolbar.Controls.Add(this.addProductButton);
            this.productsToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsToolbar.Location = new System.Drawing.Point(0, 0);
            this.productsToolbar.Name = "productsToolbar";
            this.productsToolbar.Size = new System.Drawing.Size(1617, 59);
            this.productsToolbar.TabIndex = 0;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(6, 9);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(106, 44);
            this.addProductButton.TabIndex = 0;
            this.addProductButton.Text = "Добавить...";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.productsPanel);
            this.Controls.Add(this.menuFlowLayoutPanel);
            this.Name = "DirectorForm";
            this.Text = "DirectorForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DirectorForm_FormClosed);
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            this.menuFlowLayoutPanel.ResumeLayout(false);
            this.productsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.productsToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel menuFlowLayoutPanel;
        private Panel productsPanel;
        private DataGridView productDataGridView;
        private DataGridViewTextBoxColumn Product_code;
        private DataGridViewTextBoxColumn Product_name;
        private DataGridViewTextBoxColumn Product_description;
        private DataGridViewTextBoxColumn Product_price;
        private Panel productsToolbar;
        private Button addProductButton;
        private Button productsButton;
    }
}