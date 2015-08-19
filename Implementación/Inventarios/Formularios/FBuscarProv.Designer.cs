namespace Inventarios.Formularios
{
    partial class FBuscarProv
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
            this.sgc_prov = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.SuspendLayout();
            // 
            // sgc_prov
            // 
            this.sgc_prov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgc_prov.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.sgc_prov.Location = new System.Drawing.Point(0, 0);
            this.sgc_prov.Name = "sgc_prov";
            this.sgc_prov.PrimaryGrid.AllowEdit = false;
            this.sgc_prov.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.sgc_prov.PrimaryGrid.EnableColumnFiltering = true;
            this.sgc_prov.PrimaryGrid.EnableFiltering = true;
            this.sgc_prov.PrimaryGrid.Filter.Visible = true;
            this.sgc_prov.Size = new System.Drawing.Size(951, 529);
            this.sgc_prov.TabIndex = 0;
            this.sgc_prov.Text = "superGridControl1";
            this.sgc_prov.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.sgc_prov_RowDoubleClick);
            // 
            // FBuscarProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 529);
            this.Controls.Add(this.sgc_prov);
            this.Name = "FBuscarProv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBuscarProv";
            this.Load += new System.EventHandler(this.FBuscarProv_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl sgc_prov;
    }
}