using BlazorDiscovery.Areas.PersonManagement.Contracts;

namespace BlazorDiscovery.Views
{
    public class PersonPartialView
    {
        public PersonPartialView(PersonModel person)
        {
            Id = person.Id;
            Name = person.Name;
            BirthDate = person.BirthDate;
            Document = Mascarar(person.Document);
            Address = new PersonPartialViewAddress(person.Address);
            Phone = person.Phone;
            Email = person.Email;
            CreationDate = person.CreationDate;
            LastModificationDate = person.LastModificationDate;
        }

        private static string Mascarar(string document)
        {
            return document.Length == 11
                ? $"{document.Substring(0, 3)}.{document.Substring(3, 3)}.{document.Substring(6, 3)}-{document.Substring(9, 2)}"
                : document;
        }

        public Guid Id { get; init; }
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Document { get; private set; }
        public PersonPartialViewAddress Address { get; init; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public DateTime CreationDate { get; init; }
        public DateTime? LastModificationDate { get; init; }

        public class PersonPartialViewAddress
        {
            public PersonPartialViewAddress(PersonModel.PersonModelAddress address)
            {
                Street = address.Street;
                Number = address.Number;
                City = address.City;
                State = address.State;
                ZipCode = address.ZipCode;
            }

            public string Street { get; init; }
            public int Number { get; init; }
            public string City { get; init; }
            public string State { get; init; }
            public string ZipCode { get; init; }
        }
    }
}
