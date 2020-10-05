using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
public  struct Biosum_Id
{
	public string strInvId;
	public string strSecInvId;
	public string strStateCd;
	public string strNimsCycle;
	public string strNimsSubCycle;
	public string strCountyCd;
	public string strPlot;
	public string strPnwIdbForestOrBlmDistrict;
	public string strCondId;
}

namespace FIA_Biosum_Manager
{
	/// <summary>
	/// Summary description for uc_biosum_id.
	/// </summary>
	public class uc_biosum_id : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.Label lblTitle;
		private Biosum_Id m_biosumid;
		public int m_intHt=350;
		public int m_intWd=600;
		const int BIOSUM_COND_ID_LENGTH=25;
		const int BIOSUM_PLOT_ID_LENGTH=24;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblInvSource;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblYearMeasured;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.Label lblCounty;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblPlot;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblCycle;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblSubcycle;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblPNWOrBLM;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblCondId;
		private System.Windows.Forms.Label label10;
		public System.Windows.Forms.Button btnClose;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public uc_biosum_id(string strBiosumId)
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
            this.m_biosumid = new Biosum_Id();
			
			this.m_biosumid.strInvId = strBiosumId.ToString().Substring(0,1);
			this.m_biosumid.strSecInvId = strBiosumId.ToString().Substring(1,4);
			this.m_biosumid.strStateCd = strBiosumId.ToString().Substring(5,2);
			this.m_biosumid.strNimsCycle = strBiosumId.ToString().Substring(7,2);
			this.m_biosumid.strNimsSubCycle = strBiosumId.ToString().Substring(9,2);
			this.m_biosumid.strCountyCd = strBiosumId.ToString().Substring(11,3);
			this.m_biosumid.strPlot = strBiosumId.ToString().Substring(14,7);
			this.m_biosumid.strPnwIdbForestOrBlmDistrict = strBiosumId.ToString().Substring(21,3);
			if (strBiosumId.Trim().Length  == BIOSUM_COND_ID_LENGTH)
			{
				this.m_biosumid.strCondId = strBiosumId.ToString().Substring(24,1);
				this.lblCondId.Text = this.m_biosumid.strCondId;
			}
			else
			{
				this.m_biosumid.strCondId = "NA";
				this.lblCondId.Text = "NA";
			}

			switch (this.m_biosumid.strInvId)
			{
				case "1":
					this.lblInvSource.Text  = "FIADB";
					this.lblCycle.Text = this.m_biosumid.strNimsCycle;
					this.lblSubcycle.Text = this.m_biosumid.strNimsSubCycle;
					this.lblPNWOrBLM.Text = "NA";
					break;
				case "2":
					this.lblInvSource.Text  = "PNW IDB";
					this.lblCycle.Text = "NA";
					this.lblSubcycle.Text = "NA";
					this.lblPNWOrBLM.Text = this.m_biosumid.strPnwIdbForestOrBlmDistrict;
					break;
				case "3":
					this.lblInvSource.Text = "NIMS";
					this.lblCycle.Text = this.m_biosumid.strNimsCycle;
					this.lblSubcycle.Text = this.m_biosumid.strNimsSubCycle;
					this.lblPNWOrBLM.Text = "NA";
					break;
				default: 
					this.lblInvSource.Text = "Unknown";
					this.lblCycle.Text = "NA";
					this.lblSubcycle.Text = "NA";
					this.lblPNWOrBLM.Text = "NA";

					break;
			}

			env p_oEnv = new env();
			ado_data_access  p_ado = new ado_data_access();
			string strFile = p_oEnv.strAppDir + "\\db\\ref_master.mdb";
			string strConn="";
			strConn=p_ado.getMDBConnString(strFile,"admin","");
           	string strSQL = "select inv_id_def from inventories where trim(ucase(inv_id)) = '" + this.m_biosumid.strSecInvId.Trim().ToUpper() + "';";
            p_ado.SqlQueryReader(strConn,strSQL);
			if (p_ado.m_intError==0)
			{
				if (p_ado.m_OleDbDataReader.HasRows == true)
				{
					p_ado.m_OleDbDataReader.Read();
					this.lblYearMeasured.Text = p_ado.m_OleDbDataReader["inv_id_def"].ToString().Trim();
				}
				else 
				{
					this.lblYearMeasured.Text = this.m_biosumid.strSecInvId.Trim();
				}
				p_ado.m_OleDbDataReader.Close();
				p_ado.m_OleDbConnection.Close();
			 
			}
			p_ado.m_OleDbDataReader=null;
			p_ado.m_OleDbConnection = null;
			p_ado=null;

			this.lblState.Text = this.ConvertStateCd(this.m_biosumid.strStateCd);
			this.lblCounty.Text = this.m_biosumid.strCountyCd;
			this.lblPlot.Text = this.m_biosumid.strPlot;

			// TODO: Add any initialization after the InitializeComponent call

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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCondId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPNWOrBLM = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSubcycle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCycle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPlot = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblYearMeasured = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInvSource = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.lblCondId);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblPNWOrBLM);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblSubcycle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblCycle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblPlot);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblCounty);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblYearMeasured);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblInvSource);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(512, 296);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 32);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCondId
            // 
            this.lblCondId.Location = new System.Drawing.Point(179, 264);
            this.lblCondId.Name = "lblCondId";
            this.lblCondId.Size = new System.Drawing.Size(304, 16);
            this.lblCondId.TabIndex = 44;
            this.lblCondId.Text = "PNW IDB";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(20, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Condition Id:";
            // 
            // lblPNWOrBLM
            // 
            this.lblPNWOrBLM.Location = new System.Drawing.Point(179, 240);
            this.lblPNWOrBLM.Name = "lblPNWOrBLM";
            this.lblPNWOrBLM.Size = new System.Drawing.Size(304, 16);
            this.lblPNWOrBLM.TabIndex = 42;
            this.lblPNWOrBLM.Text = "PNW IDB";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(20, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "PNW Forest Or BLM District:";
            // 
            // lblSubcycle
            // 
            this.lblSubcycle.Location = new System.Drawing.Point(179, 216);
            this.lblSubcycle.Name = "lblSubcycle";
            this.lblSubcycle.Size = new System.Drawing.Size(304, 16);
            this.lblSubcycle.TabIndex = 40;
            this.lblSubcycle.Text = "PNW IDB";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Subcycle:";
            // 
            // lblCycle
            // 
            this.lblCycle.Location = new System.Drawing.Point(179, 192);
            this.lblCycle.Name = "lblCycle";
            this.lblCycle.Size = new System.Drawing.Size(304, 16);
            this.lblCycle.TabIndex = 38;
            this.lblCycle.Text = "PNW IDB";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(20, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Cycle:";
            // 
            // lblPlot
            // 
            this.lblPlot.Location = new System.Drawing.Point(179, 161);
            this.lblPlot.Name = "lblPlot";
            this.lblPlot.Size = new System.Drawing.Size(304, 16);
            this.lblPlot.TabIndex = 36;
            this.lblPlot.Text = "PNW IDB";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Plot:";
            // 
            // lblCounty
            // 
            this.lblCounty.Location = new System.Drawing.Point(179, 136);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(304, 16);
            this.lblCounty.TabIndex = 34;
            this.lblCounty.Text = "PNW IDB";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "County";
            // 
            // lblState
            // 
            this.lblState.Location = new System.Drawing.Point(179, 112);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(304, 16);
            this.lblState.TabIndex = 32;
            this.lblState.Text = "PNW IDB";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "State:";
            // 
            // lblYearMeasured
            // 
            this.lblYearMeasured.Location = new System.Drawing.Point(179, 88);
            this.lblYearMeasured.Name = "lblYearMeasured";
            this.lblYearMeasured.Size = new System.Drawing.Size(304, 16);
            this.lblYearMeasured.TabIndex = 30;
            this.lblYearMeasured.Text = "PNW IDB";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Inventory/Year Measured:";
            // 
            // lblInvSource
            // 
            this.lblInvSource.Location = new System.Drawing.Point(179, 64);
            this.lblInvSource.Name = "lblInvSource";
            this.lblInvSource.Size = new System.Drawing.Size(304, 16);
            this.lblInvSource.TabIndex = 28;
            this.lblInvSource.Text = "PNW IDB";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Inventory Source:";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Green;
            this.lblTitle.Location = new System.Drawing.Point(3, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(586, 32);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "FIA Biosum Id";
            // 
            // uc_biosum_id
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.groupBox1);
            this.Name = "uc_biosum_id";
            this.Size = new System.Drawing.Size(592, 336);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.ParentForm.Close();
		}
		private string ConvertStateCd(string p_strStateCd)
		{
			if (p_strStateCd.Trim().Length == 0) return "";
			switch (p_strStateCd.Trim())
			{
				case "1": return "Alabama";
				case "01": return "Alabama";
				case "2": return "Alaska";
				case "02": return "Alaska";
				case "4": return "Arizona";
				case "04": return "Arizona";		
				case "5": return "Arkansas";
				case "05": return "Arkansas";
				case "6": return "California";
				case "06": return "California";
				case "8": return "Colorado";
				case "08": return "Colorado";
				case "9": return "Connecticut";
				case "09": return "Connecticut";
				case "10": return "Delaware";
				case "11": return "District of Columbia";
				case "12": return "Florida";
				case "13": return "Georgia";
				case "15": return "Hawaii";
				case "16": return "Idaho";
				case "17": return "Illinois";
				case "18": return "Indiana";
				case "19": return "Iowa";
				case "20": return "Kansas";
				case "21": return "Kentucky";
				case "22": return "Louisiana";
				case "23": return "Maine";
				case "24": return "Maryland";
				case "25": return "Massachusetts";
				case "26": return "Michigan";
				case "27": return "Minnesota";
				case "28": return "Mississippi";
				case "29": return "Missouri";
				case "30": return "Montana";
				case "31": return "Nebraska";
				case "32": return "Nevada";
				case "33": return "New Hampshire";
				case "34": return "New Jersey";
				case "35": return "New Mexico";
				case "36": return "New York";
				case "37": return "North Carolina";
				case "38": return "North Dakota";
				case "39": return "Ohio";
				case "40": return "Oklahoma";
				case "41": return "Oregon";
				case "42": return "Pennsylvania";
				case "44": return "Rhode Island";
				case "45": return "South Carolina";
				case "46": return "South Dakota";
				case "47": return "Tennessee";
				case "48": return "Texas";
				case "49": return "Utah";
				case "50": return "Vermont";
				case "51": return "Virginia";
				case "53": return "Washington";
				case "54": return "West Virginia";
				case "55": return "Wisconsin";
				case "56": return "Wyoming";
				case "72": return "Puerto Rico";
				case "78": return "Virgin Islands";
				default: return "";
			}
		}
	}
}
