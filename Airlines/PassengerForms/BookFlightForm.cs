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
            Flight myFlight = new Flight(cmbxDepartCity.Text , cmbxArrCity.Text , cmbxTripType.Text , mskdtxtbxDate.Text);
            Flight item = FlightDL.checkFlight(myFlight);
            if (item != null)
            {
                p.Adult = int.Parse(mskdtxtbxAdult.Text);
                p.Child = int.Parse(mskdtxtbxChild.Text);
                p.Infant = int.Parse(mskdtxtbxInfant.Text);

                myFlight.Seats = p.Adult + p.Child + p.Infant;
                myFlight.FlightClass = cmbxClass.Text;
                double x = p.calculatePrice(item , myFlight);
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
        }
        private void combobox (Flight item)
        {
            if (item.FlightClass != "All")
            {
                cmbxClass.DataSource = item.FlightClass;
            }
        }

        private void mskdtxtbxDate_MaskInputRejected (object sender , MaskInputRejectedEventArgs e)
        {

        }
    }
}
