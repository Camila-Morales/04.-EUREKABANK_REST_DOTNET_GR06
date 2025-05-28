using System.ComponentModel.DataAnnotations;

namespace Eurekabank_Cliente_Dotnet_Rest_G5.Models
{
    public class Movimiento
    {
        public int MovNumero { get; set; }
        public string CuNumero { get; set; }
        public string MovFecha { get; set; } // Formato de fecha como string
        public string EmplCodigo { get; set; }
        public string TipoCodigo { get; set; }
        public string TipoMovimiento { get; set; }
        public decimal MovValor { get; set; }
        public string CuenReferencia { get; set; }
        public decimal SaldoActual { get; set; } // Nuevo campo para el saldo actual
    }
}
