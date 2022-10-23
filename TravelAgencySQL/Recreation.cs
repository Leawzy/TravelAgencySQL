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
    public partial class Recreation : Form
    {
        public Recreation()
        {
            InitializeComponent();
        }

        private void recreationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.recreationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelAgencyDataSet);

        }

        private void Recreation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelAgencyDataSet.Recreation' table. You can move, or remove it, as needed.
            this.recreationTableAdapter.Fill(this.travelAgencyDataSet.Recreation);

        }
    }
}
