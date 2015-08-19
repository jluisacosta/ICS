﻿using System;
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


namespace Inventarios.Reportes.Ordenes_Compra
{
    public partial class FOrdenes_Compra : Form
    {
        private MySqlConnection con;
        private dataSet_inventarios ds;
        private Orden_CompraTableAdapter ordenes_compra;
        private crOrdenesCompra reporte;
        private int id_oc;

        public FOrdenes_Compra(int id)
        {
            InitializeComponent();
           
            con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
            ds = new dataSet_inventarios();
            ordenes_compra = new Orden_CompraTableAdapter();
            reporte = new crOrdenesCompra();
            id_oc = id;
            cargarReporte();
        }

        public void cargarReporte()
        {
            ordenes_compra.Connection = con;
            ordenes_compra.CrearOrdenCompra(ds.Orden_Compra,id_oc);
            reporte.SetDataSource(ds);
            crv.ReportSource = reporte;
        }
    }
}



