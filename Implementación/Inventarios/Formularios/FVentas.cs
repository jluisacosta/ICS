using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using DevComponents.DotNetBar;
using System.IO;
using DevComponents.DotNetBar.SuperGrid;

namespace Inventarios.Formularios
{
    public partial class FVentas : Form
    {
        private List<List<int>>posicionProductXY;
        private List<System.Windows.Forms.Panel> categorias;
        private List<GridCell> product_select;
        private List<List<object>> detalleVenta;
        private DataTable products;
        private float subTotal;
        private int width = 210;
        private int heigth = 130;

        public FVentas()
        {
            InitializeComponent();
            posicionProductXY = new List<List<int>>();
            detalleVenta = new List<List<object>>();

            for (int i = 0; i < 5; i++)
            {
                List<int> L = new List<int>();
                L.Add(8);
                L.Add(8);
                posicionProductXY.Add(L);
            }

            categorias = new List<System.Windows.Forms.Panel>();
            
            categorias.Add(p_pays);
            categorias.Add(p_pasteles);
            categorias.Add(p_muffins);
            categorias.Add(p_galletas);
            categorias.Add(p_cp);
        }

        private void FVentas_Load(object sender, EventArgs e)
        {
            int tipoCat = -1;

            tb_fecha.Text = DateTime.Today.ToLongDateString();

            products = Conexion.obtenerDatos("SELECT id_producto,categoria,nombre,precio,imagen_url FROM Productos order by categoria desc").Tables[0];
            
            for (int i = 0; i < products.Rows.Count; i++)
            {
                string cat = products.Rows[i][1].ToString();

                switch (cat)
                {
                    case "Pays":
                        tipoCat = 0;
                        break;
                    case "Pasteles":
                        tipoCat = 1;
                        break;
                    case "Muffins":
                        tipoCat = 2;
                        break;
                    case "Galletas":
                        tipoCat = 3;
                        break;
                    case "CupCakes":
                        tipoCat = 4;
                        break;
                }
                cargarProductos(products.Rows[i],tipoCat,i);
            }
        }
        
        private void cargarProductos(DataRow prod,int cat,int row)
        {
            int posX, posY;

            posX = posicionProductXY[cat][0];
            posY = posicionProductXY[cat][1];
            
            //Asignar imagen
            PictureBox pB = new PictureBox();

            pB.Width = width;
            pB.Height = heigth;
            pB.Location = new Point(posX,posY);
            pB.SizeMode = PictureBoxSizeMode.StretchImage;
            pB.Cursor = Cursors.Hand;
            pB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            //pB.BackColor = Color.Red;
            pB.ImageLocation = Path.Combine(Application.StartupPath, prod[4].ToString().Replace("|", "\\"));
            pB.Name = row.ToString();
            pB.DoubleClick += new System.EventHandler(agregarProductoDV);

            categorias[cat].Controls.Add(pB);
            
            //Modificar coordenada
            posX += width + 10;
            if (posX < 2 * width + 10)
                posicionProductXY[cat][0] = posX;
            else
            {
                posicionProductXY[cat][0] =8;
                posicionProductXY[cat][1] += heigth + 30;
            }
        }

        private void agregarProductoDV(object sender, EventArgs e)
        {
            FCapturaDatos fc = new FCapturaDatos();
            object[] datos_product = new object[5];
            int row = Convert.ToInt32(((PictureBox)sender).Name);
            int cant;
            float iva;

            if (tb_cantidad.Text.Length > 0)
                cant = Convert.ToInt32(tb_cantidad.Text);
            else
            {
                fc.ShowDialog();
                cant = Convert.ToInt32(fc.tb_cant.Text);
            }

            if (cant.ToString().Length > 0)
            {
                datos_product[0] = cant;
                datos_product[1] = products.Rows[row][0];
                datos_product[2] = products.Rows[row][2];
                datos_product[3] = products.Rows[row][3];
                datos_product[4] = Convert.ToSingle(cant * Convert.ToSingle(products.Rows[row][3]));

                sgc_dv.PrimaryGrid.Rows.Add(new GridRow(datos_product));
                ajustarDetalleVenta(datos_product[1], cant, datos_product[4], true);
                
                subTotal += Convert.ToSingle(datos_product[4]);
                subTotal = Convert.ToSingle(Math.Round((decimal)subTotal, 2));

                tb_subtotal.Text = subTotal.ToString();
                tb_iva.Text = (Math.Round(subTotal * 0.16, 2)).ToString();
                tb_total.Text = (Math.Round(subTotal + (subTotal * 0.16), 2)).ToString();

                tb_cantidad.Text = "";
            }
        }

        private void addCant(object sender, EventArgs e)
        {
            string num = ((ButtonX)sender).Text;

            if (num.ToString().CompareTo("C") == 0)
            {
                if (tb_cantidad.Text.Length > 0)
                    tb_cantidad.Text = tb_cantidad.Text.Remove(tb_cantidad.Text.Length - 1);
            }
            else
                if (tb_cantidad.Text.Length > 0 && tb_cantidad.Text[0] == '0')
                    tb_cantidad.Text = num;
                else
                    tb_cantidad.Text += num;
        }

        private void ajustarDetalleVenta(object idP, object cant, object importe, bool operacion)
        {
            List<object> producto;
            int indexP = -1;

            for (int i = 0; i < detalleVenta.Count; i++)
                if (detalleVenta[i][0].ToString().CompareTo(idP.ToString()) == 0)
                {
                    indexP = i;
                    break;
                }

            if (operacion)//Se ha agregado el producto al detalle
            {
                if (indexP == -1)//Nueva MP
                {
                    producto = new List<object>();
                    producto.Add(idP);
                    producto.Add(cant);
                    producto.Add(importe);
                    detalleVenta.Add(producto);
                }
                else
                {
                    detalleVenta[indexP][1] = Convert.ToInt32(detalleVenta[indexP][1]) + Convert.ToInt32(cant);
                    detalleVenta[indexP][2] = (float)detalleVenta[indexP][2] + (float)importe;
                }
            }
            else//Quitarlo del detalle
            {
                detalleVenta[indexP][1] = Convert.ToInt32(detalleVenta[indexP][1]) - Convert.ToInt32(cant);
                detalleVenta[indexP][2] = (float)detalleVenta[indexP][2] - (float)importe;

                if ((int)detalleVenta[indexP][1] == 0)
                    detalleVenta.RemoveAt(indexP);
            }
        }

        private void sgc_dv_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            product_select = sgc_dv.PrimaryGrid.GridPanel.GetSelectedRows().GetCells();

            if (product_select.Count != 0)
            {
                if (MessageBox.Show("Esta seguro que quiere eliminarlo", "Quitar materia prima", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    sgc_dv.PrimaryGrid.Rows.Remove(sgc_dv.PrimaryGrid.GridPanel.GetSelectedRows()[0]);
                    
                    subTotal -= Convert.ToSingle(product_select[4].Value);
                    subTotal = Convert.ToSingle(Math.Round((decimal)subTotal, 2));

                    tb_subtotal.Text = subTotal.ToString();
                    tb_iva.Text = (Math.Round(subTotal * 0.16, 2)).ToString();
                    tb_total.Text = (Math.Round(subTotal + (subTotal * 0.16), 2)).ToString();
                    
                    ajustarDetalleVenta(product_select[1].Value, product_select[0].Value, product_select[4].Value, false);
                }
            }
            else
                MessageBox.Show("Seleccione todo el registro para eliminar", "Agregar MP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_confirmar_Click(object sender, EventArgs e)
        {
            object idVenta;
            
            if (detalleVenta.Count > 0)
            {
                string q = "INSERT INTO Ventas(id_empleado,fecha,iva,total)VALUES(" +
                                tb_id_emp.Text + ",'" + DateTime.Today.ToString("yyyy/MM/dd") + "',0.16," + tb_total.Text + ")";
                Conexion.ejecutaConsulta(q);

                idVenta = Conexion.obtenerDatos("select Max(id_venta) from ventas").Tables[0].Rows[0][0];

                for (int i = 0; i < detalleVenta.Count; i++)
                    Conexion.ejecutaConsulta("INSERT INTO detalle_venta(id_venta,id_producto,cantidad,subtotal)VALUES(" +
                                    idVenta + "," + detalleVenta[i][0] + "," + detalleVenta[i][1] + "," + detalleVenta[i][2] + ")");

                //Se limpia la tabla del detalle de compra
                sgc_dv.PrimaryGrid.Rows.Clear();

                //Limpiar datos de la compra
                subTotal = 0;
                tb_subtotal.Text = "0";
                tb_iva.Text = "0";
                tb_total.Text = "0";
            }
            else
                MessageBox.Show("Agregar un producto a la venta", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
