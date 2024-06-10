using BancaEnLinea.DataAccess;
using BancaEnLinea.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BancaEnLinea.BL
{
    public class CuentaController : Controller
    {
        //Funcion que obtiene una cuenta en especifico
        public static Models.Cuenta getCuenta(string numero_cuenta)
        {
            DataAccess.CuentaDA dbop = new DataAccess.CuentaDA();

            DataSet dataSetConsultado = dbop.ConsultaCuenta(numero_cuenta);
            List<Models.Cuenta> listaCuentas = new List<Models.Cuenta>();
            Cuenta cuentaConsultada = new Cuenta();
            foreach (DataRow dr in dataSetConsultado.Tables[0].Rows)
            {
                listaCuentas.Add(new Models.Cuenta {

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

            cuentaConsultada = listaCuentas[0];

            dataSetConsultado = dbop.ConsultaSaldo(numero_cuenta);

            //SP que obtiene el saldo



            return cuentaConsultada;

        }

        

    }
}
