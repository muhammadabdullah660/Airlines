using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
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
            //ChangeLanguage("es-ES");

        }

        private void maskedTextBox1_MaskInputRejected (object sender , MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected (object sender , MaskInputRejectedEventArgs e)
        {

        }
        /* private void ChangeLanguage (string lang)
         {
             foreach (Control c in this.Controls)
             {
                 ComponentResourceManager resources = new ComponentResourceManager(typeof(SignIn));
                 resources.ApplyResources(c , c.Name , new CultureInfo(lang));
             }
         }*/
        private void btnNext_Click (object sender , EventArgs e)
        {

            string userName = txtUserName.Text;
            string userPassword = txtPassword.Text;
            string path = "MUser.txt";
            MUser user = new MUser(userName , userPassword);
            MUser userX = MUserDL.isValid(user);
            if (userX != null)
            {
                //MessageBox.Show(userX.UserName);
                if (!userX.isAdmin())
                {
                    //Passenger p = PassengerDL.isValidPassenger(userX);
                    PassengerMainForm pass = new PassengerMainForm(PassengerDL.isValidPassenger(userX));
                    pass.Show();

                }
                else if (userX.isAdmin())
                {
                    userX = new TicketAgent();
                    TicketAgent a;
                    a = (TicketAgent)userX;
                    TicketAgentMainForm adm = new TicketAgentMainForm(a);
                    adm.Show();
                }
                else
                {
                    MessageBox.Show("User is invalid");

                }
            }
            clearData();
        }

        private void btnBack_Click (object sender , EventArgs e)
        {
            this.Close();
        }

        private void signUpToolStripMenuItem_Click (object sender , EventArgs e)
        {
            this.Close();
            Form signUpForm = new SignUp();
            signUpForm.Show();
        }

        private void menuStrpMain_ItemClicked (object sender , ToolStripItemClickedEventArgs e)
        {

        }
    }
}
