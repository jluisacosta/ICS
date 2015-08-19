using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using Inventarios.dataSet_inventariosTableAdapters;
using Inventarios.Reportes.Orden_Produccion;

namespace Inventarios.Formularios
{
    public partial class FOrdenProduccion : Form
    {
        private object id_prod;
        private MySqlConnection con;
        private dataSet_inventarios ds;
        private Orden_ProduccionTableAdapter orden_prod;
        private crOrdenProduccion reporte;

        public FOrdenProduccion()
        {
            InitializeComponent();
        }

        private void FOrdenProduccion_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            ds = new dataSet_inventarios();
            orden_prod = new Orden_ProduccionTableAdapter();
            reporte = new crOrdenProduccion();
        }

        private void b_buscar_Click(object sender, EventArgs e)
        {
            FBuscarProd fbp = new FBuscarProd();
            
            fbp.ShowDialog();

            if (fbp.producto.Count > 0)
            {
                id_prod = fbp.producto[0].Value;
                tb_categoria.Text = fbp.producto[1].Value.ToString();
                tb_nomp.Text = fbp.producto[2].Value.ToString();
                tb_desc.Text = fbp.producto[3].Value.ToString();
                tb_precio.Text = fbp.producto[4].Value.ToString();
                tb_sact.Text = fbp.producto[5].Value.ToString();
                tb_smin.Text = fbp.producto[6].Value.ToString();
                tb_smax.Text = fbp.producto[7].Value.ToString();
                tb_unidad.Text = fbp.producto[8].Value.ToString();
            }
        }

        private void b_generar_Click(object sender, EventArgs e)
        {
            string q = "INSERT INTO ordenes_produccion(id_empleado,id_producto,fecha_inicio,fecha_entrega,cantidad)VALUES("+
                           tb_idemp.Text +","+ id_prod +",'" + dti_fecha.Value.ToString("yyyy/MM/dd") + "','" + dti_fecha.Value.ToString("yyyy/MM/dd") + "',"+ tb_cantidad.Text+ ")";
            
            Conexion.ejecutaConsulta(q);
            //Recuperar id de la orden de produccion para cargar el reporte

            object id = Conexion.obtenerDatos("Select MAX(id_orden_produccion) from ordenes_produccion").Tables[0].Rows[0][0];
            cargarReporte((int)id);
        }

        private void cargarReporte(int id_op)
        {
            orden_prod.Connection = con;
            orden_prod.Fill(ds.Orden_Produccion, id_op);
            reporte.SetDataSource(ds);
            crv.ReportSource = reporte;
        }
    }
}
