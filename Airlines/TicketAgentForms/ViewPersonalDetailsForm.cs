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
    public partial class ViewPersonalDetailsForm : Form
    {
        public ViewPersonalDetailsForm ()
        {
            InitializeComponent();
        }

        private void ViewPersonalDetailsForm_Load (object sender , EventArgs e)
        {
            gvPassengers.DataSource = PassengerDL.PassengersList;
        }

        private void btnBack_Click (object sender , EventArgs e)
        {
            this.Close();
        }

        private void gvPassengers_CellContentClick (object sender , DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint (object sender , PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint (object sender , PaintEventArgs e)
        {

        }
    }
}
