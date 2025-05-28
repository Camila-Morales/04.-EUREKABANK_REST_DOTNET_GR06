using ec.edu.monster.model;
using Newtonsoft.Json;

namespace ec.edu.monster.controller
{
    public class HomeController
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public bool Login(string username, string password)
        {
            var loginModel = new { Username = username, PasswordHash = password };
            var url = "http://localhost:5277/api/Login";

            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(loginModel), System.Text.Encoding.UTF8, "application/json");
                var response = _httpClient.PostAsync(url, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Movimiento> ConsultarMovimientos(string numeroCuenta, out decimal saldoActual)
        {
            saldoActual = 0; // Inicializa el saldo actual
            var url = $"http://localhost:5277/api/EurekabankControlador/Movimientos?numeroCuenta={numeroCuenta}";

            try
            {
                var response = _httpClient.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var apiResponse = JsonConvert.DeserializeObject<dynamic>(content);

                    var movimientos = JsonConvert.DeserializeObject<List<Movimiento>>(apiResponse.response.ToString());

                    if (movimientos != null && movimientos.Count > 0)
                    {
                        saldoActual = movimientos[0].SaldoActual; // Toma el saldo del primer movimiento
                    }

                    foreach (var movimiento in movimientos)
                    {
                        movimiento.MovFechaFormateada = movimiento.MovFecha.ToString("dd/MM/yyyy");
                    }

                    return movimientos;
                }
                else
                {
                    MessageBox.Show($"Error al obtener movimientos: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar movimientos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }


        public void RealizarDeposito(string numeroCuenta, decimal valor)
        {
            var url = $"http://localhost:5277/api/EurekabankControlador/Deposito?numeroCuenta={numeroCuenta}&valor={valor}";

            try
            {
                var response = _httpClient.PostAsync(url, null).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Depósito realizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error al realizar el depósito: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar el depósito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RealizarRetiro(string numeroCuenta, decimal valor)
        {
            var url = $"http://localhost:5277/api/EurekabankControlador/Retiro?numeroCuenta={numeroCuenta}&valor={valor}";

            try
            {
                var response = _httpClient.PostAsync(url, null).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Retiro realizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error al realizar el retiro: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar el retiro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RealizarTransferencia(string cuentaOrigen, string cuentaDestino, decimal valor)
        {
            if (string.IsNullOrEmpty(cuentaOrigen) || string.IsNullOrEmpty(cuentaDestino))
            {
                MessageBox.Show("Ambos números de cuenta son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var url = $"http://localhost:5277/api/EurekabankControlador/Transferencia?cuentaOrigen={cuentaOrigen}&cuentaDestino={cuentaDestino}&valor={valor}";

            try
            {
                var response = _httpClient.PostAsync(url, null).Result;

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Transferencia realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Error al realizar la transferencia: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la transferencia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
