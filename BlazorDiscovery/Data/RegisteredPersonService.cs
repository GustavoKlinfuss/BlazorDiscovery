namespace BlazorDiscovery.Data
{
    public class PersonRegisterManagementService
    {
        public PersonRegisterManagementService() { }

        public async Task<PersonModel[]> GetPeopleAsync()
        {
            return await Task.FromResult(Enumerable.Range(1, 5).Select(index => new PersonModel
            {
                Id = Guid.NewGuid(),
                Name = "João da Silva",
                Document = "11111111111",
                Phone = "41999999999",
                Email = "joaosilva@hotmail.com",
                Address = new PersonModel.PersonModelAddress()
                {
                    Street = "Rua De Salém",
                    Number = "2",
                    City = "Curitiba",
                    State = "Paraná",
                    ZipCode = "81920123"
                },
                BirthDate = new DateOnly(2024, 1, 1),
                DataCadastro = new DateTime(2024, 1, 1, 1, 1, 1)
            }).ToArray());
        }
    }
}
