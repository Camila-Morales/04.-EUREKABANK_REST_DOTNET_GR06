using ec.edu.monster.view;
using ec.edu.monster.model;
using Newtonsoft.Json;

namespace ec.edu.monster.controller
{
    public class LoginController
    {
        private readonly ConsoleView _view;
        private static readonly HttpClient _httpClient = new HttpClient();

        public LoginController(ConsoleView view)
        {
            _view = view;
        }

        public bool Login()
        {
            _view.ShowLogin();
            var username = _view.PromptForUsername();
            var password = _view.PromptForPassword();

            var loginModel = new Usuario
            {
                Username = username,
                PasswordHash = password
            };

            string url = "http://10.40.17.105:5277/api/Login";
            var content = new StringContent(JsonConvert.SerializeObject(loginModel), System.Text.Encoding.UTF8, "application/json");

            try
            {
                var response = _httpClient.PostAsync(url, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    _view.ShowMessage("Inicio de sesión exitoso.");
                    return true;
                }
                else
                {
                    _view.ShowMessage("Credenciales incorrectas.");
                    _view.Pause("Presione 'Enter' para intentar nuevamente...");
                    return false;
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error al iniciar sesión: {ex.Message}");
                _view.Pause("Presione 'Enter' para intentar nuevamente...");
                return false;
            }
        }
    }
}
