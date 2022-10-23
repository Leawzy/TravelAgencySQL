using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clients frm = new Clients();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employees frm = new Employees();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hotel frm = new Hotel();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Post frm = new Post();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Recreation frm = new Recreation();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Services frm = new Services();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Tickets frm = new Tickets();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
