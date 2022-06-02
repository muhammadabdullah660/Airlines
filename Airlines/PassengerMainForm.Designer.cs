
namespace Airlines
{
    partial class PassengerMainForm
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
            this.passengerMenuStrp = new System.Windows.Forms.MenuStrip();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePersonalDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.passengerMenuStrp.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.passengerMenuStrp, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // passengerMenuStrp
            // 
            this.passengerMenuStrp.AutoSize = false;
            this.passengerMenuStrp.BackColor = System.Drawing.Color.DarkRed;
            this.tableLayoutPanel1.SetColumnSpan(this.passengerMenuStrp, 2);
            this.passengerMenuStrp.Dock = System.Windows.Forms.DockStyle.Left;
            this.passengerMenuStrp.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.passengerMenuStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.requestToolStripMenuItem,
            this.myFlightsToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.updatePersonalDetailsToolStripMenuItem});
            this.passengerMenuStrp.Location = new System.Drawing.Point(0, 0);
            this.passengerMenuStrp.Name = "passengerMenuStrp";
            this.tableLayoutPanel1.SetRowSpan(this.passengerMenuStrp, 2);
            this.passengerMenuStrp.Size = new System.Drawing.Size(200, 450);
            this.passengerMenuStrp.TabIndex = 25;
            this.passengerMenuStrp.Text = "menuStrip1";
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.personalToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.personalToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.personalToolStripMenuItem.Text = "Personal Details";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.bookToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bookToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.bookToolStripMenuItem.Text = "Book a Flight";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // requestToolStripMenuItem
            // 
            this.requestToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.requestToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.requestToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.requestToolStripMenuItem.Name = "requestToolStripMenuItem";
            this.requestToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.requestToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.requestToolStripMenuItem.Text = "Request a Flight";
            this.requestToolStripMenuItem.Click += new System.EventHandler(this.requestToolStripMenuItem_Click);
            // 
            // myFlightsToolStripMenuItem
            // 
            this.myFlightsToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.myFlightsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.myFlightsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.myFlightsToolStripMenuItem.Name = "myFlightsToolStripMenuItem";
            this.myFlightsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.myFlightsToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.myFlightsToolStripMenuItem.Text = "My Flights";
            this.myFlightsToolStripMenuItem.Click += new System.EventHandler(this.myFlightsToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.cancelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cancelToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.cancelToolStripMenuItem.Text = "Cancel a Flight";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // updatePersonalDetailsToolStripMenuItem
            // 
            this.updatePersonalDetailsToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.updatePersonalDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.updatePersonalDetailsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.updatePersonalDetailsToolStripMenuItem.Name = "updatePersonalDetailsToolStripMenuItem";
            this.updatePersonalDetailsToolStripMenuItem.Size = new System.Drawing.Size(183, 20);
            this.updatePersonalDetailsToolStripMenuItem.Text = "Update Personal Details";
            this.updatePersonalDetailsToolStripMenuItem.Click += new System.EventHandler(this.updatePersonalDetailsToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = global::Airlines.Properties.Resources.saj_shafique_h1Z4CNkncfo_unsplash;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnLogOut, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(200, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(600, 450);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogOut.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(522, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 26;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // PassengerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PassengerMainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.PassengerMainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.passengerMenuStrp.ResumeLayout(false);
            this.passengerMenuStrp.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MenuStrip passengerMenuStrp;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myFlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePersonalDetailsToolStripMenuItem;
        private System.Windows.Forms.Button btnLogOut;
    }
}