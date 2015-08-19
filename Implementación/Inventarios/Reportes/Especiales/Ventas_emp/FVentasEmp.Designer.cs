﻿namespace Inventarios.Reportes.Especiales.Ventas_emp
{
    partial class FVentasEmp
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
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(875, 11);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(100, 30);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 24;
            this.buttonX1.Text = "Generar reporte";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(121, 18);
            this.dtp.MaxDate = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            this.dtp.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 23;
            this.dtp.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fecha de consulta :";
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv.Location = new System.Drawing.Point(15, 62);
            this.crv.Name = "crv";
            this.crv.Size = new System.Drawing.Size(957, 624);
            this.crv.TabIndex = 21;
            this.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cb_tipo
            // 
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Texto",
            "Gráfica",
            "Ambos"});
            this.cb_tipo.Location = new System.Drawing.Point(342, 18);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(108, 21);
            this.cb_tipo.TabIndex = 33;
            // 
            // FVentasEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 701);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crv);
            this.Name = "FVentasEmp";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas por empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private System.Windows.Forms.ComboBox cb_tipo;
    }
}