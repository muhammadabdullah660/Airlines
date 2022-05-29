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
    public partial class AddFlightForm : Form
    {
        public AddFlightForm ()
        {
            InitializeComponent();
        }

        private void AddFlightForm_Load (object sender , EventArgs e)
        {
        }
        private void btnAdd_Click (object sender , EventArgs e)
        {

            Flight newFlight = new Flight(txtDept.Text , txtArr.Text , cmbxTrip.Text , mskdtxtbxDate.Text , mskdtxtbxTime.Text , int.Parse(mskdtxtbxSeats.Text) , int.Parse(mskdtxtbxPrice.Text));
            FlightDL.addFlightIntoList(newFlight);
            MessageBox.Show("Added Succesfully");
            resetTxt();

        }
        private void resetTxt ()
        {
            foreach (Control C in this.Controls)
            {
                if (C is TextBox)
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
