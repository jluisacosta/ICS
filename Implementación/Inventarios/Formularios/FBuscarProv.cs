using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.SuperGrid;

namespace Inventarios.Formularios
{
    public partial class FBuscarProv : Form
    {
        internal List<GridCell> proveedor;

        public FBuscarProv()
        {
            InitializeComponent();
        }

        private void FBuscarProv_Load(object sender, EventArgs e)
        {
            DataSet ds = Conexion.obtenerDatos("select id_proveedor as ID_PROVEEDOR, razon_social as RAZON_SOCIAL, rfc as RFC, contacto as CONTACTO, ciudad as CIUDAD, cp as CP,direccion as DIRECCION,telefono as TELEFONO, email as EMAIL FROM Proveedores");

            sgc_prov.PrimaryGrid.ClearAll();
            sgc_prov.PrimaryGrid.DataSource = ds.Tables[0];
        }
        
        private void sgc_prov_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            proveedor = sgc_prov.PrimaryGrid.GridPanel.GetSelectedRows().GetCells();
            
            if(proveedor.Count != 0)
                this.Close();
        }
    }
}
