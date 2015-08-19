namespace Inventarios.Reportes.Gerenciales.Gasto_prom_insumos
{
    partial class FGasto_PI
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
            this.dtp_i = new System.Windows.Forms.DateTimePicker();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_gr = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_f = new System.Windows.Forms.DateTimePicker();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_i
            // 
            this.dtp_i.Location = new System.Drawing.Point(110, 25);
            this.dtp_i.MaxDate = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            this.dtp_i.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dtp_i.Name = "dtp_i";
            this.dtp_i.Size = new System.Drawing.Size(200, 20);
            this.dtp_i.TabIndex = 24;
            this.dtp_i.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv.Location = new System.Drawing.Point(15, 58);
            this.crv.Name = "crv";
            this.crv.Size = new System.Drawing.Size(957, 628);
            this.crv.TabIndex = 25;
            this.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btn_gr
            // 
            this.btn_gr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gr.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gr.Location = new System.Drawing.Point(860, 18);
            this.btn_gr.Name = "btn_gr";
            this.btn_gr.Size = new System.Drawing.Size(112, 30);
            this.btn_gr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gr.TabIndex = 27;
            this.btn_gr.Text = "Generar reporte";
            this.btn_gr.Click += new System.EventHandler(this.btn_gr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Fecha de Inicio :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fecha de Final :";
            // 
            // dtp_f
            // 
            this.dtp_f.Location = new System.Drawing.Point(405, 25);
            this.dtp_f.MaxDate = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            this.dtp_f.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dtp_f.Name = "dtp_f";
            this.dtp_f.Size = new System.Drawing.Size(200, 20);
            this.dtp_f.TabIndex = 28;
            this.dtp_f.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // cb_tipo
            // 
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Texto",
            "Gráfica",
            "Ambos"});
            this.cb_tipo.Location = new System.Drawing.Point(701, 25);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(108, 21);
            this.cb_tipo.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tipo de Reporte";
            // 
            // FGasto_PI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 701);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_f);
            this.Controls.Add(this.btn_gr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crv);
            this.Controls.Add(this.dtp_i);
            this.Name = "FGasto_PI";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gasto promedio de insumos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_i;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private DevComponents.DotNetBar.ButtonX btn_gr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_f;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Label label3;
    }
}