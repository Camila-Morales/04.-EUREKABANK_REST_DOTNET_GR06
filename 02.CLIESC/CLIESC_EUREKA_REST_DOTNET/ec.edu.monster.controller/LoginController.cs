using System.Net.Http;
using Newtonsoft.Json;
using ec.edu.monster.model;

namespace ec.edu.monster.controller
{
    public class LoginController
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public bool Login(string username, string password)
        {
            var loginModel = new Usuario { Username = username, PasswordHash = password };
            var url = "http://localhost:5277/api/Login";
            var content = new StringContent(JsonConvert.SerializeObject(loginModel), System.Text.Encoding.UTF8, "application/json");

            var response = _httpClient.PostAsync(url, content).Result;
            return response.IsSuccessStatusCode;
        }
    }
}
