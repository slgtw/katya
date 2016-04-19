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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"D:\services1.sqlite"))
            {
                SQLiteConnection.CreateFile(@"D:\services1.sqlite");
                SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\services1.sqlite; Version=3");
                SQLiteCommand sc = new SQLiteCommand("create table Services(id INTEGER PIMARY KEY, name TEXT, cost INTEGER)", sql);

                sql.Open(); sc.ExecuteNonQuery(); sql.Close();
            }

            SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\services1.sqlite; Version=3");
            sqlcon.Open();

            SQLiteCommand sql1 = new SQLiteCommand(sqlcon);
            sql1.CommandText = @"SELECT * FROM Services;";

            SQLiteDataReader sdr = sql1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;

            sdr.Close();
            sqlcon.Close();
        }

        private void button1_add_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\services1.sqlite; Version=3");
 sql.Open();
            //генерация id

            SQLiteCommand sc1 = new SQLiteCommand(@"select max(id) from Services", sql);
            SQLiteDataReader sdr = sc1.ExecuteReader();

            sdr.Read();
            string id1 = sdr.GetValue(0).ToString();
            if (id1.Length < 1)
                id1 = "0";


            SQLiteCommand sc = new SQLiteCommand(@"INSERT INTO Services(id,name,cost) values(" + (Convert.ToInt32(id1) + 1) + @", '" + textBox_name.Text + @"', '" + textBox_cost.Text + @"')", sql);
           
            sc.ExecuteNonQuery();
            sql.Close();
        }
    }
}
