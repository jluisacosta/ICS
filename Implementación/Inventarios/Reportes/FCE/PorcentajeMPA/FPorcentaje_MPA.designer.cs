namespace Inventarios.Reportes.Gerenciales.Porcentaje_MP_Almacen
{
    partial class FPorcentaje_MPA
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
            this.label3 = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.btn_gr = new DevComponents.DotNetBar.ButtonX();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tipo de Reporte";
            // 
            // cb_tipo
            // 
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Texto",
            "Gráfica",
            "Ambos"});
            this.cb_tipo.Location = new System.Drawing.Point(108, 18);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(139, 21);
            this.cb_tipo.TabIndex = 37;
            // 
            // btn_gr
            // 
            this.btn_gr.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_gr.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_gr.Location = new System.Drawing.Point(849, 18);
            this.btn_gr.Name = "btn_gr";
            this.btn_gr.Size = new System.Drawing.Size(123, 30);
            this.btn_gr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_gr.TabIndex = 36;
            this.btn_gr.Text = "Generar reporte";
            this.btn_gr.Click += new System.EventHandler(this.btn_gr_Click);
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv.Location = new System.Drawing.Point(15, 61);
            this.crv.Name = "crv";
            this.crv.Size = new System.Drawing.Size(957, 625);
            this.crv.TabIndex = 39;
            this.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FPorcentaje_MPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 701);
            this.Controls.Add(this.crv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.btn_gr);
            this.Name = "FPorcentaje_MPA";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Porcentaje de materia prima en almacén";
            this.Load += new System.EventHandler(this.FPorcentaje_MPA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tipo;
        private DevComponents.DotNetBar.ButtonX btn_gr;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
    }
}