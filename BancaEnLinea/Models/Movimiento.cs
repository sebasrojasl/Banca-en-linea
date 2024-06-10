namespace BancaEnLinea.Models
{
    public class Movimiento
    {
        public int Id { get; set; }

        public string Numero_Cuenta { get; set; }
        public string Tipo { get; set; }

        public string Monto { get; set; }

        public string IBANDestino { get; set; }


    }
}
