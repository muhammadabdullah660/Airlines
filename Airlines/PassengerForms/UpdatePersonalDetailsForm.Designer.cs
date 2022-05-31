
namespace Airlines.PassengerForms
{
    partial class UpdatePersonalDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbxGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPassport = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.mskdtxtbxContact = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtbxCnic = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(188, 179);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 17);
            this.lblEmail.TabIndex = 51;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(252, 120);
            this.txtPassport.Multiline = true;
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(281, 35);
            this.txtPassport.TabIndex = 50;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(252, 161);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 35);
            this.txtEmail.TabIndex = 49;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(252, 80);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 35);
            this.txtName.TabIndex = 47;
            // 
            // cmbxGender
            // 
            this.cmbxGender.FormattingEnabled = true;
            this.cmbxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Rather Not Say"});
            this.cmbxGender.Location = new System.Drawing.Point(252, 297);
            this.cmbxGender.Name = "cmbxGender";
            this.cmbxGender.Size = new System.Drawing.Size(121, 21);
            this.cmbxGender.TabIndex = 46;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(174, 301);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 45;
            this.lblGender.Text = "Gender:";
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassport.Location = new System.Drawing.Point(149, 138);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(90, 17);
            this.lblPassport.TabIndex = 44;
            this.lblPassport.Text = "Passport No:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(185, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "Name:";
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Trebuchet MS", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(201, 9);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(399, 40);
            this.lblMainHeading.TabIndex = 42;
            this.lblMainHeading.Text = "Enter Your Personal Details";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(625, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(106, 368);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 27);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // mskdtxtbxContact
            // 
            this.mskdtxtbxContact.Location = new System.Drawing.Point(252, 256);
            this.mskdtxtbxContact.Mask = "0000-0000000";
            this.mskdtxtbxContact.Name = "mskdtxtbxContact";
            this.mskdtxtbxContact.Size = new System.Drawing.Size(281, 20);
            this.mskdtxtbxContact.TabIndex = 58;
            // 
            // mskdtxtbxCnic
            // 
            this.mskdtxtbxCnic.Location = new System.Drawing.Point(252, 216);
            this.mskdtxtbxCnic.Mask = "00000-0000000-0";
            this.mskdtxtbxCnic.Name = "mskdtxtbxCnic";
            this.mskdtxtbxCnic.Size = new System.Drawing.Size(281, 20);
            this.mskdtxtbxCnic.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Contact No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "CNIC No:";
            // 
            // UpdatePersonalDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskdtxtbxContact);
            this.Controls.Add(this.mskdtxtbxCnic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbxGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPassport);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMainHeading);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Name = "UpdatePersonalDetailsForm";
            this.Text = "UpdatePersonalDetailsForm";
            this.Load += new System.EventHandler(this.UpdatePersonalDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbxGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MaskedTextBox mskdtxtbxContact;
        private System.Windows.Forms.MaskedTextBox mskdtxtbxCnic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}