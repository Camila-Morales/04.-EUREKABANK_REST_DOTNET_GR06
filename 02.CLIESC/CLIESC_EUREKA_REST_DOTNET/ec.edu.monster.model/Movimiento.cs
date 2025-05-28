namespace ec.edu.monster.model
{
    public class Movimiento
    {
        public int MovNumero { get; set; }
        public string CuNumero { get; set; }
        public string TipoMovimiento { get; set; }
        public decimal MovValor { get; set; }
        public DateTime MovFecha { get; set; }
        public string MovFechaFormateada { get; set; }
        public decimal SaldoActual { get; set; } 
    }
}


