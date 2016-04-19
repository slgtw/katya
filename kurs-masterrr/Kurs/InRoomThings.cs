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
    public partial class InRoomThings : Form
    {
        public InRoomThings()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InRoomThings_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"D:\rooms1.sqlite"))
            {
                SQLiteConnection.CreateFile(@"D:\inroomthings1.sqlite");
                SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\inroomthings1.sqlite; Version=3");
                SQLiteCommand sc = new SQLiteCommand("create table inroomthings(id INTEGER PIMARY KEY, name TEXT,cost INTEGER,status TEXT)", sql);

                sql.Open();
                //sc.CommandText ="INSERT INTO Rooms (id, type, status, cost) VALUES(1,'sdas', 'sqq', 1000)";
                sc.ExecuteNonQuery();
                sql.Close();
            }
            SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\inroomthings1.sqlite; Version=3");
            sqlcon.Open();

            SQLiteCommand sql1 = new SQLiteCommand(sqlcon);
            sql1.CommandText = @"SELECT * FROM inroomthings;";

            SQLiteDataReader sdr = sql1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;

            sdr.Close();
            sqlcon.Close();

        }

        private void button_add_thing_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\inroomthings1.sqlite; Version=3");

            //генерация id
            SQLiteCommand sc1 = new SQLiteCommand(@"select max(id) from inroomthings", sql);
            sql.Open();
            SQLiteDataReader sdr = sc1.ExecuteReader();

            sdr.Read();
            string id1 = sdr.GetValue(0).ToString();
            if (id1.Length < 1)
                id1 = "0";



            SQLiteCommand sc = new SQLiteCommand(@"INSERT INTO inroomthings(id,name,cost,status) values(" + (Convert.ToInt32(id1) + 1) + @", '" + textBox_nameOfthing.Text + @"', '" + costOFthing.Text + @"', '" + textBox_status.Text + @"')", sql);
            
            
            sc.ExecuteNonQuery();
            sql.Close();
            SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\inroomthings1.sqlite; Version=3");


            SQLiteCommand sql1 = new SQLiteCommand(sqlcon);
            // sql1.CommandText = "INSERT INTO Rooms (id, type, status, cost) VALUES(1,'sdas', 'sqq', 1000)";
            sqlcon.Open();
            sql1.CommandText = @"SELECT * FROM inroomthings;";


            SQLiteDataReader sdr1 = sql1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr1);
            dataGridView1.DataSource = dt;

            sdr1.Close();
            sqlcon.Close();
        }

      
    }
}
