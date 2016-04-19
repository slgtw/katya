namespace Kurs
{
    partial class Bill
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cheque = new System.Windows.Forms.DataGridView();
            this.services = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_bill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.services)).BeginInit();
            this.SuspendLayout();
            // 
            // cheque
            // 
            this.cheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cheque.Location = new System.Drawing.Point(78, 38);
            this.cheque.Name = "cheque";
            this.cheque.Size = new System.Drawing.Size(665, 231);
            this.cheque.TabIndex = 0;
            // 
            // services
            // 
            this.services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.services.Location = new System.Drawing.Point(78, 308);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(665, 141);
            this.services.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Счёт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Услуги";
            // 
            // button_bill
            // 
            this.button_bill.Location = new System.Drawing.Point(761, 422);
            this.button_bill.Name = "button_bill";
            this.button_bill.Size = new System.Drawing.Size(118, 27);
            this.button_bill.TabIndex = 4;
            this.button_bill.Text = "Сформировать счёт";
            this.button_bill.UseVisualStyleBackColor = true;
            this.button_bill.Click += new System.EventHandler(this.button_bill_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 461);
            this.Controls.Add(this.button_bill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.services);
            this.Controls.Add(this.cheque);
            this.Name = "Bill";
            this.Text = "Bill";
            ((System.ComponentModel.ISupportInitialize)(this.cheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.services)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cheque;
        private System.Windows.Forms.DataGridView services;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_bill;
    }
}