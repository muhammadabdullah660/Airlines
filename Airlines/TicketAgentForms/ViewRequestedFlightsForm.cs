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
using Airlines.FlightForms;
namespace Airlines.TicketAgentForms
{
    public partial class ViewRequestedFlightsForm : Form
    {
        private string path = "Flight.txt";
        private string pathF = "FlightReq.txt";
        public ViewRequestedFlightsForm ()
        {
            InitializeComponent();
            gvFlights.DataSource = FlightDL.RequestedFlightsList;
        }

        private void gvFlights_CellContentClick (object sender , DataGridViewCellEventArgs e)
        {
            Flight newFlight = (Flight)gvFlights.CurrentRow.DataBoundItem;
            if (gvFlights.Columns["Add"].Index == e.ColumnIndex)
            {
                FlightDL.addFlightIntoList(newFlight);
                UpdateFlightForm newForm = new UpdateFlightForm(newFlight);
                newForm.ShowDialog();
                FlightDL.deleteRequestedFlight(newFlight);
                FlightDL.storeAllFlightsIntoFile(path , pathF);
                dataBind();
            }
        }
        public void dataBind ()
        {
            gvFlights.DataSource = null;
            gvFlights.DataSource = FlightDL.RequestedFlightsList;
            gvFlights.Refresh();
        }
        private void ViewRequestedFlightsForm_Load (object sender , EventArgs e)
        {

        }
    }
}
