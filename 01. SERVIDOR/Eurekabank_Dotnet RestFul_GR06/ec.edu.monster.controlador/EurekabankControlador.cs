using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Eurekabank_Dotnet_RestFul_G5.ec.edu.monster.modelo;
using System.Collections.Generic;

namespace Eurekabank_Dotnet_RestFul_G5.ec.edu.monster.controlador
{
    [Route("api/[controller]")]
    [ApiController]
    public class EurekabankControlador : ControllerBase
    {
        private readonly string cadenaSQL;

        public EurekabankControlador(IConfiguration config) => cadenaSQL = config.GetConnectionString("CadenaSQL");

        [HttpGet]
        [Route("Movimientos")]
        public IActionResult Movimientos(string numeroCuenta)
        {
            List<Movimiento> movimientos = new();
            try
            {
                using var conexion = new SqlConnection(cadenaSQL);
                conexion.Open();
                string sql = @"
                SELECT 
                    M.int_movinumero, M.chr_cuencodigo, M.dtt_movifecha, M.chr_emplcodigo,
                    M.chr_tipocodigo, TM.vch_tipodescripcion AS TipoMovimiento, 
                    M.dec_moviimporte, M.chr_cuenreferencia, C.dec_cuensaldo
                FROM dbo.Movimiento M
                INNER JOIN dbo.Cuenta C ON M.chr_cuencodigo = C.chr_cuencodigo
                INNER JOIN dbo.TipoMovimiento TM ON M.chr_tipocodigo = TM.chr_tipocodigo
                WHERE C.chr_cuencodigo = @NumeroCuenta";
                var cmd = new SqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                using var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    movimientos.Add(new Movimiento
                    {
                        MovNumero = Convert.ToInt32(rd["int_movinumero"]),
                        CuNumero = rd["chr_cuencodigo"].ToString(),
                        MovFecha = rd["dtt_movifecha"] != DBNull.Value ? Convert.ToDateTime(rd["dtt_movifecha"]) : (DateTime?)null,
                        EmplCodigo = rd["chr_emplcodigo"].ToString(),
                        TipoCodigo = rd["chr_tipocodigo"].ToString(),
                        TipoMovimiento = rd["TipoMovimiento"].ToString(),
                        MovValor = Convert.ToDecimal(rd["dec_moviimporte"]),
                        CuenReferencia = rd["chr_cuenreferencia"]?.ToString(),
                        SaldoActual = Convert.ToDecimal(rd["dec_cuensaldo"])
                    });
                }
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok", response = movimientos });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = e.Message, response = movimientos });
            }
        }

        [HttpPost]
        [Route("Deposito")]
        public IActionResult Deposito(string numeroCuenta, decimal valor)
        {
            try
            {
                using var conexion = new SqlConnection(cadenaSQL);
                conexion.Open();
                var transaction = conexion.BeginTransaction();
                try
                {
                    string sqlCuenta = "SELECT COUNT(*) FROM dbo.Cuenta WHERE chr_cuencodigo = @NumeroCuenta";
                    var cmdCuenta = new SqlCommand(sqlCuenta, conexion, transaction);
                    cmdCuenta.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                    if (Convert.ToInt32(cmdCuenta.ExecuteScalar()) == 0)
                        throw new Exception("La cuenta especificada no existe.");
                    string sqlActualizarSaldo = "UPDATE dbo.Cuenta SET dec_cuensaldo = dec_cuensaldo + @Valor WHERE chr_cuencodigo = @NumeroCuenta";
                    var cmdActualizarSaldo = new SqlCommand(sqlActualizarSaldo, conexion, transaction);
                    cmdActualizarSaldo.Parameters.AddWithValue("@Valor", valor);
                    cmdActualizarSaldo.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                    cmdActualizarSaldo.ExecuteNonQuery();
                    string sqlRegistrarMovimiento = "INSERT INTO dbo.Movimiento (chr_cuencodigo, int_movinumero, dtt_movifecha, chr_emplcodigo, chr_tipocodigo, dec_moviimporte, chr_cuenreferencia) " +
                                                    "VALUES (@NumeroCuenta, (SELECT ISNULL(MAX(int_movinumero), 0) + 1 FROM dbo.Movimiento WHERE chr_cuencodigo = @NumeroCuenta), GETDATE(), '9999', '003', @Valor, NULL)";
                    var cmdRegistrarMovimiento = new SqlCommand(sqlRegistrarMovimiento, conexion, transaction);
                    cmdRegistrarMovimiento.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                    cmdRegistrarMovimiento.Parameters.AddWithValue("@Valor", valor);
                    cmdRegistrarMovimiento.ExecuteNonQuery();
                    transaction.Commit();
                    return GetUpdatedSaldo(numeroCuenta);
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = e.Message });
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = e.Message });
            }
        }

        [HttpPost]
        [Route("Retiro")]
        public IActionResult Retiro(string numeroCuenta, decimal valor)
        {
            try
            {
                using var conexion = new SqlConnection(cadenaSQL);
                conexion.Open();
                var transaction = conexion.BeginTransaction();
                try
                {
                    string sqlSaldo = "SELECT dec_cuensaldo FROM dbo.Cuenta WHERE chr_cuencodigo = @NumeroCuenta";
                    var cmdSaldo = new SqlCommand(sqlSaldo, conexion, transaction);
                    cmdSaldo.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                    decimal saldoActual = Convert.ToDecimal(cmdSaldo.ExecuteScalar());
                    if (saldoActual < valor)
                        throw new Exception("Saldo insuficiente para realizar el retiro.");
                    string sqlActualizarSaldo = "UPDATE dbo.Cuenta SET dec_cuensaldo = dec_cuensaldo - @Valor WHERE chr_cuencodigo = @NumeroCuenta";
                    var cmdActualizarSaldo = new SqlCommand(sqlActualizarSaldo, conexion, transaction);
                    cmdActualizarSaldo.Parameters.AddWithValue("@Valor", valor);
                    cmdActualizarSaldo.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                    cmdActualizarSaldo.ExecuteNonQuery();
                    string sqlRegistrarMovimiento = "INSERT INTO dbo.Movimiento (chr_cuencodigo, int_movinumero, dtt_movifecha, chr_emplcodigo, chr_tipocodigo, dec_moviimporte, chr_cuenreferencia) " +
                                                    "VALUES (@NumeroCuenta, (SELECT ISNULL(MAX(int_movinumero), 0) + 1 FROM dbo.Movimiento WHERE chr_cuencodigo = @NumeroCuenta), GETDATE(), '9999', '004', @Valor, NULL)";
                    var cmdRegistrarMovimiento = new SqlCommand(sqlRegistrarMovimiento, conexion, transaction);
                    cmdRegistrarMovimiento.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                    cmdRegistrarMovimiento.Parameters.AddWithValue("@Valor", valor);
                    cmdRegistrarMovimiento.ExecuteNonQuery();
                    transaction.Commit();
                    return GetUpdatedSaldo(numeroCuenta);
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = e.Message });
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = e.Message });
            }
        }

        [HttpPost]
        [Route("Transferencia")]
        public IActionResult Transferencia(string cuentaOrigen, string cuentaDestino, decimal valor)
        {
            try
            {
                using var conexion = new SqlConnection(cadenaSQL);
                conexion.Open();
                var transaction = conexion.BeginTransaction();
                try
                {
                    string sqlSaldoOrigen = "SELECT dec_cuensaldo FROM dbo.Cuenta WHERE chr_cuencodigo = @CuentaOrigen";
                    var cmdSaldoOrigen = new SqlCommand(sqlSaldoOrigen, conexion, transaction);
                    cmdSaldoOrigen.Parameters.AddWithValue("@CuentaOrigen", cuentaOrigen);
                    decimal saldoOrigen = Convert.ToDecimal(cmdSaldoOrigen.ExecuteScalar());
                    if (saldoOrigen < valor)
                        throw new Exception("Saldo insuficiente para realizar la transferencia.");
                    string sqlCuentaDestino = "SELECT COUNT(*) FROM dbo.Cuenta WHERE chr_cuencodigo = @CuentaDestino";
                    var cmdCuentaDestino = new SqlCommand(sqlCuentaDestino, conexion, transaction);
                    cmdCuentaDestino.Parameters.AddWithValue("@CuentaDestino", cuentaDestino);
                    if (Convert.ToInt32(cmdCuentaDestino.ExecuteScalar()) == 0)
                        throw new Exception("La cuenta de destino especificada no existe.");
                    string sqlActualizarSaldoOrigen = "UPDATE dbo.Cuenta SET dec_cuensaldo = dec_cuensaldo - @Valor WHERE chr_cuencodigo = @CuentaOrigen";
                    var cmdActualizarSaldoOrigen = new SqlCommand(sqlActualizarSaldoOrigen, conexion, transaction);
                    cmdActualizarSaldoOrigen.Parameters.AddWithValue("@Valor", valor);
                    cmdActualizarSaldoOrigen.Parameters.AddWithValue("@CuentaOrigen", cuentaOrigen);
                    cmdActualizarSaldoOrigen.ExecuteNonQuery();
                    string sqlActualizarSaldoDestino = "UPDATE dbo.Cuenta SET dec_cuensaldo = dec_cuensaldo + @Valor WHERE chr_cuencodigo = @CuentaDestino";
                    var cmdActualizarSaldoDestino = new SqlCommand(sqlActualizarSaldoDestino, conexion, transaction);
                    cmdActualizarSaldoDestino.Parameters.AddWithValue("@Valor", valor);
                    cmdActualizarSaldoDestino.Parameters.AddWithValue("@CuentaDestino", cuentaDestino);
                    cmdActualizarSaldoDestino.ExecuteNonQuery();
                    string sqlRegistrarMovimientoOrigen = "INSERT INTO dbo.Movimiento (chr_cuencodigo, int_movinumero, dtt_movifecha, chr_emplcodigo, chr_tipocodigo, dec_moviimporte, chr_cuenreferencia) " +
                                                          "VALUES (@CuentaOrigen, (SELECT ISNULL(MAX(int_movinumero), 0) + 1 FROM dbo.Movimiento WHERE chr_cuencodigo = @CuentaOrigen), GETDATE(), '9999', '009', @Valor, @CuentaDestino)";
                    var cmdRegistrarMovimientoOrigen = new SqlCommand(sqlRegistrarMovimientoOrigen, conexion, transaction);
                    cmdRegistrarMovimientoOrigen.Parameters.AddWithValue("@CuentaOrigen", cuentaOrigen);
                    cmdRegistrarMovimientoOrigen.Parameters.AddWithValue("@Valor", valor);
                    cmdRegistrarMovimientoOrigen.Parameters.AddWithValue("@CuentaDestino", cuentaDestino);
                    cmdRegistrarMovimientoOrigen.ExecuteNonQuery();
                    string sqlRegistrarMovimientoDestino = "INSERT INTO dbo.Movimiento (chr_cuencodigo, int_movinumero, dtt_movifecha, chr_emplcodigo, chr_tipocodigo, dec_moviimporte, chr_cuenreferencia) " +
                                                           "VALUES (@CuentaDestino, (SELECT ISNULL(MAX(int_movinumero), 0) + 1 FROM dbo.Movimiento WHERE chr_cuencodigo = @CuentaDestino), GETDATE(), '9999', '008', @Valor, @CuentaOrigen)";
                    var cmdRegistrarMovimientoDestino = new SqlCommand(sqlRegistrarMovimientoDestino, conexion, transaction);
                    cmdRegistrarMovimientoDestino.Parameters.AddWithValue("@CuentaDestino", cuentaDestino);
                    cmdRegistrarMovimientoDestino.Parameters.AddWithValue("@Valor", valor);
                    cmdRegistrarMovimientoDestino.Parameters.AddWithValue("@CuentaOrigen", cuentaOrigen);
                    cmdRegistrarMovimientoDestino.ExecuteNonQuery();
                    transaction.Commit();
                    return GetUpdatedSaldo(cuentaOrigen);
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = e.Message });
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = e.Message });
            }
        }

        private IActionResult GetUpdatedSaldo(string numeroCuenta)
        {
            try
            {
                using var conexion = new SqlConnection(cadenaSQL);
                conexion.Open();
                string sqlSaldo = "SELECT dec_cuensaldo FROM dbo.Cuenta WHERE chr_cuencodigo = @NumeroCuenta";
                var cmdSaldo = new SqlCommand(sqlSaldo, conexion);
                cmdSaldo.Parameters.AddWithValue("@NumeroCuenta", numeroCuenta);
                decimal saldoActual = Convert.ToDecimal(cmdSaldo.ExecuteScalar());
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Transacción exitosa", saldoActual });
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { mensaje = e.Message });
            }
        }
    }
}
