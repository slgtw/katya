namespace Kurs
{
    partial class list_of_Booking
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
            this.dataGridView_booking = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_booking)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_booking
            // 
            this.dataGridView_booking.AllowUserToAddRows = false;
            this.dataGridView_booking.AllowUserToDeleteRows = false;
            this.dataGridView_booking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_booking.Location = new System.Drawing.Point(70, 129);
            this.dataGridView_booking.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_booking.Name = "dataGridView_booking";
            this.dataGridView_booking.ReadOnly = true;
            this.dataGridView_booking.Size = new System.Drawing.Size(900, 257);
            this.dataGridView_booking.TabIndex = 1;
            // 
            // list_of_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 428);
            this.Controls.Add(this.dataGridView_booking);
            this.Name = "list_of_Booking";
            this.Text = "list_of_Booking";
            this.Load += new System.EventHandler(this.list_of_Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_booking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView_booking;
    }
}