using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosCoppel
{
    internal class ManejaMarca
    {
        public static DataTable obtenMarca()
        {
            SqlConnection conn = null;
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();

            try
            {
                conn = Conectar.CrearConexion();
                conn.Open();
                string strComando = "select CarMarcaID as 'ID Marca',CarMarca as 'Nombre Marca' from marca";
                SqlCommand cmd = new SqlCommand(strComando, conn);
                lector = cmd.ExecuteReader();
                tabla.Load(lector);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
