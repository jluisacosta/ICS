namespace Inventarios.Formularios
{
    partial class FAgregaMateria
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn13 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn14 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn15 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn16 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gp_prod = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pb_producto = new System.Windows.Forms.PictureBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.sgc_mp = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.sgc_receta = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.b_eliminar = new DevComponents.DotNetBar.ButtonX();
            this.b_agregar = new DevComponents.DotNetBar.ButtonX();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.b_aceptar = new DevComponents.DotNetBar.ButtonX();
            this.b_cancelar = new DevComponents.DotNetBar.ButtonX();
            this.tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gp_prod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_producto)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 1;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp.Controls.Add(this.splitContainer1, 0, 0);
            this.tlp.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.Location = new System.Drawing.Point(15, 15);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 2;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.50835F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.49165F));
            this.tlp.Size = new System.Drawing.Size(865, 659);
            this.tlp.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gp_prod);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(859, 228);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // gp_prod
            // 
            this.gp_prod.BackColor = System.Drawing.Color.White;
            this.gp_prod.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp_prod.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp_prod.Controls.Add(this.pb_producto);
            this.gp_prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gp_prod.Location = new System.Drawing.Point(0, 0);
            this.gp_prod.Name = "gp_prod";
            this.gp_prod.Padding = new System.Windows.Forms.Padding(15);
            this.gp_prod.Size = new System.Drawing.Size(300, 228);
            // 
            // 
            // 
            this.gp_prod.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp_prod.Style.BackColorGradientAngle = 90;
            this.gp_prod.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp_prod.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_prod.Style.BorderBottomWidth = 1;
            this.gp_prod.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp_prod.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_prod.Style.BorderLeftWidth = 1;
            this.gp_prod.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_prod.Style.BorderRightWidth = 1;
            this.gp_prod.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp_prod.Style.BorderTopWidth = 1;
            this.gp_prod.Style.CornerDiameter = 4;
            this.gp_prod.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp_prod.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp_prod.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp_prod.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp_prod.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp_prod.TabIndex = 1;
            this.gp_prod.Text = "Producto";
            // 
            // pb_producto
            // 
            this.pb_producto.BackColor = System.Drawing.Color.Transparent;
            this.pb_producto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_producto.Location = new System.Drawing.Point(15, 15);
            this.pb_producto.Name = "pb_producto";
            this.pb_producto.Size = new System.Drawing.Size(264, 177);
            this.pb_producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_producto.TabIndex = 1;
            this.pb_producto.TabStop = false;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.sgc_mp);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.groupPanel1.Size = new System.Drawing.Size(555, 228);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Materias primas";
            // 
            // sgc_mp
            // 
            this.sgc_mp.BackColor = System.Drawing.Color.White;
            this.sgc_mp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgc_mp.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.sgc_mp.ForeColor = System.Drawing.Color.Black;
            this.sgc_mp.Location = new System.Drawing.Point(15, 15);
            this.sgc_mp.Name = "sgc_mp";
            this.sgc_mp.PrimaryGrid.AllowEdit = false;
            this.sgc_mp.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.sgc_mp.PrimaryGrid.EnableColumnFiltering = true;
            this.sgc_mp.PrimaryGrid.EnableFiltering = true;
            this.sgc_mp.PrimaryGrid.Filter.Visible = true;
            this.sgc_mp.Size = new System.Drawing.Size(519, 177);
            this.sgc_mp.TabIndex = 2;
            this.sgc_mp.Text = "superGridControl2";
            this.sgc_mp.RowClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs>(this.sgc_mp_RowClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupPanel4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 237);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.2093F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7907F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(859, 419);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // groupPanel4
            // 
            this.groupPanel4.BackColor = System.Drawing.Color.White;
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.tableLayoutPanel5);
            this.groupPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel4.Location = new System.Drawing.Point(3, 3);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Padding = new System.Windows.Forms.Padding(15);
            this.groupPanel4.Size = new System.Drawing.Size(853, 359);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 2;
            this.groupPanel4.Text = "Agregados a receta";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.46334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.53666F));
            this.tableLayoutPanel5.Controls.Add(this.sgc_receta, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(817, 308);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // sgc_receta
            // 
            this.sgc_receta.BackColor = System.Drawing.Color.White;
            this.sgc_receta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgc_receta.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.sgc_receta.ForeColor = System.Drawing.Color.Black;
            this.sgc_receta.Location = new System.Drawing.Point(3, 3);
            this.sgc_receta.Name = "sgc_receta";
            this.sgc_receta.PrimaryGrid.AllowEdit = false;
            this.sgc_receta.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn13.HeaderText = "CANTIDAD(kg)";
            gridColumn13.Name = "";
            gridColumn14.HeaderText = "ID_MATERIA";
            gridColumn14.Name = "";
            gridColumn15.HeaderText = "NOMBRE";
            gridColumn15.Name = "";
            gridColumn16.HeaderText = "DESCRIPCION";
            gridColumn16.Name = "";
            this.sgc_receta.PrimaryGrid.Columns.Add(gridColumn13);
            this.sgc_receta.PrimaryGrid.Columns.Add(gridColumn14);
            this.sgc_receta.PrimaryGrid.Columns.Add(gridColumn15);
            this.sgc_receta.PrimaryGrid.Columns.Add(gridColumn16);
            this.sgc_receta.Size = new System.Drawing.Size(675, 302);
            this.sgc_receta.TabIndex = 1;
            this.sgc_receta.Text = "superGridControl2";
            this.sgc_receta.RowClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs>(this.sgc_receta_RowClick);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.b_eliminar, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.b_agregar, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(684, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(130, 100);
            this.tableLayoutPanel6.TabIndex = 12;
            // 
            // b_eliminar
            // 
            this.b_eliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.b_eliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.b_eliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_eliminar.Location = new System.Drawing.Point(3, 53);
            this.b_eliminar.Name = "b_eliminar";
            this.b_eliminar.Size = new System.Drawing.Size(124, 44);
            this.b_eliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.b_eliminar.TabIndex = 1;
            this.b_eliminar.Text = "Eliminar";
            this.b_eliminar.Click += new System.EventHandler(this.b_eliminar_Click);
            // 
            // b_agregar
            // 
            this.b_agregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.b_agregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.b_agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_agregar.Location = new System.Drawing.Point(3, 3);
            this.b_agregar.Name = "b_agregar";
            this.b_agregar.Size = new System.Drawing.Size(124, 44);
            this.b_agregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.b_agregar.TabIndex = 0;
            this.b_agregar.Text = "Agregar";
            this.b_agregar.Click += new System.EventHandler(this.b_agregar_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.b_aceptar, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.b_cancelar, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(456, 368);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(400, 48);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // b_aceptar
            // 
            this.b_aceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.b_aceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.b_aceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_aceptar.Location = new System.Drawing.Point(205, 5);
            this.b_aceptar.Margin = new System.Windows.Forms.Padding(5);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(190, 38);
            this.b_aceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.b_aceptar.TabIndex = 2;
            this.b_aceptar.Text = "Aceptar";
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.b_cancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.b_cancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_cancelar.Location = new System.Drawing.Point(5, 5);
            this.b_cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(190, 38);
            this.b_cancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.b_cancelar.TabIndex = 1;
            this.b_cancelar.Text = "Cancelar";
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // FAgregaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 689);
            this.Controls.Add(this.tlp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FAgregaMateria";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar materia prima a producto";
            this.Load += new System.EventHandler(this.FAgregaMateria_Load);
            this.tlp.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gp_prod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_producto)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl sgc_receta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private DevComponents.DotNetBar.ButtonX b_eliminar;
        private DevComponents.DotNetBar.ButtonX b_agregar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private DevComponents.DotNetBar.ButtonX b_aceptar;
        private DevComponents.DotNetBar.ButtonX b_cancelar;
        private DevComponents.DotNetBar.Controls.GroupPanel gp_prod;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl sgc_mp;
        internal System.Windows.Forms.PictureBox pb_producto;
    }
}