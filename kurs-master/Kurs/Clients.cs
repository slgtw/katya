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
                SQLiteCommand sc = new SQLiteCommand("create table Clients(id INTEGER PIMARY KEY, name TEXT, data TEXT)", sql);

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

             
            // sc.CommandText = "insert into Clients(id,name,data) values (2, 'Петров','тел. 55-77-66' )";



        }
        private void button_del_cl_Click(object sender, EventArgs e)
        {
            //SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\1\mydb.sqlite;Version=3");

            //SQLiteCommand sc = new SQLiteCommand("DELETE FROM Student WHERE id = '" + textBox1.Text + "'", sql);
            //sql.Open();
            //sc.ExecuteNonQuery();
            //sql.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
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

            textBox_FIO.Clear();
            textBox_data.Clear();
        }

        private void button_addClient_complete_Click(object sender, EventArgs e)
        {
            SQLiteConnection sql = new SQLiteConnection(@"Data Source=D:\clients1.sqlite; Version=3");
           
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

           SQLiteCommand sc = new SQLiteCommand(@"INSERT INTO Clients(id,name,data) values(" + id + @", '" + textBox_FIO.Text + @"', '" + textBox_data.Text + @"')", sql);
            //   sc.CommandText = "insert into Clients(id,name,data) values (1, 'Иванов','тел. 55-55-66' )";
            
            ////SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\clients1.sqlite; Version=3");
            //sql.Open();

            //SQLiteCommand sql1 = new SQLiteCommand(sql);
            //sql1.CommandText = @"SELECT * FROM Clients;";

            //SQLiteDataReader sdr = sql1.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(sdr);
            //dataGridView1.DataSource = dt;

            //sdr.Close();
            //sql.Close();
            
            sql.Open();
            sc.ExecuteNonQuery();
            sql.Close();
        }


    }
}
