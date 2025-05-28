using System.ComponentModel.DataAnnotations;

namespace Eurekabank_Cliente_Dotnet_Rest_G5.Models
{
    public class Cuenta
    {
        [Key]
        public int CuId { get; set; }

        public int CliId { get; set; }

        public string CuNumero { get; set; }

        public string CuTipo { get; set; }

        public float? CuSaldo { get; set; }
    }
}
