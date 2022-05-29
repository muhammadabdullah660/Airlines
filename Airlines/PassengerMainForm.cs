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

        }

        private void myFlightsToolStripMenuItem_Click (object sender , EventArgs e)
        {

        }

        private void cancelToolStripMenuItem_Click (object sender , EventArgs e)
        {

        }
    }
}
