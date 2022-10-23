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
    public partial class Hotel : Form
    {
        public Hotel()
        {
            InitializeComponent();
        }

        private void hotelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelAgencyDataSet);

        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelAgencyDataSet.Hotel' table. You can move, or remove it, as needed.
            this.hotelTableAdapter.Fill(this.travelAgencyDataSet.Hotel);

        }
    }
}
