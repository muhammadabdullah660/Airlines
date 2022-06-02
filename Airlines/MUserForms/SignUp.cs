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
    public partial class SignUp : Form
    {
        public SignUp ()
        {
            InitializeComponent();
        }

        private void clearData ()
        {
            txtPassword.Text = "";
            cmbxRole.Text = "";
            txtUserName.Text = "";
        }
        private void SignUp_Load (object sender , EventArgs e)
        {

        }
        private void btnNext_Click (object sender , EventArgs e)
        {

            string userName = txtUserName.Text;
            string userPassword = txtPassword.Text;
            string userRole = cmbxRole.Text;
            string path = "MUser.txt";
            string path1 = "Passenger.txt";
            if (userName != "" && userPassword != "")
            {
                MUser user = new MUser(userName , userPassword , userRole);
                MUserDL.addUserIntoList(user);
                MUserDL.storeIntoFile(path , user);
                if (!user.isAdmin())
                {
                    Passenger p = new Passenger();
                    p.UserName = user.UserName;
                    p.UserRole = user.UserRole;
                    p.UserPassword = user.UserPassword;
                    // MessageBox.Show(p.UserName);
                    PassengerDL.addPassengerIntoList(p);
                    PassengerDL.storeIntoFile(path1 , p);

                }
                /*  else
                  {
                      userX = new TicketAgent();
                      TicketAgent a;
                      a = (TicketAgent)userX;
                  }*/
                MessageBox.Show("Account Created Successfully. You can now Sign In");
                clearData();
            }
            else
            {
                MessageBox.Show("Input must not be empty");
            }

        }

        private void btnBack_Click (object sender , EventArgs e)
        {
            this.Close();
        }

        private void signInToolStripMenuItem_Click (object sender , EventArgs e)
        {
            this.Close();
            Form signInForm = new SignIn();
            signInForm.Show();
        }

        private void txtUserName_Validating (object sender , CancelEventArgs e)
        {
            if (txtUserName.Text == String.Empty)
            {
                MessageBox.Show("Enter a Valid Name");
            }
        }

        private void comboBox1_SelectedIndexChanged (object sender , EventArgs e)
        {

        }
    }
}
