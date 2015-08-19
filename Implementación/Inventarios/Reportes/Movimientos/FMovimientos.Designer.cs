﻿namespace Inventarios.Reportes.Movimientos
{
    partial class FMovimientos
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
            this.fecha_Fin = new System.Windows.Forms.DateTimePicker();
            this.fecha_Ini = new System.Windows.Forms.DateTimePicker();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bt_generaReporte = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // fecha_Fin
            // 
            this.fecha_Fin.Location = new System.Drawing.Point(415, 14);
            this.fecha_Fin.MaxDate = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            this.fecha_Fin.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.fecha_Fin.Name = "fecha_Fin";
            this.fecha_Fin.Size = new System.Drawing.Size(200, 20);
            this.fecha_Fin.TabIndex = 19;
            this.fecha_Fin.Value = new System.DateTime(2004, 7, 1, 0, 0, 0, 0);
            // 
            // fecha_Ini
            // 
            this.fecha_Ini.Location = new System.Drawing.Point(88, 14);
            this.fecha_Ini.MaxDate = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            this.fecha_Ini.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.fecha_Ini.Name = "fecha_Ini";
            this.fecha_Ini.Size = new System.Drawing.Size(200, 20);
            this.fecha_Ini.TabIndex = 18;
            this.fecha_Ini.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(15, 46);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(957, 640);
            this.crystalReportViewer1.TabIndex = 17;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // bt_generaReporte
            // 
            this.bt_generaReporte.Location = new System.Drawing.Point(847, 11);
            this.bt_generaReporte.Name = "bt_generaReporte";
            this.bt_generaReporte.Size = new System.Drawing.Size(128, 27);
            this.bt_generaReporte.TabIndex = 16;
            this.bt_generaReporte.Text = "Generar Reporte";
            this.bt_generaReporte.UseVisualStyleBackColor = true;
            this.bt_generaReporte.Click += new System.EventHandler(this.bt_generaReporte_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha Final :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha Inicial :";
            // 
            // cb_tipo
            // 
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Texto",
            "Gráfica",
            "Ambos"});
            this.cb_tipo.Location = new System.Drawing.Point(654, 13);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(97, 21);
            this.cb_tipo.TabIndex = 35;
            // 
            // FMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 701);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.fecha_Fin);
            this.Controls.Add(this.fecha_Ini);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.bt_generaReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FMovimientos";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos por empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha_Fin;
        private System.Windows.Forms.DateTimePicker fecha_Ini;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button bt_generaReporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_tipo;
    }
}