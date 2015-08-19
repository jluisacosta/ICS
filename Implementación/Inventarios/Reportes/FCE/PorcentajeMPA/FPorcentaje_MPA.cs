using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Inventarios.Reportes.FCE.PorcentajeMPA;

namespace Inventarios.Reportes.Gerenciales.Porcentaje_MP_Almacen
{
    public partial class FPorcentaje_MPA : Form
    {
        private dataSet_inventarios ds;
        private MySqlConnection con;
        private crPorcentajeMpT reporteT;
        private crPorcentajeMpA reporteA;
        private crPorcentajeMpG reporteG;
        private string query;

        public FPorcentaje_MPA()
        {
            InitializeComponent();
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            cb_tipo.SelectedIndex = 0;
        }

        private void FPorcentaje_MPA_Load(object sender, EventArgs e)
        {

        }

        public void cargarReporte()
        {
            MySqlDataAdapter adapter;

            try
            {
                crearConsulta();
                ds = new dataSet_inventarios();
                adapter = new MySqlDataAdapter(query, con);
                adapter.Fill(ds.Porcentaje_MP);

                switch (cb_tipo.SelectedIndex)
                {
                    case 0://Texto
                        reporteT = new crPorcentajeMpT();
                        reporteT.SetDataSource(ds);
                        crv.ReportSource = reporteT;
                        break;
                    case 1://Grafica
                        reporteG = new crPorcentajeMpG();
                        reporteG.SetDataSource(ds);
                        crv.ReportSource = reporteG;
                        crv.Zoom(75);
                        break;
                    case 2://Ambos
                        reporteA = new crPorcentajeMpA();
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
            query = "select id_materia, nombre, stock, stock_minimo, stock_maximo,((stock-stock_minimo)*100)/(stock_maximo-stock_minimo) as por_almacen from materias_primas";
        }

        private void btn_gr_Click(object sender, EventArgs e)
        {
            cargarReporte();
        }
    }
}
