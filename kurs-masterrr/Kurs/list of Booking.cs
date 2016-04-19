using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class list_of_Booking : Form
    {
        public list_of_Booking()
        {
            InitializeComponent();
        }

        private void list_of_Booking_Load(object sender, EventArgs e)
        {
            SQLiteConnection sqlcon = new SQLiteConnection(@"Data Source=D:\reservations1.sqlite; Version=3");


            SQLiteCommand sql1 = new SQLiteCommand(sqlcon);
            // sql1.CommandText = "INSERT INTO Rooms (id, type, status, cost) VALUES(1,'sdas', 'sqq', 1000)";
            sqlcon.Open();
            sql1.CommandText = @"SELECT * FROM Reservations;";


            SQLiteDataReader sdr = sql1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dataGridView_booking.DataSource = dt;

            sdr.Close();
            sqlcon.Close();
        }
    }
}
