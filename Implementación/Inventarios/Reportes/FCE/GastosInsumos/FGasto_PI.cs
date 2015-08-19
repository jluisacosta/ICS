using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Inventarios.Reportes.FCE.GastosInsumos;

namespace Inventarios.Reportes.Gerenciales.Gasto_prom_insumos
{
    public partial class FGasto_PI : Form
    {
        private dataSet_inventarios ds;
        private MySqlConnection con;
        crGastosPromT reporteT;
        crGastosPromA reporteA;
        crGastosPromG reporteG;
        private string query;

        public FGasto_PI()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            cb_tipo.SelectedIndex = 0;
        }

        public void cargarReporte()
        {
            MySqlDataAdapter adapter;
            
            try
            {
                crearConsulta();
                ds = new dataSet_inventarios();
                adapter = new MySqlDataAdapter(query, con);
                adapter.Fill(ds.Gastos_Prom_Ins);

                switch (cb_tipo.SelectedIndex)
                {
                    case 0://Texto
                        reporteT = new crGastosPromT();
                        reporteT.SetDataSource(ds);
                        crv.ReportSource = reporteT;
                    break;
                    case 1://Grafica
                        reporteG = new crGastosPromG();
                        reporteG.SetDataSource(ds);
                        crv.ReportSource = reporteG;
                        crv.Zoom(75);
                    break;
                    case 2://Ambos
                        reporteA = new crGastosPromA();
                        reporteA.SetDataSource(ds);
                        crv.ReportSource = reporteA;
                    break;
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message);
            }
        }

        private void crearConsulta()
        {
            query = "select mp.id_materia, mp.nombre, mp.precio,SUM(dc.cantidad) as cantidad_ord,SUM(oc.costo_total) as gasto_total, AVG(oc.costo_total) as gasto_prom" +
                    " from ordenes_compra oc, detalle_compra dc, materias_primas mp" +
                    " where oc.id_orden_compra = dc.id_orden_compra" +
                    " and dc.id_materia_prima = mp.id_materia" +
                    " and oc.fecha_pedido >='" + dtp_i.Value.ToString("yyyy/MM/dd") +
                    "' and oc.fecha_pedido <='" + dtp_f.Value.ToString("yyyy/MM/dd") +
                    "' group by mp.id_materia";
        }

        private void btn_gr_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }
    }
}
