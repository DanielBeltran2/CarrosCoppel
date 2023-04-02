using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarrosCoppel.conexion
{
    internal class Conectar
    {
        public static SqlConnection CrearConexion()
        {
            SqlConnection conn;
            try
            {
                string strCon = "Data Source=DESKTOP-CLO4AN2;Initial Catalog=Carros;Integrated Security=True";
                conn = new SqlConnection(strCon);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return conn;
        }
    }
}
