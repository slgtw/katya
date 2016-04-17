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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void button_book_Click(object sender, EventArgs e)
        {

            Reservation res = new Reservation();
            res.Hide();
            res.Show();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"D:\rooms1.sqlite"))
            {
                SQLiteConnection.CreateFile(@"D:\rooms1.sqlite");
                SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\rooms1.sqlite; Version=3");
                SQLiteCommand sc = new SQLiteCommand("create table Rooms(id INTEGER PIMARY KEY, type TEXT, status TEXT, cost INTEGER);               INSERT INTO Rooms (id, type, status, cost) VALUES(1,'sdas', 'sqq', 1000)", sql);
                 
                sql.Open();
     //     sc.CommandText ="INSERT INTO Rooms (id, type, status, cost) VALUES(1,'sdas', 'sqq', 1000)";
                sc.ExecuteNonQuery();
                sql.Close();
            }
            SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\rooms1.sqlite; Version=3");


            SQLiteCommand sql1 = new SQLiteCommand(sqlcon);
           // sql1.CommandText = "INSERT INTO Rooms (id, type, status, cost) VALUES(1,'sdas', 'sqq', 1000)";
            sqlcon.Open();
            sql1.CommandText = @"SELECT * FROM Rooms;";
            

            SQLiteDataReader sdr = sql1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;

            sdr.Close();
            sqlcon.Close();
        }
    }
}
