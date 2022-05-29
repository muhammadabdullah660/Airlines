
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
            this.passengerMenuStrp = new System.Windows.Forms.MenuStrip();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePersonalDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passengerMenuStrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // passengerMenuStrp
            // 
            this.passengerMenuStrp.AutoSize = false;
            this.passengerMenuStrp.BackColor = System.Drawing.Color.DarkRed;
            this.passengerMenuStrp.Dock = System.Windows.Forms.DockStyle.Left;
            this.passengerMenuStrp.Font = new System.Drawing.Font("Lucida Bright", 10F);
            this.passengerMenuStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.requestToolStripMenuItem,
            this.myFlightsToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.contactUsToolStripMenuItem,
            this.updatePersonalDetailsToolStripMenuItem});
            this.passengerMenuStrp.Location = new System.Drawing.Point(0, 0);
            this.passengerMenuStrp.Name = "passengerMenuStrp";
            this.passengerMenuStrp.Size = new System.Drawing.Size(138, 450);
            this.passengerMenuStrp.TabIndex = 4;
            this.passengerMenuStrp.Text = "menuStrip1";
            this.passengerMenuStrp.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.passengerMenuStrp_ItemClicked);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.personalToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.personalToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(126, 30);
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
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(126, 30);
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
            this.requestToolStripMenuItem.Size = new System.Drawing.Size(126, 30);
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
            this.myFlightsToolStripMenuItem.Size = new System.Drawing.Size(126, 30);
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
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(126, 30);
            this.cancelToolStripMenuItem.Text = "Cancel a Flight";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 15);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.contactUsToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.contactUsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.contactUsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.contactUsToolStripMenuItem.Text = "Contact Us";
            // 
            // updatePersonalDetailsToolStripMenuItem
            // 
            this.updatePersonalDetailsToolStripMenuItem.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold);
            this.updatePersonalDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.updatePersonalDetailsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.updatePersonalDetailsToolStripMenuItem.Name = "updatePersonalDetailsToolStripMenuItem";
            this.updatePersonalDetailsToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.updatePersonalDetailsToolStripMenuItem.Text = "Update Personal Details";
            this.updatePersonalDetailsToolStripMenuItem.Click += new System.EventHandler(this.updatePersonalDetailsToolStripMenuItem_Click);
            // 
            // PassengerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passengerMenuStrp);
            this.Name = "PassengerMainForm";
            this.Text = "PassengerMainForm";
            this.Load += new System.EventHandler(this.PassengerMainForm_Load);
            this.passengerMenuStrp.ResumeLayout(false);
            this.passengerMenuStrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip passengerMenuStrp;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myFlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePersonalDetailsToolStripMenuItem;
    }
}