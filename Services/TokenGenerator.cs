using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Titan.Models.Estafeta.Response;

namespace Titan.Services
{
    public class TokenGenerator
    {
        private readonly HttpClient _httpClient;
        private const string TokenUrl = "https://apiqa.estafeta.com:8443/auth/oauth/v2/token";
        private const string ClientId = "l78a868fb4191544939e722f38db1c821e";
        private const string ClientSecret = "8fb9d4e1a76145c0a6d1cdbde2841e1b";
        private const string Scope = "execute";

        public TokenGenerator()
        {
            _httpClient = new HttpClient();
        }
        public async Task<string> GenerateTokenAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Post, TokenUrl);
            var clientIdSecret = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{ClientId}:{ClientSecret}"));
            request.Headers.Add("Authorization", $"Basic {clientIdSecret}");

            var requestBody = new FormUrlEncodedContent(new[]
            {
            new KeyValuePair<string, string>("grant_type", "client_credentials"),
            new KeyValuePair<string, string>("scope", Scope)
        });
            request.Content = requestBody;

            var response = await _httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = JsonConvert.DeserializeObject<ResponseTokenEstafeta>(await response.Content.ReadAsStringAsync());
                // Extraer el token de la respuesta
                var token = responseContent; // Aquí debes implementar la lógica para extraer el token del responseContent
                return token.access_token;
            }
            else
            {
                throw new Exception($"Error al obtener el token. Código de respuesta: {response.StatusCode}");
            }
        }
    }
}
