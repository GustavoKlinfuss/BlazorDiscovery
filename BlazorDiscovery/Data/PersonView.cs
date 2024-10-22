namespace BlazorDiscovery.Data
{
    public class PersonView
    {
        public PersonView(PersonModel person)
        {
            Id = person.Id;
            Name = person.Name;
            BirthDate = person.BirthDate;
            Document = Mascarar(person.Document);
            Address = new PersonViewAddress(person.Address);
            Phone = person.Phone;
            Email = person.Email;
            RegisterDate = person.DataCadastro;
            LastModificationDate = person.DataUltimaModificacao;
        }

        private static string Mascarar(string document)
        {
            return document.Length == 11
                ? $"{document.Substring(0, 3)}.{document.Substring(3, 3)}.{document.Substring(6, 3)}-{document.Substring(9, 2)}"
                : document;
        }

        public Guid Id { get; init; }
        public string Name { get; init; }
        public DateOnly BirthDate { get; init; }
        public string Document { get; init; }
        public PersonViewAddress Address { get; init; }
        public string Phone { get; init; }
        public string Email { get; init; }
        public DateTime RegisterDate { get; init; }
        public DateTime? LastModificationDate { get; init; }

        public class PersonViewAddress
        {
            public PersonViewAddress(PersonModel.PersonModelAddress address)
            {
                Street = address.Street;
                Number = address.Number;
                City = address.City;
                State = address.State;
                ZipCode = address.ZipCode;
            }

            public string Street { get; init; }
            public string Number { get; init; }
            public string City { get; init; }
            public string State { get; init; }
            public string ZipCode { get; init; }
        }
    }
}
