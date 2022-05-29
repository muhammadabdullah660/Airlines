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
    public partial class CancelBookedFlightForm : Form
    {
        private Passenger p;

        public CancelBookedFlightForm (Passenger p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void CancelBookedFlightForm_Load (object sender , EventArgs e)
        {
            gvFlights.DataSource = p.MyFlights;//Introspection
        }
        public void dataBind ()
        {
            gvFlights.DataSource = null;
            gvFlights.DataSource = FlightDL.FlightsList;
            gvFlights.Refresh();
        }

        private void gvFlights_CellContentClick (object sender , DataGridViewCellEventArgs e)
        {

            Flight newFlight = (Flight)gvFlights.CurrentRow.DataBoundItem;
            if (gvFlights.Columns["Cancel"].Index == e.ColumnIndex)
            {
                p.cancelBookedFlight(newFlight);
                dataBind();
            }


        }


        private void btnBack_Click (object sender , EventArgs e)
        {
            this.Close();
        }
    }
}
