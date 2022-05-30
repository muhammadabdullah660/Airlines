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
            mskdtxtbxDate.Text = previous.DepartDate;
            mskdtxtbxTime.Text = previous.DepartTime;
            mskdtxtbxSeats.Text = (previous.Seats).ToString();
            mskdtxtbxPrice.Text = (previous.Price).ToString();
            cmbxClass.Text = previous.FlightClass;
        }




        private void btnSave_Click (object sender , EventArgs e)
        {
            Flight updated = new Flight(txtDept.Text , txtArr.Text , cmbxTrip.Text , mskdtxtbxDate.Text , mskdtxtbxTime.Text , int.Parse(mskdtxtbxSeats.Text) , int.Parse(mskdtxtbxPrice.Text) , cmbxClass.Text);
            FlightDL.editFlightFromList(previous , updated);
            MessageBox.Show("Updated Successfully");
        }

        private void btnBack_Click (object sender , EventArgs e)
        {
            this.Close();
        }
    }
}
