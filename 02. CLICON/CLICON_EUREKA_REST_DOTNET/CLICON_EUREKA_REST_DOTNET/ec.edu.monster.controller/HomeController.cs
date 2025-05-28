using ec.edu.monster.view;
using ec.edu.monster.model;
using Newtonsoft.Json;

namespace ec.edu.monster.controller
{
    public class HomeController
    {
        private readonly ConsoleView _view;
        private static readonly HttpClient _httpClient = new HttpClient();

        public HomeController(ConsoleView view)
        {
            _view = view;
        }

        public void Start()
        {
            while (true)
            {
                _view.ShowMainMenu();
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ConsultarMovimientos();
                        break;
                    case "2":
                        RealizarDeposito();
                        break;
                    case "3":
                        RealizarRetiro();
                        break;
                    case "4":
                        RealizarTransferencia();
                        break;
                    case "5":
                        _view.ShowMessage("Cerrando sesión...");
                        return;
                    case "6":
                        Console.Clear();
                        _view.ShowMessage("¡Gracias por usar Eureka Bank, hasta luego!");
                        Environment.Exit(0);
                        break;
                    default:
                        _view.ShowMessage("Opción no válida.");
                        break;
                }
            }
        }

        private void ConsultarMovimientos()
        {
            _view.ShowMessage("Ingrese el número de cuenta:");
            var cuentaNumero = Console.ReadLine();

            if (string.IsNullOrEmpty(cuentaNumero))
            {
                _view.ShowMessage("El número de cuenta no puede estar vacío.");
                return;
            }

            var url = $"http://localhost:5277/api/EurekabankControlador/Movimientos?numeroCuenta={cuentaNumero}";

            try
            {
                var response = _httpClient.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var responseObject = JsonConvert.DeserializeObject<dynamic>(content);

                    if (responseObject != null && responseObject.response != null)
                    {
                        var movimientos = JsonConvert.DeserializeObject<List<Movimiento>>(responseObject.response.ToString());

                        if (movimientos != null && movimientos.Count > 0)
                        {
                            // Inicializar el saldo actual con el primer movimiento si existe un campo de saldo en el servidor
                            decimal saldoActual = movimientos[0].SaldoActual;

                            foreach (var movimiento in movimientos)
                            {
                                movimiento.MovFechaFormateada = movimiento.MovFecha.ToString("dd/MM/yyyy");

                                // Ajustar el cálculo del saldo basado en cada movimiento
                                if (movimiento.TipoMovimiento.Equals("INGRESO", StringComparison.OrdinalIgnoreCase))
                                {
                                    saldoActual += movimiento.MovValor;
                                }
                                else if (movimiento.TipoMovimiento.Equals("SALIDA", StringComparison.OrdinalIgnoreCase))
                                {
                                    saldoActual -= movimiento.MovValor;
                                }
                            }

                            _view.ShowMovimientos(movimientos, saldoActual);
                        }
                        else
                        {
                            _view.ShowMessage("No se encontraron movimientos para esta cuenta.");
                        }
                    }
                    else
                    {
                        _view.ShowMessage("No se encontraron movimientos para esta cuenta.");
                    }
                }
                else
                {
                    _view.ShowMessage($"Error al obtener movimientos: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Ocurrió un error inesperado: {ex.Message}");
            }
        }



        private void RealizarDeposito()
        {
            _view.ShowMessage("Ingrese el número de cuenta:");
            var cuentaNumero = Console.ReadLine();

            _view.ShowMessage("Ingrese el valor a depositar:");
            if (!decimal.TryParse(Console.ReadLine(), out var valor) || valor <= 0)
            {
                _view.ShowMessage("El valor ingresado no es válido.");
                return;
            }

            var url = $"http://localhost:5277/api/EurekabankControlador/Deposito?numeroCuenta={cuentaNumero}&valor={valor}";

            try
            {
                var response = _httpClient.PostAsync(url, null).Result;

                if (response.IsSuccessStatusCode)
                {
                    _view.ShowMessage("Depósito realizado con éxito.");
                    Console.WriteLine("Presione 'Enter' para volver al menú principal...");
                    Console.ReadLine();

                }
                else
                {
                    _view.ShowMessage($"Error al realizar el depósito: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Ocurrió un error inesperado: {ex.Message}");
            }
        }

        private void RealizarRetiro()
        {
            _view.ShowMessage("Ingrese el número de cuenta:");
            var cuentaNumero = Console.ReadLine();

            _view.ShowMessage("Ingrese el valor a retirar:");
            if (!decimal.TryParse(Console.ReadLine(), out var valor) || valor <= 0)
            {
                _view.ShowMessage("El valor ingresado no es válido.");
                return;
            }

            var url = $"http://localhost:5277/api/EurekabankControlador/Retiro?numeroCuenta={cuentaNumero}&valor={valor}";

            try
            {
                var response = _httpClient.PostAsync(url, null).Result;

                if (response.IsSuccessStatusCode)
                {
                    _view.ShowMessage("Retiro realizado con éxito.");
                    Console.WriteLine("Presione 'Enter' para volver al menú principal...");
                    Console.ReadLine();
                }
                else
                {
                    _view.ShowMessage($"Error al realizar el retiro: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Ocurrió un error inesperado: {ex.Message}");
            }
        }

        private void RealizarTransferencia()
        {
            _view.ShowMessage("Ingrese el número de cuenta origen:");
            var cuentaOrigen = Console.ReadLine();

            _view.ShowMessage("Ingrese el número de cuenta destino:");
            var cuentaDestino = Console.ReadLine();

            _view.ShowMessage("Ingrese el valor a transferir:");
            if (!decimal.TryParse(Console.ReadLine(), out var valor) || valor <= 0)
            {
                _view.ShowMessage("El valor ingresado no es válido.");
                return;
            }

            var url = $"http://localhost:5277/api/EurekabankControlador/Transferencia?cuentaOrigen={cuentaOrigen}&cuentaDestino={cuentaDestino}&valor={valor}";

            try
            {
                var response = _httpClient.PostAsync(url, null).Result;

                if (response.IsSuccessStatusCode)
                {
                    _view.ShowMessage("Transferencia realizada con éxito.");
                    Console.WriteLine("Presione 'Enter' para volver al menú principal...");
                    Console.ReadLine();
                }
                else
                {
                    _view.ShowMessage($"Error al realizar la transferencia: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Ocurrió un error inesperado: {ex.Message}");
            }
        }
    }
}
