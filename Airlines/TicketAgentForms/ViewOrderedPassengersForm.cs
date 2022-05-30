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
namespace Airlines.TicketAgentForms
{
    public partial class ViewOrderedPassengersForm : Form
    {
        public ViewOrderedPassengersForm ()
        {
            InitializeComponent();
        }

        private void ViewOrderedPassengersForm_Load (object sender , EventArgs e)
        {
            PassengerDL.sortPassengersByTotal();
            gvPassengers.DataSource = PassengerDL.SortedPassengersList;

            /*   Flights.DataSource = PassengerDL.SortedPassengersList.Select(c => new
               {
                   c.MyFlights
               }).ToList();*/

        }

        private void btnBack_Click (object sender , EventArgs e)
        {
            this.Close();
        }

        private void gvPassengers_CellContentClick (object sender , DataGridViewCellEventArgs e)
        {
            Passenger p = (Passenger)gvPassengers.CurrentRow.DataBoundItem;
            if (gvPassengers.Columns["Flights"].Index == e.ColumnIndex)
            {
                ViewBookedFlightsForm viewForm = new ViewBookedFlightsForm(p);
                viewForm.Show();
                //dataBind();
            }

        }

        private void passengerDLBindingSource_CurrentChanged (object sender , EventArgs e)
        {

        }
        public void dataBind ()
        {
            gvPassengers.DataSource = null;
            gvPassengers.DataSource = PassengerDL.SortedPassengersList.Select(p => new
            {
                p.UserName ,
                p.Name ,
                p.Cnic ,
                p.ContactNum ,
                p.Gender ,
                p.PassportNo ,
                p.EMail ,
                p.Total ,

            }).ToList();
            gvPassengers.Refresh();
        }
    }
}
