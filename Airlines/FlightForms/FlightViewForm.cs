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
        public FlightViewForm ()
        {
            InitializeComponent();
        }


        public void dataBind ()
        {
            gvUsers.DataSource = null;
            gvUsers.DataSource = FlightDL.FlightsList;
            gvUsers.Refresh();
        }

        private void btnNew_Click (object sender , EventArgs e)
        {
            AddFlightForm newForm = new AddFlightForm();
            newForm.ShowDialog();
            FlightDL.storeAllFlightsIntoFile(path);
            dataBind();
        }

        private void gvUsers_CellContentClick (object sender , DataGridViewCellEventArgs e)
        {
            Flight newFlight = (Flight)gvUsers.CurrentRow.DataBoundItem;
            if (gvUsers.Columns["Delete"].Index == e.ColumnIndex)
            {
                FlightDL.cancelFlight(newFlight);
                FlightDL.storeAllFlightsIntoFile(path);
                dataBind();
            }
            else if (gvUsers.Columns["Edit"].Index == e.ColumnIndex)
            {
                UpdateFlightForm newForm = new UpdateFlightForm(newFlight);
                newForm.ShowDialog();
                FlightDL.storeAllFlightsIntoFile(path);
                dataBind();
            }
        }

        private void FlightViewForm_Load (object sender , EventArgs e)
        {
            FlightDL.loadFromFile(path);
            gvUsers.DataSource = FlightDL.FlightsList;//Introspection
        }
    }
}
