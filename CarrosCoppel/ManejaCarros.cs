using System.Data;
using System.Data.SqlClient;

namespace CarrosCoppel
{
    internal class ManejaCarros
    {
        public static DataTable obtenCarro()
        {
            SqlConnection conn = null;
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();

            try
            {
                conn = Conectar.CrearConexion();
                conn.Open();
                string strComando = "SELECT CarID as 'Carro ID', CarMod as 'Modelo', CarAño as 'Año', marca.CarMarca as 'Marca', CarTip as 'Tipo', CarColor as 'Color' FROM carros JOIN marca ON carros.CarMarcaID = marca.CarMarcaID JOIN tipo ON carros.CarTipID = tipo.CarTipID JOIN Color ON carros.CarColorID = Color.CarColorID";
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