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
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private void вещиВНомерахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InRoomThings irt = new InRoomThings();
            irt.Hide();
            irt.Show();

        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients cl = new Clients();
            cl.Hide();
            cl.Show();
        }

        private void номераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rooms r = new Rooms();
            r.Hide();
            r.Show();
        }

        private void бронированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Booking b = new Booking();
            b.Hide();
            b.Show();

        }

        private void сформироватьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report rep = new Report();
            rep.Hide();
            rep.Show();
        }

        private void сформироватьСчетpdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            b.Hide();
            b.Show();

        }

        private void клиентБанкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client_Bank cb = new Client_Bank();
            cb.Hide();
            cb.Show();

        }
    }
}
