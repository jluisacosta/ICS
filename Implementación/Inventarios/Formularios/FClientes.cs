using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevComponents.DotNetBar.SuperGrid;

namespace Inventarios.Formularios
{
    public partial class FClientes : Form
    {
        public FClientes()
        {
            InitializeComponent();
        }

        private void b_alta_Click(object sender, EventArgs e)
        {
            Conexion.ejecutaConsulta("INSERT INTO Clientes(razon_social,rfc,ciudad,cp,direccion,telefono,email)VALUES('" +
                            tb_rs.Text + "','" + tb_rfc.Text + "','" + tb_ciudad.Text + "','" + tb_cp.Text + "','" + tb_direccion.Text + "','" +
                            tb_tel.Text + "','" + tb_email.Text + "')");
            mostrarTabla();
        }
        
        private void b_baja_Click(object sender, EventArgs e)
        {
            Conexion.ejecutaConsulta("DELETE FROM Clientes WHERE id_cliente = "+tb_id.Text);
            mostrarTabla();
        }

        private void b_modif_Click(object sender, EventArgs e)
        {
            Conexion.ejecutaConsulta("UPDATE Clientes set razon_social='" + tb_rs.Text +
                                                  "',rfc='" + tb_rfc.Text +
                                                  "',ciudad='" + tb_ciudad.Text +
                                                  "',cp='" + tb_cp.Text +
                                                  "',direccion='" + tb_direccion.Text +
                                                  "',telefono='" + tb_tel.Text +
                                                  "',email='" + tb_email.Text + "' WHERE id_cliente =" + tb_id.Text);
            mostrarTabla();
        }

        private void FClientes_Load(object sender, EventArgs e)
        {
            mostrarTabla();
        }

        private void mostrarTabla()
        {
            DataSet ds = Conexion.obtenerDatos("select id_cliente as ID_CLIENTE, razon_social as RAZON_SOCIAL, rfc as RFC, ciudad as CIUDAD, cp as CODIGO_POSTAL,direccion as DIRECCION,telefono as TELEFONO, email as EMAIL from clientes");
           
            sgc_cli.PrimaryGrid.ClearAll();
            sgc_cli.PrimaryGrid.DataSource = ds.Tables[0];
        }

        private void sgc_cli_RowClick(object sender, DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs e)
        {
            List<GridCell> row = sgc_cli.PrimaryGrid.GridPanel.GetSelectedRows().GetCells();

            if (row.Count != 0)
            {
                tb_id.Text = row[0].Value.ToString();
                tb_rs.Text = row[1].Value.ToString();
                tb_rfc.Text = row[2].Value.ToString();
                tb_ciudad.Text = row[3].Value.ToString();
                tb_cp.Text = row[4].Value.ToString();
                tb_direccion.Text = row[5].Value.ToString();
                tb_tel.Text = row[6].Value.ToString();
                tb_email.Text = row[7].Value.ToString();
            }       
        }
    }
}
