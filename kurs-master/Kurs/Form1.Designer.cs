namespace Kurs
{
    partial class Main_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_menu = new System.Windows.Forms.MenuStrip();
            this.бДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бронированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьСчетpdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентБанкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вещиВНомерахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.Main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_menu
            // 
            this.Main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бДToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.сервисToolStripMenuItem});
            this.Main_menu.Location = new System.Drawing.Point(0, 0);
            this.Main_menu.Name = "Main_menu";
            this.Main_menu.Size = new System.Drawing.Size(862, 24);
            this.Main_menu.TabIndex = 0;
            this.Main_menu.Text = "menuStrip1";
            // 
            // бДToolStripMenuItem
            // 
            this.бДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.номераToolStripMenuItem,
            this.клиентыToolStripMenuItem});
            this.бДToolStripMenuItem.Name = "бДToolStripMenuItem";
            this.бДToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.бДToolStripMenuItem.Text = "БД";
            // 
            // номераToolStripMenuItem
            // 
            this.номераToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бронированиеToolStripMenuItem});
            this.номераToolStripMenuItem.Name = "номераToolStripMenuItem";
            this.номераToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.номераToolStripMenuItem.Text = "Номера";
            this.номераToolStripMenuItem.Click += new System.EventHandler(this.номераToolStripMenuItem_Click);
            // 
            // бронированиеToolStripMenuItem
            // 
            this.бронированиеToolStripMenuItem.Name = "бронированиеToolStripMenuItem";
            this.бронированиеToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.бронированиеToolStripMenuItem.Text = "Бронирование";
            this.бронированиеToolStripMenuItem.Click += new System.EventHandler(this.бронированиеToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сформироватьОтчетToolStripMenuItem,
            this.сформироватьСчетpdfToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // сформироватьОтчетToolStripMenuItem
            // 
            this.сформироватьОтчетToolStripMenuItem.Name = "сформироватьОтчетToolStripMenuItem";
            this.сформироватьОтчетToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.сформироватьОтчетToolStripMenuItem.Text = "Сформировать отчет ";
            this.сформироватьОтчетToolStripMenuItem.Click += new System.EventHandler(this.сформироватьОтчетToolStripMenuItem_Click);
            // 
            // сформироватьСчетpdfToolStripMenuItem
            // 
            this.сформироватьСчетpdfToolStripMenuItem.Name = "сформироватьСчетpdfToolStripMenuItem";
            this.сформироватьСчетpdfToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.сформироватьСчетpdfToolStripMenuItem.Text = "Сформировать счет (pdf)";
            this.сформироватьСчетpdfToolStripMenuItem.Click += new System.EventHandler(this.сформироватьСчетpdfToolStripMenuItem_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентБанкToolStripMenuItem,
            this.вещиВНомерахToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // клиентБанкToolStripMenuItem
            // 
            this.клиентБанкToolStripMenuItem.Name = "клиентБанкToolStripMenuItem";
            this.клиентБанкToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.клиентБанкToolStripMenuItem.Text = "Клиент-Банк";
            this.клиентБанкToolStripMenuItem.Click += new System.EventHandler(this.клиентБанкToolStripMenuItem_Click);
            // 
            // вещиВНомерахToolStripMenuItem
            // 
            this.вещиВНомерахToolStripMenuItem.Name = "вещиВНомерахToolStripMenuItem";
            this.вещиВНомерахToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.вещиВНомерахToolStripMenuItem.Text = "Вещи в номерах";
            this.вещиВНомерахToolStripMenuItem.Click += new System.EventHandler(this.вещиВНомерахToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Бэкап";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Main_menu);
            this.MainMenuStrip = this.Main_menu;
            this.Name = "Main_form";
            this.Text = "Main_form";
            this.Main_menu.ResumeLayout(false);
            this.Main_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Main_menu;
        private System.Windows.Forms.ToolStripMenuItem бДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бронированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьСчетpdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентБанкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вещиВНомерахToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

