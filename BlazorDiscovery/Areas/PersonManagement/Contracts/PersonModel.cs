using static BlazorDiscovery.Areas.PersonManagement.Contracts.PersonModel;

namespace BlazorDiscovery.Areas.PersonManagement.Contracts
{
    public class PersonModel
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public DateOnly BirthDate { get; init; }
        public string Document { get; init; }
        public PersonModelAddress Address { get; init; }
        public string Phone { get; init; }
        public string Email { get; init; }
        public DateTime RegisterDate { get; set; }
        public DateTime? LastModificationDate { get; set; }

        public class PersonModelAddress
        {
            public PersonModelAddress(string street, string number, string city, string state, string zipCode)
            {
                Street = street;
                Number = number;
                City = city;
                State = state;
                ZipCode = zipCode;
            }

            public string Street { get; init; }
            public string Number { get; init; }
            public string City { get; init; }
            public string State { get; init; }
            public string ZipCode { get; init; }
        }
    }

    public class CreatePersonModel
    {
        public CreatePersonModel(string name, DateOnly birthDate, string document, PersonModelAddress address, string phone, string email)
        {
            Name = name;
            BirthDate = birthDate;
            Document = document;
            Address = address;
            Phone = phone;
            Email = email;
        }

        public string Name { get; init; }
        public DateOnly BirthDate { get; init; }
        public string Document { get; init; }
        public PersonModelAddress Address { get; init; }
        public string Phone { get; init; }
        public string Email { get; init; }
    }

    public class UpdatePersonModel
    {
        public UpdatePersonModel(string name, DateOnly birthDate, string document, PersonModelAddress address, string phone, string email)
        {
            Name = name;
            BirthDate = birthDate;
            Document = document;
            Address = address;
            Phone = phone;
            Email = email;
        }

        public string Name { get; init; }
        public DateOnly BirthDate { get; init; }
        public string Document { get; init; }
        public PersonModelAddress Address { get; init; }
        public string Phone { get; init; }
        public string Email { get; init; }
    }
}
