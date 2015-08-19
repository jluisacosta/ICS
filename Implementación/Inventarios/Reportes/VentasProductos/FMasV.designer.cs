﻿namespace Inventarios.Reportes.Movimientos
{
    partial class FMasV
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_mmv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_n = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv.Location = new System.Drawing.Point(15, 55);
            this.crv.Name = "crv";
            this.crv.Size = new System.Drawing.Size(957, 631);
            this.crv.TabIndex = 0;
            this.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(370, 19);
            this.dtp2.MaxDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dtp2.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 20);
            this.dtp2.TabIndex = 12;
            this.dtp2.Value = new System.DateTime(2004, 2, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha final :";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(875, 12);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(100, 30);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 10;
            this.buttonX1.Text = "Generar reporte";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(90, 19);
            this.dtp.MaxDate = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            this.dtp.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 9;
            this.dtp.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha inicial :";
            // 
            // cb_mmv
            // 
            this.cb_mmv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mmv.FormattingEnabled = true;
            this.cb_mmv.Items.AddRange(new object[] {
            "Top",
            "Less"});
            this.cb_mmv.Location = new System.Drawing.Point(590, 19);
            this.cb_mmv.Name = "cb_mmv";
            this.cb_mmv.Size = new System.Drawing.Size(121, 21);
            this.cb_mmv.TabIndex = 13;
            this.cb_mmv.SelectedIndexChanged += new System.EventHandler(this.cb_mmv_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(730, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "N  :";
            // 
            // tb_n
            // 
            this.tb_n.Location = new System.Drawing.Point(760, 19);
            this.tb_n.Name = "tb_n";
            this.tb_n.Size = new System.Drawing.Size(54, 20);
            this.tb_n.TabIndex = 16;
            // 
            // FMasV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 701);
            this.Controls.Add(this.tb_n);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_mmv);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crv);
            this.Name = "FMasV";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos más y menos vendidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_mmv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_n;
    }
}