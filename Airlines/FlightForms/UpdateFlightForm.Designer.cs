
namespace Airlines.FlightForms
{
    partial class UpdateFlightForm
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
            this.mskdtxtbxSeats = new System.Windows.Forms.MaskedTextBox();
            this.lblSeats = new System.Windows.Forms.Label();
            this.mskdtxtbxDate = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtbxTime = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtbxPrice = new System.Windows.Forms.MaskedTextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtArr = new System.Windows.Forms.TextBox();
            this.lblDeptDate = new System.Windows.Forms.Label();
            this.lblDeptTime = new System.Windows.Forms.Label();
            this.lblTrip = new System.Windows.Forms.Label();
            this.cmbxTrip = new System.Windows.Forms.ComboBox();
            this.lblArrCity = new System.Windows.Forms.Label();
            this.lblDeptCity = new System.Windows.Forms.Label();
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskdtxtbxSeats
            // 
            this.mskdtxtbxSeats.Location = new System.Drawing.Point(254, 347);
            this.mskdtxtbxSeats.Mask = "0000";
            this.mskdtxtbxSeats.Name = "mskdtxtbxSeats";
            this.mskdtxtbxSeats.Size = new System.Drawing.Size(101, 20);
            this.mskdtxtbxSeats.TabIndex = 80;
            this.mskdtxtbxSeats.ValidatingType = typeof(int);
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.Location = new System.Drawing.Point(197, 347);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(48, 17);
            this.lblSeats.TabIndex = 79;
            this.lblSeats.Text = "Seats:";
            // 
            // mskdtxtbxDate
            // 
            this.mskdtxtbxDate.Location = new System.Drawing.Point(255, 272);
            this.mskdtxtbxDate.Mask = "00/00/0000";
            this.mskdtxtbxDate.Name = "mskdtxtbxDate";
            this.mskdtxtbxDate.Size = new System.Drawing.Size(100, 20);
            this.mskdtxtbxDate.TabIndex = 78;
            this.mskdtxtbxDate.ValidatingType = typeof(System.DateTime);
            // 
            // mskdtxtbxTime
            // 
            this.mskdtxtbxTime.Location = new System.Drawing.Point(254, 228);
            this.mskdtxtbxTime.Mask = "90:00";
            this.mskdtxtbxTime.Name = "mskdtxtbxTime";
            this.mskdtxtbxTime.Size = new System.Drawing.Size(100, 20);
            this.mskdtxtbxTime.TabIndex = 77;
            this.mskdtxtbxTime.ValidatingType = typeof(System.DateTime);
            // 
            // mskdtxtbxPrice
            // 
            this.mskdtxtbxPrice.Location = new System.Drawing.Point(254, 185);
            this.mskdtxtbxPrice.Mask = "00000000";
            this.mskdtxtbxPrice.Name = "mskdtxtbxPrice";
            this.mskdtxtbxPrice.Size = new System.Drawing.Size(101, 20);
            this.mskdtxtbxPrice.TabIndex = 76;
            this.mskdtxtbxPrice.ValidatingType = typeof(int);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(197, 185);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 75;
            this.lblPrice.Text = "Price:";
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(254, 91);
            this.txtDept.Multiline = true;
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(281, 35);
            this.txtDept.TabIndex = 74;
            // 
            // txtArr
            // 
            this.txtArr.Location = new System.Drawing.Point(254, 131);
            this.txtArr.Multiline = true;
            this.txtArr.Name = "txtArr";
            this.txtArr.Size = new System.Drawing.Size(281, 35);
            this.txtArr.TabIndex = 73;
            // 
            // lblDeptDate
            // 
            this.lblDeptDate.AutoSize = true;
            this.lblDeptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptDate.Location = new System.Drawing.Point(138, 272);
            this.lblDeptDate.Name = "lblDeptDate";
            this.lblDeptDate.Size = new System.Drawing.Size(110, 17);
            this.lblDeptDate.TabIndex = 72;
            this.lblDeptDate.Text = "Departure Date:";
            // 
            // lblDeptTime
            // 
            this.lblDeptTime.AutoSize = true;
            this.lblDeptTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptTime.Location = new System.Drawing.Point(137, 231);
            this.lblDeptTime.Name = "lblDeptTime";
            this.lblDeptTime.Size = new System.Drawing.Size(111, 17);
            this.lblDeptTime.TabIndex = 71;
            this.lblDeptTime.Text = "Departure Time:";
            // 
            // lblTrip
            // 
            this.lblTrip.AutoSize = true;
            this.lblTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrip.Location = new System.Drawing.Point(168, 312);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(73, 17);
            this.lblTrip.TabIndex = 70;
            this.lblTrip.Text = "Trip Type:";
            // 
            // cmbxTrip
            // 
            this.cmbxTrip.FormattingEnabled = true;
            this.cmbxTrip.Items.AddRange(new object[] {
            "One Way",
            "Return"});
            this.cmbxTrip.Location = new System.Drawing.Point(254, 308);
            this.cmbxTrip.Name = "cmbxTrip";
            this.cmbxTrip.Size = new System.Drawing.Size(101, 21);
            this.cmbxTrip.TabIndex = 69;
            // 
            // lblArrCity
            // 
            this.lblArrCity.AutoSize = true;
            this.lblArrCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrCity.Location = new System.Drawing.Point(162, 149);
            this.lblArrCity.Name = "lblArrCity";
            this.lblArrCity.Size = new System.Drawing.Size(79, 17);
            this.lblArrCity.TabIndex = 68;
            this.lblArrCity.Text = "Arrival City:";
            // 
            // lblDeptCity
            // 
            this.lblDeptCity.AutoSize = true;
            this.lblDeptCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptCity.Location = new System.Drawing.Point(145, 109);
            this.lblDeptCity.Name = "lblDeptCity";
            this.lblDeptCity.Size = new System.Drawing.Size(103, 17);
            this.lblDeptCity.TabIndex = 67;
            this.lblDeptCity.Text = "Departure City:";
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Trebuchet MS", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(247, 9);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(261, 40);
            this.lblMainHeading.TabIndex = 66;
            this.lblMainHeading.Text = "Add a New Flight";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(662, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(108, 379);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 27);
            this.btnBack.TabIndex = 64;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UpdateFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskdtxtbxSeats);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.mskdtxtbxDate);
            this.Controls.Add(this.mskdtxtbxTime);
            this.Controls.Add(this.mskdtxtbxPrice);
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
            this.Name = "UpdateFlightForm";
            this.Text = "UpdateFlightForm";
            this.Load += new System.EventHandler(this.UpdateFlightForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskdtxtbxSeats;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.MaskedTextBox mskdtxtbxDate;
        private System.Windows.Forms.MaskedTextBox mskdtxtbxTime;
        private System.Windows.Forms.MaskedTextBox mskdtxtbxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtArr;
        private System.Windows.Forms.Label lblDeptDate;
        private System.Windows.Forms.Label lblDeptTime;
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.ComboBox cmbxTrip;
        private System.Windows.Forms.Label lblArrCity;
        private System.Windows.Forms.Label lblDeptCity;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}