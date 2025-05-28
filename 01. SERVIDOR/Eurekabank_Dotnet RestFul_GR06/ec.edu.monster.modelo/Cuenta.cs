using System.ComponentModel.DataAnnotations;

namespace Eurekabank_Dotnet_RestFul_G5.ec.edu.monster.modelo
{
    public class Cuenta
    {
        [Key]
        public string CuNumero { get; set; } // chr_cuencodigo
        public string CliCodigo { get; set; } // chr_cliecodigo
        public string MonedaCodigo { get; set; } // chr_monecodigo
        public decimal CuSaldo { get; set; } // dec_cuensaldo
        public string CuEstado { get; set; } // vch_cuenestado
    }
}
