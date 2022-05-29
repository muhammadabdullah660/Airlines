using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airlines.BL;
using Airlines.DL;

namespace Airlines.PassengerForms
{
    public partial class ViewBookedFlightsForm : Form
    {
        private Passenger p;
        public ViewBookedFlightsForm (Passenger p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void ViewBookedFlightsForm_Load (object sender , EventArgs e)
        {
            gvFlights.DataSource = p.MyFlights;
        }

        private void gvFlights_CellContentClick (object sender , DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click (object sender , EventArgs e)
        {
            this.Close();
        }
    }
}
