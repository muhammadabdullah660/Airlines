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
using Airlines.FlightForms;
namespace Airlines
{
    public partial class TicketAgentMainForm : Form
    {
        private TicketAgent a;
        public TicketAgentMainForm (TicketAgent a)
        {
            InitializeComponent();
            this.a = a;
        }

        private void TicketAgentMainForm_Load (object sender , EventArgs e)
        {

        }

        private void flightStripMenuItem_Click (object sender , EventArgs e)
        {
            FlightViewForm newForm = new FlightViewForm();
            newForm.Show();
        }

        private void TicketAgentMainForm_InputLanguageChanged (object sender , InputLanguageChangedEventArgs e)
        {

        }

        private void personalToolStripMenuItem1_Click (object sender , EventArgs e)
        {

        }

        private void orderedPassengersToolStripMenuItem_Click (object sender , EventArgs e)
        {

        }
    }
}
