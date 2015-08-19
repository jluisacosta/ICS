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
    public partial class FEmpleados : Form
    {
        private int puesto;

        public FEmpleados()
        {
            InitializeComponent();
        }

        private void FEmpleados_Load(object sender, EventArgs e)
        {
            cb_tipo.SelectedIndex = 0;
            mostrarTabla();
        }

        private void mostrarTabla()
        {
            DataSet ds = Conexion.obtenerDatos("select id_empleado as ID, id_tipo_empleado as PUESTO, nombre as NOMBRE, fecha_nacimiento as FECHA_NACIMIENTO, direccion as DIRECCION, telefono as TELEFONO, email as EMAIL, departamento as DEPTO FROM Empleados");
            
            sgc_emp.PrimaryGrid.ClearAll();
            sgc_emp.PrimaryGrid.DataSource = ds.Tables[0];
        }

        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            puesto = cb_tipo.SelectedIndex+1;

            switch(puesto-1)
            {
                case 0:
                    tb_depto.Text = "Ventas";
                    break;
                case 1:
                case 2:
                    tb_depto.Text = "Producción";
                break;
                case 3:
                case 4:
                    tb_depto.Text = "Almacen";
                break;
                default:
                    tb_depto.Text = "Administración";
                break;
            }
        }

        private void sgc_emp_RowClick(object sender, GridRowClickEventArgs e)
        {
            List<GridCell> row = sgc_emp.PrimaryGrid.GridPanel.GetSelectedRows().GetCells();

            if (row.Count != 0)
            {
                tb_id.Text = row[0].Value.ToString();

                cb_tipo.SelectedIndex = Convert.ToInt32(row[1].Value)-1;
                tb_nombre.Text = row[2].Value.ToString();
                dti_fecha.Value = Convert.ToDateTime(row[3].Value.ToString());
                tb_direccion.Text = row[4].Value.ToString();
                tb_tel.Text = row[5].Value.ToString();
                tb_email.Text = row[6].Value.ToString();
            }  
        }

        private void b_alta_Click(object sender, EventArgs e)
        {
            string q = "INSERT INTO Empleados(id_usuario,id_tipo_empleado,nombre,fecha_nacimiento,direccion,telefono,email,departamento)VALUES(1," +
                           puesto.ToString() + ",'" + tb_nombre.Text + "','" + dti_fecha.Value.ToString("yyyy/MM/dd") + "','" + tb_direccion.Text + "','" + tb_tel.Text + "','" +
                           tb_email.Text + "','" + tb_depto.Text + "')";
            Conexion.ejecutaConsulta(q);
            mostrarTabla();
        }

        private void b_baja_Click(object sender, EventArgs e)
        {
            Conexion.ejecutaConsulta("DELETE FROM Empleados WHERE id_empleado = " + tb_id.Text);
            mostrarTabla();
        }

        private void b_modif_Click(object sender, EventArgs e)
        {
            Conexion.ejecutaConsulta("UPDATE Empleados set id_tipo_empleado =" + puesto.ToString() +
                                                  ",nombre='" + tb_nombre.Text +
                                                  "',fecha_nacimiento='" + dti_fecha.Value.ToString("yyyy/MM/dd") +
                                                  "',direccion='" + tb_direccion.Text +
                                                  "',telefono='" + tb_tel.Text +
                                                  "',email='" + tb_email.Text +
                                                  "',departamento='" + tb_depto.Text + "' WHERE id_empleado =" + tb_id.Text);
            mostrarTabla();
        }
    }
}
