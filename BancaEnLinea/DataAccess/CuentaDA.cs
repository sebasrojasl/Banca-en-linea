using Microsoft.Data.SqlClient;
using System.Data;

namespace BancaEnLinea.DataAccess
{
    public class CuentaDA
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8LRP70H;Initial Catalog=BancaEnLinea;Integrated Security=True;Trust Server Certificate=True");

        //Get informacion de la cuenta cuenta
        public DataSet ConsultaCuenta(string numero_cuenta)
        {
            string msg = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                SqlCommand com = new SqlCommand("OBTENER_CUENTA", connection);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CUENTA", numero_cuenta);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds);

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            return ds;
        }

        //Get saldo de una cuenta

        public DataSet ConsultaSaldo(string numero_cuenta)
        {
            string msg = string.Empty;
            DataSet ds = new DataSet();

            try
            {
                SqlCommand com = new SqlCommand("OBTENER_SALDO", connection);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("CUENTA", numero_cuenta);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds);

            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            return ds;
        }

    }
}
