using CarrosCoppel.conexion;
using CarrosCoppel.datos;
using System.Data;
using System.Data.SqlClient;

namespace CarrosCoppel.controlador
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
                string strComando = "SELECT CarID as 'Carro ID', CarMod as 'Modelo', marca.CarMarca as 'Marca', CarAño as 'Año', CarTip as 'Tipo', CarColor as 'Color' FROM carros JOIN marca ON carros.CarMarcaID = marca.CarMarcaID JOIN tipo ON carros.CarTipID = tipo.CarTipID JOIN Color ON carros.CarColorID = Color.CarColorID";
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
        public static DataTable Buscar(string Buscar)
        {
            SqlConnection conn = null;
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();

            try
            {
                conn = Conectar.CrearConexion();
                conn.Open();
                SqlCommand cmd = new SqlCommand(Buscar, conn);
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
        public static DataTable llenarCampos()
        {
            SqlConnection conn = null;
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();

            try
            {
                conn = Conectar.CrearConexion();
                conn.Open();
                string strComando = "select * from carros";
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

        public static string AgregarCarro(carros car)
        {
            string idcarro;
            idcarro = "";

            SqlConnection conn = null;
            SqlDataReader lector = null;


            try
            {
                conn = Conectar.CrearConexion();
                conn.Open();
                string cons = "SP_MTTOCARROS";
                SqlCommand cmd = new SqlCommand(cons, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramId = new SqlParameter("@CARID", SqlDbType.Int);
                paramId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramId);
                cmd.Parameters.AddWithValue("@CARMOD", car.CarMod);
                cmd.Parameters.AddWithValue("@CARAÑO", car.Caraño);
                cmd.Parameters.AddWithValue("@CARMARCAID", car.CarMarcaID);
                cmd.Parameters.AddWithValue("@CARTIPID", car.TipID);
                cmd.Parameters.AddWithValue("@CARCOLORID", car.CarColorId);
                cmd.ExecuteNonQuery();

                idcarro = Convert.ToInt32(cmd.Parameters["@CARID"].Value).ToString();

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
            return idcarro;
        }

        internal static void EliminaCarro(string id)
        {
            SqlConnection conn = null;
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();

            try
            {
                conn = Conectar.CrearConexion();
                conn.Open();
                string strComando = "DELETE FROM carros WHERE CarID =" + id;
                SqlCommand cmd = new SqlCommand(strComando, conn);
                lector = cmd.ExecuteReader();
                tabla.Load(lector);

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

        public static string ModificarCarro(carros car)
        {

            SqlConnection conn = null;
            SqlDataReader lector = null;


            try
            {
                conn = Conectar.CrearConexion();
                conn.Open();
                string cons = "SP_MTTOCARROS";
                SqlCommand cmd = new SqlCommand(cons, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramId = new SqlParameter("@CARID", SqlDbType.Int);
                paramId.Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@CARID", car.CarId);
                cmd.Parameters.AddWithValue("@CARMOD", car.CarMod);
                cmd.Parameters.AddWithValue("@CARAÑO", car.Caraño);
                cmd.Parameters.AddWithValue("@CARMARCAID", car.CarMarcaID);
                cmd.Parameters.AddWithValue("@CARTIPID", car.TipID);
                cmd.Parameters.AddWithValue("@CARCOLORID", car.CarColorId);
                cmd.ExecuteNonQuery();

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
            return car.CarId;
        }
    }

}