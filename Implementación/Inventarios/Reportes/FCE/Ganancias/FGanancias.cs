using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventarios.Reportes.FCE.Ganancias
{
    public partial class FGanancias : Form
    {
        MySqlConnection con;
        dataSet_inventarios ds;
        crGananciasA reporte;
        crGananciasT reportetxt;
        crGananciasG reporteg;
        string query, fechaIni, fechaFin;

        public FGanancias()
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
                adapter.Fill(ds, "GB");
                
                switch (cb_tipo.SelectedIndex)
                { 
                    case 0://Texto
                        reportetxt = new crGananciasT();
                        reportetxt.SetDataSource(ds);
                        crv.ReportSource = reportetxt;
                    break;
                    case 1://Grafica
                        reporteg = new crGananciasG();
                        reporteg.SetDataSource(ds);
                        crv.ReportSource = reporteg;
                    break;
                    case 2://Ambos
                        reporte = new crGananciasA();
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
            query = "select fecha,sum(ganancia_bruta) as ganancia_bruta,sum(ganancia_neta) as ganancia_neta " +
                    "from ganancias where fecha >= '" + fechaIni + "' and fecha < '" + fechaFin + "' " +
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
