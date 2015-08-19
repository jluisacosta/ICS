namespace Inventarios.Formularios
{
    partial class FPrincipal
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsb_prov = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_productos = new System.Windows.Forms.ToolStripButton();
            this.tsb_mp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_orden_comp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsp_ventas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsb_prov,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.tsb_productos,
            this.tsb_mp,
            this.toolStripSeparator2,
            this.tsb_orden_comp,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton8,
            this.toolStripSeparator4,
            this.tsp_ventas,
            this.toolStripSeparator5,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(123, 766);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Inventarios.Properties.Resources.cliente;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(120, 65);
            this.toolStripButton1.Text = "Clientes";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsb_prov
            // 
            this.tsb_prov.Image = global::Inventarios.Properties.Resources.prove;
            this.tsb_prov.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_prov.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_prov.Name = "tsb_prov";
            this.tsb_prov.Size = new System.Drawing.Size(120, 64);
            this.tsb_prov.Text = "Proveedores";
            this.tsb_prov.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_prov.Click += new System.EventHandler(this.tsb_prov_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::Inventarios.Properties.Resources.Empleados;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(120, 65);
            this.toolStripButton3.Text = "Empleados";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // tsb_productos
            // 
            this.tsb_productos.Image = global::Inventarios.Properties.Resources.strawberry_cake_icon;
            this.tsb_productos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_productos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_productos.Name = "tsb_productos";
            this.tsb_productos.Size = new System.Drawing.Size(120, 65);
            this.tsb_productos.Text = "Productos";
            this.tsb_productos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_productos.Click += new System.EventHandler(this.tsb_productos_Click);
            // 
            // tsb_mp
            // 
            this.tsb_mp.Image = global::Inventarios.Properties.Resources.mp;
            this.tsb_mp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_mp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_mp.Name = "tsb_mp";
            this.tsb_mp.Size = new System.Drawing.Size(120, 65);
            this.tsb_mp.Text = "Materias Primas";
            this.tsb_mp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_mp.Click += new System.EventHandler(this.tsb_mp_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(120, 6);
            // 
            // tsb_orden_comp
            // 
            this.tsb_orden_comp.Image = global::Inventarios.Properties.Resources.orden_compra;
            this.tsb_orden_comp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsb_orden_comp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_orden_comp.Name = "tsb_orden_comp";
            this.tsb_orden_comp.Size = new System.Drawing.Size(120, 65);
            this.tsb_orden_comp.Text = "Ordenes de Compra";
            this.tsb_orden_comp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_orden_comp.Click += new System.EventHandler(this.tsb_orden_comp_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::Inventarios.Properties.Resources.First_Year_Production_icon;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(120, 65);
            this.toolStripButton4.Text = "Ordenes de Producción";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(120, 6);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = global::Inventarios.Properties.Resources.movs;
            this.toolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(120, 65);
            this.toolStripButton8.Text = "Movimientos";
            this.toolStripButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(120, 6);
            // 
            // tsp_ventas
            // 
            this.tsp_ventas.Image = global::Inventarios.Properties.Resources.caja;
            this.tsp_ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsp_ventas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsp_ventas.Name = "tsp_ventas";
            this.tsp_ventas.Size = new System.Drawing.Size(120, 65);
            this.tsp_ventas.Text = "Ventas";
            this.tsp_ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsp_ventas.Click += new System.EventHandler(this.tsp_ventas_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(120, 6);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Inventarios.Properties.Resources.reportes_grafic;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(120, 65);
            this.toolStripButton2.Text = "Reportes";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 766);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capela Bakery - Sistema de control de inventarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tsb_prov;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton tsb_orden_comp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton tsb_productos;
        private System.Windows.Forms.ToolStripButton tsb_mp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsp_ventas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}