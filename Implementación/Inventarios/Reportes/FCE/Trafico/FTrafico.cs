using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventarios.Reportes.FCE.Trafico
{
    public partial class FTrafico : Form
    {
        MySqlConnection con;
        dataSet_inventarios ds;
        crTraficoA reporte;
        crTraficoT reportetxt;
        crTraficoG reporteg;
        string query, fechaIni, fechaFin;

        public FTrafico()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            cb_tipo.SelectedIndex = 0;
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
                adapter.Fill(ds, "Trafico");
                
                switch (cb_tipo.SelectedIndex)
                { 
                    case 0://Texto
                        reportetxt = new crTraficoT();
                        reportetxt.SetDataSource(ds);
                        crv.ReportSource = reportetxt;
                    break;
                    case 1://Grafica
                        reporteg = new crTraficoG();
                        reporteg.SetDataSource(ds);
                        crv.ReportSource = reporteg;
                    break;
                    case 2://Ambos
                        reporte = new crTraficoA();
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
            query = "select mp.id_materia,mp.nombre,m.fecha,m.tipo_movimiento from movimientos m,detalle_movimiento dm," +
                    "materias_primas mp where m.id_movimiento = dm.id_movimiento and dm.id_materia_prima = mp.id_materia " +
                    "and m.fecha >= '" + fechaIni + "' and m.fecha < ' " + fechaFin + "'";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }
    }
}
