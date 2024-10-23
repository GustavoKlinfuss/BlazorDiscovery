﻿namespace BlazorDiscovery.Data
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
                Address = new PersonModel.PersonModelAddress("Rua De Salém", "2", "Curitiba", "Paraná", "81920123"),
                BirthDate = new DateOnly(2024, 1, 1),
                RegisterDate = new DateTime(2024, 1, 1, 1, 1, 1)
            }).ToArray());
        }

        public async Task<PersonModel> GetPeopleAsync(Guid id)
        {
            return await Task.FromResult(new PersonModel
            {
                Id = id,
                Name = "João da Silva",
                Document = "11111111111",
                Phone = "41999999999",
                Email = "joaosilva@hotmail.com",
                Address = new PersonModel.PersonModelAddress("Rua De Salém", "2", "Curitiba", "Paraná", "81920123"),
                BirthDate = new DateOnly(2024, 1, 1),
                RegisterDate = new DateTime(2024, 1, 1, 1, 1, 1)
            });
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
                RegisterDate = new DateTime(2024, 1, 1, 1, 1, 1),
                LastModificationDate = new DateTime(2024, 1, 1, 1, 1, 1)
            });
        }
    }
}
