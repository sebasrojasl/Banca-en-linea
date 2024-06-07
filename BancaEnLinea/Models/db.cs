using Microsoft.Data.SqlClient;
using System.Data;

namespace BancaEnLinea.Models
{
    public class db
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-8LRP70H;Initial Catalog=BancaEnLinea;Integrated Security=True;Trust Server Certificate=True");
    
        //Get cuenta
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
    }
}
