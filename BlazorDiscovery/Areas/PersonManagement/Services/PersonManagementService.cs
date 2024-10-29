using System.Text.Json;
using BlazorDiscovery.Areas.PersonManagement.Contracts;
using BlazorDiscovery.Shared;

namespace BlazorDiscovery.Areas.PersonManagement.Services
{
    public class PersonManagementService
    {
        private readonly HttpClient _httpClient;

        public PersonManagementService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PersonModel[]> GetPeopleAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<GetPersonsResponse>("person");
            return response.Dados;
        }

        public async Task<PersonModel> GetPeopleAsync(Guid id)
        {
            var resopnse = await _httpClient.GetFromJsonAsync<GetPersonByIdResponse>($"person/{id}");
            return resopnse.Dados;
        }

        public async Task<BaseApiResponse<PersonModel>?> CreateAsync(CreatePersonModel model)
        {
            var response = await _httpClient.PostAsJsonAsync($"person", model);
            var contentString = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<BaseApiResponse<PersonModel>?>(
                contentString,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<PersonModel> UpdateAsync(Guid id, UpdatePersonModel model)
        {
            return await Task.FromResult(new PersonModel
            {
                Id = id,
                Name = model.Name,
                Document = model.Document,
                Phone = model.Phone,
                Email = model.Email,
                Address = model.Address,
                BirthDate = model.BirthDate,
                CreationDate = new DateTime(2024, 1, 1, 1, 1, 1),
                LastModificationDate = new DateTime(2024, 1, 1, 1, 1, 1)
            });
        }

        public async Task DeleteAsync(Guid id)
        {
            await Task.CompletedTask;
        }
    }
}
