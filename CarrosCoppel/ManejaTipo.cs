using System.Data;
using System.Data.SqlClient;

namespace CarrosCoppel
{
    internal class ManejaTipo
    {
        public static DataTable obtenTipo()
        {
            SqlConnection conn = null;
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();

            try
            {
                conn = Conectar.CrearConexion();
                conn.Open();
                string strComando = "select CarTipID as 'ID Tipo',CarTip as 'Tipo ' from tipo";
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