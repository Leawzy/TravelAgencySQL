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
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }

        private void ticketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelAgencyDataSet);

        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelAgencyDataSet.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.travelAgencyDataSet.Tickets);

        }
    }
}
