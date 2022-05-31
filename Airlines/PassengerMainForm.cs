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
namespace Airlines
{
    public partial class PassengerMainForm : Form
    {
        private Passenger p;
        private string path = "Passenger.txt";
        public PassengerMainForm (Passenger p)
        {
            InitializeComponent();
            this.p = p;
        }
        private void PassengerMainForm_Load (object sender , EventArgs e)
        {


        }
        private void bookToolStripMenuItem_Click (object sender , EventArgs e)
        {
            BookFlightForm bookForm = new BookFlightForm(p);
            bookForm.Show();
        }

        private void personalToolStripMenuItem_Click (object sender , EventArgs e)
        {
            PersonalDetails pDForm = new PersonalDetails(p);
            pDForm.Show();
        }

        private void requestToolStripMenuItem_Click (object sender , EventArgs e)
        {
            RequestFlightForm reqFlightForm = new RequestFlightForm();
            reqFlightForm.Show();
        }

        private void myFlightsToolStripMenuItem_Click (object sender , EventArgs e)
        {
            ViewBookedFlightsForm viewFlight = new ViewBookedFlightsForm(p);
            viewFlight.Show();
        }

        private void cancelToolStripMenuItem_Click (object sender , EventArgs e)
        {
            CancelBookedFlightForm cancelBookedFlight = new CancelBookedFlightForm(p);
            cancelBookedFlight.Show();
        }


        private void updatePersonalDetailsToolStripMenuItem_Click (object sender , EventArgs e)
        {
            UpdatePersonalDetailsForm updateDetails = new UpdatePersonalDetailsForm(p);
            updateDetails.Show();
        }

        private void btnLogOut_Click (object sender , EventArgs e)
        {
            PassengerDL.storeAllIntoFile(path);
            this.Close();
        }
    }
}
