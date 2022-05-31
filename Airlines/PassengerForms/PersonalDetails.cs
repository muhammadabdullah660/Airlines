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

namespace Airlines.PassengerForms
{
    public partial class PersonalDetails : Form
    {
        private Passenger p;
        public PersonalDetails (Passenger p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void btnSave_Click (object sender , EventArgs e)
        {
            p.Name = txtName.Text;
            p.Cnic = mskdtxtbxCnic.Text;
            p.PassportNo = txtPassport.Text;
            p.ContactNum = mskdtxtbxContact.Text;
            p.Gender = cmbxGender.Text;
            p.EMail = txtEmail.Text;
            MessageBox.Show("Details Saved");
        }

        private void txtName_TextChanged (object sender , EventArgs e)
        {

        }

        private void btnBack_Click (object sender , EventArgs e)
        {
            this.Close();
        }

        private void PersonalDetails_Load (object sender , EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint (object sender , PaintEventArgs e)
        {

        }
    }
}
