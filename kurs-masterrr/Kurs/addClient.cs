using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using iTextSharp.text;
using iTextSharp;
using iTextSharp.text.pdf;

namespace Kurs
{
    public partial class addClient : Form
    {
        public addClient()
        {
            InitializeComponent();
        }
        Clients cl = new Clients();
     
        private void button_add_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\clients1.sqlite; Version=3");
            sql.Open();

            //генерация id     
            

            SQLiteCommand sc1 = new SQLiteCommand(@"select max(id) from Clients",sql);
            SQLiteDataReader sdr = sc1.ExecuteReader();
          
            sdr.Read();
            string id1 =sdr.GetValue(0).ToString();
            if (id1.Length < 1)
                id1 = "0";

            SQLiteCommand sc = new SQLiteCommand(@" INSERT INTO Clients(id,name,birthday,sex,child,phone,info) values(" + (Convert.ToInt32(id1)+1) + @", '" + textBox_name.Text + @"', '" + dateTimePicker_Birthday.Value.ToShortDateString() + "', '" + comboBox1.SelectedItem.ToString() + "', '" + textBox_child.Text +"', '" + textBox_phone.Text + "','" + textBox_dop.Text +"')", sql);
           
            sc.ExecuteNonQuery();
            sql.Close();


            this.Close();
        }

        private void addClient_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void addClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }
    }
}
