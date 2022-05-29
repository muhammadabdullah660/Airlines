
namespace Airlines.PassengerForms
{
    partial class CancelBookedFlightForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.gvFlights = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFlights)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent , 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1 , 0 , 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0 , 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent , 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800 , 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gvFlights);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3 , 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794 , 444);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btnBack);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3 , 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(264 , 91);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(3 , 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75 , 46);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(273 , 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(256 , 91);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(535 , 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(238 , 91);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // gvFlights
            // 
            this.gvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFlights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cancel});
            this.gvFlights.Location = new System.Drawing.Point(3 , 3);
            this.gvFlights.Name = "gvFlights";
            this.gvFlights.Size = new System.Drawing.Size(800 , 351);
            this.gvFlights.TabIndex = 2;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3 , 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(794 , 94);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent , 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel5 , 0 , 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3 , 360);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent , 48F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800 , 100);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // Cancel
            // 
            this.Cancel.HeaderText = "Cancel";
            this.Cancel.Name = "Cancel";
            this.Cancel.Text = "Cancel";
            this.Cancel.UseColumnTextForButtonValue = true;
            // 
            // CancelBookedFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F , 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800 , 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CancelBookedFlightForm";
            this.Text = "CancelBookedFlightForm";
            this.Load += new System.EventHandler(this.CancelBookedFlightForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvFlights)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView gvFlights;
        private System.Windows.Forms.DataGridViewButtonColumn Cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}