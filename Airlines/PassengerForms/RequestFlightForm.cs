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
    public partial class RequestFlightForm : Form
    {
        public RequestFlightForm ()
        {
            InitializeComponent();
        }

        private void RequestFlightForm_Load (object sender , EventArgs e)
        {

        }

        private void btnSave_Click (object sender , EventArgs e)
        {
            Flight reqFlight = new Flight(txtDept.Text , txtArr.Text , cmbxTripType.Text , dateTimePicker1.Value);
            FlightDL.addReqFlightIntoList(reqFlight);
            FlightDL.storeReqFlightsIntoFile("FlightReq.txt" , reqFlight);
            MessageBox.Show("Request Sent");
            resetTxt();
        }
        private void resetTxt ()
        {
            foreach (Control C in this.Controls)
            {
                if (C is TextBox || C is MaskedTextBox || C is ComboBox)
                {
                    C.Text = "";
                }
            }
        }

        private void btnBack_Click (object sender , EventArgs e)
        {
            this.Close();
        }
    }
}
