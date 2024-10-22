namespace BlazorDiscovery.Data
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
        public DateTime DataCadastro { get; set; }
        public DateTime? DataUltimaModificacao { get; set; }

        public class PersonModelAddress
        {
            public string Street { get; init; }
            public string Number { get; init; }
            public string City { get; init; }
            public string State { get; init; }
            public string ZipCode { get; init; }
        }
    }
}
