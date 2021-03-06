﻿namespace FIA_Biosum_Manager
{
    partial class uc_optimizer_scenario_processor_scenario_select
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkFullDetails = new System.Windows.Forms.CheckBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lvProcessorScenario = new System.Windows.Forms.ListView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.colScenarioId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckBox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 457);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.chkFullDetails);
            this.panel1.Controls.Add(this.txtDetails);
            this.panel1.Controls.Add(this.lvProcessorScenario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 406);
            this.panel1.TabIndex = 28;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // chkFullDetails
            // 
            this.chkFullDetails.AutoSize = true;
            this.chkFullDetails.ForeColor = System.Drawing.Color.Black;
            this.chkFullDetails.Location = new System.Drawing.Point(12, 185);
            this.chkFullDetails.Name = "chkFullDetails";
            this.chkFullDetails.Size = new System.Drawing.Size(77, 17);
            this.chkFullDetails.TabIndex = 2;
            this.chkFullDetails.Text = "Full Details";
            this.chkFullDetails.UseVisualStyleBackColor = true;
            this.chkFullDetails.CheckedChanged += new System.EventHandler(this.chkFullDetails_CheckedChanged);
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(12, 208);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDetails.Size = new System.Drawing.Size(769, 174);
            this.txtDetails.TabIndex = 1;
            // 
            // lvProcessorScenario
            // 
            this.lvProcessorScenario.CheckBoxes = true;
            this.lvProcessorScenario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCheckBox,
            this.colScenarioId,
            this.colDesc});
            this.lvProcessorScenario.GridLines = true;
            this.lvProcessorScenario.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvProcessorScenario.Location = new System.Drawing.Point(12, 18);
            this.lvProcessorScenario.MultiSelect = false;
            this.lvProcessorScenario.Name = "lvProcessorScenario";
            this.lvProcessorScenario.Size = new System.Drawing.Size(769, 160);
            this.lvProcessorScenario.TabIndex = 0;
            this.lvProcessorScenario.UseCompatibleStateImageBehavior = false;
            this.lvProcessorScenario.View = System.Windows.Forms.View.Details;
            this.lvProcessorScenario.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvProcessorScenario_ItemCheck);
            this.lvProcessorScenario.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvProcessorScenario_ItemChecked);
            this.lvProcessorScenario.SelectedIndexChanged += new System.EventHandler(this.lvProcessorScenario_SelectedIndexChanged);
            this.lvProcessorScenario.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvProcessorScenario_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Green;
            this.lblTitle.Location = new System.Drawing.Point(3, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(798, 32);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Processor Scenario";
            // 
            // colScenarioId
            // 
            this.colScenarioId.Text = "Scenario_Id";
            this.colScenarioId.Width = 121;
            // 
            // colDesc
            // 
            this.colDesc.Text = "Description";
            this.colDesc.Width = 619;
            // 
            // colCheckBox
            // 
            this.colCheckBox.Text = "";
            this.colCheckBox.Width = 31;
            // 
            // uc_scenario_processor_scenario_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "uc_scenario_processor_scenario_select";
            this.Size = new System.Drawing.Size(804, 457);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.ListView lvProcessorScenario;
        private System.Windows.Forms.CheckBox chkFullDetails;
        private System.Windows.Forms.ColumnHeader colScenarioId;
        private System.Windows.Forms.ColumnHeader colDesc;
        private System.Windows.Forms.ColumnHeader colCheckBox;
    }
}
