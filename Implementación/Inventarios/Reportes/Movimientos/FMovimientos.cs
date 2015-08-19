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

namespace Inventarios.Reportes.Movimientos
{
    public partial class FMovimientos : Form
    {
        MySqlConnection con;
        dataSet_inventarios ds;
        MovimientosTableAdapter mov;
        cr_Movimientos reporte;
        cr_MovimientosG reporteg;
        cr_MovimientosA reportea;

        public FMovimientos()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            ds = new dataSet_inventarios();
            mov = new MovimientosTableAdapter();
            cb_tipo.SelectedIndex = 0;
        }

        private void bt_generaReporte_Click(object sender, EventArgs e)
        {
            DateTime FI = fecha_Ini.Value;
            DateTime FF = fecha_Fin.Value;

            mov.Connection = con;
            mov.Fill(ds.Movimientos, FI, FF);

            switch (cb_tipo.SelectedIndex)
            {
                case 0://Texto
                    reporte = new cr_Movimientos();
                    reporte.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = reporte;
                    break;
                case 1://Grafica
                    reporteg = new cr_MovimientosG();
                    reporteg.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = reporteg;
                    break;
                case 2://Ambos
                    reportea = new cr_MovimientosA();
                    reportea.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = reportea;
                break;
            }
        }
    }
}
