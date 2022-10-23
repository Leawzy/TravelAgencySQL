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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void servicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelAgencyDataSet);

        }

        private void Services_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelAgencyDataSet.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.travelAgencyDataSet.Services);

        }
    }
}
