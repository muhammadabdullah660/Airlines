
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.lblDeptCity = new System.Windows.Forms.Label();
            this.lblArrCity = new System.Windows.Forms.Label();
            this.txtArr = new System.Windows.Forms.TextBox();
            this.numUpDnPrice = new System.Windows.Forms.NumericUpDown();
            this.lblDeptTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.mskdtxtbxTime = new System.Windows.Forms.MaskedTextBox();
            this.lblDeptDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblTrip = new System.Windows.Forms.Label();
            this.cmbxTrip = new System.Windows.Forms.ComboBox();
            this.numUpDnSeats = new System.Windows.Forms.NumericUpDown();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbxClass = new System.Windows.Forms.ComboBox();
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnPrice)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnSeats)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(710, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 99;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 313);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 27);
            this.btnBack.TabIndex = 98;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(403, 3);
            this.txtDept.Multiline = true;
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(281, 32);
            this.txtDept.TabIndex = 81;
            // 
            // lblDeptCity
            // 
            this.lblDeptCity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDeptCity.AutoSize = true;
            this.lblDeptCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptCity.Location = new System.Drawing.Point(294, 10);
            this.lblDeptCity.Name = "lblDeptCity";
            this.lblDeptCity.Size = new System.Drawing.Size(103, 17);
            this.lblDeptCity.TabIndex = 80;
            this.lblDeptCity.Text = "Departure City:";
            // 
            // lblArrCity
            // 
            this.lblArrCity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblArrCity.AutoSize = true;
            this.lblArrCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrCity.Location = new System.Drawing.Point(318, 48);
            this.lblArrCity.Name = "lblArrCity";
            this.lblArrCity.Size = new System.Drawing.Size(79, 17);
            this.lblArrCity.TabIndex = 82;
            this.lblArrCity.Text = "Arrival City:";
            // 
            // txtArr
            // 
            this.txtArr.Location = new System.Drawing.Point(403, 41);
            this.txtArr.Multiline = true;
            this.txtArr.Name = "txtArr";
            this.txtArr.Size = new System.Drawing.Size(281, 32);
            this.txtArr.TabIndex = 83;
            // 
            // numUpDnPrice
            // 
            this.numUpDnPrice.Location = new System.Drawing.Point(403, 79);
            this.numUpDnPrice.Name = "numUpDnPrice";
            this.numUpDnPrice.Size = new System.Drawing.Size(120, 20);
            this.numUpDnPrice.TabIndex = 87;
            // 
            // lblDeptTime
            // 
            this.lblDeptTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeptTime.AutoSize = true;
            this.lblDeptTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptTime.Location = new System.Drawing.Point(286, 114);
            this.lblDeptTime.Name = "lblDeptTime";
            this.lblDeptTime.Size = new System.Drawing.Size(111, 17);
            this.lblDeptTime.TabIndex = 88;
            this.lblDeptTime.Text = "Departure Time:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtDept, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDeptCity, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblArrCity, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtArr, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPrice, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.numUpDnPrice, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblDeptTime, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.mskdtxtbxTime, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblDeptDate, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblTrip, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.cmbxTrip, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.numUpDnSeats, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblSeats, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblClass, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.cmbxClass, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.btnBack, 0, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 350);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(353, 76);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 84;
            this.lblPrice.Text = "Price:";
            // 
            // mskdtxtbxTime
            // 
            this.mskdtxtbxTime.Location = new System.Drawing.Point(403, 117);
            this.mskdtxtbxTime.Mask = "90:00";
            this.mskdtxtbxTime.Name = "mskdtxtbxTime";
            this.mskdtxtbxTime.Size = new System.Drawing.Size(100, 20);
            this.mskdtxtbxTime.TabIndex = 89;
            this.mskdtxtbxTime.ValidatingType = typeof(System.DateTime);
            // 
            // lblDeptDate
            // 
            this.lblDeptDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeptDate.AutoSize = true;
            this.lblDeptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptDate.Location = new System.Drawing.Point(287, 152);
            this.lblDeptDate.Name = "lblDeptDate";
            this.lblDeptDate.Size = new System.Drawing.Size(110, 17);
            this.lblDeptDate.TabIndex = 90;
            this.lblDeptDate.Text = "Departure Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(403, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 91;
            // 
            // lblTrip
            // 
            this.lblTrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrip.AutoSize = true;
            this.lblTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrip.Location = new System.Drawing.Point(324, 190);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(73, 17);
            this.lblTrip.TabIndex = 92;
            this.lblTrip.Text = "Trip Type:";
            // 
            // cmbxTrip
            // 
            this.cmbxTrip.FormattingEnabled = true;
            this.cmbxTrip.Items.AddRange(new object[] {
            "One Way",
            "Return"});
            this.cmbxTrip.Location = new System.Drawing.Point(403, 193);
            this.cmbxTrip.Name = "cmbxTrip";
            this.cmbxTrip.Size = new System.Drawing.Size(101, 21);
            this.cmbxTrip.TabIndex = 93;
            // 
            // numUpDnSeats
            // 
            this.numUpDnSeats.Location = new System.Drawing.Point(403, 231);
            this.numUpDnSeats.Name = "numUpDnSeats";
            this.numUpDnSeats.Size = new System.Drawing.Size(120, 20);
            this.numUpDnSeats.TabIndex = 95;
            // 
            // lblSeats
            // 
            this.lblSeats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeats.AutoSize = true;
            this.lblSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.Location = new System.Drawing.Point(349, 228);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(48, 17);
            this.lblSeats.TabIndex = 94;
            this.lblSeats.Text = "Seats:";
            // 
            // lblClass
            // 
            this.lblClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(313, 266);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(84, 17);
            this.lblClass.TabIndex = 97;
            this.lblClass.Text = "Flight Class:";
            // 
            // cmbxClass
            // 
            this.cmbxClass.FormattingEnabled = true;
            this.cmbxClass.Items.AddRange(new object[] {
            "Economy ",
            "Business",
            "All"});
            this.cmbxClass.Location = new System.Drawing.Point(403, 269);
            this.cmbxClass.Name = "cmbxClass";
            this.cmbxClass.Size = new System.Drawing.Size(101, 21);
            this.cmbxClass.TabIndex = 96;
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMainHeading, 2);
            this.lblMainHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMainHeading.Font = new System.Drawing.Font("Trebuchet MS", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(3, 0);
            this.lblMainHeading.Name = "lblMainHeading";
            this.tableLayoutPanel1.SetRowSpan(this.lblMainHeading, 2);
            this.lblMainHeading.Size = new System.Drawing.Size(794, 100);
            this.lblMainHeading.TabIndex = 72;
            this.lblMainHeading.Text = "Update Flight Details";
            this.lblMainHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblMainHeading, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // UpdateFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UpdateFlightForm";
            this.Text = "UpdateFlightForm";
            this.Load += new System.EventHandler(this.UpdateFlightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnPrice)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnSeats)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label lblDeptCity;
        private System.Windows.Forms.Label lblArrCity;
        private System.Windows.Forms.TextBox txtArr;
        private System.Windows.Forms.NumericUpDown numUpDnPrice;
        private System.Windows.Forms.Label lblDeptTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.MaskedTextBox mskdtxtbxTime;
        private System.Windows.Forms.Label lblDeptDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.ComboBox cmbxTrip;
        private System.Windows.Forms.NumericUpDown numUpDnSeats;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbxClass;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}