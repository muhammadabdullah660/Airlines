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

        }
    }
}
