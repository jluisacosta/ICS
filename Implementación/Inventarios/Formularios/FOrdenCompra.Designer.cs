﻿namespace Inventarios.Formularios
{
    partial class FOrdenCompra
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.reflectionLabel4 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.tb_idemp = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reflectionLabel3 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.tb_nombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reflectionLabel2 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.dti_fecha = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_dir = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_razon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_idprov = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.b_buscar = new DevComponents.DotNetBar.ButtonX();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_rfc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_tel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.sgc_mp = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.sgc_detalle = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.tb_subtotal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_iva = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_total = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.reflectionLabel5 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.reflectionLabel6 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.reflectionLabel7 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.b_mod_cant = new DevComponents.DotNetBar.ButtonX();
            this.b_agregar = new DevComponents.DotNetBar.ButtonX();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.b_imprimir = new DevComponents.DotNetBar.ButtonX();
            this.b_cancelar = new DevComponents.DotNetBar.ButtonX();
            this.tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dti_fecha)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupPanel3.SuspendLayout();
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
            this.tlp.Controls.Add(this.groupPanel3, 0, 1);
            this.tlp.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.Location = new System.Drawing.Point(15, 15);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 3;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.Size = new System.Drawing.Size(986, 736);
            this.tlp.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.groupPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(980, 141);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.White;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.reflectionLabel4);
            this.groupPanel2.Controls.Add(this.tb_idemp);
            this.groupPanel2.Controls.Add(this.reflectionLabel3);
            this.groupPanel2.Controls.Add(this.tb_nombre);
            this.groupPanel2.Controls.Add(this.reflectionLabel2);
            this.groupPanel2.Controls.Add(this.dti_fecha);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.DrawTitleBox = false;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(300, 141);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            // 
            // reflectionLabel4
            // 
            this.reflectionLabel4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel4.Location = new System.Drawing.Point(32, 25);
            this.reflectionLabel4.Name = "reflectionLabel4";
            this.reflectionLabel4.Size = new System.Drawing.Size(83, 22);
            this.reflectionLabel4.TabIndex = 8;
            this.reflectionLabel4.Text = "ID Empleado :";
            // 
            // tb_idemp
            // 
            this.tb_idemp.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_idemp.Border.Class = "TextBoxBorder";
            this.tb_idemp.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_idemp.ForeColor = System.Drawing.Color.Black;
            this.tb_idemp.Location = new System.Drawing.Point(121, 25);
            this.tb_idemp.Name = "tb_idemp";
            this.tb_idemp.PreventEnterBeep = true;
            this.tb_idemp.Size = new System.Drawing.Size(140, 20);
            this.tb_idemp.TabIndex = 7;
            this.tb_idemp.Text = "1";
            // 
            // reflectionLabel3
            // 
            this.reflectionLabel3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.reflectionLabel3.Location = new System.Drawing.Point(61, 55);
            this.reflectionLabel3.Name = "reflectionLabel3";
            this.reflectionLabel3.Size = new System.Drawing.Size(54, 22);
            this.reflectionLabel3.TabIndex = 6;
            this.reflectionLabel3.Text = "Nombre :";
            // 
            // tb_nombre
            // 
            this.tb_nombre.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_nombre.Border.Class = "TextBoxBorder";
            this.tb_nombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_nombre.ForeColor = System.Drawing.Color.Black;
            this.tb_nombre.Location = new System.Drawing.Point(121, 55);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.PreventEnterBeep = true;
            this.tb_nombre.Size = new System.Drawing.Size(140, 20);
            this.tb_nombre.TabIndex = 5;
            this.tb_nombre.Text = "Pepito";
            // 
            // reflectionLabel2
            // 
            this.reflectionLabel2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.reflectionLabel2.Location = new System.Drawing.Point(69, 85);
            this.reflectionLabel2.Name = "reflectionLabel2";
            this.reflectionLabel2.Size = new System.Drawing.Size(48, 27);
            this.reflectionLabel2.TabIndex = 4;
            this.reflectionLabel2.Text = "Fecha :";
            // 
            // dti_fecha
            // 
            // 
            // 
            // 
            this.dti_fecha.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dti_fecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_fecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dti_fecha.ButtonDropDown.Visible = true;
            this.dti_fecha.IsPopupCalendarOpen = false;
            this.dti_fecha.Location = new System.Drawing.Point(121, 85);
            // 
            // 
            // 
            this.dti_fecha.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dti_fecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_fecha.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dti_fecha.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dti_fecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dti_fecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_fecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dti_fecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dti_fecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dti_fecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dti_fecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_fecha.MonthCalendar.DisplayMonth = new System.DateTime(2014, 3, 1, 0, 0, 0, 0);
            this.dti_fecha.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dti_fecha.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dti_fecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dti_fecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dti_fecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dti_fecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dti_fecha.MonthCalendar.TodayButtonVisible = true;
            this.dti_fecha.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dti_fecha.Name = "dti_fecha";
            this.dti_fecha.Size = new System.Drawing.Size(140, 20);
            this.dti_fecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dti_fecha.TabIndex = 1;
            this.dti_fecha.Value = new System.DateTime(2014, 5, 1, 0, 0, 0, 0);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.tableLayoutPanel1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.groupPanel1.Size = new System.Drawing.Size(676, 141);
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
            this.groupPanel1.Text = "Datos del Proveedor";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tb_dir, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 90);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_dir
            // 
            this.tb_dir.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_dir.Border.Class = "TextBoxBorder";
            this.tb_dir.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_dir.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_dir.ForeColor = System.Drawing.Color.Black;
            this.tb_dir.Location = new System.Drawing.Point(3, 33);
            this.tb_dir.Name = "tb_dir";
            this.tb_dir.PreventEnterBeep = true;
            this.tb_dir.Size = new System.Drawing.Size(634, 20);
            this.tb_dir.TabIndex = 10;
            this.tb_dir.WatermarkText = "Dirección";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.tb_razon, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_idprov, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.b_buscar, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(640, 30);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tb_razon
            // 
            this.tb_razon.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_razon.Border.Class = "TextBoxBorder";
            this.tb_razon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_razon.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_razon.ForeColor = System.Drawing.Color.Black;
            this.tb_razon.Location = new System.Drawing.Point(131, 3);
            this.tb_razon.Name = "tb_razon";
            this.tb_razon.PreventEnterBeep = true;
            this.tb_razon.Size = new System.Drawing.Size(314, 20);
            this.tb_razon.TabIndex = 12;
            this.tb_razon.WatermarkText = "Razón Social";
            // 
            // tb_idprov
            // 
            this.tb_idprov.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_idprov.Border.Class = "TextBoxBorder";
            this.tb_idprov.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_idprov.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_idprov.ForeColor = System.Drawing.Color.Black;
            this.tb_idprov.Location = new System.Drawing.Point(3, 3);
            this.tb_idprov.Name = "tb_idprov";
            this.tb_idprov.PreventEnterBeep = true;
            this.tb_idprov.Size = new System.Drawing.Size(122, 20);
            this.tb_idprov.TabIndex = 9;
            this.tb_idprov.WatermarkText = "ID";
            // 
            // b_buscar
            // 
            this.b_buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.b_buscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.b_buscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.b_buscar.Location = new System.Drawing.Point(451, 3);
            this.b_buscar.Name = "b_buscar";
            this.b_buscar.Size = new System.Drawing.Size(186, 23);
            this.b_buscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.b_buscar.TabIndex = 11;
            this.b_buscar.Text = "Buscar";
            this.b_buscar.Click += new System.EventHandler(this.b_buscar_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tb_rfc, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_tel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(640, 30);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tb_rfc
            // 
            this.tb_rfc.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_rfc.Border.Class = "TextBoxBorder";
            this.tb_rfc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_rfc.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_rfc.ForeColor = System.Drawing.Color.Black;
            this.tb_rfc.Location = new System.Drawing.Point(323, 3);
            this.tb_rfc.Name = "tb_rfc";
            this.tb_rfc.PreventEnterBeep = true;
            this.tb_rfc.Size = new System.Drawing.Size(314, 20);
            this.tb_rfc.TabIndex = 11;
            this.tb_rfc.WatermarkText = "RFC";
            // 
            // tb_tel
            // 
            this.tb_tel.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_tel.Border.Class = "TextBoxBorder";
            this.tb_tel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_tel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_tel.ForeColor = System.Drawing.Color.Black;
            this.tb_tel.Location = new System.Drawing.Point(3, 3);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.PreventEnterBeep = true;
            this.tb_tel.Size = new System.Drawing.Size(314, 20);
            this.tb_tel.TabIndex = 10;
            this.tb_tel.WatermarkText = "Teléfono";
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.Color.White;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.sgc_mp);
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel3.Location = new System.Drawing.Point(3, 150);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Padding = new System.Windows.Forms.Padding(15);
            this.groupPanel3.Size = new System.Drawing.Size(980, 214);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 1;
            this.groupPanel3.Text = "Materia prima";
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
            this.sgc_mp.Size = new System.Drawing.Size(944, 163);
            this.sgc_mp.TabIndex = 0;
            this.sgc_mp.Text = "superGridControl1";
            this.sgc_mp.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.sgc_mp_RowDoubleClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupPanel4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 370);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(980, 363);
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
            this.groupPanel4.Size = new System.Drawing.Size(974, 302);
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
            this.groupPanel4.Text = "Detalle de compra";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Controls.Add(this.sgc_detalle, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tb_subtotal, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tb_iva, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tb_total, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.reflectionLabel5, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.reflectionLabel6, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.reflectionLabel7, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(938, 251);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // sgc_detalle
            // 
            this.sgc_detalle.BackColor = System.Drawing.Color.White;
            this.sgc_detalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgc_detalle.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.sgc_detalle.ForeColor = System.Drawing.Color.Black;
            this.sgc_detalle.Location = new System.Drawing.Point(3, 3);
            this.sgc_detalle.Name = "sgc_detalle";
            this.sgc_detalle.PrimaryGrid.AllowEdit = false;
            this.sgc_detalle.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl);
            gridColumn1.HeaderText = "CANTIDAD";
            gridColumn1.Name = "";
            gridColumn2.HeaderText = "ID_MATERIA";
            gridColumn2.Name = "";
            gridColumn3.HeaderText = "NOMBRE";
            gridColumn3.Name = "";
            gridColumn4.HeaderText = "PRECIO";
            gridColumn4.Name = "";
            gridColumn5.HeaderText = "IMPORTE";
            gridColumn5.Name = "";
            this.sgc_detalle.PrimaryGrid.Columns.Add(gridColumn1);
            this.sgc_detalle.PrimaryGrid.Columns.Add(gridColumn2);
            this.sgc_detalle.PrimaryGrid.Columns.Add(gridColumn3);
            this.sgc_detalle.PrimaryGrid.Columns.Add(gridColumn4);
            this.sgc_detalle.PrimaryGrid.Columns.Add(gridColumn5);
            this.sgc_detalle.PrimaryGrid.EnableColumnFiltering = true;
            this.sgc_detalle.PrimaryGrid.EnableFiltering = true;
            this.sgc_detalle.Size = new System.Drawing.Size(838, 169);
            this.sgc_detalle.TabIndex = 1;
            this.sgc_detalle.Text = "superGridControl2";
            this.sgc_detalle.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.sgc_detalle_RowDoubleClick);
            // 
            // tb_subtotal
            // 
            this.tb_subtotal.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_subtotal.Border.Class = "TextBoxBorder";
            this.tb_subtotal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_subtotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.tb_subtotal.ForeColor = System.Drawing.Color.Black;
            this.tb_subtotal.Location = new System.Drawing.Point(730, 178);
            this.tb_subtotal.Name = "tb_subtotal";
            this.tb_subtotal.PreventEnterBeep = true;
            this.tb_subtotal.Size = new System.Drawing.Size(111, 20);
            this.tb_subtotal.TabIndex = 2;
            this.tb_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_iva
            // 
            this.tb_iva.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_iva.Border.Class = "TextBoxBorder";
            this.tb_iva.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_iva.Dock = System.Windows.Forms.DockStyle.Right;
            this.tb_iva.ForeColor = System.Drawing.Color.Black;
            this.tb_iva.Location = new System.Drawing.Point(730, 203);
            this.tb_iva.Name = "tb_iva";
            this.tb_iva.PreventEnterBeep = true;
            this.tb_iva.Size = new System.Drawing.Size(111, 20);
            this.tb_iva.TabIndex = 3;
            this.tb_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_total
            // 
            this.tb_total.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_total.Border.Class = "TextBoxBorder";
            this.tb_total.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_total.Dock = System.Windows.Forms.DockStyle.Right;
            this.tb_total.ForeColor = System.Drawing.Color.Black;
            this.tb_total.Location = new System.Drawing.Point(730, 228);
            this.tb_total.Name = "tb_total";
            this.tb_total.PreventEnterBeep = true;
            this.tb_total.Size = new System.Drawing.Size(111, 20);
            this.tb_total.TabIndex = 4;
            this.tb_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // reflectionLabel5
            // 
            this.reflectionLabel5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.reflectionLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel5.Location = new System.Drawing.Point(847, 178);
            this.reflectionLabel5.Name = "reflectionLabel5";
            this.reflectionLabel5.Size = new System.Drawing.Size(83, 19);
            this.reflectionLabel5.TabIndex = 9;
            this.reflectionLabel5.Text = "Subtotal";
            // 
            // reflectionLabel6
            // 
            this.reflectionLabel6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.reflectionLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel6.Location = new System.Drawing.Point(847, 203);
            this.reflectionLabel6.Name = "reflectionLabel6";
            this.reflectionLabel6.Size = new System.Drawing.Size(83, 19);
            this.reflectionLabel6.TabIndex = 10;
            this.reflectionLabel6.Text = "I.V.A.";
            // 
            // reflectionLabel7
            // 
            this.reflectionLabel7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.reflectionLabel7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.reflectionLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel7.Location = new System.Drawing.Point(847, 228);
            this.reflectionLabel7.Name = "reflectionLabel7";
            this.reflectionLabel7.Size = new System.Drawing.Size(83, 20);
            this.reflectionLabel7.TabIndex = 11;
            this.reflectionLabel7.Text = "Total";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.b_mod_cant, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.b_agregar, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(847, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(88, 100);
            this.tableLayoutPanel6.TabIndex = 12;
            // 
            // b_mod_cant
            // 
            this.b_mod_cant.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.b_mod_cant.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.b_mod_cant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_mod_cant.Location = new System.Drawing.Point(3, 53);
            this.b_mod_cant.Name = "b_mod_cant";
            this.b_mod_cant.Size = new System.Drawing.Size(82, 44);
            this.b_mod_cant.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.b_mod_cant.TabIndex = 1;
            this.b_mod_cant.Text = "Eliminar";
            // 
            // b_agregar
            // 
            this.b_agregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.b_agregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.b_agregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_agregar.Location = new System.Drawing.Point(3, 3);
            this.b_agregar.Name = "b_agregar";
            this.b_agregar.Size = new System.Drawing.Size(82, 44);
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
            this.tableLayoutPanel7.Controls.Add(this.b_imprimir, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.b_cancelar, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(577, 311);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(400, 49);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // b_imprimir
            // 
            this.b_imprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.b_imprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.b_imprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_imprimir.Location = new System.Drawing.Point(203, 3);
            this.b_imprimir.Name = "b_imprimir";
            this.b_imprimir.Size = new System.Drawing.Size(194, 43);
            this.b_imprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.b_imprimir.TabIndex = 2;
            this.b_imprimir.Text = "Imprimir";
            this.b_imprimir.Click += new System.EventHandler(this.b_imprimir_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.b_cancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.b_cancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_cancelar.Location = new System.Drawing.Point(3, 3);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(194, 43);
            this.b_cancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.b_cancelar.TabIndex = 1;
            this.b_cancelar.Text = "Cancelar";
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // FOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 766);
            this.Controls.Add(this.tlp);
            this.Name = "FOrdenCompra";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de compra";
            this.Load += new System.EventHandler(this.FOrdenCompra_Load);
            this.tlp.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dti_fecha)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
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
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel4;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_idemp;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel3;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_nombre;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dti_fecha;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_dir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_idprov;
        private DevComponents.DotNetBar.ButtonX b_buscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_rfc;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_tel;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl sgc_mp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl sgc_detalle;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_subtotal;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_iva;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_total;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel5;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel6;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private DevComponents.DotNetBar.ButtonX b_imprimir;
        private DevComponents.DotNetBar.ButtonX b_cancelar;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_razon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private DevComponents.DotNetBar.ButtonX b_agregar;
        private DevComponents.DotNetBar.ButtonX b_mod_cant;
    }
}