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
    public partial class FProveedores : Form
    {
        public FProveedores()
        {
            InitializeComponent();

            mostrarTabla();
        }

        private void b_alta_Click(object sender, EventArgs e)
        {
            int numReg = sgc_prov.PrimaryGrid.GridPanel.Rows.Count;
            int idPro = Convert.ToInt32(sgc_prov.PrimaryGrid.GridPanel.GetCell(numReg-1, 0).Value.ToString()) + 1;
            
            Conexion.ejecutaConsulta("INSERT INTO Proveedores(id_proveedor,razon_social,rfc,contacto,ciudad,cp,direccion,telefono,email)VALUES("+ idPro.ToString() +",'"+
                    tb_rs.Text + "','" + tb_rfc.Text + "','" + tb_contacto.Text + "','" + tb_ciudad.Text + "','" + tb_cp.Text + "','" + tb_direccion.Text + "','" +
                    tb_tel.Text + "','" + tb_email.Text + "')");

            mostrarTabla();
        }

        private void mostrarTabla()
        {
            DataSet ds = Conexion.obtenerDatos("select id_proveedor as ID_PROVEEDOR, razon_social as RAZON_SOCIAL, rfc as RFC, contacto as CONTACTO, ciudad as CIUDAD, cp as CP,direccion as DIRECCION,telefono as TELEFONO, email as EMAIL FROM Proveedores");

            sgc_prov.PrimaryGrid.ClearAll();
            sgc_prov.PrimaryGrid.DataSource = ds.Tables[0];
        }

        private void sgc_prov_RowClick(object sender, DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs e)
        {
            List<GridCell> row = sgc_prov.PrimaryGrid.GridPanel.GetSelectedRows().GetCells();
        
            if (row.Count != 0)
            {
                tb_id.Text = row[0].Value.ToString();
                tb_rs.Text = row[1].Value.ToString();
                tb_rfc.Text = row[2].Value.ToString();
                tb_contacto.Text = row[3].Value.ToString();
                tb_ciudad.Text = row[4].Value.ToString();
                tb_cp.Text = row[5].Value.ToString();
                tb_direccion.Text = row[6].Value.ToString();
                tb_tel.Text = row[7].Value.ToString();
                tb_email.Text = row[8].Value.ToString();
            } 
        }

        private void b_baja_Click(object sender, EventArgs e)
        {
            Conexion.ejecutaConsulta("DELETE FROM Proveedores WHERE id_proveedor = " + tb_id.Text);
            mostrarTabla();
        }

        private void b_modif_Click(object sender, EventArgs e)
        {
            Conexion.ejecutaConsulta("UPDATE Proveedores set razon_social='" + tb_rs.Text +
                                                  "',rfc='" + tb_rfc.Text +
                                                  "',contacto='" + tb_contacto.Text +
                                                  "',ciudad='" + tb_ciudad.Text +
                                                  "',cp='" + tb_cp.Text +
                                                  "',direccion='" + tb_direccion.Text +
                                                  "',telefono='" + tb_tel.Text +
                                                  "',email='" + tb_email.Text + "' WHERE id_proveedor =" + tb_id.Text);
            mostrarTabla();
        }
    }
}
