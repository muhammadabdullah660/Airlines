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
    public partial class SignIn : Form
    {
        public SignIn ()
        {
            InitializeComponent();
        }
        private void clearData ()
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
        }
        private void SignIn_Load (object sender , EventArgs e)
        {
            //this.SetDesktopLocation(10 , 10);

        }

        private void maskedTextBox1_MaskInputRejected (object sender , MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected (object sender , MaskInputRejectedEventArgs e)
        {

        }

        private void btnNext_Click (object sender , EventArgs e)
        {
            string userName = txtUserName.Text;
            string userPassword = txtPassword.Text;
            string path = "MUser.txt";
            MUser user = new MUser(userName , userPassword);
            MUser userX = MUserDL.isValid(user);
            userX = new Passenger();
            Passenger p = new Passenger();
            p = (Passenger)userX;
            if (!userX.isAdmin())
            {
                PassengerMainForm pass = new PassengerMainForm(p);
                pass.Show();

            }
            else if (userX.isAdmin())
            {

            }
            else
            {
                MessageBox.Show("User is invalid");

            }
            clearData();
        }

        private void btnBack_Click (object sender , EventArgs e)
        {
            this.Close();
        }

        private void signUpToolStripMenuItem_Click (object sender , EventArgs e)
        {
            Form signUpForm = new SignUp();
            signUpForm.Show();
        }
    }
}
