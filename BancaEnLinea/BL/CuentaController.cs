using BancaEnLinea.Data;
using BancaEnLinea.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BancaEnLinea.BL
{
    public class CuentaController : Controller
    {
        //Funcion que obtiene una cuenta en especifico de la BD
        public static Cuenta getCuenta(string numero_cuenta)
        {
            db dbop = new db();

            DataSet ds = dbop.ConsultaCuenta(numero_cuenta);
            List<Cuenta> listaCuentas = new List<Cuenta> ();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                listaCuentas.Add(new Cuenta {

                    NumeroCuenta = dr["NUMERO_CUENTA"].ToString(),
                    Cliente_Id = dr["CLIENTE_ID"].ToString(),
                    TipoProducto = dr["TIPO_PRODUCTO"].ToString(),
                    Moneda  = dr["MONEDA"].ToString(),
                    Fecha_Apertura = dr["FECHA_APERTURA"].ToString(),
                    IBAN = dr["IBAN"].ToString(),
                    Estado = dr["ESTADO"].ToString(),
                    TasaInteres = dr["TASA_INTERES"].ToString(),

                });

            }
     
            return listaCuentas[0];
        }
    }
}
