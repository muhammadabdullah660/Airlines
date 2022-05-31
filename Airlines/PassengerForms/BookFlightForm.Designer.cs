
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
            this.lblAdult = new System.Windows.Forms.Label();
            this.lblInfant = new System.Windows.Forms.Label();
            this.lblChild = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbxClass = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numUpDnAdult = new System.Windows.Forms.NumericUpDown();
            this.numUpDnInfant = new System.Windows.Forms.NumericUpDown();
            this.numUpDnChild = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnInfant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnChild)).BeginInit();
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
            this.cmbxDepartCity.Items.AddRange(new object[] {
            " "});
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
            this.cmbxTripType.SelectedIndexChanged += new System.EventHandler(this.cmbxTripType_SelectedIndexChanged);
            // 
            // cmbxArrCity
            // 
            this.cmbxArrCity.DisplayMember = "ArrCity";
            this.cmbxArrCity.FormattingEnabled = true;
            this.cmbxArrCity.Location = new System.Drawing.Point(290, 102);
            this.cmbxArrCity.Name = "cmbxArrCity";
            this.cmbxArrCity.Size = new System.Drawing.Size(121, 21);
            this.cmbxArrCity.TabIndex = 57;
            this.cmbxArrCity.TextChanged += new System.EventHandler(this.cmbxArrCity_SelectedIndexChanged);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(290, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 68;
            // 
            // numUpDnAdult
            // 
            this.numUpDnAdult.Location = new System.Drawing.Point(291, 224);
            this.numUpDnAdult.Name = "numUpDnAdult";
            this.numUpDnAdult.Size = new System.Drawing.Size(120, 20);
            this.numUpDnAdult.TabIndex = 69;
            // 
            // numUpDnInfant
            // 
            this.numUpDnInfant.Location = new System.Drawing.Point(291, 292);
            this.numUpDnInfant.Name = "numUpDnInfant";
            this.numUpDnInfant.Size = new System.Drawing.Size(120, 20);
            this.numUpDnInfant.TabIndex = 70;
            // 
            // numUpDnChild
            // 
            this.numUpDnChild.Location = new System.Drawing.Point(290, 260);
            this.numUpDnChild.Name = "numUpDnChild";
            this.numUpDnChild.Size = new System.Drawing.Size(120, 20);
            this.numUpDnChild.TabIndex = 71;
            // 
            // BookFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numUpDnChild);
            this.Controls.Add(this.numUpDnInfant);
            this.Controls.Add(this.numUpDnAdult);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cmbxClass);
            this.Controls.Add(this.lblChild);
            this.Controls.Add(this.lblInfant);
            this.Controls.Add(this.lblAdult);
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
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnInfant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnChild)).EndInit();
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
        private System.Windows.Forms.Label lblAdult;
        private System.Windows.Forms.Label lblInfant;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbxClass;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numUpDnAdult;
        private System.Windows.Forms.NumericUpDown numUpDnInfant;
        private System.Windows.Forms.NumericUpDown numUpDnChild;
    }
}