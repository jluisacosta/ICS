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
    public partial class FBuscarProd : Form
    {
        internal List<GridCell> producto;

        public FBuscarProd()
        {
            InitializeComponent();
        }

        private void FBuscarProd_Load(object sender, EventArgs e)
        {
            DataSet ds = Conexion.obtenerDatos("select id_producto as ID_PRODUCTO, categoria as CATEGORIA, nombre as NOMBRE, descripcion as DESCRIPCION, precio as PRECIO, stock as STOCK, stock_minimo as STOCK_MINIMO,stock_maximo as STOCK_MAXIMO, unidad as UNIDAD FROM Productos");

            sgc_prod.PrimaryGrid.ClearAll();
            sgc_prod.PrimaryGrid.DataSource = ds.Tables[0];
        }

        private void sgc_prod_RowDoubleClick(object sender, DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs e)
        {
            producto = sgc_prod.PrimaryGrid.GridPanel.GetSelectedRows().GetCells();

            if (producto.Count != 0)
                this.Close();
        }
    }
}
