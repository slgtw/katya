namespace Kurs
{
    partial class Clients
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_FIO = new System.Windows.Forms.TextBox();
            this.textBox_data = new System.Windows.Forms.TextBox();
            this.button_addClient_complete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_del_cl = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(787, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox_FIO
            // 
            this.textBox_FIO.Location = new System.Drawing.Point(272, 377);
            this.textBox_FIO.Name = "textBox_FIO";
            this.textBox_FIO.Size = new System.Drawing.Size(100, 20);
            this.textBox_FIO.TabIndex = 1;
            // 
            // textBox_data
            // 
            this.textBox_data.Location = new System.Drawing.Point(421, 377);
            this.textBox_data.Name = "textBox_data";
            this.textBox_data.Size = new System.Drawing.Size(100, 20);
            this.textBox_data.TabIndex = 2;
            // 
            // button_addClient_complete
            // 
            this.button_addClient_complete.Location = new System.Drawing.Point(360, 416);
            this.button_addClient_complete.Name = "button_addClient_complete";
            this.button_addClient_complete.Size = new System.Drawing.Size(75, 23);
            this.button_addClient_complete.TabIndex = 3;
            this.button_addClient_complete.Text = "OK";
            this.button_addClient_complete.UseVisualStyleBackColor = true;
            this.button_addClient_complete.Click += new System.EventHandler(this.button_addClient_complete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Данные";
            // 
            // button_del_cl
            // 
            this.button_del_cl.Location = new System.Drawing.Point(711, 404);
            this.button_del_cl.Name = "button_del_cl";
            this.button_del_cl.Size = new System.Drawing.Size(75, 23);
            this.button_del_cl.TabIndex = 6;
            this.button_del_cl.Text = "DEL";
            this.button_del_cl.UseVisualStyleBackColor = true;
            this.button_del_cl.Click += new System.EventHandler(this.button_del_cl_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(711, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "обновить табл";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 473);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_del_cl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_addClient_complete);
            this.Controls.Add(this.textBox_data);
            this.Controls.Add(this.textBox_FIO);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_FIO;
        private System.Windows.Forms.TextBox textBox_data;
        private System.Windows.Forms.Button button_addClient_complete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_del_cl;
        private System.Windows.Forms.Button button2;
    }
}