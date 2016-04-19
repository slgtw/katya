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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        list_of_Booking b = new list_of_Booking();
        private void button_reservation_complete_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\reservations1.sqlite; Version=3");
            sql.Open();
            //генерация id
            SQLiteCommand sc1 = new SQLiteCommand(@"select max(id) from Reservations", sql);
            SQLiteDataReader sdr = sc1.ExecuteReader();

            sdr.Read();
            string id1 = sdr.GetValue(0).ToString();
            if (id1.Length < 1)
                id1 = "0";



            SQLiteCommand sc = new SQLiteCommand(@"INSERT INTO Reservations(id,dateReserv,reservEnd,status) values(" + (Convert.ToInt32(id1) + 1) + @",'" + dateTimePicker1.Value.ToShortDateString() + @"', '" + dateTimePicker2.Value.ToShortDateString() + @"','" + textBox3.Text + @"')", sql);

            sc.ExecuteNonQuery();
            sql.Close();
            // Booking b = new Booking();
            b.ShowDialog();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reservation_Load(object sender, EventArgs e)
        {

            if (!File.Exists(@"D:\reservations1.sqlite"))
            {
                SQLiteConnection.CreateFile(@"D:\reservations1.sqlite");
                SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\reservations1.sqlite; Version=3");
                SQLiteCommand sc = new SQLiteCommand("create table Reservations(id INTEGER PIMARY KEY, dateReserv TEXT, reservEnd TEXT, status TEXT)", sql);

                sql.Open(); sc.ExecuteNonQuery(); sql.Close();
            }

            SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\clients1.sqlite; Version=3");
            sqlcon.Open();

            SQLiteCommand sс = new SQLiteCommand(sqlcon);
            sс.CommandText = @"SELECT * FROM Clients;";

            SQLiteDataReader sdr = sс.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;

            sdr.Close();
            sqlcon.Close();

            SQLiteConnection sqlcon1 = new SQLiteConnection(@"Data Source=D:\rooms1.sqlite; Version=3");
            sqlcon1.Open();

            SQLiteCommand sс1 = new SQLiteCommand(sqlcon1);
            sс1.CommandText = @"SELECT * FROM Rooms;";

            SQLiteDataReader sdr1 = sс1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(sdr1);
            dataGridView2.DataSource = dt1;

            sdr1.Close();
            sqlcon1.Close();
        }
    }
}
