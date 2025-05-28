using Eurekabank_Cliente_Dotnet_Rest_G5.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Linq; // Importante para usar LINQ

namespace Eurekabank_Cliente_Dotnet_Rest_G5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static readonly HttpClient httpClient = new HttpClient();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       

        [HttpGet][HttpGet]
public async Task<IActionResult> Movimientos(string cuentaNumero)
{
    if (string.IsNullOrEmpty(cuentaNumero))
    {
        ViewBag.Error = "Por favor, ingresa un número de cuenta.";
        return View();
    }

    string url = $"http://10.40.17.105:5277/api/EurekabankControlador/Movimientos?numeroCuenta={cuentaNumero}";

    try
    {
        HttpResponseMessage response = await httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<dynamic>(content);

            if (responseObject != null && responseObject.response != null)
            {
                var movimientos = JsonConvert.DeserializeObject<List<Movimiento>>(responseObject.response.ToString());
                decimal? saldoActual = movimientos.Count > 0 ? movimientos[0].SaldoActual : (decimal?)null;

                foreach (var movimiento in movimientos)
                {
                    if (DateTime.TryParse(movimiento.MovFecha, out DateTime fecha))
                    {
                        movimiento.MovFecha = fecha.ToString("dd/MM/yyyy");
                    }
                }

                ViewBag.Resultado = movimientos;
                ViewBag.NumeroCuenta = cuentaNumero;
                        ViewBag.SaldoActual = saldoActual.HasValue
                            ? saldoActual.Value.ToString("C", new System.Globalization.CultureInfo("en-US"))
                            : "N/A";
                    }
            else
            {
                ViewBag.Error = "No se encontraron movimientos para esta cuenta.";
            }
        }
        else
        {
            ViewBag.Error = $"Error al obtener movimientos: {response.ReasonPhrase}";
        }
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error al obtener movimientos");
        ViewBag.Error = $"Ocurrió un error inesperado: {ex.Message}";
    }

    return View();
}

        public IActionResult Retiro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Retiro(string cuentaNumero, decimal valor)
        {
            if (string.IsNullOrEmpty(cuentaNumero) || valor <= 0)
            {
                ViewBag.Mensaje = "Por favor, ingresa datos válidos.";
                ViewBag.CssClass = "alert-danger";
                return View();
            }

            string url = $"http://10.40.17.105:5277/api/EurekabankControlador/Retiro?numeroCuenta={cuentaNumero}&valor={valor}";

            try
            {
                HttpResponseMessage response = await httpClient.PostAsync(url, null);

                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Mensaje = "Retiro realizado con éxito.";
                    ViewBag.CssClass = "alert-success";
                }
                else
                {
                    ViewBag.Mensaje = $"Error al realizar el retiro: {response.ReasonPhrase}";
                    ViewBag.CssClass = "alert-danger";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al realizar el retiro");
                ViewBag.Mensaje = $"Ocurrió un error inesperado: {ex.Message}";
                ViewBag.CssClass = "alert-danger";
            }

            return View();
        }

        [HttpGet]
        public IActionResult Transferencia()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Transferencia(string cuentaOrigen, string cuentaDestino, decimal valor)
        {
            if (string.IsNullOrEmpty(cuentaOrigen) || string.IsNullOrEmpty(cuentaDestino) || valor <= 0)
            {
                ViewBag.Mensaje = "Por favor, ingresa datos válidos.";
                ViewBag.CssClass = "alert-danger";
                return View();
            }

            string url = $"http://10.40.17.105:5277/api/EurekabankControlador/Transferencia?cuentaOrigen={cuentaOrigen}&cuentaDestino={cuentaDestino}&valor={valor}";

            try
            {
                HttpResponseMessage response = await httpClient.PostAsync(url, null);

                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Mensaje = "Transferencia realizada con éxito.";
                    ViewBag.CssClass = "alert-success";
                }
                else
                {
                    ViewBag.Mensaje = $"Error al realizar la transferencia: {response.ReasonPhrase}";
                    ViewBag.CssClass = "alert-danger";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al realizar la transferencia");
                ViewBag.Mensaje = $"Ocurrió un error inesperado: {ex.Message}";
                ViewBag.CssClass = "alert-danger";
            }

            return View();
        }

        [HttpGet]
        public IActionResult Deposito()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Deposito(string cuentaNumero, decimal valor)
        {
            if (string.IsNullOrEmpty(cuentaNumero) || valor <= 0)
            {
                ViewBag.Mensaje = "Por favor, ingresa datos válidos.";
                ViewBag.CssClass = "alert-danger";
                return View();
            }

            string url = $"http://10.40.17.105:5277/api/EurekabankControlador/Deposito?numeroCuenta={cuentaNumero}&valor={valor}";

            try
            {
                HttpResponseMessage response = await httpClient.PostAsync(url, null);

                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Mensaje = "Depósito realizado con éxito.";
                    ViewBag.CssClass = "alert-success";
                }
                else
                {
                    ViewBag.Mensaje = $"Error al realizar el depósito: {response.ReasonPhrase}";
                    ViewBag.CssClass = "alert-danger";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al realizar el depósito");
                ViewBag.Mensaje = $"Ocurrió un error inesperado: {ex.Message}";
                ViewBag.CssClass = "alert-danger";
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
