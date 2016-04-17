namespace Kurs
{
    partial class Rooms
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
            this.button_book = new System.Windows.Forms.Button();
            this.button_checkedin = new System.Windows.Forms.Button();
            this.button_checkedout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(948, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_book
            // 
            this.button_book.Location = new System.Drawing.Point(196, 453);
            this.button_book.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_book.Name = "button_book";
            this.button_book.Size = new System.Drawing.Size(139, 28);
            this.button_book.TabIndex = 1;
            this.button_book.Text = "Забронировать";
            this.button_book.UseVisualStyleBackColor = true;
            this.button_book.Click += new System.EventHandler(this.button_book_Click);
            // 
            // button_checkedin
            // 
            this.button_checkedin.Location = new System.Drawing.Point(356, 453);
            this.button_checkedin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_checkedin.Name = "button_checkedin";
            this.button_checkedin.Size = new System.Drawing.Size(136, 28);
            this.button_checkedin.TabIndex = 2;
            this.button_checkedin.Text = "Сдать";
            this.button_checkedin.UseVisualStyleBackColor = true;
            // 
            // button_checkedout
            // 
            this.button_checkedout.Location = new System.Drawing.Point(517, 453);
            this.button_checkedout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_checkedout.Name = "button_checkedout";
            this.button_checkedout.Size = new System.Drawing.Size(136, 28);
            this.button_checkedout.TabIndex = 3;
            this.button_checkedout.Text = "Освободить";
            this.button_checkedout.UseVisualStyleBackColor = true;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 581);
            this.Controls.Add(this.button_checkedout);
            this.Controls.Add(this.button_checkedin);
            this.Controls.Add(this.button_book);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Rooms";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_book;
        private System.Windows.Forms.Button button_checkedin;
        private System.Windows.Forms.Button button_checkedout;
    }
}