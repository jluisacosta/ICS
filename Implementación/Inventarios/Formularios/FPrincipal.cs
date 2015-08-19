using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventarios.Formularios
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FClientes cli = new FClientes();

            cli.MdiParent = this;
            cli.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FReportes repo = new FReportes();

            repo.MdiParent = this;
            repo.Show();
        }

        private void tsb_prov_Click(object sender, EventArgs e)
        {
            FProveedores prov = new FProveedores();

            prov.MdiParent = this;
            prov.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FEmpleados emp = new FEmpleados();

            emp.MdiParent = this;
            emp.Show();
        }

        private void tsb_orden_comp_Click(object sender, EventArgs e)
        {
            FOrdenCompra oc = new FOrdenCompra();

            oc.MdiParent = this;
            oc.Show();
        }

        private void tsb_productos_Click(object sender, EventArgs e)
        {
            FProductos fp = new FProductos();

            fp.MdiParent = this;
            fp.Show();
        }

        private void tsb_mp_Click(object sender, EventArgs e)
        {
            FMateriasPrimas mp = new FMateriasPrimas();

            mp.MdiParent = this;
            mp.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FOrdenProduccion op = new FOrdenProduccion();

            op.MdiParent = this;
            op.Show();
        }

        private void tsp_ventas_Click(object sender, EventArgs e)
        {
            FVentas fv = new FVentas();

            fv.MdiParent = this;
            fv.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            FMovimientosMP mmp = new FMovimientosMP();

            mmp.MdiParent = this;
            mmp.Show();
        }
    }
}
