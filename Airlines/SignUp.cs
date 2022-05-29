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
            comboBox1.Text = "";
            txtUserName.Text = "";
        }
        private void SignUp_Load (object sender , EventArgs e)
        {

        }




        private void btnNext_Click (object sender , EventArgs e)
        {
            string userName = txtUserName.Text;
            string userPassword = txtPassword.Text;
            string userRole = comboBox1.Text;
            string path = "MUser.txt";
            MUser user = new MUser(userName , userPassword , userRole);
            MUserDL.addUserIntoList(user);
            MUserDL.storeIntoFile(path , user);
            MessageBox.Show("Account Created Successfully. You can now Sign In");
            clearData();
        }

        private void btnBack_Click (object sender , EventArgs e)
        {
            this.Close();
        }

        private void signInToolStripMenuItem_Click (object sender , EventArgs e)
        {
            Form signInForm = new SignIn();
            signInForm.Show();
        }
    }
}
