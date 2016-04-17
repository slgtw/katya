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
                //     sc.CommandText ="INSERT INTO Rooms (id, type, status, cost) VALUES(1,'sdas', 'sqq', 1000)";
                sc.ExecuteNonQuery();
                sql.Close();
            }
        }

        private void button_add_thing_Click(object sender, EventArgs e)
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



            SQLiteCommand sc = new SQLiteCommand(@"INSERT INTO Services(id,name,cost) values(" + id + @", '" + textBox_nameOfthing.Text + @"', '" + costOFthing.Text + @"', '" + textBox_status + @"')", sql);
            sql.Open();
            sc.ExecuteNonQuery();
            sql.Close();
        }
    }
}
