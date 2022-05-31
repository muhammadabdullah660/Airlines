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
    public partial class UpdatePersonalDetailsForm : Form
    {
        private Passenger p;
        public UpdatePersonalDetailsForm (Passenger p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void UpdatePersonalDetailsForm_Load (object sender , EventArgs e)
        {
            txtName.Text = p.Name;
            mskdtxtbxCnic.Text = p.Cnic;
            txtPassport.Text = p.PassportNo;
            mskdtxtbxContact.Text = p.ContactNum;
            cmbxGender.Text = p.Gender;
            txtEmail.Text = p.EMail;
        }

        private void btnSave_Click (object sender , EventArgs e)
        {
            p.Name = txtName.Text;
            p.Cnic = mskdtxtbxCnic.Text;
            p.PassportNo = txtPassport.Text;
            p.ContactNum = mskdtxtbxContact.Text;
            p.Gender = cmbxGender.Text;
            p.EMail = txtEmail.Text;
            MessageBox.Show("Details Updated");
        }

        private void btnBack_Click (object sender , EventArgs e)
        {
            this.Close();
        }
    }
}
