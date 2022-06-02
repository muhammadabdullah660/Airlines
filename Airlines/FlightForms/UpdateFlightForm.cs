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
    public partial class UpdateFlightForm : Form
    {


        private Flight previous;
        public UpdateFlightForm (Flight previous)
        {
            InitializeComponent();
            this.previous = previous;

        }
        private void UpdateFlightForm_Load (object sender , EventArgs e)
        {
            txtDept.Text = previous.DepartCity;
            txtArr.Text = previous.ArrCity;
            cmbxTrip.Text = previous.TripType;
            dateTimePicker1.Value = previous.DepartDate;
            mskdtxtbxTime.Text = previous.DepartTime;
            numUpDnSeats.Value = (previous.Seats);
            numUpDnPrice.Value = Convert.ToDecimal(previous.Price);
            cmbxClass.Text = previous.FlightClass;
        }




        private void btnSave_Click (object sender , EventArgs e)
        {
            double price = Convert.ToDouble(Math.Round(numUpDnPrice.Value , 0));
            int seats = Convert.ToInt32(Math.Round(numUpDnSeats.Value , 0));

            Flight updated = new Flight(txtDept.Text , txtArr.Text , cmbxTrip.Text , dateTimePicker1.Value , mskdtxtbxTime.Text , seats , price , cmbxClass.Text);
            FlightDL.editFlightFromList(previous , updated);
            MessageBox.Show("Updated Successfully");
        }

        private void btnBack_Click (object sender , EventArgs e)
        {
            this.Close();
        }

        private void lblMainHeading_Click (object sender , EventArgs e)
        {

        }
    }
}
