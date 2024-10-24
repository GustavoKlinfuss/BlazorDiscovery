using BlazorDiscovery.Areas.Identity.Contracts;
using System.Text.Json;

namespace BlazorDiscovery.Areas.Identity.Services
{
    public class LoginService
    {
        private readonly HttpClient _httpClient;

        public LoginService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<AuthResponse?> Login(AuthRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("auth/login", request);
            if (result.IsSuccessStatusCode)
            {
                var content = await result.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<AuthResponse>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
