
namespace Airlines.PassengerForms
{
    partial class BookFlightForm
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
            this.lblTrip = new System.Windows.Forms.Label();
            this.lblDeptDate = new System.Windows.Forms.Label();
            this.cmbxDepartCity = new System.Windows.Forms.ComboBox();
            this.lblArrCity = new System.Windows.Forms.Label();
            this.lblDeptCity = new System.Windows.Forms.Label();
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbxTripType = new System.Windows.Forms.ComboBox();
            this.cmbxArrCity = new System.Windows.Forms.ComboBox();
            this.mskdtxtbxAdult = new System.Windows.Forms.MaskedTextBox();
            this.lblAdult = new System.Windows.Forms.Label();
            this.lblInfant = new System.Windows.Forms.Label();
            this.lblChild = new System.Windows.Forms.Label();
            this.mskdtxtbxInfant = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtbxChild = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtbxDate = new System.Windows.Forms.MaskedTextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbxClass = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTrip
            // 
            this.lblTrip.AutoSize = true;
            this.lblTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrip.Location = new System.Drawing.Point(211, 143);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(73, 17);
            this.lblTrip.TabIndex = 52;
            this.lblTrip.Text = "Trip Type:";
            // 
            // lblDeptDate
            // 
            this.lblDeptDate.AutoSize = true;
            this.lblDeptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptDate.Location = new System.Drawing.Point(195, 185);
            this.lblDeptDate.Name = "lblDeptDate";
            this.lblDeptDate.Size = new System.Drawing.Size(89, 17);
            this.lblDeptDate.TabIndex = 51;
            this.lblDeptDate.Text = "Depart Date:";
            // 
            // cmbxDepartCity
            // 
            this.cmbxDepartCity.DisplayMember = "DepartCity";
            this.cmbxDepartCity.FormattingEnabled = true;
            this.cmbxDepartCity.Location = new System.Drawing.Point(290, 62);
            this.cmbxDepartCity.Name = "cmbxDepartCity";
            this.cmbxDepartCity.Size = new System.Drawing.Size(121, 21);
            this.cmbxDepartCity.TabIndex = 46;
            this.cmbxDepartCity.TextChanged += new System.EventHandler(this.cmbxDepartCity_SelectedIndexChanged);
            // 
            // lblArrCity
            // 
            this.lblArrCity.AutoSize = true;
            this.lblArrCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrCity.Location = new System.Drawing.Point(205, 102);
            this.lblArrCity.Name = "lblArrCity";
            this.lblArrCity.Size = new System.Drawing.Size(79, 17);
            this.lblArrCity.TabIndex = 44;
            this.lblArrCity.Text = "Arrival City:";
            // 
            // lblDeptCity
            // 
            this.lblDeptCity.AutoSize = true;
            this.lblDeptCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptCity.Location = new System.Drawing.Point(181, 63);
            this.lblDeptCity.Name = "lblDeptCity";
            this.lblDeptCity.Size = new System.Drawing.Size(103, 17);
            this.lblDeptCity.TabIndex = 43;
            this.lblDeptCity.Text = "Departure City:";
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Trebuchet MS", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(283, 9);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(203, 40);
            this.lblMainHeading.TabIndex = 42;
            this.lblMainHeading.Text = "Book a Flight";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(647, 368);
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
            this.btnBack.Location = new System.Drawing.Point(105, 368);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 27);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbxTripType
            // 
            this.cmbxTripType.FormattingEnabled = true;
            this.cmbxTripType.Items.AddRange(new object[] {
            "One way",
            "Return"});
            this.cmbxTripType.Location = new System.Drawing.Point(290, 143);
            this.cmbxTripType.Name = "cmbxTripType";
            this.cmbxTripType.Size = new System.Drawing.Size(121, 21);
            this.cmbxTripType.TabIndex = 56;
            // 
            // cmbxArrCity
            // 
            this.cmbxArrCity.DisplayMember = "ArrCity";
            this.cmbxArrCity.FormattingEnabled = true;
            this.cmbxArrCity.Location = new System.Drawing.Point(290, 102);
            this.cmbxArrCity.Name = "cmbxArrCity";
            this.cmbxArrCity.Size = new System.Drawing.Size(121, 21);
            this.cmbxArrCity.TabIndex = 57;
            // 
            // mskdtxtbxAdult
            // 
            this.mskdtxtbxAdult.Location = new System.Drawing.Point(290, 223);
            this.mskdtxtbxAdult.Mask = "00000";
            this.mskdtxtbxAdult.Name = "mskdtxtbxAdult";
            this.mskdtxtbxAdult.Size = new System.Drawing.Size(121, 20);
            this.mskdtxtbxAdult.TabIndex = 59;
            this.mskdtxtbxAdult.ValidatingType = typeof(int);
            // 
            // lblAdult
            // 
            this.lblAdult.AutoSize = true;
            this.lblAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdult.Location = new System.Drawing.Point(240, 224);
            this.lblAdult.Name = "lblAdult";
            this.lblAdult.Size = new System.Drawing.Size(44, 17);
            this.lblAdult.TabIndex = 60;
            this.lblAdult.Text = "Adult:";
            // 
            // lblInfant
            // 
            this.lblInfant.AutoSize = true;
            this.lblInfant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfant.Location = new System.Drawing.Point(236, 295);
            this.lblInfant.Name = "lblInfant";
            this.lblInfant.Size = new System.Drawing.Size(47, 17);
            this.lblInfant.TabIndex = 61;
            this.lblInfant.Text = "Infant:";
            // 
            // lblChild
            // 
            this.lblChild.AutoSize = true;
            this.lblChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChild.Location = new System.Drawing.Point(240, 260);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(43, 17);
            this.lblChild.TabIndex = 62;
            this.lblChild.Text = "Child:";
            // 
            // mskdtxtbxInfant
            // 
            this.mskdtxtbxInfant.Location = new System.Drawing.Point(290, 294);
            this.mskdtxtbxInfant.Mask = "00000";
            this.mskdtxtbxInfant.Name = "mskdtxtbxInfant";
            this.mskdtxtbxInfant.Size = new System.Drawing.Size(121, 20);
            this.mskdtxtbxInfant.TabIndex = 63;
            this.mskdtxtbxInfant.ValidatingType = typeof(int);
            // 
            // mskdtxtbxChild
            // 
            this.mskdtxtbxChild.Location = new System.Drawing.Point(290, 260);
            this.mskdtxtbxChild.Mask = "00000";
            this.mskdtxtbxChild.Name = "mskdtxtbxChild";
            this.mskdtxtbxChild.Size = new System.Drawing.Size(121, 20);
            this.mskdtxtbxChild.TabIndex = 64;
            this.mskdtxtbxChild.ValidatingType = typeof(int);
            // 
            // mskdtxtbxDate
            // 
            this.mskdtxtbxDate.Location = new System.Drawing.Point(290, 184);
            this.mskdtxtbxDate.Mask = "00/00/0000";
            this.mskdtxtbxDate.Name = "mskdtxtbxDate";
            this.mskdtxtbxDate.Size = new System.Drawing.Size(121, 20);
            this.mskdtxtbxDate.TabIndex = 65;
            this.mskdtxtbxDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(198, 336);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(84, 17);
            this.lblClass.TabIndex = 67;
            this.lblClass.Text = "Flight Class:";
            // 
            // cmbxClass
            // 
            this.cmbxClass.FormattingEnabled = true;
            this.cmbxClass.Items.AddRange(new object[] {
            "Economy ",
            "Business"});
            this.cmbxClass.Location = new System.Drawing.Point(290, 332);
            this.cmbxClass.Name = "cmbxClass";
            this.cmbxClass.Size = new System.Drawing.Size(101, 21);
            this.cmbxClass.TabIndex = 66;
            // 
            // BookFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cmbxClass);
            this.Controls.Add(this.mskdtxtbxDate);
            this.Controls.Add(this.mskdtxtbxChild);
            this.Controls.Add(this.mskdtxtbxInfant);
            this.Controls.Add(this.lblChild);
            this.Controls.Add(this.lblInfant);
            this.Controls.Add(this.lblAdult);
            this.Controls.Add(this.mskdtxtbxAdult);
            this.Controls.Add(this.cmbxArrCity);
            this.Controls.Add(this.cmbxTripType);
            this.Controls.Add(this.lblTrip);
            this.Controls.Add(this.lblDeptDate);
            this.Controls.Add(this.cmbxDepartCity);
            this.Controls.Add(this.lblArrCity);
            this.Controls.Add(this.lblDeptCity);
            this.Controls.Add(this.lblMainHeading);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Name = "BookFlightForm";
            this.Text = "BookFlightForm";
            this.Load += new System.EventHandler(this.BookFlightForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.Label lblDeptDate;
        private System.Windows.Forms.ComboBox cmbxDepartCity;
        private System.Windows.Forms.Label lblArrCity;
        private System.Windows.Forms.Label lblDeptCity;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbxTripType;
        private System.Windows.Forms.ComboBox cmbxArrCity;
        private System.Windows.Forms.MaskedTextBox mskdtxtbxAdult;
        private System.Windows.Forms.Label lblAdult;
        private System.Windows.Forms.Label lblInfant;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.MaskedTextBox mskdtxtbxInfant;
        private System.Windows.Forms.MaskedTextBox mskdtxtbxChild;
        private System.Windows.Forms.MaskedTextBox mskdtxtbxDate;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbxClass;
    }
}