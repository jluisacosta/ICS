using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventarios.Reportes.FCE.FrecuenciaCompra
{
    public partial class FFrecuencia : Form
    {
        MySqlConnection con;
        dataSet_inventarios ds;
        crFrecuenciaA reporte;
        crFrecuenciaT reportetxt;
        crFrecuenciaG reporteg;
        string query, fechaIni, fechaFin,top_less;

        public FFrecuencia()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            cb_tipo.SelectedIndex = 0;
            cb_mmv.SelectedIndex = 0;
            top_less = "DESC";
        }

        public void cargarReporte()
        {
            MySqlDataAdapter adapter;
            
            fechaIni = dtp.Value.Year.ToString() + "/" + dtp.Value.Month.ToString() + "/" + dtp.Value.Day.ToString();
            fechaFin = dtp2.Value.Year.ToString() + "/" + dtp2.Value.Month.ToString() + "/" + dtp2.Value.Day.ToString();

            try
            {
                crearConsulta();
                ds = new dataSet_inventarios();
                adapter = new MySqlDataAdapter(query, con);
                adapter.Fill(ds, "Frecuencia");
                
                switch (cb_tipo.SelectedIndex)
                { 
                    case 0://Texto
                        reportetxt = new crFrecuenciaT();
                        reportetxt.SetDataSource(ds);
                        crv.ReportSource = reportetxt;
                    break;
                    case 1://Grafica
                        reporteg = new crFrecuenciaG();
                        reporteg.SetDataSource(ds);
                        crv.ReportSource = reporteg;
                    break;
                    case 2://Ambos
                        reporte = new crFrecuenciaA();
                        reporte.SetDataSource(ds);
                        crv.ReportSource = reporte;
                    break;
                }
                
            }
            catch(FormatException fex)
            {
                MessageBox.Show(fex.Message);
            }
        }

        public void crearConsulta()
        {
            query = "select c.id_cliente,c.razon_social,count(f.id_factura) as cuenta,sum(v.total) as total " +
                    "from clientes c,facturas f, ventas v where c.id_cliente = f.id_cliente and f.id_venta = v.id_venta " +
                    "and f.fecha >= '" + fechaIni + "' and f.fecha < ' " + fechaFin + "' group by c.id_cliente "+
                    "order by v.total " + top_less + " LIMIT " + Convert.ToInt16(tb_n.Text).ToString();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }

        private void cb_mmv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_mmv.SelectedIndex == 0)
            {
                top_less = "DESC";
            }
            else
            {
                top_less = "ASC";
            }
        }
    }
}
