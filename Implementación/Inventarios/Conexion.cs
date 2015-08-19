using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Inventarios
{
    public class Conexion
    {
        private static MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=root;database=si_inventarios");
        private static MySqlCommand cmd;
        
        public static void ejecutaConsulta(string query)
        {
            try
            {
                cmd = new MySqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static DataSet obtenerDatos(string query)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(query,con);
            DataSet ds = new DataSet();
            
            da.Fill(ds);
            
            return ds;
        }
    }
}