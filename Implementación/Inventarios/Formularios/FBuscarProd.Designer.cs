namespace Inventarios.Formularios
{
    partial class FBuscarProd
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
            this.sgc_prod = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.SuspendLayout();
            // 
            // sgc_prod
            // 
            this.sgc_prod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgc_prod.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.sgc_prod.Location = new System.Drawing.Point(0, 0);
            this.sgc_prod.Name = "sgc_prod";
            this.sgc_prod.PrimaryGrid.AllowEdit = false;
            this.sgc_prod.PrimaryGrid.ColumnAutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.sgc_prod.PrimaryGrid.EnableColumnFiltering = true;
            this.sgc_prod.PrimaryGrid.EnableFiltering = true;
            this.sgc_prod.PrimaryGrid.Filter.Visible = true;
            this.sgc_prod.Size = new System.Drawing.Size(891, 504);
            this.sgc_prod.TabIndex = 1;
            this.sgc_prod.Text = "superGridControl1";
            this.sgc_prod.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.sgc_prod_RowDoubleClick);
            // 
            // FBuscarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 504);
            this.Controls.Add(this.sgc_prod);
            this.Name = "FBuscarProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBuscarProd";
            this.Load += new System.EventHandler(this.FBuscarProd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl sgc_prod;
    }
}