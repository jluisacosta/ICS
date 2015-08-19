using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Inventarios.dataSet_inventariosTableAdapters;
using Inventarios.Reportes.Pruebas;

namespace Inventarios.Reportes.Corte
{
    public partial class FCorte : Form
    {
        MySqlConnection con;
        dataSet_inventarios ds;
        CorteTableAdapter corte;
        crCorte reporte;
        crCorteA reportea;
        crCorteG reporteg;

        public FCorte()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            ds = new dataSet_inventarios();
            corte = new CorteTableAdapter();
            cb_tipo.SelectedIndex = 0;
        }

        public void cargarReporte()
        {
            corte.Connection = con;
            corte.Fill(ds.Corte, dtp.Value);

            switch (cb_tipo.SelectedIndex)
            {
                case 0://Texto
                    reporte = new crCorte();
                    reporte.SetDataSource(ds);
                    crv.ReportSource = reporte;
                    break;
                case 1://Grafica
                    reporteg = new crCorteG();
                    reporteg.SetDataSource(ds);
                    crv.ReportSource = reporteg;
                    break;
                case 2://Ambos
                    reportea = new crCorteA();
                    reportea.SetDataSource(ds);
                    crv.ReportSource = reportea;
               break;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }
    }
}






