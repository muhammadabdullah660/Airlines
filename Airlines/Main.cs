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

namespace Airlines
{
    public partial class Main : Form
    {
        public Main ()
        {
            InitializeComponent();
            //this.SetDesktopLocation(10 , 10);
            string path = "MUser.txt";
            string path1 = "Flight.txt";
            if (MUserDL.loadFromFile(path) && FlightDL.loadFromFile(path1))
            {
                MessageBox.Show("Data Successfully Loaded");
            }
            else
            {
                MessageBox.Show("Data Loading Failed");
            }
        }

        private void Main_Load (object sender , EventArgs e)
        {

        }

        private void announcementsToolStripMenuItem_Click (object sender , EventArgs e)
        {

        }

        private void signInToolStripMenuItem_Click (object sender , EventArgs e)
        {
            Form signInForm = new SignIn();
            signInForm.Show();
        }

        private void signUpToolStripMenuItem_Click (object sender , EventArgs e)
        {
            Form signUpForm = new SignUp();
            signUpForm.Show();
        }

        private void tableLayoutPanel2_Paint (object sender , PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint (object sender , PaintEventArgs e)
        {

        }

        private void menuStrpMain_ItemClicked (object sender , ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint (object sender , PaintEventArgs e)
        {

        }
    }
}
