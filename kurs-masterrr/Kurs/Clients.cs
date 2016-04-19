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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"D:\clients1.sqlite"))
            {
                SQLiteConnection.CreateFile(@"D:\clients1.sqlite");
                SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\clients1.sqlite; Version=3");
                SQLiteCommand sc = new SQLiteCommand("create table Clients(id INTEGER PIMARY KEY, name TEXT, birthday TEXT, sex TEXT, child INTEGER, phone TEXT, info TEXT )", sql);

                sql.Open(); sc.ExecuteNonQuery(); sql.Close();
            }

            SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\clients1.sqlite; Version=3");
            sqlcon.Open();

            SQLiteCommand sql1 = new SQLiteCommand(sqlcon);
            sql1.CommandText = @"SELECT * FROM Clients;";
            SQLiteDataReader sdr = sql1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            sdr.Close();
            sqlcon.Close();
        }
        private void button_del_cl_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\clients1.sqlite;Version=3");

            SQLiteCommand sc = new SQLiteCommand("DELETE FROM Clients WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value.ToString(), sql);
           // sc.CommandText = "select * from Clients";
            sql.Open();
            sc.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Клиент удален из БД");
            SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\clients1.sqlite; Version=3");
            sqlcon.Open();

            SQLiteCommand sql1 = new SQLiteCommand(sqlcon);
            sql1.CommandText = @"SELECT * FROM Clients;";
            SQLiteDataReader sdr = sql1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
            sdr.Close();
            sqlcon.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            addClient ac = new addClient();
            //ac.Hide();
            ac.ShowDialog();


            //kod_vypolнyaetsya_posle_zakrytiya_formy_addCLIEНT

            SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\clients1.sqlite; Version=3");
            sqlcon.Open();

            SQLiteCommand sql = new SQLiteCommand(sqlcon);
            sql.CommandText = @"SELECT * FROM Clients;";

            SQLiteDataReader sdr = sql.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;

            sdr.Close();
            sqlcon.Close();

        }
    }
}
