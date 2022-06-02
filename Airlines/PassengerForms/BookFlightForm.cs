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
            cmbxDepartCity.DataSource = FlightDL.FlightsList.Select(c => new { c.DepartCity }).Distinct().ToList();
            cmbxArrCity.DataSource = FlightDL.FlightsList.Select(c => new { c.ArrCity }).Distinct().ToList();
        }

        private void btnSave_Click (object sender , EventArgs e)
        {
            Flight myFlight = new Flight(cmbxDepartCity.Text , cmbxArrCity.Text , cmbxTripType.Text , dateTimePicker1.Value);
            Flight item = FlightDL.checkFlight(myFlight);
            if (item != null)
            {
                int Adult = Convert.ToInt32(Math.Round(numUpDnAdult.Value , 0));
                int Child = Convert.ToInt32(Math.Round(numUpDnChild.Value , 0));
                int Infant = Convert.ToInt32(Math.Round(numUpDnInfant.Value , 0));
                myFlight.DepartTime = item.DepartTime;
                myFlight.Seats = Adult + Child + Infant;
                myFlight.FlightClass = cmbxClass.Text;
                double x = p.calculatePrice(item , myFlight , Adult , Child , Infant);
                myFlight.Price = x;
                p.bookFlight(myFlight);
            }

            MessageBox.Show("Saved");
        }

        private void btnBack_Click (object sender , EventArgs e)
        {
            this.Close();
        }

        private void cmbxDepartCity_SelectedIndexChanged (object sender , EventArgs e)
        {
            cmbxArrCity.DataSource = FlightDL.FlightsList.Where(x => x.DepartCity == cmbxDepartCity.Text).Select(x => x.ArrCity).Distinct().ToList();
            cmbxTripType.DataSource = FlightDL.FlightsList.Where(x => x.DepartCity == cmbxDepartCity.Text && x.ArrCity == cmbxArrCity.Text).Select(x => x.TripType).Distinct().ToList();
        }
        private void cmbxArrCity_SelectedIndexChanged (object sender , EventArgs e)
        {
            cmbxTripType.DataSource = FlightDL.FlightsList.Where(x => x.DepartCity == cmbxDepartCity.Text && x.ArrCity == cmbxArrCity.Text).Select(x => x.TripType).Distinct().ToList();
        }
        private void cmbxTripType_SelectedIndexChanged (object sender , EventArgs e)
        {
            dateTimePicker1.Value = FlightDL.FlightsList.Where(x => x.DepartCity == cmbxDepartCity.Text && x.ArrCity == cmbxArrCity.Text).Select(x => x.DepartDate).First();
        }

        private void lblMainHeading_Click (object sender , EventArgs e)
        {

        }
    }
}

