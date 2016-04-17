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

            //генерация id
            int id = -1;
            int max_id = -1;




            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) > max_id)
                {
                    max_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    id = max_id + 1;
                }

            }
            if (max_id == -1) id = 1;



         SQLiteCommand sc = new SQLiteCommand(@"INSERT INTO Services(id,name,cost) values(" + id + @", '" + textBox_name.Text + @"', '" + textBox_cost.Text + @"')", sql);
            sql.Open();
            sc.ExecuteNonQuery();
            sql.Close();
        }
    }
}
