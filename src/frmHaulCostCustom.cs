using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FIA_Biosum_Manager
{
	/// <summary>
	/// Summary description for frmHaulCostCustom.
	/// </summary>
	public class frmHaulCostCustom : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grpPlot;
		private System.Windows.Forms.GroupBox grpCustom;
		private System.Windows.Forms.GroupBox grpCheapestRoute;
		private System.Windows.Forms.GroupBox grpTravelTimes;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmHaulCostCustom()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.grpPlot = new System.Windows.Forms.GroupBox();
            this.grpCustom = new System.Windows.Forms.GroupBox();
            this.grpCheapestRoute = new System.Windows.Forms.GroupBox();
            this.grpTravelTimes = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // grpPlot
            // 
            this.grpPlot.Location = new System.Drawing.Point(17, 23);
            this.grpPlot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPlot.Name = "grpPlot";
            this.grpPlot.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPlot.Size = new System.Drawing.Size(349, 226);
            this.grpPlot.TabIndex = 0;
            this.grpPlot.TabStop = false;
            this.grpPlot.Text = "Plot Table";
            // 
            // grpCustom
            // 
            this.grpCustom.Location = new System.Drawing.Point(384, 39);
            this.grpCustom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCustom.Name = "grpCustom";
            this.grpCustom.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCustom.Size = new System.Drawing.Size(333, 86);
            this.grpCustom.TabIndex = 1;
            this.grpCustom.TabStop = false;
            this.grpCustom.Text = "User Selected Routes For Plot To Processing Site";
            // 
            // grpCheapestRoute
            // 
            this.grpCheapestRoute.Location = new System.Drawing.Point(384, 140);
            this.grpCheapestRoute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCheapestRoute.Name = "grpCheapestRoute";
            this.grpCheapestRoute.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCheapestRoute.Size = new System.Drawing.Size(333, 101);
            this.grpCheapestRoute.TabIndex = 2;
            this.grpCheapestRoute.TabStop = false;
            this.grpCheapestRoute.Text = "Cheapest Routes From Plot To Processing Site";
            // 
            // grpTravelTimes
            // 
            this.grpTravelTimes.Location = new System.Drawing.Point(17, 265);
            this.grpTravelTimes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTravelTimes.Name = "grpTravelTimes";
            this.grpTravelTimes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTravelTimes.Size = new System.Drawing.Size(691, 187);
            this.grpTravelTimes.TabIndex = 3;
            this.grpTravelTimes.TabStop = false;
            this.grpTravelTimes.Text = "Plots And Processing Sites";
            // 
            // frmHaulCostCustom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(459, 345);
            this.Controls.Add(this.grpTravelTimes);
            this.Controls.Add(this.grpCheapestRoute);
            this.Controls.Add(this.grpCustom);
            this.Controls.Add(this.grpPlot);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHaulCostCustom";
            this.Text = "Manually Assign Processing Sites To Plots";
            this.ResumeLayout(false);

		}
		#endregion
	}
}
