using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.Controls;
using System.IO;

namespace Inventarios.Formularios
{
    public partial class FProductos : Form
    {
        private string ruta_imagen;
        private string id_prod;

        public FProductos()
        {
            InitializeComponent();
        }

        private void FProductos_Load(object sender, EventArgs e)
        {
            mostrarTabla();

            cb_cat.SelectedIndex = 0;
            cb_unidad.SelectedIndex = 0;
        }

        private void b_alta_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Productos(categoria,nombre,descripcion,precio,stock,stock_minimo,stock_maximo,fecha_ingreso,unidad,imagen_url)VALUES('" +
                            cb_cat.SelectedItem.ToString() + "','" + tb_nombre.Text + "','" + tb_desc.Text + "','" + tb_precio.Text + "'," + tb_sact.Text + "," + tb_smin.Text + "," +
                            tb_smax.Text + ",'" + DateTime.Now.ToString("yyyy/MM/dd") + "','" + cb_unidad.SelectedItem.ToString() + "','" + ruta_imagen + "')";

            Conexion.ejecutaConsulta(query);
            mostrarTabla();
        }

        private void mostrarTabla()
        {
            DataSet ds = Conexion.obtenerDatos("select id_producto as ID, categoria as CATEGORIA, nombre as NOMBRE, descripcion as DESCRIPCION,"+
                         "precio as PRECIO,stock as STOCK,stock_minimo as STOCK_MINIMO, stock_maximo as STOCK_MAXIMO,fecha_ingreso as FECHA_INGRESO,unidad as UNIDAD, imagen_url as RUTA_IMAGEN from productos");

            sgc_prod.PrimaryGrid.ClearAll();
            sgc_prod.PrimaryGrid.DataSource = ds.Tables[0];
        }
        
        private void sgc_prod_RowClick(object sender, GridRowClickEventArgs e)
        {
            List<GridCell> row = sgc_prod.PrimaryGrid.GridPanel.GetSelectedRows().GetCells();

            if (row.Count != 0)
            {
                id_prod = row[0].Value.ToString();
                cb_cat.SelectedIndex = obtenerIndice(row[1].Value,cb_cat);
                tb_nombre.Text = row[2].Value.ToString();
                tb_desc.Text = row[3].Value.ToString();
                tb_precio.Text = row[4].Value.ToString();
                tb_sact.Text = row[5].Value.ToString();
                tb_smin.Text = row[6].Value.ToString();
                tb_smax.Text = row[7].Value.ToString();
                cb_unidad.SelectedIndex = obtenerIndice(row[9].Value, cb_unidad);

                ruta_imagen = row[10].Value.ToString().Replace("|", "\\");
                pb_carga.ImageLocation = Path.Combine(Application.StartupPath, ruta_imagen);
            }
        }

        private int obtenerIndice(object item, ComboBoxEx cb)
        {
            for (int i = 0; i < cb.Items.Count; i++)
                if (cb.Items[i].ToString().CompareTo(item.ToString()) == 0)
                    return i;
        
            return 0;
        }
    
        private void b_baja_Click(object sender, EventArgs e)
        {
            Conexion.ejecutaConsulta("DELETE FROM Productos WHERE id_producto = " + id_prod);
            mostrarTabla();
        }

        private void b_modif_Click(object sender, EventArgs e)
        {
            Conexion.ejecutaConsulta("UPDATE Productos set categoria ='" + cb_cat.SelectedItem.ToString() +
                                                  "',nombre='" + tb_nombre.Text +
                                                  "',descripcion='" + tb_desc.Text +
                                                  "',precio=" + tb_precio.Text +
                                                  ",stock=" + tb_sact.Text +
                                                  ",stock_minimo=" + tb_smin.Text +
                                                  ",stock_maximo=" + tb_smax.Text +
                                                  ",unidad='" + cb_unidad.SelectedItem.ToString() +
                                                  "',imagen_url='" + ruta_imagen + "' WHERE id_producto =" + id_prod);
            mostrarTabla();
        }

        private void b_agrega_Click(object sender, EventArgs e)
        {
            FAgregaMateria amp;

            if (id_prod != null && id_prod.Length > 0)
            {
                amp = new FAgregaMateria(id_prod);
                amp.pb_producto.Image = this.pb_carga.Image;
                amp.ShowDialog();
            }
            else
                MessageBox.Show("Seleccione un producto de la tabla", "Seleccionar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void b_cargaimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarImagen = new OpenFileDialog();
            DirectoryInfo di;
            string imagepath;

            buscarImagen.Filter = "Archivos de Imagen |*.png";
            buscarImagen.FileName = "";
            buscarImagen.Title = "Seleccionar Imagen de Platillo";
            buscarImagen.InitialDirectory = "..\\Debug\\Imagenes_Productos";

            if (buscarImagen.ShowDialog() == DialogResult.OK)
            {
                ruta_imagen = buscarImagen.FileName;
                di = Directory.GetParent(ruta_imagen);
                ruta_imagen = "Imagenes_Productos\\" + di.Name + "\\" + buscarImagen.SafeFileName;
                
                imagepath = Path.Combine(Application.StartupPath ,ruta_imagen);
                pb_carga.ImageLocation = imagepath ;

                ruta_imagen = ruta_imagen.Replace("\\", "|");
            }
        }
    }
}