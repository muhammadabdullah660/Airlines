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
using Airlines.PassengerForms;
namespace Airlines.FlightForms
{
    public partial class FlightViewForm : Form
    {
        private string path = "Flight.txt";
        private string pathF = "FlightReq.txt";
        public FlightViewForm ()
        {
            InitializeComponent();
        }

        private void FlightViewForm_Load (object sender , EventArgs e)
        {
            gvFlights.DataSource = FlightDL.FlightsList;//Introspection
        }
        public void dataBind ()
        {
            gvFlights.DataSource = null;
            gvFlights.DataSource = FlightDL.FlightsList;
            gvFlights.Refresh();
        }

        private void btnNew_Click (object sender , EventArgs e)
        {
            AddFlightForm newForm = new AddFlightForm();
            newForm.ShowDialog();
            FlightDL.storeAllFlightsIntoFile(path , pathF);
            dataBind();
        }

        private void gvFlights_CellContentClick (object sender , DataGridViewCellEventArgs e)
        {
            Flight newFlight = (Flight)gvFlights.CurrentRow.DataBoundItem;
            if (gvFlights.Columns["Delete"].Index == e.ColumnIndex)
            {
                FlightDL.cancelFlight(newFlight);
                FlightDL.storeAllFlightsIntoFile(path , pathF);
                dataBind();
            }
            else if (gvFlights.Columns["Edit"].Index == e.ColumnIndex)
            {
                UpdateFlightForm newForm = new UpdateFlightForm(newFlight);
                newForm.ShowDialog();
                FlightDL.storeAllFlightsIntoFile(path , pathF);
                dataBind();
            }
        }

        private void flowLayoutPanel1_Paint (object sender , PaintEventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint (object sender , PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint (object sender , PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint (object sender , PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint (object sender , PaintEventArgs e)
        {

        }
    }
}
