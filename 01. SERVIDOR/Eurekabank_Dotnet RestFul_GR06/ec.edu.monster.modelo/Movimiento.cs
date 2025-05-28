using System.ComponentModel.DataAnnotations;

namespace Eurekabank_Dotnet_RestFul_G5.ec.edu.monster.modelo
{
    public class Movimiento
    {
        [Key]
        public int MovNumero { get; set; } // int_movinumero

        public string CuNumero { get; set; } // chr_cuencodigo
        public DateTime? MovFecha { get; set; } // dtt_movifecha
        public string EmplCodigo { get; set; } // chr_emplcodigo
        public string TipoCodigo { get; set; } // chr_tipocodigo
        public string TipoMovimiento { get; set; } // vch_tipodescripcion
        public decimal MovValor { get; set; } // dec_moviimporte
        public string CuenReferencia { get; set; } // chr_cuenreferencia
        public decimal SaldoActual { get; set; } // dec_cuensaldo
    }
}
