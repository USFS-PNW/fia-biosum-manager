using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FIA_Biosum_Manager
{
	/// <summary>
	/// Summary description for frmSettings.
	/// </summary>
	public class frmSettings : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grpGrids;
		private System.Windows.Forms.Button btnGridFont;
		private System.Windows.Forms.Label lblGridFontName;
		private System.Windows.Forms.Label lblGridFontSize;
		private System.Windows.Forms.Label lblGridFontStyle;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblGridFont;
		private System.Windows.Forms.Label lblGridRowBackgroundColor;
		private System.Windows.Forms.Button btnGridAlternateRowBackground;
		private System.Windows.Forms.Button btnGridRowBackgroundColor;
		private System.Windows.Forms.Button btnGridBackground;
		private System.Windows.Forms.Label lblGridBackgroundColor;
		private System.Windows.Forms.Label lblGridAlternateRowBackgroundColor;
		private System.Windows.Forms.Label lblGridRowForegroundColor;
		private System.Windows.Forms.Button btnGridSelectedRowBackgroundColor;
        private System.Windows.Forms.Label lblGridSelectedRowBackgroundColor;
        private GroupBox grpDebug;
        private Label label1;
        private ComboBox cmbDebug;
        private CheckBox chkDebug;
        private GroupBox grpTableRecordCounts;
        private CheckBox chkScenarioProcessorForm;
        private CheckBox chkFVSOutputForm;
        private CheckBox chkFVSInputForm;
        private GroupBox grpOpcost;
        private Label lblRScriptDir;
        private Label lblOpcostDir;
        private TextBox txtRdir;
        private Button btnOpcost;
        private TextBox txtOpcost;
        private env m_oEnv;
        private Help m_oHelp;
        private string m_xpsFile = Help.DefaultMainFile;
        private Button btnSave;
        private Button btnHelp;
        private GroupBox grpAppData;
        private TextBox txtAppData;
        private Button btnRdir;



        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public frmSettings()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            //
            //GRIDVIEW
            //
			this.lblGridBackgroundColor.BackColor = frmMain.g_oGridViewBackgroundColor;
			this.lblGridAlternateRowBackgroundColor.BackColor=frmMain.g_oGridViewAlternateRowBackgroundColor;
			this.lblGridRowBackgroundColor.BackColor = frmMain.g_oGridViewRowBackgroundColor;
			this.lblGridRowForegroundColor.BackColor = frmMain.g_oGridViewRowForegroundColor;
			this.lblGridSelectedRowBackgroundColor.BackColor = frmMain.g_oGridViewSelectedRowBackgroundColor;
			if (frmMain.g_oGridViewFont != null)
			{
					this.lblGridFont.Font = frmMain.g_oGridViewFont;
				    this.lblGridFontName.Text = frmMain.g_oGridViewFont.Name;
				    this.lblGridFontSize.Text = frmMain.g_oGridViewFont.Size.ToString().Trim();
				    this.lblGridFontStyle.Text = frmMain.g_oGridViewFont.Style.ToString().Trim();
			}
            //
            //DEBUG
            //
            if (frmMain.g_bDebug) this.chkDebug.Checked = true;
            else this.chkDebug.Checked = false;
            cmbDebug.SelectedIndex = frmMain.g_intDebugLevel-1;
            //
            //SUPPRESS TABLE RECORD COUNTS
            //
            chkFVSInputForm.Checked = frmMain.g_bSuppressFVSInputTableRowCount;
            chkFVSOutputForm.Checked = frmMain.g_bSuppressFVSOutputTableRowCount;
            chkScenarioProcessorForm.Checked = frmMain.g_bSuppressProcessorScenarioTableRowCount;

            //
            //OPCOST SETTINGS
            //
            if (frmMain.g_strOPCOSTDirectory.Trim().Length == 0)
            {
                txtOpcost.Text = frmSettings.GetDefaultOpcostPath();
            }
            else
            {
                if (System.IO.File.Exists(frmMain.g_strOPCOSTDirectory) == true)
                    txtOpcost.Text = frmMain.g_strOPCOSTDirectory;
            }

            if (frmMain.g_strRDirectory.Trim().Length > 0 &&
                System.IO.File.Exists(frmMain.g_strRDirectory) == true) txtRdir.Text = frmMain.g_strRDirectory;

            // 
            // AppData path
            //
            txtAppData.Text = frmMain.g_oEnv.strApplicationDataDirectory.Trim() + "\\FIABiosum";

            this.m_oEnv = new env();


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.grpGrids = new System.Windows.Forms.GroupBox();
            this.lblGridSelectedRowBackgroundColor = new System.Windows.Forms.Label();
            this.btnGridSelectedRowBackgroundColor = new System.Windows.Forms.Button();
            this.lblGridRowForegroundColor = new System.Windows.Forms.Label();
            this.lblGridBackgroundColor = new System.Windows.Forms.Label();
            this.btnGridBackground = new System.Windows.Forms.Button();
            this.lblGridFont = new System.Windows.Forms.Label();
            this.lblGridFontStyle = new System.Windows.Forms.Label();
            this.lblGridFontSize = new System.Windows.Forms.Label();
            this.lblGridFontName = new System.Windows.Forms.Label();
            this.lblGridAlternateRowBackgroundColor = new System.Windows.Forms.Label();
            this.lblGridRowBackgroundColor = new System.Windows.Forms.Label();
            this.btnGridFont = new System.Windows.Forms.Button();
            this.btnGridAlternateRowBackground = new System.Windows.Forms.Button();
            this.btnGridRowBackgroundColor = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpDebug = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDebug = new System.Windows.Forms.ComboBox();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.grpTableRecordCounts = new System.Windows.Forms.GroupBox();
            this.chkScenarioProcessorForm = new System.Windows.Forms.CheckBox();
            this.chkFVSOutputForm = new System.Windows.Forms.CheckBox();
            this.chkFVSInputForm = new System.Windows.Forms.CheckBox();
            this.grpOpcost = new System.Windows.Forms.GroupBox();
            this.btnRdir = new System.Windows.Forms.Button();
            this.btnOpcost = new System.Windows.Forms.Button();
            this.txtOpcost = new System.Windows.Forms.TextBox();
            this.lblOpcostDir = new System.Windows.Forms.Label();
            this.txtRdir = new System.Windows.Forms.TextBox();
            this.lblRScriptDir = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.grpAppData = new System.Windows.Forms.GroupBox();
            this.txtAppData = new System.Windows.Forms.TextBox();
            this.grpGrids.SuspendLayout();
            this.grpDebug.SuspendLayout();
            this.grpTableRecordCounts.SuspendLayout();
            this.grpOpcost.SuspendLayout();
            this.grpAppData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGrids
            // 
            this.grpGrids.Controls.Add(this.lblGridSelectedRowBackgroundColor);
            this.grpGrids.Controls.Add(this.btnGridSelectedRowBackgroundColor);
            this.grpGrids.Controls.Add(this.lblGridRowForegroundColor);
            this.grpGrids.Controls.Add(this.lblGridBackgroundColor);
            this.grpGrids.Controls.Add(this.btnGridBackground);
            this.grpGrids.Controls.Add(this.lblGridFont);
            this.grpGrids.Controls.Add(this.lblGridFontStyle);
            this.grpGrids.Controls.Add(this.lblGridFontSize);
            this.grpGrids.Controls.Add(this.lblGridFontName);
            this.grpGrids.Controls.Add(this.lblGridAlternateRowBackgroundColor);
            this.grpGrids.Controls.Add(this.lblGridRowBackgroundColor);
            this.grpGrids.Controls.Add(this.btnGridFont);
            this.grpGrids.Controls.Add(this.btnGridAlternateRowBackground);
            this.grpGrids.Controls.Add(this.btnGridRowBackgroundColor);
            this.grpGrids.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGrids.Location = new System.Drawing.Point(19, 79);
            this.grpGrids.Name = "grpGrids";
            this.grpGrids.Size = new System.Drawing.Size(1029, 213);
            this.grpGrids.TabIndex = 0;
            this.grpGrids.TabStop = false;
            this.grpGrids.Text = "Grids";
            // 
            // lblGridSelectedRowBackgroundColor
            // 
            this.lblGridSelectedRowBackgroundColor.BackColor = System.Drawing.Color.Blue;
            this.lblGridSelectedRowBackgroundColor.Location = new System.Drawing.Point(904, 168);
            this.lblGridSelectedRowBackgroundColor.Name = "lblGridSelectedRowBackgroundColor";
            this.lblGridSelectedRowBackgroundColor.Size = new System.Drawing.Size(70, 35);
            this.lblGridSelectedRowBackgroundColor.TabIndex = 13;
            // 
            // btnGridSelectedRowBackgroundColor
            // 
            this.btnGridSelectedRowBackgroundColor.Image = ((System.Drawing.Image)(resources.GetObject("btnGridSelectedRowBackgroundColor.Image")));
            this.btnGridSelectedRowBackgroundColor.Location = new System.Drawing.Point(886, 23);
            this.btnGridSelectedRowBackgroundColor.Name = "btnGridSelectedRowBackgroundColor";
            this.btnGridSelectedRowBackgroundColor.Size = new System.Drawing.Size(100, 130);
            this.btnGridSelectedRowBackgroundColor.TabIndex = 12;
            this.btnGridSelectedRowBackgroundColor.Text = "Selected Row Background";
            this.btnGridSelectedRowBackgroundColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGridSelectedRowBackgroundColor.Click += new System.EventHandler(this.btnGridSelectedRowBackgroundColor_Click);
            // 
            // lblGridRowForegroundColor
            // 
            this.lblGridRowForegroundColor.BackColor = System.Drawing.Color.Black;
            this.lblGridRowForegroundColor.Location = new System.Drawing.Point(39, 168);
            this.lblGridRowForegroundColor.Name = "lblGridRowForegroundColor";
            this.lblGridRowForegroundColor.Size = new System.Drawing.Size(70, 35);
            this.lblGridRowForegroundColor.TabIndex = 11;
            // 
            // lblGridBackgroundColor
            // 
            this.lblGridBackgroundColor.BackColor = System.Drawing.Color.White;
            this.lblGridBackgroundColor.Location = new System.Drawing.Point(476, 168);
            this.lblGridBackgroundColor.Name = "lblGridBackgroundColor";
            this.lblGridBackgroundColor.Size = new System.Drawing.Size(70, 35);
            this.lblGridBackgroundColor.TabIndex = 10;
            // 
            // btnGridBackground
            // 
            this.btnGridBackground.Image = ((System.Drawing.Image)(resources.GetObject("btnGridBackground.Image")));
            this.btnGridBackground.Location = new System.Drawing.Point(463, 23);
            this.btnGridBackground.Name = "btnGridBackground";
            this.btnGridBackground.Size = new System.Drawing.Size(100, 130);
            this.btnGridBackground.TabIndex = 9;
            this.btnGridBackground.Text = "Grid Background";
            this.btnGridBackground.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGridBackground.Click += new System.EventHandler(this.btnGridBackground_Click);
            // 
            // lblGridFont
            // 
            this.lblGridFont.Location = new System.Drawing.Point(151, 138);
            this.lblGridFont.Name = "lblGridFont";
            this.lblGridFont.Size = new System.Drawing.Size(304, 59);
            this.lblGridFont.TabIndex = 8;
            this.lblGridFont.Text = "Font Example";
            // 
            // lblGridFontStyle
            // 
            this.lblGridFontStyle.Location = new System.Drawing.Point(151, 97);
            this.lblGridFontStyle.Name = "lblGridFontStyle";
            this.lblGridFontStyle.Size = new System.Drawing.Size(256, 23);
            this.lblGridFontStyle.TabIndex = 7;
            this.lblGridFontStyle.Text = "Regular";
            // 
            // lblGridFontSize
            // 
            this.lblGridFontSize.Location = new System.Drawing.Point(151, 67);
            this.lblGridFontSize.Name = "lblGridFontSize";
            this.lblGridFontSize.Size = new System.Drawing.Size(256, 23);
            this.lblGridFontSize.TabIndex = 6;
            this.lblGridFontSize.Text = "8.25";
            // 
            // lblGridFontName
            // 
            this.lblGridFontName.Location = new System.Drawing.Point(151, 36);
            this.lblGridFontName.Name = "lblGridFontName";
            this.lblGridFontName.Size = new System.Drawing.Size(268, 24);
            this.lblGridFontName.TabIndex = 5;
            this.lblGridFontName.Text = "Microsoft Sans Serif";
            // 
            // lblGridAlternateRowBackgroundColor
            // 
            this.lblGridAlternateRowBackgroundColor.BackColor = System.Drawing.Color.LightGreen;
            this.lblGridAlternateRowBackgroundColor.Location = new System.Drawing.Point(765, 168);
            this.lblGridAlternateRowBackgroundColor.Name = "lblGridAlternateRowBackgroundColor";
            this.lblGridAlternateRowBackgroundColor.Size = new System.Drawing.Size(70, 35);
            this.lblGridAlternateRowBackgroundColor.TabIndex = 4;
            // 
            // lblGridRowBackgroundColor
            // 
            this.lblGridRowBackgroundColor.BackColor = System.Drawing.Color.White;
            this.lblGridRowBackgroundColor.Location = new System.Drawing.Point(623, 168);
            this.lblGridRowBackgroundColor.Name = "lblGridRowBackgroundColor";
            this.lblGridRowBackgroundColor.Size = new System.Drawing.Size(70, 35);
            this.lblGridRowBackgroundColor.TabIndex = 3;
            // 
            // btnGridFont
            // 
            this.btnGridFont.Image = ((System.Drawing.Image)(resources.GetObject("btnGridFont.Image")));
            this.btnGridFont.Location = new System.Drawing.Point(26, 23);
            this.btnGridFont.Name = "btnGridFont";
            this.btnGridFont.Size = new System.Drawing.Size(100, 130);
            this.btnGridFont.TabIndex = 2;
            this.btnGridFont.Text = "Font";
            this.btnGridFont.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGridFont.Click += new System.EventHandler(this.btnGridFont_Click);
            // 
            // btnGridAlternateRowBackground
            // 
            this.btnGridAlternateRowBackground.Image = ((System.Drawing.Image)(resources.GetObject("btnGridAlternateRowBackground.Image")));
            this.btnGridAlternateRowBackground.Location = new System.Drawing.Point(750, 23);
            this.btnGridAlternateRowBackground.Name = "btnGridAlternateRowBackground";
            this.btnGridAlternateRowBackground.Size = new System.Drawing.Size(100, 130);
            this.btnGridAlternateRowBackground.TabIndex = 1;
            this.btnGridAlternateRowBackground.Text = "Alternate Row Background";
            this.btnGridAlternateRowBackground.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGridAlternateRowBackground.Click += new System.EventHandler(this.btnGridAlternateRowBackground_Click);
            // 
            // btnGridRowBackgroundColor
            // 
            this.btnGridRowBackgroundColor.Image = ((System.Drawing.Image)(resources.GetObject("btnGridRowBackgroundColor.Image")));
            this.btnGridRowBackgroundColor.Location = new System.Drawing.Point(607, 23);
            this.btnGridRowBackgroundColor.Name = "btnGridRowBackgroundColor";
            this.btnGridRowBackgroundColor.Size = new System.Drawing.Size(100, 130);
            this.btnGridRowBackgroundColor.TabIndex = 0;
            this.btnGridRowBackgroundColor.Text = "Row Background";
            this.btnGridRowBackgroundColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGridRowBackgroundColor.Click += new System.EventHandler(this.btnGridRowBackgroundColor_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(19, 18);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 50);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(197, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpDebug
            // 
            this.grpDebug.Controls.Add(this.label1);
            this.grpDebug.Controls.Add(this.cmbDebug);
            this.grpDebug.Controls.Add(this.chkDebug);
            this.grpDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDebug.Location = new System.Drawing.Point(19, 307);
            this.grpDebug.Name = "grpDebug";
            this.grpDebug.Size = new System.Drawing.Size(421, 60);
            this.grpDebug.TabIndex = 3;
            this.grpDebug.TabStop = false;
            this.grpDebug.Text = "Debug";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Level";
            // 
            // cmbDebug
            // 
            this.cmbDebug.FormattingEnabled = true;
            this.cmbDebug.Items.AddRange(new object[] {
            "1 - Minimal",
            "2 - Some",
            "3 - Maximum"});
            this.cmbDebug.Location = new System.Drawing.Point(200, 23);
            this.cmbDebug.Name = "cmbDebug";
            this.cmbDebug.Size = new System.Drawing.Size(203, 26);
            this.cmbDebug.TabIndex = 4;
            this.cmbDebug.Text = "3 - Maximum";
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(26, 26);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(84, 22);
            this.chkDebug.TabIndex = 4;
            this.chkDebug.Text = "Turn On";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // grpTableRecordCounts
            // 
            this.grpTableRecordCounts.Controls.Add(this.chkScenarioProcessorForm);
            this.grpTableRecordCounts.Controls.Add(this.chkFVSOutputForm);
            this.grpTableRecordCounts.Controls.Add(this.chkFVSInputForm);
            this.grpTableRecordCounts.Location = new System.Drawing.Point(461, 307);
            this.grpTableRecordCounts.Name = "grpTableRecordCounts";
            this.grpTableRecordCounts.Size = new System.Drawing.Size(587, 60);
            this.grpTableRecordCounts.TabIndex = 4;
            this.grpTableRecordCounts.TabStop = false;
            this.grpTableRecordCounts.Text = "Suppress Table Record Counts";
            // 
            // chkScenarioProcessorForm
            // 
            this.chkScenarioProcessorForm.AutoSize = true;
            this.chkScenarioProcessorForm.Location = new System.Drawing.Point(363, 25);
            this.chkScenarioProcessorForm.Name = "chkScenarioProcessorForm";
            this.chkScenarioProcessorForm.Size = new System.Drawing.Size(190, 21);
            this.chkScenarioProcessorForm.TabIndex = 6;
            this.chkScenarioProcessorForm.Text = "Processor Scenario Form";
            this.chkScenarioProcessorForm.UseVisualStyleBackColor = true;
            // 
            // chkFVSOutputForm
            // 
            this.chkFVSOutputForm.AutoSize = true;
            this.chkFVSOutputForm.Location = new System.Drawing.Point(182, 25);
            this.chkFVSOutputForm.Name = "chkFVSOutputForm";
            this.chkFVSOutputForm.Size = new System.Drawing.Size(139, 21);
            this.chkFVSOutputForm.TabIndex = 5;
            this.chkFVSOutputForm.Text = "FVS Output Form";
            this.chkFVSOutputForm.UseVisualStyleBackColor = true;
            // 
            // chkFVSInputForm
            // 
            this.chkFVSInputForm.AutoSize = true;
            this.chkFVSInputForm.Location = new System.Drawing.Point(14, 25);
            this.chkFVSInputForm.Name = "chkFVSInputForm";
            this.chkFVSInputForm.Size = new System.Drawing.Size(127, 21);
            this.chkFVSInputForm.TabIndex = 4;
            this.chkFVSInputForm.Text = "FVS Input Form";
            this.chkFVSInputForm.UseVisualStyleBackColor = true;
            // 
            // grpOpcost
            // 
            this.grpOpcost.Controls.Add(this.btnRdir);
            this.grpOpcost.Controls.Add(this.btnOpcost);
            this.grpOpcost.Controls.Add(this.txtOpcost);
            this.grpOpcost.Controls.Add(this.lblOpcostDir);
            this.grpOpcost.Controls.Add(this.txtRdir);
            this.grpOpcost.Controls.Add(this.lblRScriptDir);
            this.grpOpcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOpcost.Location = new System.Drawing.Point(19, 447);
            this.grpOpcost.Name = "grpOpcost";
            this.grpOpcost.Size = new System.Drawing.Size(1029, 186);
            this.grpOpcost.TabIndex = 5;
            this.grpOpcost.TabStop = false;
            this.grpOpcost.Text = "OPCOST";
            // 
            // btnRdir
            // 
            this.btnRdir.Image = ((System.Drawing.Image)(resources.GetObject("btnRdir.Image")));
            this.btnRdir.Location = new System.Drawing.Point(909, 42);
            this.btnRdir.Name = "btnRdir";
            this.btnRdir.Size = new System.Drawing.Size(51, 46);
            this.btnRdir.TabIndex = 37;
            this.btnRdir.Click += new System.EventHandler(this.btnRdir_Click);
            // 
            // btnOpcost
            // 
            this.btnOpcost.Image = ((System.Drawing.Image)(resources.GetObject("btnOpcost.Image")));
            this.btnOpcost.Location = new System.Drawing.Point(909, 126);
            this.btnOpcost.Name = "btnOpcost";
            this.btnOpcost.Size = new System.Drawing.Size(51, 46);
            this.btnOpcost.TabIndex = 36;
            this.btnOpcost.Click += new System.EventHandler(this.btnOpcost_Click);
            // 
            // txtOpcost
            // 
            this.txtOpcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcost.Location = new System.Drawing.Point(21, 129);
            this.txtOpcost.Name = "txtOpcost";
            this.txtOpcost.Size = new System.Drawing.Size(878, 26);
            this.txtOpcost.TabIndex = 35;
            this.txtOpcost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOpcost_KeyDown);
            this.txtOpcost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpcost_KeyPress);
            // 
            // lblOpcostDir
            // 
            this.lblOpcostDir.AutoSize = true;
            this.lblOpcostDir.Location = new System.Drawing.Point(18, 104);
            this.lblOpcostDir.Name = "lblOpcostDir";
            this.lblOpcostDir.Size = new System.Drawing.Size(287, 18);
            this.lblOpcostDir.TabIndex = 34;
            this.lblOpcostDir.Text = "Directory path of the OPCOST.R file name";
            // 
            // txtRdir
            // 
            this.txtRdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRdir.Location = new System.Drawing.Point(21, 50);
            this.txtRdir.Name = "txtRdir";
            this.txtRdir.Size = new System.Drawing.Size(878, 26);
            this.txtRdir.TabIndex = 32;
            this.txtRdir.Enter += new System.EventHandler(this.txtRdir_Enter);
            this.txtRdir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRdir_KeyDown);
            this.txtRdir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRdir_KeyPress);
            // 
            // lblRScriptDir
            // 
            this.lblRScriptDir.AutoSize = true;
            this.lblRScriptDir.Location = new System.Drawing.Point(18, 23);
            this.lblRScriptDir.Name = "lblRScriptDir";
            this.lblRScriptDir.Size = new System.Drawing.Size(318, 18);
            this.lblRScriptDir.TabIndex = 31;
            this.lblRScriptDir.Text = "Directory path of the (i386) RScript.exe location";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(374, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 50);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHelp.Location = new System.Drawing.Point(898, 18);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(150, 50);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // grpAppData
            // 
            this.grpAppData.Controls.Add(this.txtAppData);
            this.grpAppData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAppData.Location = new System.Drawing.Point(19, 381);
            this.grpAppData.Name = "grpAppData";
            this.grpAppData.Size = new System.Drawing.Size(1029, 53);
            this.grpAppData.TabIndex = 8;
            this.grpAppData.TabStop = false;
            this.grpAppData.Text = "Directory path of the BioSum settings folder";
            // 
            // txtAppData
            // 
            this.txtAppData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppData.Location = new System.Drawing.Point(17, 18);
            this.txtAppData.Name = "txtAppData";
            this.txtAppData.ReadOnly = true;
            this.txtAppData.Size = new System.Drawing.Size(882, 26);
            this.txtAppData.TabIndex = 33;
            // 
            // frmSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1116, 653);
            this.Controls.Add(this.grpAppData);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpOpcost);
            this.Controls.Add(this.grpTableRecordCounts);
            this.Controls.Add(this.grpDebug);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpGrids);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.grpGrids.ResumeLayout(false);
            this.grpDebug.ResumeLayout(false);
            this.grpDebug.PerformLayout();
            this.grpTableRecordCounts.ResumeLayout(false);
            this.grpTableRecordCounts.PerformLayout();
            this.grpOpcost.ResumeLayout(false);
            this.grpOpcost.PerformLayout();
            this.grpAppData.ResumeLayout(false);
            this.grpAppData.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
            if (saveValuesToMemory() >= 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
		}

        private int saveValuesToMemory()
        {
            //GRIDVIEW
            //
            frmMain.g_oGridViewAlternateRowBackgroundColor = this.lblGridAlternateRowBackgroundColor.BackColor;
            frmMain.g_oGridViewRowBackgroundColor = this.lblGridRowBackgroundColor.BackColor;
            frmMain.g_oGridViewBackgroundColor = this.lblGridBackgroundColor.BackColor;
            frmMain.g_oGridViewFont = this.lblGridFont.Font;
            frmMain.g_oGridViewRowForegroundColor = this.lblGridRowForegroundColor.BackColor;
            frmMain.g_oGridViewSelectedRowBackgroundColor = this.lblGridSelectedRowBackgroundColor.BackColor;
            //
            //DEBUG
            //
            frmMain.g_bDebug = chkDebug.Checked;
            if (this.cmbDebug.Text.Trim().Length > 0)
            {
                if (this.cmbDebug.Text.Substring(0, 1) == "1") frmMain.g_intDebugLevel = 1;
                if (this.cmbDebug.Text.Substring(0, 1) == "2") frmMain.g_intDebugLevel = 2;
                if (this.cmbDebug.Text.Substring(0, 1) == "3") frmMain.g_intDebugLevel = 3;
            }
            //
            //SUPPRESS TABLE RECORD COUNTS
            //
            frmMain.g_bSuppressFVSInputTableRowCount = chkFVSInputForm.Checked;
            frmMain.g_bSuppressFVSOutputTableRowCount = chkFVSOutputForm.Checked;
            frmMain.g_bSuppressProcessorScenarioTableRowCount = chkScenarioProcessorForm.Checked;
            //
            //OPCOST SETTINGS
            //
            int intSuccess = val_data();
            if (intSuccess < 0)
            {
                return intSuccess;
            }
            frmMain.g_strOPCOSTDirectory = txtOpcost.Text.Trim();
            frmMain.g_strRDirectory = txtRdir.Text.Trim();
            return 0;
        }

		private void btnGridFont_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.FontDialog frmTemp = new FontDialog();
			frmTemp.ShowColor=true;
			frmTemp.Font = this.lblGridFont.Font;
			frmTemp.Color = this.lblGridRowForegroundColor.BackColor;
			if(frmTemp.ShowDialog() != DialogResult.Cancel )
			{
				
					this.lblGridFont.Font = frmTemp.Font;
				    this.lblGridFontName.Text = frmTemp.Font.Name;
				    this.lblGridFontSize.Text = frmTemp.Font.Size.ToString().Trim();
				    this.lblGridFontStyle.Text = frmTemp.Font.Style.ToString().Trim();
				    this.lblGridRowForegroundColor.BackColor = frmTemp.Color;
				
			}
			frmTemp.Dispose();
			frmTemp=null;

		}

		private void btnGridAlternateRowBackground_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.ColorDialog frmTemp = new ColorDialog();
			if(frmTemp.ShowDialog() != DialogResult.Cancel )
			{
				this.lblGridAlternateRowBackgroundColor.BackColor = frmTemp.Color;
							
				
			}
			frmTemp.Dispose();
			frmTemp=null;

		}

		private void btnGridRowBackgroundColor_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.ColorDialog frmTemp = new ColorDialog();
			if(frmTemp.ShowDialog() != DialogResult.Cancel )
			{
				this.lblGridRowBackgroundColor.BackColor = frmTemp.Color;
			}
			frmTemp.Dispose();
			frmTemp=null;


		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;
			this.Close();
		}

		private void btnGridBackground_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.ColorDialog frmTemp = new ColorDialog();
			if(frmTemp.ShowDialog() != DialogResult.Cancel )
			{
				this.lblGridBackgroundColor.BackColor = frmTemp.Color;
							
				
			}
			frmTemp.Dispose();
			frmTemp=null;
		}

		private void btnGridSelectedRowBackgroundColor_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.ColorDialog frmTemp = new ColorDialog();
			if(frmTemp.ShowDialog() != DialogResult.Cancel )
			{
				this.lblGridSelectedRowBackgroundColor.BackColor = frmTemp.Color;
			}
			frmTemp.Dispose();
			frmTemp=null;
		
		}

        private void btnRdir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog oDialog = new OpenFileDialog();
            oDialog.Title = "32-bit version of RScript.exe File";
            oDialog.Filter = "RScript File (RScript.EXE) |RScript.EXE";
            DialogResult result = oDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtRdir.Text = oDialog.FileName;
            }
        }

        private void btnOpcost_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog oDialog = new OpenFileDialog();
            oDialog.Title = "OPCOST R File";
            oDialog.Filter = "OPCOST File (*.R) |*.r";
            DialogResult result = oDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.txtOpcost.Text = oDialog.FileName;
            }
        }

        private void txtRdir_Enter(object sender, EventArgs e)
        {

        }
        private void txtRdir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) e.SuppressKeyPress = true;

        }
        private void txtRdir_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;
        }
        private void txtOpcost_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;
        }
        private void txtOpcost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) e.SuppressKeyPress = true;
        }

        private int val_data()
        {
            if (txtRdir.Text.Trim().Length == 0)
            {
                MessageBox.Show("Specify RScript.EXE file", "FIA Biosum");
                return -1;
            }
            if (txtOpcost.Text.Trim().Length == 0)
            {
                MessageBox.Show("Specify OPCOST R file", "FIA Biosum");
                return -1;
            }

            if (System.IO.File.Exists(txtRdir.Text) == false)
            {
                MessageBox.Show("Specified RScript.EXE file not found", "FIA Biosum");
                return -1;
            }

            if (System.IO.File.Exists(txtOpcost.Text) == false)
            {
                MessageBox.Show("Specified OPCOST R file not found", "FIA Biosum");
                return -1;
            }
            return 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.saveValuesToMemory() >= 0)
            {
                frmMain.SaveSettings();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public static string GetDefaultOpcostPath()
        {
            string strReturnPath = null;
            string strDefaultOpcostDir = frmMain.g_oEnv.strAppDir.Trim() + "\\OPCOST";
            if (System.IO.Directory.Exists(strDefaultOpcostDir))
            {
                string[] arrAllFiles = System.IO.Directory.GetFiles(strDefaultOpcostDir);
                foreach (string strFullPath in arrAllFiles)
                {
                    string strExtension = System.IO.Path.GetExtension(strFullPath);
                    if (strExtension != null && strExtension.ToUpper().Equals(".R"))
                    {
                        // We only deploy the most recent .R file in the appDir/opcost folder, thus
                        // we always use the first one we find
                        strReturnPath = strDefaultOpcostDir + "\\" + System.IO.Path.GetFileName(strFullPath);
                        break;
                    }
                }

            }
            return strReturnPath;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (m_oHelp == null)
            {
                m_oHelp = new Help(m_xpsFile, m_oEnv);
            }
            m_oHelp.ShowHelp(new string[] { "MAIN", "DEBUG" });
        }
	}
}
