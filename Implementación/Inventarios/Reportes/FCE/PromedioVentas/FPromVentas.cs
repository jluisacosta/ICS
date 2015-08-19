using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventarios.Reportes.FCE.PromedioVentas
{
    public partial class FPromVentas : Form
    {
        MySqlConnection con;
        dataSet_inventarios ds;
        crPromVentasA reporte;
        crPromVentasT reportetxt;
        crPromVentasG reporteg;
        string query, fechaIni, fechaFin;

        public FPromVentas()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            cb_tipo.SelectedIndex = 0;
            cb_por.SelectedIndex = 0;
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
                adapter.Fill(ds, "PromediosVentas");
                
                switch (cb_tipo.SelectedIndex)
                { 
                    case 0://Texto
                        reportetxt = new crPromVentasT();
                        reportetxt.SetDataSource(ds);
                        crv.ReportSource = reportetxt;
                    break;
                    case 1://Grafica
                        reporteg = new crPromVentasG();
                        reporteg.SetDataSource(ds);
                        crv.ReportSource = reporteg;
                    break;
                    case 2://Ambos
                        reporte = new crPromVentasA();
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
            query = "select fecha,count(id_venta) as total_ventas,avg(total) as prom_ingresos " +
                    "from ventas where fecha>= '" + fechaIni + "' and fecha < '" + fechaFin + "' " +
                    "group by year(fecha)";

            switch (cb_por.SelectedIndex)
            { 
                case 0://Por dia
                    query += ",month(fecha),day(fecha)";
                break;
                case 1://por mes
                    query += ",month(fecha)";
                break;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }
    }
}
