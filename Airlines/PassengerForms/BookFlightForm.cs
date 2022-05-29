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
    public partial class BookFlightForm : Form
    {
        private Passenger p;
        public BookFlightForm (Passenger p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void BookFlightForm_Load (object sender , EventArgs e)
        {
            cmbxDepartCity.DataSource = FlightDL.FlightsList.Select(c => new { c.DepartCity }).ToList();
            cmbxArrCity.DataSource = FlightDL.FlightsList.Select(c => new { c.ArrCity }).ToList();
        }

        private void btnSave_Click (object sender , EventArgs e)
        {
            Flight myFlight = new Flight(cmbxDepartCity.Text , cmbxArrCity.Text , cmbxTripType.Text , mskdtxtbxDate.Text);
            Flight item = FlightDL.checkFlight(myFlight);
            double x;
            int Adult = int.Parse(mskdtxtbxAdult.Text);
            int Child = int.Parse(mskdtxtbxChild.Text);
            int Infant = int.Parse(mskdtxtbxInfant.Text);
            x = ((Adult * item.Price) + (Child * (item.Price)) / 2 + (Infant * (item.Price) / 4));
            myFlight.Price = x;
            myFlight.Seats = Adult + Child + Infant;
            p.MyFlights.Add(myFlight);
            MessageBox.Show("Saved");
        }

        private void btnBack_Click (object sender , EventArgs e)
        {
            this.Close();
        }
    }
}
