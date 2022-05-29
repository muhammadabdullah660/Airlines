
namespace Airlines
{
    partial class TicketAgentMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketAgentMainForm));
            this.ticketagentMenuStrp = new System.Windows.Forms.MenuStrip();
            this.passengersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.travelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderedPassengersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketagentMenuStrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketagentMenuStrp
            // 
            resources.ApplyResources(this.ticketagentMenuStrp, "ticketagentMenuStrp");
            this.ticketagentMenuStrp.BackColor = System.Drawing.Color.DarkRed;
            this.ticketagentMenuStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passengersToolStripMenuItem,
            this.flightToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.contactUsToolStripMenuItem,
            this.orderedPassengersToolStripMenuItem});
            this.ticketagentMenuStrp.Name = "ticketagentMenuStrp";
            // 
            // passengersToolStripMenuItem
            // 
            this.passengersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalToolStripMenuItem1,
            this.travelToolStripMenuItem});
            resources.ApplyResources(this.passengersToolStripMenuItem, "passengersToolStripMenuItem");
            this.passengersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.passengersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.passengersToolStripMenuItem.Name = "passengersToolStripMenuItem";
            this.passengersToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            // 
            // personalToolStripMenuItem1
            // 
            this.personalToolStripMenuItem1.Name = "personalToolStripMenuItem1";
            resources.ApplyResources(this.personalToolStripMenuItem1, "personalToolStripMenuItem1");
            this.personalToolStripMenuItem1.Click += new System.EventHandler(this.personalToolStripMenuItem1_Click);
            // 
            // travelToolStripMenuItem
            // 
            this.travelToolStripMenuItem.Name = "travelToolStripMenuItem";
            resources.ApplyResources(this.travelToolStripMenuItem, "travelToolStripMenuItem");
            // 
            // flightToolStripMenuItem
            // 
            resources.ApplyResources(this.flightToolStripMenuItem, "flightToolStripMenuItem");
            this.flightToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.flightToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.flightToolStripMenuItem.Name = "flightToolStripMenuItem";
            this.flightToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.flightToolStripMenuItem.Click += new System.EventHandler(this.flightStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.contactUsToolStripMenuItem, "contactUsToolStripMenuItem");
            this.contactUsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.contactUsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            // 
            // orderedPassengersToolStripMenuItem
            // 
            resources.ApplyResources(this.orderedPassengersToolStripMenuItem, "orderedPassengersToolStripMenuItem");
            this.orderedPassengersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.orderedPassengersToolStripMenuItem.Name = "orderedPassengersToolStripMenuItem";
            this.orderedPassengersToolStripMenuItem.Click += new System.EventHandler(this.orderedPassengersToolStripMenuItem_Click);
            // 
            // TicketAgentMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ticketagentMenuStrp);
            this.Name = "TicketAgentMainForm";
            this.Load += new System.EventHandler(this.TicketAgentMainForm_Load);
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.TicketAgentMainForm_InputLanguageChanged);
            this.ticketagentMenuStrp.ResumeLayout(false);
            this.ticketagentMenuStrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip ticketagentMenuStrp;
        private System.Windows.Forms.ToolStripMenuItem passengersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem travelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderedPassengersToolStripMenuItem;
    }
}