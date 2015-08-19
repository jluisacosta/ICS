using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.SuperGrid;
using Inventarios.Reportes.Ordenes_Compra;

namespace Inventarios.Formularios
{
    public partial class FOrdenCompra : Form
    {
        private List<GridCell> mp_select;
        private List<List<object>> detalleCompra;
        private float subTotal;

        public FOrdenCompra()
        {
            InitializeComponent();
            detalleCompra = new List<List<object>>();
        }

        private void FOrdenCompra_Load(object sender, EventArgs e)
        {
            cargarMateriaPrima();
        }

        private void cargarMateriaPrima()
        {
            DataSet ds = Conexion.obtenerDatos("SELECT id_materia as ID_MATERIA, nombre as NOMBRE, descripcion as DESCRIPCION, precio as PRECIO, stock as STOCK, unidad as UNIDAD FROM Materias_Primas");

            sgc_mp.PrimaryGrid.ClearAll();
            sgc_mp.PrimaryGrid.DataSource = ds.Tables[0];
        }

        private void b_buscar_Click(object sender, EventArgs e)
        {
            FBuscarProv bp = new FBuscarProv();
            bp.ShowDialog();

            if (bp.proveedor != null)
            {
                tb_idprov.Text = bp.proveedor[0].Value.ToString();
                tb_razon.Text = bp.proveedor[1].Value.ToString();
                tb_rfc.Text = bp.proveedor[2].Value.ToString();
                tb_dir.Text = bp.proveedor[6].Value.ToString();
                tb_tel.Text = bp.proveedor[7].Value.ToString();
            }
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            agregarMP();
        }
        
        private void sgc_mp_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            agregarMP();
        }

        private void agregarMP()
        {
            FCapturaDatos fc; 
            object[] datos_mp;
            int cant;

            fc = new FCapturaDatos();
            datos_mp = new object[5];

            mp_select = sgc_mp.PrimaryGrid.GridPanel.GetSelectedRows().GetCells();

            if (mp_select.Count != 0)
            {
                if (fc.ShowDialog() == DialogResult.OK)
                {
                    cant = Convert.ToInt32(fc.tb_cant.Text);

                    datos_mp[0] = cant;
                    datos_mp[1] = mp_select[0].Value;
                    datos_mp[2] = mp_select[1].Value;
                    datos_mp[3] = mp_select[3].Value;
                    datos_mp[4] = cant * Convert.ToSingle(mp_select[3].Value);

                    sgc_detalle.PrimaryGrid.Rows.Add(new GridRow(datos_mp));

                    subTotal += Convert.ToSingle(datos_mp[4]);
                    subTotal = Convert.ToSingle(Math.Round((decimal)subTotal, 2));

                    tb_subtotal.Text = subTotal.ToString();
                    tb_iva.Text = (Math.Round(subTotal * 0.16, 2)).ToString();
                    tb_total.Text = (Math.Round(subTotal + (subTotal * 0.16), 2)).ToString();

                    ajustarDetalleCompra(datos_mp[1], cant, datos_mp[4], true);
                }
            }
            else
                MsgError("Seleccione todo el registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sgc_detalle_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            quitarMP();
        }

        private void quitarMP()
        {
            mp_select = sgc_detalle.PrimaryGrid.GridPanel.GetSelectedRows().GetCells();

            if (mp_select.Count != 0)
            {
                if (MessageBox.Show("Esta seguro que quiere eliminarlo", "Quitar materia prima", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    sgc_detalle.PrimaryGrid.Rows.Remove(sgc_detalle.PrimaryGrid.GridPanel.GetSelectedRows()[0]);

                    subTotal -= Convert.ToSingle(mp_select[4].Value);
                    subTotal = Convert.ToSingle(Math.Round((decimal)subTotal, 2));

                    tb_subtotal.Text = subTotal.ToString();
                    tb_iva.Text = (Math.Round(subTotal * 0.16, 2)).ToString();
                    tb_total.Text = (Math.Round(subTotal + (subTotal * 0.16), 2)).ToString();

                    ajustarDetalleCompra(mp_select[1].Value, mp_select[0].Value, mp_select[4].Value, false);
                }
            }
            else
                MsgError("Seleccione todo el registro para eliminar","Agregar MP",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void ajustarDetalleCompra(object idMP, object cant, object importe,bool operacion)
        {
            List<object> matPrima;
            int indexMP = -1;

            for (int i = 0; i < detalleCompra.Count; i++)
                if (detalleCompra[i][0] == idMP)
                {
                    indexMP = i;
                    break;
                }

            if (operacion)//Se ha agregado una materia prima al detalle
            {
                if (indexMP == -1)//Nueva MP
                {
                    matPrima = new List<object>();
                    matPrima.Add(idMP);
                    matPrima.Add(cant);
                    matPrima.Add(importe);
                    detalleCompra.Add(matPrima);
                }
                else
                {
                    detalleCompra[indexMP][1] = Convert.ToInt32(detalleCompra[indexMP][1]) + Convert.ToInt32(cant);
                    detalleCompra[indexMP][2] = (float)detalleCompra[indexMP][2] + (float)importe;
                }
            }
            else//Quitarlo del detalle
            {
                detalleCompra[indexMP][1] = Convert.ToInt32(detalleCompra[indexMP][1]) - Convert.ToInt32(cant);
                detalleCompra[indexMP][2] = (float)detalleCompra[indexMP][2] - (float)importe;

                if ((int)detalleCompra[indexMP][1] == 0)
                    detalleCompra.RemoveAt(indexMP);
            }
        }

        private void b_imprimir_Click(object sender, EventArgs e)
        {
            object idOc;

            if(tb_idprov.Text.Length > 0 )
            {
                if(detalleCompra.Count > 0)
                {
                    Conexion.ejecutaConsulta("INSERT INTO Ordenes_compra(id_empleado,id_proveedor,fecha_pedido,costo_total,iva)VALUES(" +
                                    tb_idemp.Text + "," + tb_idprov.Text + ",'" + dti_fecha.Value.ToString("yyyy/MM/dd") + "'," + tb_total.Text + ",0.16)");
           
                    idOc = Conexion.obtenerDatos("select Max(id_orden_compra) from ordenes_compra").Tables[0].Rows[0][0];

                    for (int i = 0; i < detalleCompra.Count; i++)
                        Conexion.ejecutaConsulta("INSERT INTO detalle_compra(id_orden_compra,id_materia_prima,cantidad,subtotal)VALUES(" +
                                        idOc + "," + detalleCompra[i][0] + "," + detalleCompra[i][1] + "," + detalleCompra[i][2] + ")");

                    new FOrdenes_Compra((int)idOc).ShowDialog();
                    
                    //Se limpia la tabla del detalle de compra
                    sgc_detalle.PrimaryGrid.Rows.Clear();
                    
                    //Limpiar datos del proveedor
                    tb_idprov.Text = null;
                    tb_razon.Text = null;
                    tb_tel.Text = null;
                    tb_dir.Text = null;
                    tb_rfc.Text = null;

                    //Limpiar datos de la compra
                    subTotal = 0;
                    tb_subtotal.Text = "0";
                    tb_iva.Text = "0";
                    tb_total.Text = "0";
                }else
                    MsgError("Agregar materia prima a la compra", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else
                MsgError("Agregue un proveedor a la orden de compra","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void MsgError(string error,string title, MessageBoxButtons btns, MessageBoxIcon tipo)
        {
            MessageBox.Show(error, title, btns,tipo);
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
