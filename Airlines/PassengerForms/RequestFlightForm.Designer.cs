
namespace Airlines.PassengerForms
{
    partial class RequestFlightForm
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
            this.mskdtxtbxDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbxTripType = new System.Windows.Forms.ComboBox();
            this.lblTrip = new System.Windows.Forms.Label();
            this.lblDeptDate = new System.Windows.Forms.Label();
            this.lblArrCity = new System.Windows.Forms.Label();
            this.lblDeptCity = new System.Windows.Forms.Label();
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtArr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mskdtxtbxDate
            // 
            this.mskdtxtbxDate.Location = new System.Drawing.Point(290, 235);
            this.mskdtxtbxDate.Mask = "00/00/0000";
            this.mskdtxtbxDate.Name = "mskdtxtbxDate";
            this.mskdtxtbxDate.Size = new System.Drawing.Size(121, 20);
            this.mskdtxtbxDate.TabIndex = 82;
            this.mskdtxtbxDate.ValidatingType = typeof(System.DateTime);
            // 
            // cmbxTripType
            // 
            this.cmbxTripType.FormattingEnabled = true;
            this.cmbxTripType.Items.AddRange(new object[] {
            "One way",
            "Return"});
            this.cmbxTripType.Location = new System.Drawing.Point(290, 194);
            this.cmbxTripType.Name = "cmbxTripType";
            this.cmbxTripType.Size = new System.Drawing.Size(121, 21);
            this.cmbxTripType.TabIndex = 74;
            // 
            // lblTrip
            // 
            this.lblTrip.AutoSize = true;
            this.lblTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrip.Location = new System.Drawing.Point(211, 194);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(73, 17);
            this.lblTrip.TabIndex = 73;
            this.lblTrip.Text = "Trip Type:";
            // 
            // lblDeptDate
            // 
            this.lblDeptDate.AutoSize = true;
            this.lblDeptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptDate.Location = new System.Drawing.Point(195, 236);
            this.lblDeptDate.Name = "lblDeptDate";
            this.lblDeptDate.Size = new System.Drawing.Size(89, 17);
            this.lblDeptDate.TabIndex = 72;
            this.lblDeptDate.Text = "Depart Date:";
            // 
            // lblArrCity
            // 
            this.lblArrCity.AutoSize = true;
            this.lblArrCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrCity.Location = new System.Drawing.Point(205, 154);
            this.lblArrCity.Name = "lblArrCity";
            this.lblArrCity.Size = new System.Drawing.Size(79, 17);
            this.lblArrCity.TabIndex = 70;
            this.lblArrCity.Text = "Arrival City:";
            // 
            // lblDeptCity
            // 
            this.lblDeptCity.AutoSize = true;
            this.lblDeptCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptCity.Location = new System.Drawing.Point(181, 114);
            this.lblDeptCity.Name = "lblDeptCity";
            this.lblDeptCity.Size = new System.Drawing.Size(103, 17);
            this.lblDeptCity.TabIndex = 69;
            this.lblDeptCity.Text = "Departure City:";
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Trebuchet MS", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(267, 25);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(248, 40);
            this.lblMainHeading.TabIndex = 68;
            this.lblMainHeading.Text = "Request a Flight";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(644, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Request";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(102, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 27);
            this.btnBack.TabIndex = 66;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(290, 114);
            this.txtDept.Multiline = true;
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(121, 33);
            this.txtDept.TabIndex = 83;
            // 
            // txtArr
            // 
            this.txtArr.Location = new System.Drawing.Point(290, 153);
            this.txtArr.Multiline = true;
            this.txtArr.Name = "txtArr";
            this.txtArr.Size = new System.Drawing.Size(121, 35);
            this.txtArr.TabIndex = 84;
            // 
            // RequestFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtArr);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.mskdtxtbxDate);
            this.Controls.Add(this.cmbxTripType);
            this.Controls.Add(this.lblTrip);
            this.Controls.Add(this.lblDeptDate);
            this.Controls.Add(this.lblArrCity);
            this.Controls.Add(this.lblDeptCity);
            this.Controls.Add(this.lblMainHeading);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Name = "RequestFlightForm";
            this.Text = "RequestFlightForm";
            this.Load += new System.EventHandler(this.RequestFlightForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskdtxtbxDate;
        private System.Windows.Forms.ComboBox cmbxTripType;
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.Label lblDeptDate;
        private System.Windows.Forms.Label lblArrCity;
        private System.Windows.Forms.Label lblDeptCity;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtArr;
    }
}