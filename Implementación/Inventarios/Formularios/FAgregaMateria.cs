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
    public partial class FAgregaMateria : Form
    {
        private List<GridCell> mp_select;
        private List<List<object>> detalleReceta;
        internal object id_producto;
        
        public FAgregaMateria(object id_pro)
        {
            InitializeComponent();
            detalleReceta = new List<List<object>>();
            id_producto = id_pro;
        }

        private void FAgregaMateria_Load(object sender, EventArgs e)
        {
            cargarMateriaPrima();
        }

        private void cargarMateriaPrima()
        {
            DataSet ds = Conexion.obtenerDatos("SELECT id_materia as ID_MATERIA, nombre as NOMBRE, descripcion as DESCRIPCION FROM materias_primas");

            sgc_mp.PrimaryGrid.ClearAll();
            sgc_mp.PrimaryGrid.DataSource = ds.Tables[0];
        }

        private void sgc_mp_RowClick(object sender, DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs e)
        {
            mp_select = sgc_mp.PrimaryGrid.GridPanel.GetSelectedRows().GetCells();
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {
            agregarMP();
        }

        private void agregarMP()
        {
            FCapturaDatos fc;
            object[] datos_mp;
            int cant=0;

            fc = new FCapturaDatos();
            datos_mp = new object[4];

            mp_select = sgc_mp.PrimaryGrid.GridPanel.GetSelectedRows().GetCells();

            if (mp_select.Count != 0)
            {
                if (fc.ShowDialog() == DialogResult.OK)
                {
                    cant = Convert.ToInt32(fc.tb_cant.Text);

                    datos_mp[0] = cant;
                    datos_mp[1] = mp_select[0].Value;
                    datos_mp[2] = mp_select[1].Value;
                    datos_mp[3] = mp_select[2].Value;
                    sgc_receta.PrimaryGrid.Rows.Add(new GridRow(datos_mp));
                    
                    ajustarDetalleReseta(datos_mp[1], cant, true);
                }
            }
            else
                MsgError("Seleccione todo el registro", "Agregar MP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ajustarDetalleReseta(object idMP, object cant, bool operacion)
        {
            List<object> matPrima;
            int indexMP = -1;

            for (int i = 0; i < detalleReceta.Count; i++)
                if (detalleReceta[i][0] == idMP)
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
                    detalleReceta.Add(matPrima);
                }
                else
                   detalleReceta[indexMP][1] = Convert.ToInt32(detalleReceta[indexMP][1]) + Convert.ToInt32(cant);
                
            }
            else//Quitarlo del detalle
            {
                detalleReceta[indexMP][1] = Convert.ToInt32(detalleReceta[indexMP][1]) - Convert.ToInt32(cant);
                
                if ((int)detalleReceta[indexMP][1] == 0)
                    detalleReceta.RemoveAt(indexMP);
            }
        }

        private void MsgError(string error, string title, MessageBoxButtons btns, MessageBoxIcon tipo)
        {
            MessageBox.Show(error, title, btns, tipo);
        }

        private void sgc_receta_RowClick(object sender, GridRowClickEventArgs e)
        {
            sgc_receta.PrimaryGrid.GridPanel.GetSelectedRows().GetCells();
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            quitarMP();
        }

        private void quitarMP()
        {
            mp_select = sgc_receta.PrimaryGrid.GridPanel.GetSelectedRows().GetCells();

            if (mp_select.Count != 0)
            {
                if (MessageBox.Show("Esta seguro que quiere eliminarlo", "Quitar materia prima", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    sgc_receta.PrimaryGrid.Rows.Remove(sgc_receta.PrimaryGrid.GridPanel.GetSelectedRows()[0]);
                    ajustarDetalleReseta(mp_select[1].Value, mp_select[0].Value, false);
                }
            }
            else
                MsgError("Seleccione todo el registro para eliminar", "Quitar MP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            if (detalleReceta.Count > 0)
            {
                for (int i = 0; i < detalleReceta.Count; i++)
                    Conexion.ejecutaConsulta("INSERT INTO materiaporproducto(id_materia,id_producto,cantidad)VALUES(" +
                                     detalleReceta[i][0] + "," +id_producto +","+ detalleReceta[i][1] +")");

                MsgError("Receta creada", "Receta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Se limpia la tabla del detalle de receta
                sgc_receta.PrimaryGrid.Rows.Clear();
            }
            else
                MsgError("Agregar materia prima a la receta", "Receta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
