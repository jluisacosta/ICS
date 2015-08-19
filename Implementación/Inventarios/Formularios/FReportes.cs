using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventarios.Reportes.Facturas_Clientes;
using Inventarios.Reportes.Movimientos;
using Inventarios.Reportes.Ordenes_Compra;
using Inventarios.Reportes.Proveedores_Activos;
using Inventarios.Reportes.Corte;
using Inventarios.Reportes.OCxProveedor;
using Inventarios.Reportes.Especiales.Porcentaje_prov;
using Inventarios.Reportes.Especiales.Promedio_comp;
using Inventarios.Reportes.Especiales.Ventas_emp;
using Inventarios.Reportes.Facturas;
using Inventarios.Reportes.Orden_Produccion;
using Inventarios.Reportes.FCE.Ganancias;
using Inventarios.Reportes.FCE.FrecuenciaCompra;
using Inventarios.Reportes.FCE.Trafico;
using Inventarios.Reportes.FCE.Solvencia;
using Inventarios.Reportes.Gerenciales.Gasto_prom_insumos;
using Inventarios.Reportes.Gerenciales.Porcentaje_MP_Almacen;
using Inventarios.Reportes.FCE.PromedioVentas;

namespace Inventarios.Formularios
{
    public partial class FReportes : Form
    {
        public FReportes()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FCorte cor = new FCorte();

            cor.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FReportes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facturas_Clientes fac = new Facturas_Clientes();
            fac.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FOCproveedor orp = new FOCproveedor();

            orp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FMovimientos mov = new FMovimientos();
            mov.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FProveedores_Act pro_act = new FProveedores_Act();
            pro_act.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FOrdenes_Compra ord = new FOrdenes_Compra(107336);
            ord.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FMasV masv = new FMasV();

            masv.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FPorcentaje fp = new FPorcentaje();
            fp.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FPromedio fp = new FPromedio();
            fp.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FVentasEmp fve = new FVentasEmp();
            fve.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Facturas fac = new Facturas(100);
            fac.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FOrden_Produccion op = new FOrden_Produccion(100);
            op.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FGanancias g = new FGanancias();
            g.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FFrecuencia f = new FFrecuencia();
            f.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FTrafico t = new FTrafico();
            t.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FSolvencia s = new FSolvencia();
            s.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FGasto_PI fg = new FGasto_PI();
            fg.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FPorcentaje_MPA fp = new FPorcentaje_MPA();
            fp.Show();
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            FPromVentas fpv = new FPromVentas();
            fpv.Show();
        }

    }
}
