namespace Enterprise_Managment_IS.Forms.ManagersForms.AdminFormDirectory.AuxiliaryForms.SQLForms
{
    partial class SelectQueryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public TextBox queryTextBox = null;
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
            this.createTableQueryButton = new System.Windows.Forms.Button();
            this.createTriggerQueryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTableQueryButton
            // 
            this.createTableQueryButton.Location = new System.Drawing.Point(12, 12);
            this.createTableQueryButton.Name = "createTableQueryButton";
            this.createTableQueryButton.Size = new System.Drawing.Size(130, 50);
            this.createTableQueryButton.TabIndex = 0;
            this.createTableQueryButton.Text = "Код создания системных таблиц";
            this.createTableQueryButton.UseVisualStyleBackColor = true;
            this.createTableQueryButton.Click += new System.EventHandler(this.createTableQueryButton_Click);
            // 
            // createTriggerQueryButton
            // 
            this.createTriggerQueryButton.Location = new System.Drawing.Point(148, 12);
            this.createTriggerQueryButton.Name = "createTriggerQueryButton";
            this.createTriggerQueryButton.Size = new System.Drawing.Size(131, 50);
            this.createTriggerQueryButton.TabIndex = 1;
            this.createTriggerQueryButton.Text = "Код создания системного триггера";
            this.createTriggerQueryButton.UseVisualStyleBackColor = true;
            this.createTriggerQueryButton.Click += new System.EventHandler(this.createTriggerQueryButton_Click);
            // 
            // SelectQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 74);
            this.Controls.Add(this.createTriggerQueryButton);
            this.Controls.Add(this.createTableQueryButton);
            this.MaximumSize = new System.Drawing.Size(307, 113);
            this.MinimumSize = new System.Drawing.Size(307, 113);
            this.Name = "SelectQueryForm";
            this.Text = "SelectQueryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button createTableQueryButton;
        private Button createTriggerQueryButton;
    }
}