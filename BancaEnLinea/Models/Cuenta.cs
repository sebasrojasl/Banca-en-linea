namespace BancaEnLinea.Models
{
    public class Cuenta
    {
        public int Producto_Id { get; set; }
        public string NumeroCuenta { get; set; }

        public string Cliente_Id { get; set; }

        public string TipoProducto { get; set; }

        public string Moneda { get; set; }

        public string Fecha_Apertura { get; set; }

        public string IBAN { get; set; }

        public string Estado { get; set; }

        public string TasaInteres { get; set; }

        public string Saldo { get; set; }

        public string[] Movimientos { get; set; }

        public string InteresesDevengados { get; set; }

    }
}
