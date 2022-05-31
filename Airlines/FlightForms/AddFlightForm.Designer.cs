
namespace Airlines.FlightForms
{
    partial class AddFlightForm
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
            this.lblDeptDate = new System.Windows.Forms.Label();
            this.lblDeptTime = new System.Windows.Forms.Label();
            this.lblTrip = new System.Windows.Forms.Label();
            this.cmbxTrip = new System.Windows.Forms.ComboBox();
            this.lblArrCity = new System.Windows.Forms.Label();
            this.lblDeptCity = new System.Windows.Forms.Label();
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtArr = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.mskdtxtbxTime = new System.Windows.Forms.MaskedTextBox();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbxClass = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numUpDnPrice = new System.Windows.Forms.NumericUpDown();
            this.numUpDnSeats = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeptDate
            // 
            this.lblDeptDate.AutoSize = true;
            this.lblDeptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptDate.Location = new System.Drawing.Point(110, 257);
            this.lblDeptDate.Name = "lblDeptDate";
            this.lblDeptDate.Size = new System.Drawing.Size(110, 17);
            this.lblDeptDate.TabIndex = 54;
            this.lblDeptDate.Text = "Departure Date:";
            // 
            // lblDeptTime
            // 
            this.lblDeptTime.AutoSize = true;
            this.lblDeptTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptTime.Location = new System.Drawing.Point(109, 216);
            this.lblDeptTime.Name = "lblDeptTime";
            this.lblDeptTime.Size = new System.Drawing.Size(111, 17);
            this.lblDeptTime.TabIndex = 52;
            this.lblDeptTime.Text = "Departure Time:";
            // 
            // lblTrip
            // 
            this.lblTrip.AutoSize = true;
            this.lblTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrip.Location = new System.Drawing.Point(140, 297);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(73, 17);
            this.lblTrip.TabIndex = 51;
            this.lblTrip.Text = "Trip Type:";
            // 
            // cmbxTrip
            // 
            this.cmbxTrip.FormattingEnabled = true;
            this.cmbxTrip.Items.AddRange(new object[] {
            "One Way",
            "Return"});
            this.cmbxTrip.Location = new System.Drawing.Point(226, 293);
            this.cmbxTrip.Name = "cmbxTrip";
            this.cmbxTrip.Size = new System.Drawing.Size(101, 21);
            this.cmbxTrip.TabIndex = 46;
            // 
            // lblArrCity
            // 
            this.lblArrCity.AutoSize = true;
            this.lblArrCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrCity.Location = new System.Drawing.Point(134, 134);
            this.lblArrCity.Name = "lblArrCity";
            this.lblArrCity.Size = new System.Drawing.Size(79, 17);
            this.lblArrCity.TabIndex = 44;
            this.lblArrCity.Text = "Arrival City:";
            // 
            // lblDeptCity
            // 
            this.lblDeptCity.AutoSize = true;
            this.lblDeptCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptCity.Location = new System.Drawing.Point(117, 94);
            this.lblDeptCity.Name = "lblDeptCity";
            this.lblDeptCity.Size = new System.Drawing.Size(103, 17);
            this.lblDeptCity.TabIndex = 43;
            this.lblDeptCity.Text = "Departure City:";
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Trebuchet MS", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(219, 21);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(261, 40);
            this.lblMainHeading.TabIndex = 42;
            this.lblMainHeading.Text = "Add a New Flight";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(637, 411);
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
            this.btnBack.Location = new System.Drawing.Point(81, 411);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 27);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtArr
            // 
            this.txtArr.Location = new System.Drawing.Point(226, 116);
            this.txtArr.Multiline = true;
            this.txtArr.Name = "txtArr";
            this.txtArr.Size = new System.Drawing.Size(281, 35);
            this.txtArr.TabIndex = 56;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(226, 75);
            this.txtDept.Multiline = true;
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(281, 35);
            this.txtDept.TabIndex = 57;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(169, 170);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 58;
            this.lblPrice.Text = "Price:";
            // 
            // mskdtxtbxTime
            // 
            this.mskdtxtbxTime.Location = new System.Drawing.Point(226, 213);
            this.mskdtxtbxTime.Mask = "90:00";
            this.mskdtxtbxTime.Name = "mskdtxtbxTime";
            this.mskdtxtbxTime.Size = new System.Drawing.Size(100, 20);
            this.mskdtxtbxTime.TabIndex = 60;
            this.mskdtxtbxTime.ValidatingType = typeof(System.DateTime);
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.Location = new System.Drawing.Point(169, 332);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(48, 17);
            this.lblSeats.TabIndex = 62;
            this.lblSeats.Text = "Seats:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(133, 372);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(84, 17);
            this.lblClass.TabIndex = 65;
            this.lblClass.Text = "Flight Class:";
            // 
            // cmbxClass
            // 
            this.cmbxClass.FormattingEnabled = true;
            this.cmbxClass.Items.AddRange(new object[] {
            "Economy ",
            "Business",
            "All"});
            this.cmbxClass.Location = new System.Drawing.Point(225, 368);
            this.cmbxClass.Name = "cmbxClass";
            this.cmbxClass.Size = new System.Drawing.Size(101, 21);
            this.cmbxClass.TabIndex = 64;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 257);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 66;
            // 
            // numUpDnPrice
            // 
            this.numUpDnPrice.Location = new System.Drawing.Point(226, 170);
            this.numUpDnPrice.Name = "numUpDnPrice";
            this.numUpDnPrice.Size = new System.Drawing.Size(120, 20);
            this.numUpDnPrice.TabIndex = 67;
            // 
            // numUpDnSeats
            // 
            this.numUpDnSeats.Location = new System.Drawing.Point(226, 332);
            this.numUpDnSeats.Name = "numUpDnSeats";
            this.numUpDnSeats.Size = new System.Drawing.Size(120, 20);
            this.numUpDnSeats.TabIndex = 68;
            // 
            // AddFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numUpDnSeats);
            this.Controls.Add(this.numUpDnPrice);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cmbxClass);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.mskdtxtbxTime);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtArr);
            this.Controls.Add(this.lblDeptDate);
            this.Controls.Add(this.lblDeptTime);
            this.Controls.Add(this.lblTrip);
            this.Controls.Add(this.cmbxTrip);
            this.Controls.Add(this.lblArrCity);
            this.Controls.Add(this.lblDeptCity);
            this.Controls.Add(this.lblMainHeading);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Name = "AddFlightForm";
            this.Text = "AddFlightForm";
            this.Load += new System.EventHandler(this.AddFlightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeptDate;
        private System.Windows.Forms.Label lblDeptTime;
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.ComboBox cmbxTrip;
        private System.Windows.Forms.Label lblArrCity;
        private System.Windows.Forms.Label lblDeptCity;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtArr;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.MaskedTextBox mskdtxtbxTime;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbxClass;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numUpDnPrice;
        private System.Windows.Forms.NumericUpDown numUpDnSeats;
    }
}