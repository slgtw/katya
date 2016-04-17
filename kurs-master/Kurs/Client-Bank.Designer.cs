namespace Kurs
{
    partial class Client_Bank
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
            this.button_CB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_CB
            // 
            this.button_CB.Location = new System.Drawing.Point(374, 369);
            this.button_CB.Name = "button_CB";
            this.button_CB.Size = new System.Drawing.Size(146, 62);
            this.button_CB.TabIndex = 0;
            this.button_CB.Text = "Выбор файла txt";
            this.button_CB.UseVisualStyleBackColor = true;
            // 
            // Client_Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 443);
            this.Controls.Add(this.button_CB);
            this.Name = "Client_Bank";
            this.Text = "Client_Bank";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_CB;
    }
}