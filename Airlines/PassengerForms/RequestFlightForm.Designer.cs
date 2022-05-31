
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.btnRequest = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbxTripType = new System.Windows.Forms.ComboBox();
            this.txtArr = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDeptCity = new System.Windows.Forms.Label();
            this.lblArrCity = new System.Windows.Forms.Label();
            this.lblTrip = new System.Windows.Forms.Label();
            this.lblDeptDate = new System.Windows.Forms.Label();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel1.TabIndex = 4;
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
            this.lblMainHeading.Text = "Request a Flight";
            this.lblMainHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRequest
            // 
            this.btnRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(710, 283);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(87, 27);
            this.btnRequest.TabIndex = 100;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker1.Location = new System.Drawing.Point(403, 235);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 20);
            this.dateTimePicker1.TabIndex = 98;
            // 
            // cmbxTripType
            // 
            this.cmbxTripType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbxTripType.FormattingEnabled = true;
            this.cmbxTripType.Items.AddRange(new object[] {
            "One way",
            "Return"});
            this.cmbxTripType.Location = new System.Drawing.Point(403, 164);
            this.cmbxTripType.Name = "cmbxTripType";
            this.cmbxTripType.Size = new System.Drawing.Size(212, 21);
            this.cmbxTripType.TabIndex = 97;
            // 
            // txtArr
            // 
            this.txtArr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtArr.Location = new System.Drawing.Point(403, 90);
            this.txtArr.Multiline = true;
            this.txtArr.Name = "txtArr";
            this.txtArr.Size = new System.Drawing.Size(212, 29);
            this.txtArr.TabIndex = 96;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnBack, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblDeptCity, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblArrCity, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTrip, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblDeptDate, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtDept, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtArr, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbxTripType, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnRequest, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 350);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 283);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 27);
            this.btnBack.TabIndex = 99;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDeptCity
            // 
            this.lblDeptCity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDeptCity.AutoSize = true;
            this.lblDeptCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptCity.Location = new System.Drawing.Point(294, 26);
            this.lblDeptCity.Name = "lblDeptCity";
            this.lblDeptCity.Size = new System.Drawing.Size(103, 17);
            this.lblDeptCity.TabIndex = 90;
            this.lblDeptCity.Text = "Departure City:";
            // 
            // lblArrCity
            // 
            this.lblArrCity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblArrCity.AutoSize = true;
            this.lblArrCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrCity.Location = new System.Drawing.Point(318, 96);
            this.lblArrCity.Name = "lblArrCity";
            this.lblArrCity.Size = new System.Drawing.Size(79, 17);
            this.lblArrCity.TabIndex = 91;
            this.lblArrCity.Text = "Arrival City:";
            // 
            // lblTrip
            // 
            this.lblTrip.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTrip.AutoSize = true;
            this.lblTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrip.Location = new System.Drawing.Point(324, 166);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(73, 17);
            this.lblTrip.TabIndex = 93;
            this.lblTrip.Text = "Trip Type:";
            // 
            // lblDeptDate
            // 
            this.lblDeptDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDeptDate.AutoSize = true;
            this.lblDeptDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptDate.Location = new System.Drawing.Point(308, 236);
            this.lblDeptDate.Name = "lblDeptDate";
            this.lblDeptDate.Size = new System.Drawing.Size(89, 17);
            this.lblDeptDate.TabIndex = 94;
            this.lblDeptDate.Text = "Depart Date:";
            // 
            // txtDept
            // 
            this.txtDept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDept.Location = new System.Drawing.Point(403, 21);
            this.txtDept.Multiline = true;
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(212, 28);
            this.txtDept.TabIndex = 95;
            // 
            // RequestFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RequestFlightForm";
            this.Text = "RequestFlightForm";
            this.Load += new System.EventHandler(this.RequestFlightForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbxTripType;
        private System.Windows.Forms.TextBox txtArr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDeptCity;
        private System.Windows.Forms.Label lblArrCity;
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.Label lblDeptDate;
        private System.Windows.Forms.TextBox txtDept;
    }
}