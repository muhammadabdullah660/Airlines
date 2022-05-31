
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.lblDeptCity = new System.Windows.Forms.Label();
            this.cmbxDepartCity = new System.Windows.Forms.ComboBox();
            this.lblArrCity = new System.Windows.Forms.Label();
            this.cmbxArrCity = new System.Windows.Forms.ComboBox();
            this.lblTrip = new System.Windows.Forms.Label();
            this.cmbxTripType = new System.Windows.Forms.ComboBox();
            this.lblDeptDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblAdult = new System.Windows.Forms.Label();
            this.numUpDnAdult = new System.Windows.Forms.NumericUpDown();
            this.lblChild = new System.Windows.Forms.Label();
            this.numUpDnChild = new System.Windows.Forms.NumericUpDown();
            this.lblInfant = new System.Windows.Forms.Label();
            this.numUpDnInfant = new System.Windows.Forms.NumericUpDown();
            this.cmbxClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnInfant)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblDeptCity, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbxDepartCity, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblArrCity, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbxArrCity, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTrip, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbxTripType, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblDeptDate, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblAdult, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.numUpDnAdult, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblChild, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.numUpDnChild, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblInfant, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.numUpDnInfant, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.cmbxClass, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblClass, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnBack, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 0, 8);
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 350);
            this.tableLayoutPanel2.TabIndex = 1;
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
            this.lblMainHeading.TabIndex = 75;
            this.lblMainHeading.Text = "Book a Flight";
            this.lblMainHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeptCity
            // 
            this.lblDeptCity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDeptCity.AutoSize = true;
            this.lblDeptCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptCity.Location = new System.Drawing.Point(294, 10);
            this.lblDeptCity.Name = "lblDeptCity";
            this.lblDeptCity.Size = new System.Drawing.Size(103, 17);
            this.lblDeptCity.TabIndex = 76;
            this.lblDeptCity.Text = "Departure City:";
            // 
            // cmbxDepartCity
            // 
            this.cmbxDepartCity.DisplayMember = "DepartCity";
            this.cmbxDepartCity.FormattingEnabled = true;
            this.cmbxDepartCity.Items.AddRange(new object[] {
            " "});
            this.cmbxDepartCity.Location = new System.Drawing.Point(403, 3);
            this.cmbxDepartCity.Name = "cmbxDepartCity";
            this.cmbxDepartCity.Size = new System.Drawing.Size(121, 21);
            this.cmbxDepartCity.TabIndex = 78;
            // 
            // lblArrCity
            // 
            this.lblArrCity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblArrCity.AutoSize = true;
            this.lblArrCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrCity.Location = new System.Drawing.Point(318, 48);
            this.lblArrCity.Name = "lblArrCity";
            this.lblArrCity.Size = new System.Drawing.Size(79, 17);
            this.lblArrCity.TabIndex = 79;
            this.lblArrCity.Text = "Arrival City:";
            // 
            // cmbxArrCity
            // 
            this.cmbxArrCity.DisplayMember = "ArrCity";
            this.cmbxArrCity.FormattingEnabled = true;
            this.cmbxArrCity.Location = new System.Drawing.Point(403, 41);
            this.cmbxArrCity.Name = "cmbxArrCity";
            this.cmbxArrCity.Size = new System.Drawing.Size(121, 21);
            this.cmbxArrCity.TabIndex = 82;
            // 
            // lblTrip
            // 
            this.lblTrip.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTrip.AutoSize = true;
            this.lblTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrip.Location = new System.Drawing.Point(324, 86);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(73, 17);
            this.lblTrip.TabIndex = 83;
            this.lblTrip.Text = "Trip Type:";
            // 
            // cmbxTripType
            // 
            this.cmbxTripType.FormattingEnabled = true;
            this.cmbxTripType.Items.AddRange(new object[] {
            "One way",
            "Return"});
            this.cmbxTripType.Location = new System.Drawing.Point(403, 79);
            this.cmbxTripType.Name = "cmbxTripType";
            this.cmbxTripType.Size = new System.Drawing.Size(121, 21);
            this.cmbxTripType.TabIndex = 84;
            // 
            // lblDeptDate
            // 
            this.lblDeptDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDeptDate.AutoSize = true;
            this.lblDeptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptDate.Location = new System.Drawing.Point(308, 124);
            this.lblDeptDate.Name = "lblDeptDate";
            this.lblDeptDate.Size = new System.Drawing.Size(89, 17);
            this.lblDeptDate.TabIndex = 85;
            this.lblDeptDate.Text = "Depart Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(403, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 88;
            // 
            // lblAdult
            // 
            this.lblAdult.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAdult.AutoSize = true;
            this.lblAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdult.Location = new System.Drawing.Point(353, 162);
            this.lblAdult.Name = "lblAdult";
            this.lblAdult.Size = new System.Drawing.Size(44, 17);
            this.lblAdult.TabIndex = 89;
            this.lblAdult.Text = "Adult:";
            // 
            // numUpDnAdult
            // 
            this.numUpDnAdult.Location = new System.Drawing.Point(403, 155);
            this.numUpDnAdult.Name = "numUpDnAdult";
            this.numUpDnAdult.Size = new System.Drawing.Size(120, 20);
            this.numUpDnAdult.TabIndex = 90;
            // 
            // lblChild
            // 
            this.lblChild.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblChild.AutoSize = true;
            this.lblChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChild.Location = new System.Drawing.Point(354, 200);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(43, 17);
            this.lblChild.TabIndex = 91;
            this.lblChild.Text = "Child:";
            // 
            // numUpDnChild
            // 
            this.numUpDnChild.Location = new System.Drawing.Point(403, 193);
            this.numUpDnChild.Name = "numUpDnChild";
            this.numUpDnChild.Size = new System.Drawing.Size(120, 20);
            this.numUpDnChild.TabIndex = 92;
            // 
            // lblInfant
            // 
            this.lblInfant.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInfant.AutoSize = true;
            this.lblInfant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfant.Location = new System.Drawing.Point(350, 238);
            this.lblInfant.Name = "lblInfant";
            this.lblInfant.Size = new System.Drawing.Size(47, 17);
            this.lblInfant.TabIndex = 93;
            this.lblInfant.Text = "Infant:";
            // 
            // numUpDnInfant
            // 
            this.numUpDnInfant.Location = new System.Drawing.Point(403, 231);
            this.numUpDnInfant.Name = "numUpDnInfant";
            this.numUpDnInfant.Size = new System.Drawing.Size(120, 20);
            this.numUpDnInfant.TabIndex = 94;
            // 
            // cmbxClass
            // 
            this.cmbxClass.FormattingEnabled = true;
            this.cmbxClass.Items.AddRange(new object[] {
            "Economy ",
            "Business"});
            this.cmbxClass.Location = new System.Drawing.Point(403, 269);
            this.cmbxClass.Name = "cmbxClass";
            this.cmbxClass.Size = new System.Drawing.Size(101, 21);
            this.cmbxClass.TabIndex = 95;
            // 
            // lblClass
            // 
            this.lblClass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(313, 276);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(84, 17);
            this.lblClass.TabIndex = 96;
            this.lblClass.Text = "Flight Class:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 97;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(710, 313);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 27);
            this.btnBack.TabIndex = 98;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // BookFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "BookFlightForm";
            this.Text = "BookFlightForm";
            this.Load += new System.EventHandler(this.BookFlightForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnInfant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Label lblDeptCity;
        private System.Windows.Forms.ComboBox cmbxDepartCity;
        private System.Windows.Forms.Label lblArrCity;
        private System.Windows.Forms.ComboBox cmbxArrCity;
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.ComboBox cmbxTripType;
        private System.Windows.Forms.Label lblDeptDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblAdult;
        private System.Windows.Forms.NumericUpDown numUpDnAdult;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.NumericUpDown numUpDnChild;
        private System.Windows.Forms.Label lblInfant;
        private System.Windows.Forms.NumericUpDown numUpDnInfant;
        private System.Windows.Forms.ComboBox cmbxClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}