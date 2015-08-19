using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.SuperGrid;

namespace Inventarios.Formularios
{
    public partial class FMateriasPrimas : Form
    {
        public FMateriasPrimas()
        {
            InitializeComponent();
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            FBuscarProv bp = new FBuscarProv();
            
            bp.ShowDialog();
            tb_id_prov.Text = bp.proveedor[0].Value.ToString();
            tb_rz.Text = bp.proveedor[1].Value.ToString();
        }

        private void FMateriasPrimas_Load(object sender, EventArgs e)
        {
            cb_unidad.SelectedIndex = 0;
            mostrarTabla();
        }

        private void mostrarTabla()
        {
            DataSet ds = Conexion.obtenerDatos("select MP.id_materia as ID_MAT,Pr.id_proveedor as ID_PROV, Pr.razon_social as RS_PROV, MP.nombre as NOMBRE, "+
                                                "MP.descripcion as DESCRIPCION, MP.precio as PRECIO, MP.stock as STOCK, MP.stock_minimo as STOCK_MINIMO, MP.stock_maximo as STOCK_MAXIMO,"+
                                                "MP.unidad as UNIDAD from Materias_Primas MP inner join Proveedores Pr on  MP.id_proveedor= Pr.id_proveedor");
    
            sgc_mp.PrimaryGrid.ClearAll();
            sgc_mp.PrimaryGrid.DataSource = ds.Tables[0];
        }

        private void b_alta_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Materias_Primas(id_proveedor,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,unidad)VALUES(" +
                            tb_id_prov.Text + ",'" + tb_nombre.Text + "','" + tb_desc.Text + "','" + tb_precio.Text + "'," + tb_sact.Text + "," + tb_smin.Text + "," +
                            tb_smax.Text + ",'" + DateTime.Now.ToString("yyyy/MM/dd") + "','" + cb_unidad.SelectedItem.ToString()+"')";

            Conexion.ejecutaConsulta(query);
            mostrarTabla();
        }

        private void b_baja_Click(object sender, EventArgs e)
        {
            Conexion.ejecutaConsulta("DELETE FROM Materias_Primas WHERE id_materia = " + tb_id.Text);
            mostrarTabla();
        }

        private void sgc_mp_RowClick(object sender, DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs e)
        {
            List<GridCell> row = sgc_mp.PrimaryGrid.GridPanel.GetSelectedRows().GetCells();

            if (row.Count != 0)
            {
                tb_id.Text = row[0].Value.ToString();
                tb_id_prov.Text = row[1].Value.ToString();
                tb_rz.Text = row[2].Value.ToString();
                tb_nombre.Text = row[3].Value.ToString();
                tb_desc.Text = row[4].Value.ToString();
                tb_precio.Text = row[5].Value.ToString();
                tb_sact.Text = row[6].Value.ToString();
                tb_smin.Text = row[7].Value.ToString();
                tb_smax.Text = row[8].Value.ToString();

                if (row[9].Value.ToString().CompareTo("Litros")==0)
                    cb_unidad.SelectedIndex = 0;
                else
                    cb_unidad.SelectedIndex = 1;
            }
        }

        private void b_modif_Click(object sender, EventArgs e)
        {
            Conexion.ejecutaConsulta("UPDATE Materias_Primas set id_proveedor ='" + tb_id_prov.Text +
                                                 "',nombre='" + tb_nombre.Text +
                                                 "',descripcion='" + tb_desc.Text +
                                                 "',precio=" + tb_precio.Text +
                                                 ",stock=" + tb_sact.Text +
                                                 ",stock_minimo=" + tb_smin.Text +
                                                 ",stock_maximo=" + tb_smax.Text +
                                                 ",unidad='" + cb_unidad.SelectedItem.ToString() +
                                                 "' WHERE id_materia =" + tb_id.Text);
            mostrarTabla();
        }
    }
}
