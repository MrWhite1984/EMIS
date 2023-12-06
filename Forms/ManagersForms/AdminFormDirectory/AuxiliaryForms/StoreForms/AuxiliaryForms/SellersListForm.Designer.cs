namespace Enterprise_Managment_IS.Forms.ManagersForms.AdminFormDirectory.AuxiliaryForms.StoreForms.AuxiliaryForms
{
    partial class SellersListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public TextBox sellersTextBox;

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
            this.sellersDataGridView = new System.Windows.Forms.DataGridView();
            this.SellerData = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sellersComboBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellersLabel = new System.Windows.Forms.Label();
            this.writeAndCloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sellersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersComboBoxBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sellersDataGridView
            // 
            this.sellersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SellerData});
            this.sellersDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sellersDataGridView.Location = new System.Drawing.Point(0, 47);
            this.sellersDataGridView.Name = "sellersDataGridView";
            this.sellersDataGridView.RowTemplate.Height = 25;
            this.sellersDataGridView.Size = new System.Drawing.Size(800, 403);
            this.sellersDataGridView.TabIndex = 0;
            // 
            // SellerData
            // 
            this.SellerData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SellerData.DataSource = this.sellersComboBoxBindingSource;
            this.SellerData.HeaderText = "Продавец";
            this.SellerData.Name = "SellerData";
            // 
            // sellersComboBoxBindingSource
            // 
            this.sellersComboBoxBindingSource.DataSource = typeof(System.Windows.Forms.ComboBox);
            // 
            // sellersLabel
            // 
            this.sellersLabel.AutoSize = true;
            this.sellersLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sellersLabel.Location = new System.Drawing.Point(12, 9);
            this.sellersLabel.Name = "sellersLabel";
            this.sellersLabel.Size = new System.Drawing.Size(102, 25);
            this.sellersLabel.TabIndex = 1;
            this.sellersLabel.Text = "Продавцы";
            // 
            // writeAndCloseButton
            // 
            this.writeAndCloseButton.Location = new System.Drawing.Point(682, 2);
            this.writeAndCloseButton.Name = "writeAndCloseButton";
            this.writeAndCloseButton.Size = new System.Drawing.Size(106, 44);
            this.writeAndCloseButton.TabIndex = 2;
            this.writeAndCloseButton.Text = "Записать и закрыть";
            this.writeAndCloseButton.UseVisualStyleBackColor = true;
            this.writeAndCloseButton.Click += new System.EventHandler(this.writeAndCloseButton_Click);
            // 
            // SellersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.writeAndCloseButton);
            this.Controls.Add(this.sellersLabel);
            this.Controls.Add(this.sellersDataGridView);
            this.Name = "SellersListForm";
            this.Text = "SellersListForm";
            this.Load += new System.EventHandler(this.SellersListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersComboBoxBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView sellersDataGridView;
        private Label sellersLabel;
        private BindingSource sellersComboBoxBindingSource;
        private DataGridViewComboBoxColumn SellerData;
        private Button writeAndCloseButton;
    }
}