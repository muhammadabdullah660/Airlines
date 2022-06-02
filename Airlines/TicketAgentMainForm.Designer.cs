
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ticketagentMenuStrp = new System.Windows.Forms.MenuStrip();
            this.passengersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderedPassengersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestedFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.ticketagentMenuStrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.ticketagentMenuStrp, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // ticketagentMenuStrp
            // 
            resources.ApplyResources(this.ticketagentMenuStrp, "ticketagentMenuStrp");
            this.ticketagentMenuStrp.BackColor = System.Drawing.Color.Firebrick;
            this.tableLayoutPanel1.SetColumnSpan(this.ticketagentMenuStrp, 2);
            this.ticketagentMenuStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passengersToolStripMenuItem,
            this.flightToolStripMenuItem,
            this.orderedPassengersToolStripMenuItem,
            this.requestedFlightsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.ticketagentMenuStrp.Name = "ticketagentMenuStrp";
            this.tableLayoutPanel1.SetRowSpan(this.ticketagentMenuStrp, 2);
            // 
            // passengersToolStripMenuItem
            // 
            this.passengersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalToolStripMenuItem1});
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
            // flightToolStripMenuItem
            // 
            resources.ApplyResources(this.flightToolStripMenuItem, "flightToolStripMenuItem");
            this.flightToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.flightToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.flightToolStripMenuItem.Name = "flightToolStripMenuItem";
            this.flightToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.flightToolStripMenuItem.Click += new System.EventHandler(this.flightStripMenuItem_Click);
            // 
            // orderedPassengersToolStripMenuItem
            // 
            resources.ApplyResources(this.orderedPassengersToolStripMenuItem, "orderedPassengersToolStripMenuItem");
            this.orderedPassengersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.orderedPassengersToolStripMenuItem.Name = "orderedPassengersToolStripMenuItem";
            this.orderedPassengersToolStripMenuItem.Click += new System.EventHandler(this.orderedPassengersToolStripMenuItem_Click);
            // 
            // requestedFlightsToolStripMenuItem
            // 
            resources.ApplyResources(this.requestedFlightsToolStripMenuItem, "requestedFlightsToolStripMenuItem");
            this.requestedFlightsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.requestedFlightsToolStripMenuItem.Name = "requestedFlightsToolStripMenuItem";
            this.requestedFlightsToolStripMenuItem.Click += new System.EventHandler(this.requestedFlightsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.logOutToolStripMenuItem, "logOutToolStripMenuItem");
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = global::Airlines.Properties.Resources.difa_naufal_YPj_96uaCwU_unsplash;
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // TicketAgentMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TicketAgentMainForm";
            this.Load += new System.EventHandler(this.TicketAgentMainForm_Load);
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.TicketAgentMainForm_InputLanguageChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ticketagentMenuStrp.ResumeLayout(false);
            this.ticketagentMenuStrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip ticketagentMenuStrp;
        private System.Windows.Forms.ToolStripMenuItem passengersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem flightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderedPassengersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestedFlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}