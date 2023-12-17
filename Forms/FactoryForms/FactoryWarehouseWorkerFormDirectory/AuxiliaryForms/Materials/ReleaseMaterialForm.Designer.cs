using Enterprise_Managment_IS.Classes.TypesOfData;

namespace Enterprise_Managment_IS.Forms.FactoryWarehouseWorkerFormDirectory.AuxiliaryForms
{
    partial class ReleaseMaterialForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public int materialCode = 0;

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
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.releaseButton = new System.Windows.Forms.Button();
            this.workerLabel = new System.Windows.Forms.Label();
            this.workerСomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.Location = new System.Drawing.Point(12, 9);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(117, 15);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Введите количество";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityTextBox.Location = new System.Drawing.Point(135, 6);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(281, 23);
            this.quantityTextBox.TabIndex = 1;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // releaseButton
            // 
            this.releaseButton.Location = new System.Drawing.Point(310, 64);
            this.releaseButton.Name = "releaseButton";
            this.releaseButton.Size = new System.Drawing.Size(106, 44);
            this.releaseButton.TabIndex = 2;
            this.releaseButton.Text = "Выдать";
            this.releaseButton.UseVisualStyleBackColor = true;
            this.releaseButton.Click += new System.EventHandler(this.releaseButton_Click);
            // 
            // workerLabel
            // 
            this.workerLabel.AutoSize = true;
            this.workerLabel.Location = new System.Drawing.Point(12, 38);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(59, 15);
            this.workerLabel.TabIndex = 3;
            this.workerLabel.Text = "Работник";
            // 
            // workerСomboBox
            // 
            this.workerСomboBox.FormattingEnabled = true;
            this.workerСomboBox.Location = new System.Drawing.Point(135, 35);
            this.workerСomboBox.Name = "workerСomboBox";
            this.workerСomboBox.Size = new System.Drawing.Size(281, 23);
            this.workerСomboBox.TabIndex = 4;
            // 
            // ReleaseMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(428, 120);
            this.Controls.Add(this.workerСomboBox);
            this.Controls.Add(this.workerLabel);
            this.Controls.Add(this.releaseButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Name = "ReleaseMaterialForm";
            this.Text = "Выдать материалы";
            this.Load += new System.EventHandler(this.ReleaseMaterialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label quantityLabel;
        private TextBox quantityTextBox;
        private Button releaseButton;
        private Label workerLabel;
        private ComboBox workerСomboBox;
    }
}